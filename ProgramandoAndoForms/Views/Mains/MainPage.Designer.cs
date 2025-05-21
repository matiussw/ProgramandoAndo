namespace ProgramandoAndoForms.Views.Mains
{
    partial class MainPage
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
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 37);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 0;
            label1.Text = "ProgramandoAndo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-108, 120);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 75);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(514, 99);
            textBox1.TabIndex = 2;
            textBox1.Text = "En este Proyecto Podremos Acceder a diferentes ejercicios de logica y programacion con el lenguage de programacion de C# ";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 220);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 4;
            label4.Text = "Ejercicos MVC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 220);
            label5.Name = "label5";
            label5.Size = new Size(279, 25);
            label5.TabIndex = 5;
            label5.Text = "Ejercicos MVC Con Base De Datos";
            // 
            // button1
            // 
            button1.Location = new Point(12, 264);
            button1.Name = "button1";
            button1.Size = new Size(325, 37);
            button1.TabIndex = 6;
            button1.Text = "Pagina Principal Ejercicios MVC";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(462, 264);
            button2.Name = "button2";
            button2.Size = new Size(282, 37);
            button2.TabIndex = 7;
            button2.Text = "Pagina Principal Bases De Datos";
            button2.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MainPage";
            Text = "MainPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}