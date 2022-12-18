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
    public partial class Authorization : Form
    {
        private Label label1;
        private Button btn_input;
        private Button btn_back;
        private Label label3;
        private Label label2;
        private TextBox tb_password;
        private TextBox tb_login;
        private Panel panel1;
        string[] numArrPerem;
        string[] login;

        public Authorization()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(465, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_login);
            this.panel1.Controls.Add(this.btn_input);
            this.panel1.Location = new System.Drawing.Point(425, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 336);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(97, 177);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(125, 27);
            this.tb_password.TabIndex = 2;
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(97, 82);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(125, 27);
            this.tb_login.TabIndex = 1;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(85, 270);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(145, 41);
            this.btn_input.TabIndex = 0;
            this.btn_input.Text = "Войти";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(961, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(117, 38);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Authorization
            // 
            this.ClientSize = new System.Drawing.Size(1090, 547);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            int numArrPeremLocal;
            
            numArrPerem = File.ReadAllLines("../../../BD_users/numArr.txt");
            numArrPeremLocal = Int32.Parse(numArrPerem[0]);

            for (int i = 1; i <= numArrPeremLocal; i++)
            {
                login = File.ReadAllLines("../../../BD_users/" + i + ".txt");
                if (login[0] == tb_login.Text)
                {
                    if (login[1] == tb_password.Text)
                    {
                        StreamWriter buffer = new StreamWriter("../../../#Buffer/buffer.txt");
                        buffer.WriteLine(login[0]);
                        buffer.Close();

                        Main main = new Main();
                        main.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль");
                    }
                }

            }
        }
    }
}
