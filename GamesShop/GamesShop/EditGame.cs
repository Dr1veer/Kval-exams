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
    public partial class EditGame : Form
    {
        private Button btn_delete;
        private Panel panel1;
        private Label label1;
        private Button btn_edit;

        public EditGame()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(274, 91);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(144, 46);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(69, 91);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(155, 46);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Редактировать";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Location = new System.Drawing.Point(311, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 229);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(393, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберетите действие";
            // 
            // EditGame
            // 
            this.ClientSize = new System.Drawing.Size(1104, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "EditGame";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditGameLast editGL = new EditGameLast();
            editGL.Show();
            Hide();
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteGame delGame = new DeleteGame();
            delGame.Show();
            Hide();
        }
    }
}
