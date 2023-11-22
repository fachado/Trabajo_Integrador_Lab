namespace ConsultaAlquileres
{
    partial class FormConsultaAlquileres
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaAlquileres));
            dataGridViewAlquileres = new DataGridView();
            BotonVolver = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlquileres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlquileres
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAlquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlquileres.Location = new Point(339, -1);
            dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 255, 128);
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewAlquileres.RowTemplate.Height = 25;
            dataGridViewAlquileres.Size = new Size(512, 580);
            dataGridViewAlquileres.TabIndex = 1;
            // 
            // BotonVolver
            // 
            BotonVolver.BackColor = Color.FromArgb(0, 0, 64);
            BotonVolver.BackgroundImageLayout = ImageLayout.None;
            BotonVolver.FlatAppearance.BorderColor = Color.Red;
            BotonVolver.FlatAppearance.BorderSize = 0;
            BotonVolver.FlatStyle = FlatStyle.Flat;
            BotonVolver.ForeColor = SystemColors.ButtonHighlight;
            BotonVolver.Location = new Point(49, 425);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(219, 59);
            BotonVolver.TabIndex = 2;
            BotonVolver.Text = "Volver al inicio";
            BotonVolver.UseVisualStyleBackColor = false;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 170);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormConsultaAlquileres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 591);
            Controls.Add(pictureBox1);
            Controls.Add(BotonVolver);
            Controls.Add(dataGridViewAlquileres);
            Name = "FormConsultaAlquileres";
            Text = "Form1";
            Load += FormConsultaAlquileres_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlquileres).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAlquileres;
        private Button BotonVolver;
        private PictureBox pictureBox1;
    }
}