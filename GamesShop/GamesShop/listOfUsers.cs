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

namespace GamesShop
{
    public partial class listOfUsers : Form
    {
        private DataGridView dataOfUsers;
        private Button btn_back;
        string[] numArrPerem;
        private Button btn_deleteUser;
        private Label label1;
        private TextBox tb_deleteUser;
        string[] login;

        public listOfUsers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.dataOfUsers = new System.Windows.Forms.DataGridView();
            this.btn_deleteUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_deleteUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataOfUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1051, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataOfUsers
            // 
            this.dataOfUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOfUsers.Location = new System.Drawing.Point(365, 148);
            this.dataOfUsers.Name = "dataOfUsers";
            this.dataOfUsers.RowHeadersWidth = 51;
            this.dataOfUsers.RowTemplate.Height = 29;
            this.dataOfUsers.Size = new System.Drawing.Size(458, 345);
            this.dataOfUsers.TabIndex = 1;
            // 
            // btn_deleteUser
            // 
            this.btn_deleteUser.Location = new System.Drawing.Point(12, 230);
            this.btn_deleteUser.Name = "btn_deleteUser";
            this.btn_deleteUser.Size = new System.Drawing.Size(195, 55);
            this.btn_deleteUser.TabIndex = 2;
            this.btn_deleteUser.Text = "Удалить пользователя";
            this.btn_deleteUser.UseVisualStyleBackColor = true;
            this.btn_deleteUser.Click += new System.EventHandler(this.btn_deleteUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Номер пользователя";
            // 
            // tb_deleteUser
            // 
            this.tb_deleteUser.Location = new System.Drawing.Point(12, 185);
            this.tb_deleteUser.Name = "tb_deleteUser";
            this.tb_deleteUser.Size = new System.Drawing.Size(195, 27);
            this.tb_deleteUser.TabIndex = 4;
            // 
            // listOfUsers
            // 
            this.ClientSize = new System.Drawing.Size(1157, 553);
            this.Controls.Add(this.tb_deleteUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_deleteUser);
            this.Controls.Add(this.dataOfUsers);
            this.Controls.Add(this.btn_back);
            this.Name = "listOfUsers";
            this.Load += new System.EventHandler(this.Form1_Loading);
            ((System.ComponentModel.ISupportInitialize)(this.dataOfUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }

        private void Form1_Loading(object sender, EventArgs e)
        {
            int numArrPeremLocal;
            int count = 0;
            numArrPerem = File.ReadAllLines("../../../BD_users/numArr.txt");
            numArrPeremLocal = Int32.Parse(numArrPerem[0]);

            dataOfUsers.RowCount = numArrPeremLocal;
            dataOfUsers.ColumnCount = 3;
            dataOfUsers.Columns[0].HeaderText = "№ пользователя";
            dataOfUsers.Columns[1].HeaderText = "Логин";
            dataOfUsers.Columns[2].HeaderText = "Пароль";

            for (int i = 1; i <= numArrPeremLocal; i++)
            {
                login = File.ReadAllLines("../../../BD_users/" + i + ".txt");
                dataOfUsers.Rows[count].Cells[0].Value = i.ToString();
                dataOfUsers.Rows[count].Cells[1].Value = login[0];
                dataOfUsers.Rows[count].Cells[2].Value = login[1];
                count++;
            }
            
        }

        private void btn_deleteUser_Click(object sender, EventArgs e)
        {
            File.Delete("../../../BD_users/" + tb_deleteUser.Text + ".txt");
            numArrPerem = File.ReadAllLines("../../../BD_users/numArr.txt");
            int numArrPeremLocal = Int32.Parse(numArrPerem[0]);
            int startFor = Int32.Parse(tb_deleteUser.Text);
            int ParseI = startFor;

            for (int i = startFor; i <= numArrPeremLocal; i++)
            {
                ParseI++;
                string src = "../../../BD_users/" + ParseI + ".txt";
                string dest = "../../../BD_users/" + i + ".txt";
                try
                {
                    File.Move(src, dest);
                }
                catch { }

            }
            StreamWriter numArr = new StreamWriter("../../../BD_users/numArr.txt");
            numArrPeremLocal--;
            numArr.WriteLine(numArrPeremLocal);
            numArr.Close();

            int count = 0;

            dataOfUsers.RowCount = numArrPeremLocal;
            dataOfUsers.ColumnCount = 3;
            for (int i = 1; i <= numArrPeremLocal; i++)
            {
                login = File.ReadAllLines("../../../BD_users/" + i + ".txt");
                dataOfUsers.Rows[count].Cells[0].Value = i.ToString();
                dataOfUsers.Rows[count].Cells[1].Value = login[0];
                dataOfUsers.Rows[count].Cells[2].Value = login[1];
                count++;
            }
            MessageBox.Show("Успешно удалено");
            tb_deleteUser.Text = "";
        }
    }
}
