namespace IumeWindows
{
    partial class IumeCupMatchForm
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
            this.spinLocal = new System.Windows.Forms.NumericUpDown();
            this.spinVisitante = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCupResult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinVisitante)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoría del local";
            // 
            // spinLocal
            // 
            this.spinLocal.Location = new System.Drawing.Point(175, 31);
            this.spinLocal.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinLocal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinLocal.Name = "spinLocal";
            this.spinLocal.Size = new System.Drawing.Size(120, 23);
            this.spinLocal.TabIndex = 1;
            this.spinLocal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // spinVisitante
            // 
            this.spinVisitante.Location = new System.Drawing.Point(175, 79);
            this.spinVisitante.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.spinVisitante.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinVisitante.Name = "spinVisitante";
            this.spinVisitante.Size = new System.Drawing.Size(120, 23);
            this.spinVisitante.TabIndex = 3;
            this.spinVisitante.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoría del visitante";
            // 
            // btnCupResult
            // 
            this.btnCupResult.Location = new System.Drawing.Point(127, 134);
            this.btnCupResult.Name = "btnCupResult";
            this.btnCupResult.Size = new System.Drawing.Size(75, 23);
            this.btnCupResult.TabIndex = 4;
            this.btnCupResult.Text = "Resultado";
            this.btnCupResult.UseVisualStyleBackColor = true;
            this.btnCupResult.Click += new System.EventHandler(this.btnCupResult_Click);
            // 
            // IumeCupMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 183);
            this.Controls.Add(this.btnCupResult);
            this.Controls.Add(this.spinVisitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spinLocal);
            this.Controls.Add(this.label1);
            this.Name = "IumeCupMatchForm";
            this.Text = "Partido de Copa";
            ((System.ComponentModel.ISupportInitialize)(this.spinLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinVisitante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private NumericUpDown spinLocal;
        private NumericUpDown spinVisitante;
        private Label label2;
        private Button btnCupResult;
    }
}