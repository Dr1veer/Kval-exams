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
    public partial class Main : Form
    {
        private Label label1;
        private Button ExitApp;
        private Button edit_authorization;
        private Button btn_orders;
        private Button btn_listOfGames;
        private Button btn_users;
        private Button btn_myGames;
        string[] buffer;

        public Main()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ExitApp = new System.Windows.Forms.Button();
            this.edit_authorization = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.btn_listOfGames = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_myGames = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логотип";
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(995, 12);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(94, 29);
            this.ExitApp.TabIndex = 1;
            this.ExitApp.Text = "Выход";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // edit_authorization
            // 
            this.edit_authorization.Location = new System.Drawing.Point(879, 12);
            this.edit_authorization.Name = "edit_authorization";
            this.edit_authorization.Size = new System.Drawing.Size(94, 29);
            this.edit_authorization.TabIndex = 2;
            this.edit_authorization.UseVisualStyleBackColor = true;
            this.edit_authorization.Click += new System.EventHandler(this.edit_authorization_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Location = new System.Drawing.Point(33, 313);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(151, 51);
            this.btn_orders.TabIndex = 3;
            this.btn_orders.Text = "Заказы";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // btn_listOfGames
            // 
            this.btn_listOfGames.Location = new System.Drawing.Point(33, 134);
            this.btn_listOfGames.Name = "btn_listOfGames";
            this.btn_listOfGames.Size = new System.Drawing.Size(151, 56);
            this.btn_listOfGames.TabIndex = 4;
            this.btn_listOfGames.Text = "Каталог игр";
            this.btn_listOfGames.UseVisualStyleBackColor = true;
            this.btn_listOfGames.Click += new System.EventHandler(this.btn_listOfGames_Click);
            // 
            // btn_users
            // 
            this.btn_users.Location = new System.Drawing.Point(33, 380);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(151, 52);
            this.btn_users.TabIndex = 5;
            this.btn_users.Text = "Клиенты";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_myGames
            // 
            this.btn_myGames.Location = new System.Drawing.Point(33, 209);
            this.btn_myGames.Name = "btn_myGames";
            this.btn_myGames.Size = new System.Drawing.Size(151, 50);
            this.btn_myGames.TabIndex = 6;
            this.btn_myGames.Text = "Мои товары";
            this.btn_myGames.UseVisualStyleBackColor = true;
            this.btn_myGames.Click += new System.EventHandler(this.btn_myGames_Click);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(1101, 560);
            this.Controls.Add(this.btn_myGames);
            this.Controls.Add(this.btn_users);
            this.Controls.Add(this.btn_listOfGames);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.edit_authorization);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Loading);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void edit_authorization_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Сменить учечтную запись?",
                "Подтверждение",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form1 f1 = new Form1();
                f1.Show();
                Hide();
            }
        }

        private void btn_listOfGames_Click(object sender, EventArgs e)
        {
            listOfGames games = new listOfGames();
            games.Show();
            Hide();
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            listOfUsers listOfU = new listOfUsers();
            listOfU.Show();
            Hide();
        }

        private void Main_Loading(object sender, EventArgs e)
        {
            buffer = File.ReadAllLines("../../../#Buffer/buffer.txt");
            edit_authorization.Text = buffer[0];

            if (buffer[0] == "Менеджер")
            {
                btn_users.Visible = false;
            }
            if (buffer[0] != "Admin" && buffer[0] != "Менеджер")
            {
                btn_users.Visible = false;
                btn_orders.Visible = false;
            }
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            Orders ord = new Orders();
            ord.Show();
            Hide();
        }

        private void btn_myGames_Click(object sender, EventArgs e)
        {
            MyGames myG = new MyGames();
            myG.Show();
            Hide();
        }
    }
}
