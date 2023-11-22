namespace Carga_Cliente
{
    partial class FormCliente
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
            NombreBox = new TextBox();
            ApellidoBox = new TextBox();
            DniBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ProvinciaBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            InfoContinuar = new Button();
            CalleBox = new TextBox();
            NumeroBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            LocalidadBox = new TextBox();
            SuspendLayout();
            // 
            // NombreBox
            // 
            NombreBox.Location = new Point(107, 167);
            NombreBox.Name = "NombreBox";
            NombreBox.Size = new Size(116, 23);
            NombreBox.TabIndex = 0;
            // 
            // ApellidoBox
            // 
            ApellidoBox.Location = new Point(282, 167);
            ApellidoBox.Name = "ApellidoBox";
            ApellidoBox.Size = new Size(119, 23);
            ApellidoBox.TabIndex = 1;
            // 
            // DniBox
            // 
            DniBox.Location = new Point(107, 278);
            DniBox.Name = "DniBox";
            DniBox.Size = new Size(116, 23);
            DniBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(107, 130);
            label1.Name = "label1";
            label1.Size = new Size(94, 30);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(282, 130);
            label2.Name = "label2";
            label2.Size = new Size(93, 30);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(107, 227);
            label3.Name = "label3";
            label3.Size = new Size(50, 30);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(568, 53);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // ProvinciaBox
            // 
            ProvinciaBox.Location = new Point(488, 227);
            ProvinciaBox.Name = "ProvinciaBox";
            ProvinciaBox.Size = new Size(125, 23);
            ProvinciaBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(488, 104);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 9;
            label5.Text = "Calle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(488, 199);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 10;
            label6.Text = "Provincia";
            // 
            // InfoContinuar
            // 
            InfoContinuar.BackColor = Color.ForestGreen;
            InfoContinuar.Location = new Point(582, 351);
            InfoContinuar.Name = "InfoContinuar";
            InfoContinuar.Size = new Size(168, 64);
            InfoContinuar.TabIndex = 11;
            InfoContinuar.Text = "Continuar";
            InfoContinuar.UseVisualStyleBackColor = false;
            InfoContinuar.Click += InfoContinuar_Click;
            // 
            // CalleBox
            // 
            CalleBox.Location = new Point(488, 139);
            CalleBox.Name = "CalleBox";
            CalleBox.Size = new Size(125, 23);
            CalleBox.TabIndex = 3;
            // 
            // NumeroBox
            // 
            NumeroBox.Location = new Point(641, 139);
            NumeroBox.Name = "NumeroBox";
            NumeroBox.Size = new Size(125, 23);
            NumeroBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(645, 104);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 13;
            label7.Text = "Numero";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(645, 199);
            label8.Name = "label8";
            label8.Size = new Size(93, 25);
            label8.TabIndex = 14;
            label8.Text = "Localidad";
            // 
            // LocalidadBox
            // 
            LocalidadBox.Location = new Point(645, 227);
            LocalidadBox.Name = "LocalidadBox";
            LocalidadBox.Size = new Size(125, 23);
            LocalidadBox.TabIndex = 15;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(LocalidadBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(NumeroBox);
            Controls.Add(InfoContinuar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(ProvinciaBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CalleBox);
            Controls.Add(DniBox);
            Controls.Add(ApellidoBox);
            Controls.Add(NombreBox);
            ForeColor = Color.LawnGreen;
            Name = "FormCliente";
            Text = "Form1";
            Load += FormCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreBox;
        private TextBox ApellidoBox;
        private TextBox DniBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ProvinciaBox;
        private Label label5;
        private Label label6;
        private Button InfoContinuar;
        private TextBox CalleBox;
        private TextBox NumeroBox;
        private Label label7;
        private Label label8;
        private TextBox LocalidadBox;
    }
}