namespace WinForms_Design
{
    partial class MoveTwoList
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
            this.lstLeft = new System.Windows.Forms.ListBox();
            this.lstRight = new System.Windows.Forms.ListBox();
            this.btnOneLToR = new System.Windows.Forms.Button();
            this.btnMulLToR = new System.Windows.Forms.Button();
            this.btnOneRToL = new System.Windows.Forms.Button();
            this.btnMulRToL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLeft
            // 
            this.lstLeft.FormattingEnabled = true;
            this.lstLeft.ItemHeight = 16;
            this.lstLeft.Items.AddRange(new object[] {
            "Kamal",
            "Amal",
            "Nimal",
            "Sunil",
            "Mala",
            "Kapila",
            "Vimal",
            "Priya",
            "Gihan",
            "Tharindu"});
            this.lstLeft.Location = new System.Drawing.Point(12, 12);
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLeft.Size = new System.Drawing.Size(225, 340);
            this.lstLeft.TabIndex = 0;
            // 
            // lstRight
            // 
            this.lstRight.FormattingEnabled = true;
            this.lstRight.ItemHeight = 16;
            this.lstRight.Location = new System.Drawing.Point(420, 12);
            this.lstRight.Name = "lstRight";
            this.lstRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstRight.Size = new System.Drawing.Size(225, 340);
            this.lstRight.TabIndex = 1;
            // 
            // btnOneLToR
            // 
            this.btnOneLToR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneLToR.Location = new System.Drawing.Point(257, 26);
            this.btnOneLToR.Name = "btnOneLToR";
            this.btnOneLToR.Size = new System.Drawing.Size(148, 61);
            this.btnOneLToR.TabIndex = 2;
            this.btnOneLToR.Text = ">";
            this.btnOneLToR.UseVisualStyleBackColor = true;
            this.btnOneLToR.Click += new System.EventHandler(this.btnOneLToR_Click);
            // 
            // btnMulLToR
            // 
            this.btnMulLToR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulLToR.Location = new System.Drawing.Point(257, 112);
            this.btnMulLToR.Name = "btnMulLToR";
            this.btnMulLToR.Size = new System.Drawing.Size(148, 61);
            this.btnMulLToR.TabIndex = 3;
            this.btnMulLToR.Text = ">>";
            this.btnMulLToR.UseVisualStyleBackColor = true;
            this.btnMulLToR.Click += new System.EventHandler(this.btnMulLToR_Click);
            // 
            // btnOneRToL
            // 
            this.btnOneRToL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneRToL.Location = new System.Drawing.Point(257, 199);
            this.btnOneRToL.Name = "btnOneRToL";
            this.btnOneRToL.Size = new System.Drawing.Size(148, 61);
            this.btnOneRToL.TabIndex = 4;
            this.btnOneRToL.Text = "<";
            this.btnOneRToL.UseVisualStyleBackColor = true;
            this.btnOneRToL.Click += new System.EventHandler(this.btnOneRToL_Click);
            // 
            // btnMulRToL
            // 
            this.btnMulRToL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMulRToL.Location = new System.Drawing.Point(257, 282);
            this.btnMulRToL.Name = "btnMulRToL";
            this.btnMulRToL.Size = new System.Drawing.Size(148, 61);
            this.btnMulRToL.TabIndex = 5;
            this.btnMulRToL.Text = "<<";
            this.btnMulRToL.UseVisualStyleBackColor = true;
            this.btnMulRToL.Click += new System.EventHandler(this.btnMulRToL_Click);
            // 
            // MoveTwoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 383);
            this.Controls.Add(this.btnMulRToL);
            this.Controls.Add(this.btnOneRToL);
            this.Controls.Add(this.btnMulLToR);
            this.Controls.Add(this.btnOneLToR);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.lstLeft);
            this.Name = "MoveTwoList";
            this.Text = "MoveTwoList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstLeft;
        private System.Windows.Forms.ListBox lstRight;
        private System.Windows.Forms.Button btnOneLToR;
        private System.Windows.Forms.Button btnMulLToR;
        private System.Windows.Forms.Button btnOneRToL;
        private System.Windows.Forms.Button btnMulRToL;
    }
}