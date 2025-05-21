namespace ProgramandoAndoForms.Views.MVCExercises
{
    partial class ViewIncapacidades
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
            Calcular = new Button();
            ComboDisease = new ComboBox();
            label1 = new Label();
            SalarioSub = new Label();
            ValorIn = new Label();
            SalarioTotal = new Label();
            MostrarSalarioSub = new Label();
            MostrarValorIn = new Label();
            MostrarSalarioTotal = new Label();
            txtSalary = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // Calcular
            // 
            Calcular.Location = new Point(286, 368);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(178, 50);
            Calcular.TabIndex = 0;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // ComboDisease
            // 
            ComboDisease.FormattingEnabled = true;
            ComboDisease.Location = new Point(41, 73);
            ComboDisease.Name = "ComboDisease";
            ComboDisease.Size = new Size(217, 33);
            ComboDisease.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 29);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 2;
            label1.Text = "Enfermedades";
            // 
            // SalarioSub
            // 
            SalarioSub.AutoSize = true;
            SalarioSub.Location = new Point(286, 179);
            SalarioSub.Name = "SalarioSub";
            SalarioSub.Size = new Size(96, 25);
            SalarioSub.TabIndex = 3;
            SalarioSub.Text = "SalarioSub";
            // 
            // ValorIn
            // 
            ValorIn.AutoSize = true;
            ValorIn.Location = new Point(286, 226);
            ValorIn.Name = "ValorIn";
            ValorIn.Size = new Size(161, 25);
            ValorIn.TabIndex = 4;
            ValorIn.Text = "Valor Incapacidaad";
            // 
            // SalarioTotal
            // 
            SalarioTotal.AutoSize = true;
            SalarioTotal.Location = new Point(286, 273);
            SalarioTotal.Name = "SalarioTotal";
            SalarioTotal.Size = new Size(107, 25);
            SalarioTotal.TabIndex = 5;
            SalarioTotal.Text = "Salario Total";
            // 
            // MostrarSalarioSub
            // 
            MostrarSalarioSub.AutoSize = true;
            MostrarSalarioSub.Location = new Point(489, 179);
            MostrarSalarioSub.Name = "MostrarSalarioSub";
            MostrarSalarioSub.Size = new Size(0, 25);
            MostrarSalarioSub.TabIndex = 6;
            // 
            // MostrarValorIn
            // 
            MostrarValorIn.AutoSize = true;
            MostrarValorIn.Location = new Point(489, 226);
            MostrarValorIn.Name = "MostrarValorIn";
            MostrarValorIn.Size = new Size(0, 25);
            MostrarValorIn.TabIndex = 7;
            // 
            // MostrarSalarioTotal
            // 
            MostrarSalarioTotal.AutoSize = true;
            MostrarSalarioTotal.Location = new Point(489, 273);
            MostrarSalarioTotal.Name = "MostrarSalarioTotal";
            MostrarSalarioTotal.Size = new Size(0, 25);
            MostrarSalarioTotal.TabIndex = 8;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(513, 73);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(210, 31);
            txtSalary.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(563, 29);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 10;
            label2.Text = "Salario";
            // 
            // ViewIncapacidades
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtSalary);
            Controls.Add(MostrarSalarioTotal);
            Controls.Add(MostrarValorIn);
            Controls.Add(MostrarSalarioSub);
            Controls.Add(SalarioTotal);
            Controls.Add(ValorIn);
            Controls.Add(SalarioSub);
            Controls.Add(label1);
            Controls.Add(ComboDisease);
            Controls.Add(Calcular);
            Name = "ViewIncapacidades";
            Text = "ViewInability";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Button Calcular;
        private ComboBox ComboDisease;
        private Label label1;
        private Label SalarioSub;
        private Label ValorIn;
        private Label SalarioTotal;
        private Label MostrarSalarioSub;
        private Label MostrarValorIn;
        private Label MostrarSalarioTotal;
        private TextBox txtSalary;
        private Label label2;

    }
}