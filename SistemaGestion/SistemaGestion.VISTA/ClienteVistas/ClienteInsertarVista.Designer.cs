namespace SistemaGestion.VISTA.ClienteVistas
{
    partial class ClienteInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label1.Location = new Point(21, 61);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 94);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 1;
            label2.Text = "APELLIDO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label3.Location = new Point(21, 126);
            label3.Name = "label3";
            label3.Size = new Size(140, 16);
            label3.TabIndex = 2;
            label3.Text = "CORREOELECTRONICO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label4.Location = new Point(21, 156);
            label4.Name = "label4";
            label4.Size = new Size(69, 16);
            label4.TabIndex = 3;
            label4.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label5.Location = new Point(21, 187);
            label5.Name = "label5";
            label5.Size = new Size(73, 16);
            label5.TabIndex = 4;
            label5.Text = "DIRECCION";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(167, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(167, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(167, 149);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(167, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(256, 23);
            textBox5.TabIndex = 9;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(236, 228);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 29;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(86, 228);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 28;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Wide Latin", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(77, 9);
            label6.Name = "label6";
            label6.Size = new Size(285, 33);
            label6.TabIndex = 30;
            label6.Text = "AGREGAR";
            // 
            // ClienteInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(450, 318);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClienteInsertarVista";
            Text = "ClienteInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
        private Button button1;
        private Label label6;
    }
}