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
    public partial class AddGame : Form
    {
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox tb_bigText;
        private Button btn_addGame;
        private TextBox tb_price;
        private TextBox tb_linkOnImg;
        private Label label4;
        private Label label3;
        private Button btn_back;
        string[] numArrPerem;

        public AddGame()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_bigText = new System.Windows.Forms.TextBox();
            this.btn_addGame = new System.Windows.Forms.Button();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_linkOnImg = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(445, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить товар";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_bigText);
            this.panel1.Controls.Add(this.btn_addGame);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.tb_linkOnImg);
            this.panel1.Location = new System.Drawing.Point(344, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 419);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Описание товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ссылка на изображение";
            // 
            // tb_bigText
            // 
            this.tb_bigText.Location = new System.Drawing.Point(101, 167);
            this.tb_bigText.Name = "tb_bigText";
            this.tb_bigText.Size = new System.Drawing.Size(255, 27);
            this.tb_bigText.TabIndex = 3;
            // 
            // btn_addGame
            // 
            this.btn_addGame.Location = new System.Drawing.Point(137, 346);
            this.btn_addGame.Name = "btn_addGame";
            this.btn_addGame.Size = new System.Drawing.Size(177, 50);
            this.btn_addGame.TabIndex = 2;
            this.btn_addGame.Text = "Добавить";
            this.btn_addGame.UseVisualStyleBackColor = true;
            this.btn_addGame.Click += new System.EventHandler(this.btn_addGame_Click);
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(101, 272);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(255, 27);
            this.tb_price.TabIndex = 1;
            // 
            // tb_linkOnImg
            // 
            this.tb_linkOnImg.Location = new System.Drawing.Point(101, 60);
            this.tb_linkOnImg.Name = "tb_linkOnImg";
            this.tb_linkOnImg.Size = new System.Drawing.Size(255, 27);
            this.tb_linkOnImg.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1024, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddGame
            // 
            this.ClientSize = new System.Drawing.Size(1130, 562);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "AddGame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            listOfGames games = new listOfGames();
            games.Show();
            Hide();
        }

        private void btn_addGame_Click(object sender, EventArgs e)
        {
            int numArrPeremLocal;

            numArrPerem = File.ReadAllLines("../../../BD_games/numArr.txt");
            numArrPeremLocal = Int32.Parse(numArrPerem[0]);

            StreamWriter numArr = new StreamWriter("../../../BD_games/numArr.txt");
            numArrPeremLocal++;
            numArr.WriteLine(numArrPeremLocal);
            numArr.Close();
            StreamWriter game = new StreamWriter("../../../BD_games/" + numArrPeremLocal + ".txt");
            game.WriteLine(tb_linkOnImg.Text);
            game.WriteLine(tb_bigText.Text);
            game.WriteLine(tb_price.Text);
            game.Close();

            listOfGames games = new listOfGames();
            games.Show();
            Hide();
        }
    }
}