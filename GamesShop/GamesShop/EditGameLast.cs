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
    public partial class EditGameLast : Form
    {
        private Panel panel1;
        private Button btn_editData;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox tb_price;
        private TextBox tb_bigText;
        private TextBox tb_link;
        private TextBox tb_numGame;
        private Label label1;
        private Label label2;
        private Button btn_back;
        string[] numArrPerem;

        public EditGameLast()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_editData = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_bigText = new System.Windows.Forms.TextBox();
            this.tb_link = new System.Windows.Forms.TextBox();
            this.tb_numGame = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1014, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_editData);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_price);
            this.panel1.Controls.Add(this.tb_bigText);
            this.panel1.Controls.Add(this.tb_link);
            this.panel1.Controls.Add(this.tb_numGame);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(351, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 446);
            this.panel1.TabIndex = 1;
            // 
            // btn_editData
            // 
            this.btn_editData.Location = new System.Drawing.Point(118, 382);
            this.btn_editData.Name = "btn_editData";
            this.btn_editData.Size = new System.Drawing.Size(166, 40);
            this.btn_editData.TabIndex = 8;
            this.btn_editData.Text = "Внести изменения";
            this.btn_editData.UseVisualStyleBackColor = true;
            this.btn_editData.Click += new System.EventHandler(this.btn_editData_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Цена товара";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Описание товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ссылка на изображение";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(59, 326);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(268, 27);
            this.tb_price.TabIndex = 4;
            // 
            // tb_bigText
            // 
            this.tb_bigText.Location = new System.Drawing.Point(59, 234);
            this.tb_bigText.Name = "tb_bigText";
            this.tb_bigText.Size = new System.Drawing.Size(268, 27);
            this.tb_bigText.TabIndex = 3;
            // 
            // tb_link
            // 
            this.tb_link.Location = new System.Drawing.Point(59, 132);
            this.tb_link.Name = "tb_link";
            this.tb_link.Size = new System.Drawing.Size(268, 27);
            this.tb_link.TabIndex = 2;
            // 
            // tb_numGame
            // 
            this.tb_numGame.Location = new System.Drawing.Point(59, 44);
            this.tb_numGame.Name = "tb_numGame";
            this.tb_numGame.Size = new System.Drawing.Size(268, 27);
            this.tb_numGame.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(386, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Изменить данные товара";
            // 
            // EditGameLast
            // 
            this.ClientSize = new System.Drawing.Size(1120, 547);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Name = "EditGameLast";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            listOfGames listOfG = new listOfGames();
            listOfG.Show();
            Hide();
        }

        private void btn_editData_Click(object sender, EventArgs e)
        {
            int numArrPeremLocal;
            int numGame = Int32.Parse(tb_numGame.Text);

            try
            {
                numArrPerem = File.ReadAllLines("../../../BD_games/" + numGame + ".txt");
                StreamWriter dataOfGame = new StreamWriter("../../../BD_games/" + numGame + ".txt");
                if (tb_link.Text != "" && tb_bigText.Text != "" && tb_price.Text != "")
                {
                    dataOfGame.WriteLine(tb_link.Text);
                    dataOfGame.WriteLine(tb_bigText.Text);
                    dataOfGame.WriteLine(tb_price.Text);
                    dataOfGame.Close();

                    listOfGames listOfG = new listOfGames();
                    listOfG.Show();
                    Hide();
                } else if (tb_link.Text != "" && tb_bigText.Text != "")
                {
                    dataOfGame.WriteLine(tb_link.Text);
                    dataOfGame.WriteLine(tb_bigText.Text);
                    dataOfGame.WriteLine(numArrPerem[2]);
                    dataOfGame.Close();

                    listOfGames listOfG = new listOfGames();
                    listOfG.Show();
                    Hide();
                } else if (tb_bigText.Text != "" && tb_price.Text != "") {
                    dataOfGame.WriteLine(numArrPerem[0]);
                    dataOfGame.WriteLine(tb_bigText.Text);
                    dataOfGame.WriteLine(tb_price.Text);
                    dataOfGame.Close();

                    listOfGames listOfG = new listOfGames();
                    listOfG.Show();
                    Hide();
                } else if (tb_link.Text != "" && tb_price.Text != "")   {
                    dataOfGame.WriteLine(tb_link.Text);
                    dataOfGame.WriteLine(numArrPerem[1]);
                    dataOfGame.WriteLine(tb_price.Text);
                    dataOfGame.Close();

                    listOfGames listOfG = new listOfGames();
                    listOfG.Show();
                    Hide();
                } else if (tb_link.Text != "") {
                    dataOfGame.WriteLine(tb_link.Text);
                    dataOfGame.WriteLine(numArrPerem[1]);
                    dataOfGame.WriteLine(numArrPerem[2]);
                    dataOfGame.Close();

                    listOfGames listOfG = new listOfGames();
                    listOfG.Show();
                    Hide();
                } else if (tb_bigText.Text != "") {
                    dataOfGame.WriteLine(numArrPerem[0]);
                    dataOfGame.WriteLine(tb_bigText.Text);
                    dataOfGame.WriteLine(numArrPerem[2]);
                    dataOfGame.Close();

                    listOfGames listOfG = new listOfGames();
                    listOfG.Show();
                    Hide();
                } else if (tb_price.Text != "") {
                    dataOfGame.WriteLine(numArrPerem[0]);
                    dataOfGame.WriteLine(numArrPerem[1]);
                    dataOfGame.WriteLine(tb_price.Text);
                    dataOfGame.Close();

                    listOfGames listOfG = new listOfGames();
                    listOfG.Show();
                    Hide();
                } else
                {
                    MessageBox.Show("Введите данные");
                }
            }
            catch
            {
                MessageBox.Show("Товара с таким номером не существует");
            }
        }
    }
}
