namespace IumeWindows
{
    partial class IumeHome
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
            this.btnCampoNeutral = new System.Windows.Forms.Button();
            this.btnLocVisi = new System.Windows.Forms.Button();
            this.btnCopa = new System.Windows.Forms.Button();
            this.btnCopaEntera = new System.Windows.Forms.Button();
            this.btnReportBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCampoNeutral
            // 
            this.btnCampoNeutral.Location = new System.Drawing.Point(16, 21);
            this.btnCampoNeutral.Name = "btnCampoNeutral";
            this.btnCampoNeutral.Size = new System.Drawing.Size(190, 34);
            this.btnCampoNeutral.TabIndex = 0;
            this.btnCampoNeutral.Text = "Partido en campo neutral";
            this.btnCampoNeutral.UseVisualStyleBackColor = true;
            this.btnCampoNeutral.Click += new System.EventHandler(this.btnCampoNeutral_Click);
            // 
            // btnLocVisi
            // 
            this.btnLocVisi.Location = new System.Drawing.Point(243, 21);
            this.btnLocVisi.Name = "btnLocVisi";
            this.btnLocVisi.Size = new System.Drawing.Size(190, 34);
            this.btnLocVisi.TabIndex = 1;
            this.btnLocVisi.Text = "Partido con local y visitante";
            this.btnLocVisi.UseVisualStyleBackColor = true;
            // 
            // btnCopa
            // 
            this.btnCopa.Location = new System.Drawing.Point(16, 112);
            this.btnCopa.Name = "btnCopa";
            this.btnCopa.Size = new System.Drawing.Size(190, 34);
            this.btnCopa.TabIndex = 2;
            this.btnCopa.Text = "Partido de Copa";
            this.btnCopa.UseVisualStyleBackColor = true;
            // 
            // btnCopaEntera
            // 
            this.btnCopaEntera.Location = new System.Drawing.Point(243, 112);
            this.btnCopaEntera.Name = "btnCopaEntera";
            this.btnCopaEntera.Size = new System.Drawing.Size(190, 34);
            this.btnCopaEntera.TabIndex = 3;
            this.btnCopaEntera.Text = "Copa entera";
            this.btnCopaEntera.UseVisualStyleBackColor = true;
            // 
            // btnReportBug
            // 
            this.btnReportBug.Location = new System.Drawing.Point(151, 169);
            this.btnReportBug.Name = "btnReportBug";
            this.btnReportBug.Size = new System.Drawing.Size(141, 36);
            this.btnReportBug.TabIndex = 4;
            this.btnReportBug.Text = "Reportar un bug";
            this.btnReportBug.UseVisualStyleBackColor = true;
            this.btnReportBug.Click += new System.EventHandler(this.btnReportBug_Click);
            // 
            // IumeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 232);
            this.Controls.Add(this.btnReportBug);
            this.Controls.Add(this.btnCopaEntera);
            this.Controls.Add(this.btnCopa);
            this.Controls.Add(this.btnLocVisi);
            this.Controls.Add(this.btnCampoNeutral);
            this.Name = "IumeHome";
            this.Text = "Iume";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCampoNeutral;
        private Button btnLocVisi;
        private Button btnCopa;
        private Button btnCopaEntera;
        private Button btnReportBug;
    }
}