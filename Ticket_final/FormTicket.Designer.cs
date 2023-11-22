namespace Ticket_final
{
    partial class FormTicket
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
            labelFecha = new Label();
            lblTicketStatus = new Label();
            MostrarInfo = new Button();
            lblJuego = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.Controls.Add(labelFecha);
            panel1.Controls.Add(lblTicketStatus);
            panel1.Controls.Add(MostrarInfo);
            panel1.Controls.Add(lblJuego);
            panel1.Location = new Point(212, -17);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 473);
            panel1.TabIndex = 0;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelFecha.Location = new Point(213, 26);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(0, 28);
            labelFecha.TabIndex = 4;
            // 
            // lblTicketStatus
            // 
            lblTicketStatus.AutoSize = true;
            lblTicketStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTicketStatus.Location = new Point(24, 199);
            lblTicketStatus.Name = "lblTicketStatus";
            lblTicketStatus.Size = new Size(0, 28);
            lblTicketStatus.TabIndex = 3;
            // 
            // MostrarInfo
            // 
            MostrarInfo.BackColor = Color.FromArgb(192, 255, 192);
            MostrarInfo.FlatAppearance.BorderSize = 0;
            MostrarInfo.FlatStyle = FlatStyle.Flat;
            MostrarInfo.Location = new Point(369, 413);
            MostrarInfo.Name = "MostrarInfo";
            MostrarInfo.Size = new Size(92, 42);
            MostrarInfo.TabIndex = 2;
            MostrarInfo.Text = "Generar ticket";
            MostrarInfo.UseVisualStyleBackColor = false;
            MostrarInfo.Click += MostrarInfo_Click;
            // 
            // lblJuego
            // 
            lblJuego.AutoSize = true;
            lblJuego.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblJuego.Location = new Point(24, 41);
            lblJuego.Name = "lblJuego";
            lblJuego.Size = new Size(0, 28);
            lblJuego.TabIndex = 0;
            lblJuego.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(12, 382);
            button1.Name = "button1";
            button1.Size = new Size(169, 56);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "FormTicket";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblJuego;
        private Button MostrarInfo;
        private Button button1;
        private Label labelFecha;
        private Label lblTicketStatus;
    }
}