using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace CilentProject
{

    public partial class Form1 : Form
    {

        public void refrashList()
        {
            try
            {
                CBBookName.Items.Clear();
                SendId("7#");
                string item = "";
                for (int i = 0; i < messagefromserver.Length; i++)
                {
                    if (messagefromserver[i] == '@')
                    {
                        CBBookName.Items.Add(item);
                        item = "";
                    }
                    else
                    {
                        item += messagefromserver[i];
                    }
                }
                CBBookName.SelectedIndex = 0;
            }
            catch (Exception)
            {
                //MessageBox.Show("Please Connect to the Server", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool CheckBookName(string name)
        {
            int i = 0;
            if (name.Length<2 || name.Length>30)
            {
                return false;
            }
            while (i<name.Length)
            {
                if (!(name[i] < '9' || name[i] > '0')&& !(name[i] < 'Z' || name[i] > 'A')&& !(name[i] < 'z' || name[i] > 'a')&& !(name[i]!=' ') || name[i] == '@'|| name[i] == '*'|| name[i] == '!')
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        public bool CheckBookAuthor(string name)
        {
            int i = 0;
            if (name.Length < 2 && name.Length > 30)
            {
                return false;
            }
            while (i < name.Length)
            {
                if (!(name[i] < '9' || name[i] > '0') && !(name[i] < 'Z' || name[i] > 'A') && !(name[i] < 'z' || name[i] > 'a') && !(name[i] != ' '||name[i]!='.') || name[i] == '@' || name[i] == '*' || name[i] == '!')
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        public bool isnumber(string name)
        {
            int i = 0;
            if (name.Length ==0)
            {
                return false;
            }
            while (i < name.Length)
            {
                if (name[i] > '9' && name[i] > '0')
                {
                    return false;
                }
                i++;
            }
            return true;
        }
        string messagefromserver = "";
        public Form1()
        {
            InitializeComponent();
            TBSIP.Text="127.0.0.1";
            TBSPORT.Text = "13000";
            LAddBookAuthor.BackColor = System.Drawing.Color.Transparent;
            LSIP.BackColor = System.Drawing.Color.Transparent;
            LSPort.BackColor = System.Drawing.Color.Transparent;
            LAddBookName.BackColor = System.Drawing.Color.Transparent;
            LAddBookQuantity.BackColor = System.Drawing.Color.Transparent;
            LData.BackColor = System.Drawing.Color.Transparent;
            refrashList();
        }
        public void SendId(string strId)
        {
            try
            {
                Int32 port = int.Parse(TBSPORT.Text); // 13000
                IPAddress addressserver = IPAddress.Parse(TBSIP.Text); //33.88.44.81
                TcpClient client = new TcpClient(addressserver.ToString(), port);
                LBServerData.Items.Clear();
                LBServerData.Items.Add("Connection to server :");
                byte[] data = System.Text.Encoding.ASCII.GetBytes(strId);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);         
                data = new byte[256];
                int bytes = stream.Read(data, 0, data.Length);
                messagefromserver = Encoding.ASCII.GetString(data, 0, bytes);
                LBServerData.Items.Add("Answer from Server :" + messagefromserver);
                stream.Close();
                client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please Connect to the Server", "ERROR!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        private void BtnAddBook_Click(object sender, EventArgs e)//add
        {
            string str = "";
            int flag = 1;
            if (CheckBookName(TBAddBookName.Text) == false)
            {
                flag = 0;
                str += "Wrong name\n";
                LData.Text = str;
            }
            else
            {
                if (CheckBookName(TBAddBookAuthor.Text) == false)
                {
                    flag = 0;
                    str += "Wrong Author\n";
                    LData.Text = str;
                }
                else
                {
                    if (isnumber(TBAddBookQuantity.Text) == false)
                    {
                        flag = 0;
                        str += "Wrong Quantity\n";
                        LData.Text = str;
                    }
                    else
                    {
                        SendId("2#@" + TBAddBookName.Text + "!" + TBAddBookAuthor.Text + "*" + TBAddBookQuantity.Text);
                        if(messagefromserver == "Book added!" + TBAddBookName.Text + " " + TBAddBookAuthor.Text + " " + TBAddBookQuantity.Text)
                        {
                            MessageBox.Show("Book Added", "Book Added");
                            refrashList();
                            TBAddBookName.Text = "";
                            TBAddBookAuthor.Text = "";
                            TBAddBookQuantity.Text = "";
                        }
                                
                    }
                }
                    
            }
            if (flag==0)
            {
                MessageBox.Show(str,str);
            }
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)//delete by name
        {
            string str = "";
            int flag = 1;
            if (CheckBookName(TBAddBookName.Text) == false)
            {
                flag = 0;
                str += "Wrong name\n";
                LData.Text = str;
            }
            else
            {
                SendId("3#" + TBAddBookName.Text);
                if (messagefromserver == TBAddBookName.Text + "DELETE!")
                {
                    MessageBox.Show("DELETE", "DELETE");
                    refrashList();
                    TBAddBookName.Text = "";
                    TBAddBookAuthor.Text = "";
                    TBAddBookQuantity.Text = "";
                }

            }
            if (flag == 0)
            {
                MessageBox.Show(str, str);
            }
        }

        private void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            string str = "";
            int flag = 1;
            if (CheckBookName(TBAddBookName.Text) == false)
            {
                flag = 0;
                str += "Wrong name\n";
                LData.Text = str;
            }
            else
            {
                if (isnumber(TBAddBookQuantity.Text) == false)
                {
                    flag = 0;
                    str += "Wrong Quantity\n";
                    LData.Text = str;
                }
                else
                {
                    SendId("4#" + TBAddBookName.Text + "*" + TBAddBookQuantity.Text);
                }
            }   
            if (flag == 0)
            {
                MessageBox.Show(str, str);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void BtnShowBooks_Click(object sender, EventArgs e)
        {

                SendId("5#");
                LData.Text = messagefromserver;
        }

        private void BtnFindBookNameBook_Click(object sender, EventArgs e)
        {
            string str = "";
            int flag = 1;
            if (CheckBookName(TBAddBookName.Text) == false)
            {
                flag = 0;
                str += "Wrong name\n";
                LData.Text = str;
            }
            else
            {
                SendId("1#" + TBAddBookName.Text);
                TBAddBookName.Text = messagefromserver.Substring(messagefromserver.IndexOf('@') + 1, messagefromserver.IndexOf('!') - 1);
                TBAddBookAuthor.Text = messagefromserver.Substring(messagefromserver.IndexOf('!') + 1, messagefromserver.LastIndexOf('*') - (messagefromserver.IndexOf('!') + 1));
                TBAddBookQuantity.Text = messagefromserver.Substring(messagefromserver.LastIndexOf('*') + 1);
            }
            if (flag == 0)
            {
                MessageBox.Show(str, str);
            }
        }

        private void BtnFindBookAuthor_Click(object sender, EventArgs e)
        {
            string str = "";
            int flag = 1;
            if (CheckBookName(TBAddBookAuthor.Text) == false)
            {
                flag = 0;
                str += "Wrong Author\n";
                LData.Text = str;
            }
            else
            {
                SendId("6#" + TBAddBookAuthor.Text);
                LData.Text = messagefromserver;
            }
            if (flag == 0)
            {
                MessageBox.Show(str, str);
            }
        }

        private void RtnRefrash_Click(object sender, EventArgs e)
        {
            refrashList();
        }

        private void CBBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
                SendId("1#" + CBBookName.Text);
                TBAddBookName.Text = messagefromserver.Substring(messagefromserver.IndexOf('@') + 1, messagefromserver.IndexOf('!') - 1);
                TBAddBookAuthor.Text= messagefromserver.Substring(messagefromserver.IndexOf('!') + 1, messagefromserver.LastIndexOf('*') - (messagefromserver.IndexOf('!') + 1));
                TBAddBookQuantity.Text= messagefromserver.Substring(messagefromserver.LastIndexOf('*') + 1);
        }
    }
}
