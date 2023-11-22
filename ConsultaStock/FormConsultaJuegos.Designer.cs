namespace ConsultaStock
{
    partial class FormConsultaJuegos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaJuegos));
            dataGridViewJuegos = new DataGridView();
            BotonVolver = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJuegos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewJuegos
            // 
            dataGridViewJuegos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewJuegos.Location = new Point(352, -1);
            dataGridViewJuegos.Name = "dataGridViewJuegos";
            dataGridViewJuegos.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewJuegos.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.PaleGreen;
            dataGridViewJuegos.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridViewJuegos.RowTemplate.Height = 25;
            dataGridViewJuegos.Size = new Size(456, 576);
            dataGridViewJuegos.TabIndex = 0;
            // 
            // BotonVolver
            // 
            BotonVolver.BackColor = Color.FromArgb(128, 128, 255);
            BotonVolver.BackgroundImageLayout = ImageLayout.None;
            BotonVolver.FlatAppearance.BorderColor = Color.Red;
            BotonVolver.FlatAppearance.BorderSize = 0;
            BotonVolver.FlatStyle = FlatStyle.Flat;
            BotonVolver.ForeColor = SystemColors.ActiveCaptionText;
            BotonVolver.Location = new Point(70, 447);
            BotonVolver.Name = "BotonVolver";
            BotonVolver.Size = new Size(227, 67);
            BotonVolver.TabIndex = 3;
            BotonVolver.Text = "Volver al inicio";
            BotonVolver.UseVisualStyleBackColor = false;
            BotonVolver.Click += BotonVolver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(70, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 167);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormConsultaJuegos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 576);
            Controls.Add(pictureBox1);
            Controls.Add(BotonVolver);
            Controls.Add(dataGridViewJuegos);
            Name = "FormConsultaJuegos";
            Text = "Form1";
            Load += FormConsultaJuegos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewJuegos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewJuegos;
        private Button BotonVolver;
        private PictureBox pictureBox1;
    }
}