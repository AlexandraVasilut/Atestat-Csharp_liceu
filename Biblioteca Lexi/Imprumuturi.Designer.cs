namespace Biblioteca_Lexi
{
    partial class Imprumuturi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imprumuturi));
            this.iesireF4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iesireF4
            // 
            this.iesireF4.BackColor = System.Drawing.Color.Black;
            this.iesireF4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iesireF4.BackgroundImage")));
            this.iesireF4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iesireF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesireF4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iesireF4.Location = new System.Drawing.Point(1185, 557);
            this.iesireF4.Name = "iesireF4";
            this.iesireF4.Size = new System.Drawing.Size(153, 106);
            this.iesireF4.TabIndex = 1;
            this.iesireF4.UseVisualStyleBackColor = false;
            this.iesireF4.Click += new System.EventHandler(this.iesireF4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(469, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista împrumuturilor";
            // 
            // Imprumuturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1350, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iesireF4);
            this.Name = "Imprumuturi";
            this.Text = "Imprumuturi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iesireF4;
        private System.Windows.Forms.Label label1;
    }
}