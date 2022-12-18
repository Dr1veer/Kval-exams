
namespace GamesShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_registration = new System.Windows.Forms.Button();
            this.btn_authorization = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitApp
            // 
            this.ExitApp.Location = new System.Drawing.Point(1022, 12);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(94, 29);
            this.ExitApp.TabIndex = 1;
            this.ExitApp.Text = "Выход";
            this.ExitApp.UseVisualStyleBackColor = true;
            this.ExitApp.Click += new System.EventHandler(this.ExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(434, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_registration);
            this.panel1.Controls.Add(this.btn_authorization);
            this.panel1.Location = new System.Drawing.Point(367, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 312);
            this.panel1.TabIndex = 3;
            // 
            // btn_registration
            // 
            this.btn_registration.Location = new System.Drawing.Point(85, 179);
            this.btn_registration.Name = "btn_registration";
            this.btn_registration.Size = new System.Drawing.Size(160, 49);
            this.btn_registration.TabIndex = 1;
            this.btn_registration.Text = "Регистрация";
            this.btn_registration.UseVisualStyleBackColor = true;
            this.btn_registration.Click += new System.EventHandler(this.btn_registration_Click);
            // 
            // btn_authorization
            // 
            this.btn_authorization.Location = new System.Drawing.Point(85, 82);
            this.btn_authorization.Name = "btn_authorization";
            this.btn_authorization.Size = new System.Drawing.Size(160, 46);
            this.btn_authorization.TabIndex = 0;
            this.btn_authorization.Text = "Войти";
            this.btn_authorization.UseVisualStyleBackColor = true;
            this.btn_authorization.Click += new System.EventHandler(this.btn_authorization_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 508);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitApp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_registration;
        private System.Windows.Forms.Button btn_authorization;
    }
}

