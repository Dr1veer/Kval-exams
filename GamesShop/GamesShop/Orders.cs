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
    public partial class Orders : Form
    {
        private Button btn_back;
        private DataGridView dt_orders;
        private Button btn_confirmOrder;
        private Button btn_deleteOrder;
        private TextBox tb_numOrder;
        private Label label1;
        string[] numArrPerem;
        string[] login;
        string[] buffer;

        public Orders()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.btn_back = new System.Windows.Forms.Button();
            this.dt_orders = new System.Windows.Forms.DataGridView();
            this.btn_confirmOrder = new System.Windows.Forms.Button();
            this.btn_deleteOrder = new System.Windows.Forms.Button();
            this.tb_numOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1018, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(94, 29);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dt_orders
            // 
            this.dt_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_orders.Location = new System.Drawing.Point(295, 119);
            this.dt_orders.Name = "dt_orders";
            this.dt_orders.RowHeadersWidth = 51;
            this.dt_orders.RowTemplate.Height = 29;
            this.dt_orders.Size = new System.Drawing.Size(554, 421);
            this.dt_orders.TabIndex = 1;
            // 
            // btn_confirmOrder
            // 
            this.btn_confirmOrder.Location = new System.Drawing.Point(12, 222);
            this.btn_confirmOrder.Name = "btn_confirmOrder";
            this.btn_confirmOrder.Size = new System.Drawing.Size(188, 39);
            this.btn_confirmOrder.TabIndex = 2;
            this.btn_confirmOrder.Text = "Подтвердить продажу";
            this.btn_confirmOrder.UseVisualStyleBackColor = true;
            this.btn_confirmOrder.Click += new System.EventHandler(this.btn_confirmOrder_Click);
            // 
            // btn_deleteOrder
            // 
            this.btn_deleteOrder.Location = new System.Drawing.Point(12, 267);
            this.btn_deleteOrder.Name = "btn_deleteOrder";
            this.btn_deleteOrder.Size = new System.Drawing.Size(125, 37);
            this.btn_deleteOrder.TabIndex = 3;
            this.btn_deleteOrder.Text = "Удалить заказ";
            this.btn_deleteOrder.UseVisualStyleBackColor = true;
            this.btn_deleteOrder.Click += new System.EventHandler(this.btn_deleteOrder_Click);
            // 
            // tb_numOrder
            // 
            this.tb_numOrder.Location = new System.Drawing.Point(12, 177);
            this.tb_numOrder.Name = "tb_numOrder";
            this.tb_numOrder.Size = new System.Drawing.Size(174, 27);
            this.tb_numOrder.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Номер заказа";
            // 
            // Orders
            // 
            this.ClientSize = new System.Drawing.Size(1124, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_numOrder);
            this.Controls.Add(this.btn_deleteOrder);
            this.Controls.Add(this.btn_confirmOrder);
            this.Controls.Add(this.dt_orders);
            this.Controls.Add(this.btn_back);
            this.Name = "Orders";
            this.Load += new System.EventHandler(this.Orders_Loading);
            ((System.ComponentModel.ISupportInitialize)(this.dt_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }

        private void Orders_Loading(object sender, EventArgs e)
        {
            buffer = File.ReadAllLines("../../../#Buffer/buffer.txt");
            if (buffer[0] != "Admin")
            {
                btn_deleteOrder.Visible = false;
            }

            int numArrPeremLocal;
            int count = 0;
            numArrPerem = File.ReadAllLines("../../../BD_orders/numArr.txt");
            numArrPeremLocal = Int32.Parse(numArrPerem[0]);

            dt_orders.RowCount = numArrPeremLocal;
            dt_orders.ColumnCount = 4;
            dt_orders.Columns[0].HeaderText = "№ заказа";
            dt_orders.Columns[1].HeaderText = "Логин покупателя";
            dt_orders.Columns[2].HeaderText = "№ товара";
            dt_orders.Columns[3].HeaderText = "Подтверждение продажи";

            for (int i = 1; i <= numArrPeremLocal; i++)
            {
                login = File.ReadAllLines("../../../BD_orders/" + i + ".txt");
                dt_orders.Rows[count].Cells[0].Value = i.ToString();
                dt_orders.Rows[count].Cells[1].Value = login[0];
                dt_orders.Rows[count].Cells[2].Value = login[1];
                if (login[2] == "0")
                {
                    dt_orders.Rows[count].Cells[3].Value = "Ожидает подтверждение";
                } else
                {
                    dt_orders.Rows[count].Cells[3].Value = "Продажа подтверждена";
                }
                count++;
            }
        }

        private void btn_deleteOrder_Click(object sender, EventArgs e)
        {
            File.Delete("../../../BD_orders/" + tb_numOrder.Text + ".txt");
            numArrPerem = File.ReadAllLines("../../../BD_orders/numArr.txt");
            int numArrPeremLocal = Int32.Parse(numArrPerem[0]);
            int startFor = Int32.Parse(tb_numOrder.Text);
            int ParseI = startFor;

            for (int i = startFor; i <= numArrPeremLocal; i++)
            {
                ParseI++;
                string src = "../../../BD_orders/" + ParseI + ".txt";
                string dest = "../../../BD_orders/" + i + ".txt";
                try
                {
                    File.Move(src, dest);
                }
                catch { }

            }
            StreamWriter numArr = new StreamWriter("../../../BD_orders/numArr.txt");
            numArrPeremLocal--;
            numArr.WriteLine(numArrPeremLocal);
            numArr.Close();

            int count = 0;
            dt_orders.RowCount = numArrPeremLocal;
            dt_orders.ColumnCount = 4;
            dt_orders.Columns[0].HeaderText = "№ заказа";
            dt_orders.Columns[1].HeaderText = "Логин покупателя";
            dt_orders.Columns[2].HeaderText = "№ товара";
            dt_orders.Columns[3].HeaderText = "Подтверждение продажи";

            for (int i = 1; i <= numArrPeremLocal; i++)
            {
                login = File.ReadAllLines("../../../BD_orders/" + i + ".txt");
                dt_orders.Rows[count].Cells[0].Value = i.ToString();
                dt_orders.Rows[count].Cells[1].Value = login[0];
                dt_orders.Rows[count].Cells[2].Value = login[1];
                if (login[2] == "0")
                {
                    dt_orders.Rows[count].Cells[3].Value = "Ожидает подтверждение";
                }
                else
                {
                    dt_orders.Rows[count].Cells[3].Value = "Продажа подтверждена";
                }
                count++;
            }

            MessageBox.Show("Успешно удалено");
            tb_numOrder.Text = "";
        }

        private void btn_confirmOrder_Click(object sender, EventArgs e)
        {
            login = File.ReadAllLines("../../../BD_orders/" + tb_numOrder.Text + ".txt");
            StreamWriter order = new StreamWriter("../../../BD_orders/" + tb_numOrder.Text + ".txt");
            order.WriteLine(login[0]);
            order.WriteLine(login[1]);
            order.WriteLine("1");
            order.Close();

            numArrPerem = File.ReadAllLines("../../../BD_orders/numArr.txt");
            
            int numArrPeremLocal = Int32.Parse(numArrPerem[0]);
            int count = 0;
            dt_orders.RowCount = numArrPeremLocal;
            dt_orders.ColumnCount = 4;
            dt_orders.Columns[0].HeaderText = "№ заказа";
            dt_orders.Columns[1].HeaderText = "Логин покупателя";
            dt_orders.Columns[2].HeaderText = "№ товара";
            dt_orders.Columns[3].HeaderText = "Подтверждение продажи";

            for (int i = 1; i <= numArrPeremLocal; i++)
            {
                login = File.ReadAllLines("../../../BD_orders/" + i + ".txt");
                dt_orders.Rows[count].Cells[0].Value = i.ToString();
                dt_orders.Rows[count].Cells[1].Value = login[0];
                dt_orders.Rows[count].Cells[2].Value = login[1];
                if (login[2] == "0")
                {
                    dt_orders.Rows[count].Cells[3].Value = "Ожидает подтверждение";
                }
                else
                {
                    dt_orders.Rows[count].Cells[3].Value = "Продажа подтверждена";
                }
                count++;
            }

            MessageBox.Show("Успешно подтверждено");
            tb_numOrder.Text = "";
        }
    }
}
