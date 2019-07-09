using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace ServerV
{
    public partial class Form1 : Form
    {
        public Thread refleshThread;
        public static Socket socket;
        public static List<Socket> ClientList = new List<Socket>();


        public Form1()
        {
            InitializeComponent();
        }

        //загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {  // соединение 
            IPHostEntry iPHostEntry =  Dns.Resolve(Dns.GetHostName());
            IPAddress address = iPHostEntry.AddressList[1];
            int port = 8080;
            IPEndPoint endPoint = new IPEndPoint(address, port);
            socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(endPoint);
            socket.Listen(10);

            //Создаем новый поток для работы
            refleshThread = new Thread(waitFarConnect);
            refleshThread.Start();
        }

        public   void waitFarConnect()
        {
            Socket client = socket.Accept(); // новый сокет для подклучившегося клиена
            ClientList.Add(client);

           Invoke( (MethodInvoker) delegate { clientTable.DataSource = ClientList; });
        }

        //после заерытия формы. Методв работают до закрытия
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            refleshThread.Abort(); //завершение потока
        }

        private void ClientTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Socket cur = ClientList[e.RowIndex];
            ClientMenu clientMenu = new ClientMenu();
            clientMenu.socket = cur;
            clientMenu.Show();
        }

        private void ClientTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
