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
    public partial class MyGames : Form
    {
        private Button btn_back;
        string[] numArrPerem;
        string[] objGame;
        string[] buffer;
        string[] objOrder;


        public MyGames()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1111, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(95, 32);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // MyGames
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1244, 643);
            this.Controls.Add(this.btn_back);
            this.Name = "MyGames";
            this.Load += new System.EventHandler(this.MyGames_Loading);
            this.ResumeLayout(false);

        }

        private void MyGames_Loading(object sender, EventArgs e)
        {
            int numArrPeremLocal;
            int LocationX = 0;
            int LocationY = 0;
            buffer = File.ReadAllLines("../../../#Buffer/buffer.txt");

            numArrPerem = File.ReadAllLines("../../../BD_orders/numArr.txt");
            numArrPeremLocal = Int32.Parse(numArrPerem[0]);

            for (int i = 1; i <= numArrPeremLocal; i++)
            {
                objOrder = File.ReadAllLines("../../../BD_orders/" + i + ".txt");
                if (objOrder[0] == buffer[0])
                {
                    objGame = File.ReadAllLines("../../../BD_games/" + objOrder[1] + ".txt");
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
                    picBox2.ImageLocation = objGame[0];
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
                    label5.Text = objGame[1];
                    label5.AutoSize = false;
                    label5.BringToFront();
                    label5.BackColor = Color.FromArgb(255, 102, 0);

                    Label label6 = new Label();
                    this.Controls.Add(label6);
                    label6.AutoSize = true;
                    label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    label6.ForeColor = System.Drawing.SystemColors.Control;
                    label6.Location = new System.Drawing.Point(LocationX + 130, LocationY + 450);
                    label6.Name = "price_" + i;
                    label6.Size = new System.Drawing.Size(101, 146);
                    if (objOrder[2] == "0")
                    {
                        label6.Text = "Ожидает подтверждение";
                    }
                    else
                    {
                        label6.Text = "Покупка подтверждена";
                    }

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
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }
    }
}