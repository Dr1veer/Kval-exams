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
    public partial class DeleteGame : Form
    {
        private Panel panel1;
        private TextBox tb_numGame;
        private Label label2;
        private Button btn_delete;
        private Label label1;
        private Button btn_back;
        string[] numArrPerem;

        public DeleteGame()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_numGame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.tb_numGame);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Location = new System.Drawing.Point(438, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 326);
            this.panel1.TabIndex = 0;
            // 
            // tb_numGame
            // 
            this.tb_numGame.Location = new System.Drawing.Point(51, 101);
            this.tb_numGame.Name = "tb_numGame";
            this.tb_numGame.Size = new System.Drawing.Size(188, 27);
            this.tb_numGame.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите номер товара";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(83, 260);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(135, 46);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(464, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Удалить товар";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1015, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // DeleteGame
            // 
            this.ClientSize = new System.Drawing.Size(1121, 545);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteGame";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            File.Delete("../../../BD_games/" + tb_numGame.Text + ".txt");
            numArrPerem = File.ReadAllLines("../../../BD_games/numArr.txt");
            int numArrPeremLocal = Int32.Parse(numArrPerem[0]);
            int startFor = Int32.Parse(tb_numGame.Text);
            int ParseI = startFor;

            for (int i = startFor; i<= numArrPeremLocal; i++)
            {
                ParseI++;
                string src = "../../../BD_games/" + ParseI + ".txt";
                string dest = "../../../BD_games/" + i + ".txt";
                try
                {
                    File.Move(src, dest);
                } catch { }
                
            }
            StreamWriter numArr = new StreamWriter("../../../BD_games/numArr.txt");
            numArrPeremLocal--;
            numArr.WriteLine(numArrPeremLocal);
            numArr.Close();

            listOfGames listOfG = new listOfGames();
            listOfG.Show();
            Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            listOfGames listOfG = new listOfGames();
            listOfG.Show();
            Hide();
        }
    }
}
