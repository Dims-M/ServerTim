using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace ServerV
{
    public partial class ClientMenu : Form
    {
        public Socket socket;

        public ClientMenu()
        {
            InitializeComponent();
        }

        //Событие клик
        private void CreateBatton_Click(object sender, EventArgs e)
        {
            //передаем тект в следущую форму
            Button buttonPressed = sender as Button;
            SendMenu sendMenu = new SendMenu();
            sendMenu.Action = buttonPressed.Text;
            sendMenu.socket = socket;
            sendMenu.Show();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
