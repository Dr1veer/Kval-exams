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
    public partial class listOfGames : Form
    {
        private Button btn_back;
        private Button btn_addGames;
        private Label label1;
        string[] numArrPerem;
        private Button btn_editGame;
        private Button btn_buy;
        private TextBox tb_numGame;
        private Label label2;
        string[] login;
        string[] buffer;

        public listOfGames()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_addGames = new System.Windows.Forms.Button();
            this.btn_editGame = new System.Windows.Forms.Button();
            this.btn_buy = new System.Windows.Forms.Button();
            this.tb_numGame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логотип";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1112, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(99, 43);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_addGames
            // 
            this.btn_addGames.Location = new System.Drawing.Point(957, 10);
            this.btn_addGames.Name = "btn_addGames";
            this.btn_addGames.Size = new System.Drawing.Size(139, 44);
            this.btn_addGames.TabIndex = 2;
            this.btn_addGames.Text = "Добавить товар";
            this.btn_addGames.UseVisualStyleBackColor = true;
            this.btn_addGames.Click += new System.EventHandler(this.btn_addGames_Click);
            // 
            // btn_editGame
            // 
            this.btn_editGame.Location = new System.Drawing.Point(751, 10);
            this.btn_editGame.Name = "btn_editGame";
            this.btn_editGame.Size = new System.Drawing.Size(189, 43);
            this.btn_editGame.TabIndex = 3;
            this.btn_editGame.Text = "Редактировать товар";
            this.btn_editGame.UseVisualStyleBackColor = true;
            this.btn_editGame.Click += new System.EventHandler(this.btn_editGame_Click);
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(572, 10);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(136, 43);
            this.btn_buy.TabIndex = 4;
            this.btn_buy.Text = "Купить";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // tb_numGame
            // 
            this.tb_numGame.Location = new System.Drawing.Point(441, 28);
            this.tb_numGame.Name = "tb_numGame";
            this.tb_numGame.Size = new System.Drawing.Size(125, 27);
            this.tb_numGame.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Номер товара";
            // 
            // listOfGames
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1244, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_numGame);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.btn_editGame);
            this.Controls.Add(this.btn_addGames);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Name = "listOfGames";
            this.Load += new System.EventHandler(this.listOfGames_Loading);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }

        private void btn_addGames_Click(object sender, EventArgs e)
        {
            AddGame addgame = new AddGame();
            addgame.Show();
            Hide();
        }

        private void btn_editGame_Click(object sender, EventArgs e)
        {
            EditGame editG = new EditGame();
            editG.Show();
            Hide();
        }

        private void listOfGames_Loading(object sender, EventArgs e)
        {
            buffer = File.ReadAllLines("../../../#Buffer/buffer.txt");
            if (buffer[0] != "Admin")
            {
                btn_editGame.Visible = false;
                btn_addGames.Visible = false;

            }
            int numArrPeremLocal;
            int LocationX = 0;
            int LocationY = 0;
            numArrPerem = File.ReadAllLines("../../../BD_games/numArr.txt");
            numArrPeremLocal = Int32.Parse(numArrPerem[0]);

            for (int i = 1; i <= numArrPeremLocal; i++)
            {
                login = File.ReadAllLines("../../../BD_games/" + i + ".txt");
                Panel panel2 = new Panel();
                this.Controls.Add(panel2);
                panel2.Location = new Point(LocationX + 72, LocationY + 104);
                panel2.Name = "background_" + i;
                panel2.Width = 335;
                panel2.Height = 402;
                panel2.BackColor = Color.FromArgb(255, 102, 0);
                panel2.SendToBack();

                PictureBox picBox2 = new PictureBox();
                this.Controls.Add(picBox2);
                picBox2.ImageLocation = login[0];
                picBox2.SizeMode = PictureBoxSizeMode.Zoom;
                picBox2.Location = new Point(LocationX + 91, LocationY + 123);
                picBox2.Name = "img_" + i;
                picBox2.Width = 295;
                picBox2.Height = 172;
                picBox2.BringToFront();
                picBox2.BackColor = Color.FromArgb(255, 102, 0);


                Label label5 = new Label();
                this.Controls.Add(label5);
                label5.Location = new Point(LocationX + 91, LocationY + 318);
                label5.Width = 295;
                label5.Height = 113;
                label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                label5.ForeColor = System.Drawing.SystemColors.Control;
                label5.Name = "text_" + i;
                label5.Text = login[1];
                label5.AutoSize = false;
                label5.BringToFront();
                label5.BackColor = Color.FromArgb(255, 102, 0);

                Label label6 = new Label();
                this.Controls.Add(label6);
                label6.AutoSize = true;
                label6.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                label6.ForeColor = System.Drawing.SystemColors.Control;
                label6.Location = new System.Drawing.Point(LocationX + 183, LocationY + 450);
                label6.Name = "price_" + i;
                label6.Size = new System.Drawing.Size(101, 146);
                label6.Text = login[2] + " р.";
                label6.BringToFront();
                label6.BackColor = Color.FromArgb(192, 0, 0);

                Label label7 = new Label();
                this.Controls.Add(label7);
                label7.AutoSize = true;
                label7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                label7.ForeColor = System.Drawing.SystemColors.Control;
                label7.Location = new System.Drawing.Point(LocationX + 76, LocationY + 113);
                label7.Name = "numberOfGame_" + i;
                label7.Text = "№ " + i;
                label7.BringToFront();
                label7.BackColor = Color.FromArgb(255, 102, 0);

                LocationX += 380;
                if (LocationX > 760)
                {
                    LocationX = 0;
                    LocationY += 450;
                }
            }
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (tb_numGame.Text != "")
            {
                int numArrPeremLocal;
                buffer = File.ReadAllLines("../../../#Buffer/buffer.txt");

                numArrPerem = File.ReadAllLines("../../../BD_orders/numArr.txt");
                numArrPeremLocal = Int32.Parse(numArrPerem[0]);

                StreamWriter numArr = new StreamWriter("../../../BD_orders/numArr.txt");
                numArrPeremLocal++;
                numArr.WriteLine(numArrPeremLocal);
                numArr.Close();
                StreamWriter user = new StreamWriter("../../../BD_orders/" + numArrPeremLocal + ".txt");
                user.WriteLine(buffer[0]);
                user.WriteLine(tb_numGame.Text);
                user.WriteLine("0");
                user.Close();

                tb_numGame.Text = "";
                MessageBox.Show("Поздравляем с покупкой! \n\n Купленные товары вы можете посмотреть во вкладке \"Мои товары\"");
            } else
            {
                MessageBox.Show("Введите номер товара");
            }
        }
    }
}