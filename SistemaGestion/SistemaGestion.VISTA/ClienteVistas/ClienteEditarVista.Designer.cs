namespace SistemaGestion.VISTA.ClienteVistas
{
    partial class ClienteEditarVista
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
            button2 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(227, 222);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 41;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(77, 222);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 40;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(158, 174);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(256, 23);
            textBox5.TabIndex = 39;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 143);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(256, 23);
            textBox4.TabIndex = 38;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(158, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(158, 81);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 23);
            textBox2.TabIndex = 36;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 23);
            textBox1.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 181);
            label5.Name = "label5";
            label5.Size = new Size(73, 16);
            label5.TabIndex = 34;
            label5.Text = "DIRECCION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label4.Location = new Point(12, 150);
            label4.Name = "label4";
            label4.Size = new Size(69, 16);
            label4.TabIndex = 33;
            label4.Text = "TELEFONO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(140, 16);
            label3.TabIndex = 32;
            label3.Text = "CORREOELECTRONICO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(65, 16);
            label2.TabIndex = 31;
            label2.Text = "APELLIDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 55);
            label1.Name = "label1";
            label1.Size = new Size(59, 16);
            label1.TabIndex = 30;
            label1.Text = "NOMBRE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Wide Latin", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(106, 9);
            label6.Name = "label6";
            label6.Size = new Size(176, 26);
            label6.TabIndex = 42;
            label6.Text = "EDITAR";
            // 
            // ClienteEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(429, 280);
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
            Name = "ClienteEditarVista";
            Text = "ClienteEditarVista";
            Load += ClienteEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}