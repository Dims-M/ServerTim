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
    public partial class SendMenu : Form  //BaseSendMenu
    {
        public string Action;
        public bool morelhanOneParameter;
        public Socket socket; 
        public SendMenu()
        {
            InitializeComponent();
        }

        private void SendMenu_Load(object sender, EventArgs e)
        {
            switch (Action)
            {
                case "Create":
                    FirstName.Text = "Path";
                    morelhanOneParameter = false;
                    break;
                case "Delete":
                    FirstName.Text = "Path";
                    morelhanOneParameter = false;
                    break;
                case "Rename":
                    FirstName.Text = "Path";
                    secondParametr.Text = "Name";
                    morelhanOneParameter = true;
                    break;
            }

            if (!morelhanOneParameter)
            {
                secondParametr.Hide();
                SeconParametrTextBox.Hide(); //Скрываем
            }
        }
        //Кнопка SEND
        private void SendBuuton_Click(object sender, EventArgs e)
        {
            string command = Action.ToLower();
            string request = command + "|" + FirstParametrTextBox.Text;
            byte[] buffer = Encoding.UTF8.GetBytes(request);
            socket.Send(buffer);
        }
    }
}
