using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using Tools.LogHelper;

namespace Tools.Communications.Tcp.IO
{
    /// <summary>
    /// 阻塞式链接侦听
    /// </summary>
    public class TcpIoListener : IListener
    {
        private Socket socket = null;

        private NetworkStream ns;

        public TcpIoListener(string remoteIp)
        {
            //创建socket

        }
        void IListener.listen()
        {
            if (socket != null)
            {
                socket.Listen(100);
                //执行逻辑
                ns = new NetworkStream(socket);

            }
        }
        void IListener.stop()
        {
            try
            {
                if (socket != null && socket.IsBound)
                {
                    socket.Shutdown(0);
                }
            }
            catch (Exception ex)
            {
                LoggerManage.getInstance().error(this.GetType(), ex.Message);
            }
        }
    }
}
