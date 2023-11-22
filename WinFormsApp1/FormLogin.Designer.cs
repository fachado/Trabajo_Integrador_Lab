namespace WinFormsApp1
{
    partial class FormLogin
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
            panel1 = new Panel();
            BotonPedidos = new Button();
            BotonStock = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            BontonIngresar = new Button();
            label1 = new Label();
            ContraseñaUsuario = new TextBox();
            NombreUsuario = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(BotonPedidos);
            panel1.Controls.Add(BotonStock);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 426);
            panel1.TabIndex = 0;
            // 
            // BotonPedidos
            // 
            BotonPedidos.BackColor = Color.Transparent;
            BotonPedidos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BotonPedidos.FlatAppearance.MouseOverBackColor = Color.Gray;
            BotonPedidos.FlatStyle = FlatStyle.Flat;
            BotonPedidos.ForeColor = Color.Black;
            BotonPedidos.Location = new Point(12, 326);
            BotonPedidos.Name = "BotonPedidos";
            BotonPedidos.Size = new Size(187, 41);
            BotonPedidos.TabIndex = 7;
            BotonPedidos.Text = "Consultar Pedidos";
            BotonPedidos.UseVisualStyleBackColor = false;
            BotonPedidos.Click += BotonPedidos_Click;
            // 
            // BotonStock
            // 
            BotonStock.BackColor = Color.Transparent;
            BotonStock.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BotonStock.FlatAppearance.MouseOverBackColor = Color.Gray;
            BotonStock.FlatStyle = FlatStyle.Flat;
            BotonStock.ForeColor = Color.Black;
            BotonStock.Location = new Point(12, 279);
            BotonStock.Name = "BotonStock";
            BotonStock.Size = new Size(187, 41);
            BotonStock.TabIndex = 6;
            BotonStock.Text = "Consultar Stock";
            BotonStock.UseVisualStyleBackColor = false;
            BotonStock.Click += BotonStock_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Pantalla_Login.Properties.Resources.Logo_alquiler;
            pictureBox1.Location = new Point(-10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(216, 193);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Controls.Add(BontonIngresar);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ContraseñaUsuario);
            panel2.Controls.Add(NombreUsuario);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(206, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 426);
            panel2.TabIndex = 3;
            // 
            // BontonIngresar
            // 
            BontonIngresar.BackColor = Color.Crimson;
            BontonIngresar.FlatAppearance.BorderSize = 0;
            BontonIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BontonIngresar.FlatAppearance.MouseOverBackColor = Color.Gray;
            BontonIngresar.FlatStyle = FlatStyle.Flat;
            BontonIngresar.ForeColor = Color.Transparent;
            BontonIngresar.Location = new Point(206, 251);
            BontonIngresar.Name = "BontonIngresar";
            BontonIngresar.Size = new Size(214, 41);
            BontonIngresar.TabIndex = 5;
            BontonIngresar.Text = "Ingresar";
            BontonIngresar.UseVisualStyleBackColor = false;
            BontonIngresar.Click += BotonContinuar_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Calibri", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(229, 48);
            label1.Name = "label1";
            label1.Size = new Size(174, 78);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // ContraseñaUsuario
            // 
            ContraseñaUsuario.BackColor = Color.Crimson;
            ContraseñaUsuario.BorderStyle = BorderStyle.FixedSingle;
            ContraseñaUsuario.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            ContraseñaUsuario.ForeColor = Color.White;
            ContraseñaUsuario.ImeMode = ImeMode.NoControl;
            ContraseñaUsuario.Location = new Point(189, 200);
            ContraseñaUsuario.Multiline = true;
            ContraseñaUsuario.Name = "ContraseñaUsuario";
            ContraseñaUsuario.PasswordChar = '*';
            ContraseñaUsuario.Size = new Size(257, 36);
            ContraseñaUsuario.TabIndex = 2;
            ContraseñaUsuario.Text = "Contraseña";
            ContraseñaUsuario.Enter += ContraseñaUsuario_Enter;
            ContraseñaUsuario.KeyPress += ContraseñaUsuario_KeyPress;
            ContraseñaUsuario.Leave += ContraseñaUsuario_Leave;
            // 
            // NombreUsuario
            // 
            NombreUsuario.BackColor = Color.Crimson;
            NombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            NombreUsuario.Font = new Font("Calibri", 15F, FontStyle.Regular, GraphicsUnit.Point);
            NombreUsuario.ForeColor = Color.White;
            NombreUsuario.Location = new Point(189, 156);
            NombreUsuario.Multiline = true;
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.Size = new Size(257, 38);
            NombreUsuario.TabIndex = 1;
            NombreUsuario.Text = "Usuario";
            NombreUsuario.Enter += NombreUsuario_Enter;
            NombreUsuario.KeyPress += NombreUsuario_KeyPress;
            NombreUsuario.Leave += NombreUsuario_Leave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 426);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox ContraseñaUsuario;
        private TextBox NombreUsuario;
        private Button BontonIngresar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button BotonPedidos;
        private Button BotonStock;
    }
}