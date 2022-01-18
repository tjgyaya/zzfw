using RRQMCore.ByteManager;
using RRQMSocket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zzfw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        bool starBool = false;

        private BindingList<SocketClient> onLineClient;
        private TcpService tcpService;

        public enum AdapterType
        {
            Normal,
            FixedHeader,
            FixedSize,
            Terminator,
            JsonString
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Cb_AdapterType.ItemsSource = Enum.GetValues(typeof(AdapterType));
            this.onLineClient = new BindingList<SocketClient>();

  

            this.Lb_OnlineClient.DataSource = onLineClient;
            Lb_OnlineClient.DisplayMember = "NAME";
            Lb_OnlineClient.ValueMember = "ID";

        }
        private void btn_star_Click(object sender, EventArgs e)
        {
            if (starBool)
            {
                stop();
                starBool=false;
                btn_star.Text = "开始运行";

            }
            else
            {
                star();
                starBool = true;
                btn_star.Text = "正在运行";
            }
        }
        public void star()
        {
            if (tcpService == null)
            {
                tcpService = new TcpService();
                //订阅事件
                tcpService.Connected += Service_ClientConnected;//订阅连接事件
                tcpService.Disconnected += Service_ClientDisconnected;//订阅断开连接事件
                tcpService.Connecting += Service_Connecting;
                tcpService.Received += this.OnReceived;

                //string[] ids = tcpService.SocketClients.GetIDs();//获取目前在线的所有ID
                //foreach (var id in ids)//遍历ID
                //{
                //    if (tcpService.TryGetSocketClient(id, out SimpleSocketClient socketClient))
                //    {
                //        socketClient.Send(new byte[] { 0 });//回发
                //    }
                //}
            }

           // this.adapterIndex = this.Cb_AdapterType.SelectedIndex;

            //注入配置
            var config = new TcpServiceConfig();
            config.MaxCount = 100000;
            config.SetValue(TcpServiceConfig.ListenIPHostsProperty, new IPHost[] { new IPHost($"127.0.0.1:{tb_dk.Text }") })
                .SetValue(TcpServiceConfig.ClearTypeProperty, ClearType.Receive | ClearType.Send)
               // .SetValue(ServiceConfig.LoggerProperty, new MsgLog(this.ShowMsg))//设置内部日志记录器
                .SetValue(ServiceConfig.ThreadCountProperty, 10)//设置多线程数量
               // .SetValue(TcpServiceConfig.ClearIntervalProperty, 1000 * 20)//10秒无数据交互将被清理
                .SetValue(ServiceConfig.BufferLengthProperty, 1024);//设置缓存池大小，该数值在框架中经常用于申请ByteBlock，所以该值会影响内存池效率。;

            //载入配置
            tcpService.Setup(config);

            //或通过实例注入配置，实例注入时须实例化对应配置，否则部分属性不可见
            //var config1 = new TcpServiceConfig();
            //config1.ListenIPHosts = new IPHost[] { new IPHost(this.Tb_iPHost.Text) };
            //config1.Logger = new MsgLog(this.ShowMsg);
            //config1.ThreadCount = int.Parse(this.Tb_ThreadCount.Text);
            //config1.ClearInterval = 300;
            //config1.BufferLength = 1024;

            //载入配置
            //tcpService.Setup(config1);

            //启动
            tcpService.Start();

            ShowMsg("启动成功");


        }
        private int adapterIndex=0;
        private void Service_Connecting(SimpleSocketClient arg1, ClientOperationEventArgs arg2)
        {
            switch (this.adapterIndex)
            {
                default:
                case 0:
                    {
                        arg1.SetDataHandlingAdapter(new NormalDataHandlingAdapter());
                        break;
                    }
                case 1:
                    {
                        arg1.SetDataHandlingAdapter(new FixedHeaderPackageAdapter());
                        break;
                    }
                case 2:
                    {
                        arg1.SetDataHandlingAdapter(new FixedSizePackageAdapter(1024));
                        break;
                    }
                case 3:
                    {
                        arg1.SetDataHandlingAdapter(new TerminatorPackageAdapter(1024, "\r\n"));
                        break;
                    }
                case 4:
                    {
                        //arg1.SetDataHandlingAdapter(new JsonStringDataHandlingAdapter());
                        break;
                    }
            }
            //  if (!isPerformanceTest)
            // {
            //   ShowMsg.AppendText($"正在使用适配器=>{arg1.DataHandlingAdapter.GetType().Name}");
            //}
        }

        private void OnReceived(SimpleSocketClient client, ByteBlock byteBlock, object obj)
        {
            //System.Threading.Thread.Sleep(10);

                string mes = Encoding.UTF8.GetString(byteBlock.Buffer, 0, (int)byteBlock.Length);
            ShowMsg($"已接收到信息：{mes}");
           
        }

        private void Service_ClientDisconnected(object sender, MesEventArgs e)
        {
    
                this.onLineClient.Remove((SocketClient)sender);
                this.Tb_ClientNum.Text = this.onLineClient.Count.ToString();

   


        }

        private void Service_ClientConnected(object sender, MesEventArgs e)
        {
     
                this.onLineClient.Add((SocketClient)sender);
               Tb_ClientNum.Text = onLineClient.Count.ToString();
         //   Lb_OnlineClient.DataSource = this.onLineClient;
        }

        public  void ShowMsg(string msg)
        {
        
                msgBox.AppendText($"{msg}\r\n");
         
        }




        public void stop()
        {
            if (tcpService != null && tcpService.ServerState == ServerState.Running)
            {
                tcpService.Stop();
                ShowMsg("解除绑定");
                this.onLineClient.Clear();
            }
            else
            {
                ShowMsg("服务器未绑定");
            }


        }

        private void Lb_OnlineClient_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Lb_OnlineClient.SelectedItem != null)
            {
                if (this.Cb_IsAsync.Checked )
                {
                    ((SocketClient)this.Lb_OnlineClient.SelectedItem).SendAsync(Encoding.UTF8.GetBytes(this.Tb_TestMsg.Text));
                }
                else
                {
                    ((SocketClient)this.Lb_OnlineClient.SelectedItem).Send(Encoding.UTF8.GetBytes(this.Tb_TestMsg.Text));
                }
            }
            else
            {
                MessageBox .Show ("请先选择客户端列表");
            }
        }
    }
}
