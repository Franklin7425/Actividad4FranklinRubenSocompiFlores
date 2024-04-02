namespace SistemaGestion.VISTA.PedidoVistas
{
    partial class PedidoListarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Wide Latin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 70);
            label2.Name = "label2";
            label2.Size = new Size(403, 26);
            label2.TabIndex = 21;
            label2.Text = "LISTA DE PEDIDOS";
            // 
            // button3
            // 
            button3.Location = new Point(120, 21);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(106, 22);
            button3.TabIndex = 19;
            button3.Text = "EDITAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(232, 21);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(106, 22);
            button4.TabIndex = 18;
            button4.Text = "ELIMINAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(8, 21);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(106, 22);
            button2.TabIndex = 17;
            button2.Text = "AGREGAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 113);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(605, 320);
            dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.HotTrack;
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(676, 60);
            label1.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(344, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 22;
            button1.Text = "CALCULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PedidoListarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(675, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "PedidoListarVista";
            Text = "PedidoListarVista";
            Load += PedidoListarVista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button button3;
        private Button button4;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
    }
}