namespace Sem2CondicionalesVentana
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
            button1 = new Button();
            txtnum1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtnum2 = new TextBox();
            label3 = new Label();
            txtnum3 = new TextBox();
            lblcalculo = new Label();
            btnlimpiar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(25, 235);
            button1.Name = "button1";
            button1.Size = new Size(100, 42);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(151, 24);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(100, 23);
            txtnum1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 2;
            label1.Text = "Numero 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 74);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 4;
            label2.Text = "Numero 2: ";
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(151, 72);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(100, 23);
            txtnum2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 123);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 6;
            label3.Text = "Numero 3:";
            // 
            // txtnum3
            // 
            txtnum3.Location = new Point(151, 121);
            txtnum3.Name = "txtnum3";
            txtnum3.Size = new Size(100, 23);
            txtnum3.TabIndex = 5;
            // 
            // lblcalculo
            // 
            lblcalculo.AutoSize = true;
            lblcalculo.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblcalculo.Location = new Point(22, 195);
            lblcalculo.Name = "lblcalculo";
            lblcalculo.Size = new Size(103, 21);
            lblcalculo.TabIndex = 7;
            lblcalculo.Text = "El mayor es ";
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(151, 235);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(100, 42);
            btnlimpiar.TabIndex = 8;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 289);
            Controls.Add(btnlimpiar);
            Controls.Add(lblcalculo);
            Controls.Add(label3);
            Controls.Add(txtnum3);
            Controls.Add(label2);
            Controls.Add(txtnum2);
            Controls.Add(label1);
            Controls.Add(txtnum1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtnum1;
        private Label label1;
        private Label label2;
        private TextBox txtnum2;
        private Label label3;
        private TextBox txtnum3;
        private Label lblcalculo;
        private Button btnlimpiar;
    }
}