
namespace WinFormsApp3
{
    partial class FormPrincipal
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            botoncontinuar = new Button();
            botonsalida = new Button();
            comboBoxPlataforma = new ComboBox();
            comboBoxJuegos = new ComboBox();
            comboBoxDuracion = new ComboBox();
            barramenu = new Panel();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            muevepanal = new Panel();
            labelHora = new Label();
            barramenu.SuspendLayout();
            muevepanal.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // botoncontinuar
            // 
            botoncontinuar.BackColor = Color.Azure;
            botoncontinuar.FlatAppearance.BorderSize = 0;
            botoncontinuar.FlatStyle = FlatStyle.Flat;
            botoncontinuar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            botoncontinuar.ForeColor = Color.Gray;
            botoncontinuar.Location = new Point(1079, 529);
            botoncontinuar.Name = "botoncontinuar";
            botoncontinuar.Size = new Size(80, 80);
            botoncontinuar.TabIndex = 14;
            botoncontinuar.UseVisualStyleBackColor = false;
            botoncontinuar.Click += botoncontinuar_Click;
            botoncontinuar.MouseEnter += botoncontinuar_MouseEnter;
            botoncontinuar.MouseLeave += botoncontinuar_MouseLeave_1;
            // 
            // botonsalida
            // 
            botonsalida.BackColor = Color.LightSlateGray;
            botonsalida.FlatAppearance.BorderSize = 0;
            botonsalida.FlatStyle = FlatStyle.Flat;
            botonsalida.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            botonsalida.ForeColor = Color.Gray;
            botonsalida.Location = new Point(1079, 0);
            botonsalida.Name = "botonsalida";
            botonsalida.Size = new Size(80, 80);
            botonsalida.TabIndex = 15;
            botonsalida.UseVisualStyleBackColor = false;
            botonsalida.Click += botonsalida_Click;
            botonsalida.MouseEnter += botonsalida_MouseEnter;
            botonsalida.MouseLeave += botonsalida_MouseLeave;
            // 
            // comboBoxPlataforma
            // 
            comboBoxPlataforma.BackColor = Color.FromArgb(128, 128, 255);
            comboBoxPlataforma.FlatStyle = FlatStyle.Flat;
            comboBoxPlataforma.ForeColor = Color.Transparent;
            comboBoxPlataforma.FormattingEnabled = true;
            comboBoxPlataforma.Location = new Point(6, 449);
            comboBoxPlataforma.Name = "comboBoxPlataforma";
            comboBoxPlataforma.Size = new Size(208, 23);
            comboBoxPlataforma.TabIndex = 16;
            comboBoxPlataforma.SelectedIndexChanged += comboBoxPlataforma_SelectedIndexChanged;
            // 
            // comboBoxJuegos
            // 
            comboBoxJuegos.BackColor = Color.FromArgb(128, 128, 255);
            comboBoxJuegos.FlatStyle = FlatStyle.Flat;
            comboBoxJuegos.ForeColor = Color.Transparent;
            comboBoxJuegos.FormattingEnabled = true;
            comboBoxJuegos.Location = new Point(0, 193);
            comboBoxJuegos.Name = "comboBoxJuegos";
            comboBoxJuegos.Size = new Size(214, 23);
            comboBoxJuegos.TabIndex = 17;
            comboBoxJuegos.SelectedIndexChanged += comboBoxJuegos_SelectedIndexChanged;
            // 
            // comboBoxDuracion
            // 
            comboBoxDuracion.BackColor = Color.FromArgb(128, 128, 255);
            comboBoxDuracion.FlatStyle = FlatStyle.Flat;
            comboBoxDuracion.ForeColor = Color.Transparent;
            comboBoxDuracion.FormattingEnabled = true;
            comboBoxDuracion.Location = new Point(0, 329);
            comboBoxDuracion.Name = "comboBoxDuracion";
            comboBoxDuracion.Size = new Size(214, 23);
            comboBoxDuracion.TabIndex = 18;
            comboBoxDuracion.SelectedIndexChanged += comboBoxDuracion_SelectedIndexChanged_1;
            // 
            // barramenu
            // 
            barramenu.BackColor = Color.FromArgb(26, 32, 40);
            barramenu.Controls.Add(label4);
            barramenu.Controls.Add(label2);
            barramenu.Controls.Add(comboBoxDuracion);
            barramenu.Controls.Add(label3);
            barramenu.Controls.Add(comboBoxJuegos);
            barramenu.Controls.Add(comboBoxPlataforma);
            barramenu.Dock = DockStyle.Left;
            barramenu.Location = new Point(0, 0);
            barramenu.Name = "barramenu";
            barramenu.Size = new Size(220, 609);
            barramenu.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 192, 255);
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(203, 45);
            label4.TabIndex = 6;
            label4.Text = "Elija su Juego!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Heading", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 192, 255);
            label2.Location = new Point(0, 367);
            label2.Name = "label2";
            label2.Size = new Size(265, 45);
            label2.TabIndex = 7;
            label2.Text = "Elija su plataforma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Heading", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(192, 192, 255);
            label3.Location = new Point(0, 236);
            label3.Name = "label3";
            label3.Size = new Size(229, 45);
            label3.TabIndex = 8;
            label3.Text = "Elija la duracion";
            // 
            // muevepanal
            // 
            muevepanal.BackColor = Color.Transparent;
            muevepanal.Controls.Add(labelHora);
            muevepanal.Location = new Point(218, 0);
            muevepanal.Name = "muevepanal";
            muevepanal.Size = new Size(864, 80);
            muevepanal.TabIndex = 19;
            muevepanal.MouseDown += muevepanal_MouseDown;
            // 
            // labelHora
            // 
            labelHora.AutoSize = true;
            labelHora.BackColor = Color.Transparent;
            labelHora.ForeColor = Color.Yellow;
            labelHora.Location = new Point(12, 6);
            labelHora.Name = "labelHora";
            labelHora.Size = new Size(0, 15);
            labelHora.TabIndex = 13;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1159, 609);
            Controls.Add(muevepanal);
            Controls.Add(botonsalida);
            Controls.Add(botoncontinuar);
            Controls.Add(barramenu);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrincipal";
            Text = "continuar";
            Load += FormPrincipal_Load;
            barramenu.ResumeLayout(false);
            barramenu.PerformLayout();
            muevepanal.ResumeLayout(false);
            muevepanal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private Button botoncontinuar;
        private Button botonsalida;
        private ComboBox comboBoxPlataforma;
        private ComboBox comboBoxJuegos;
        private ComboBox comboBoxDuracion;
        private Panel barramenu;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label labelHora;
        private Panel muevepanal;
    }
}