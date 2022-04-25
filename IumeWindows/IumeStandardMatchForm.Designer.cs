using System.Windows.Forms;

namespace IumeWindows
{
    partial class IumeStandardMatchForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.cmbVisitante = new System.Windows.Forms.ComboBox();
            this.btnStdResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nivel del local";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nivel del visitante";
            // 
            // cmbLocal
            // 
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Items.AddRange(new object[] {
            "Top",
            "Alto",
            "Medio",
            "Bajo"});
            this.cmbLocal.Location = new System.Drawing.Point(177, 44);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(121, 23);
            this.cmbLocal.TabIndex = 2;
            // 
            // cmbVisitante
            // 
            this.cmbVisitante.FormattingEnabled = true;
            this.cmbVisitante.Items.AddRange(new object[] {
            "Top",
            "Alto",
            "Medio",
            "Bajo"});
            this.cmbVisitante.Location = new System.Drawing.Point(177, 99);
            this.cmbVisitante.Name = "cmbVisitante";
            this.cmbVisitante.Size = new System.Drawing.Size(121, 23);
            this.cmbVisitante.TabIndex = 3;
            // 
            // btnStdResult
            // 
            this.btnStdResult.Location = new System.Drawing.Point(133, 155);
            this.btnStdResult.Name = "btnStdResult";
            this.btnStdResult.Size = new System.Drawing.Size(75, 23);
            this.btnStdResult.TabIndex = 4;
            this.btnStdResult.Text = "Resultado";
            this.btnStdResult.UseVisualStyleBackColor = true;
            this.btnStdResult.Click += new System.EventHandler(this.btnStdResult_Click);
            // 
            // IumeStandardMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 190);
            this.Controls.Add(this.btnStdResult);
            this.Controls.Add(this.cmbVisitante);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IumeStandardMatchForm";
            this.Text = "Partido estándar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cmbLocal;
        private ComboBox cmbVisitante;
        private Button btnStdResult;
    }
}