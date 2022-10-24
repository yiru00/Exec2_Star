namespace WinFormsApp1
{
	partial class Form1
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
			this.rowslbl = new System.Windows.Forms.Label();
			this.rowstxt = new System.Windows.Forms.TextBox();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btbIso = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// rowslbl
			// 
			this.rowslbl.AutoSize = true;
			this.rowslbl.Location = new System.Drawing.Point(159, 57);
			this.rowslbl.Name = "rowslbl";
			this.rowslbl.Size = new System.Drawing.Size(31, 15);
			this.rowslbl.TabIndex = 0;
			this.rowslbl.Text = "列數";
			// 
			// rowstxt
			// 
			this.rowstxt.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.rowstxt.Location = new System.Drawing.Point(207, 54);
			this.rowstxt.Name = "rowstxt";
			this.rowstxt.Size = new System.Drawing.Size(208, 23);
			this.rowstxt.TabIndex = 1;
			this.rowstxt.Text = "請輸入列數";
			// 
			// btnLeft
			// 
			this.btnLeft.Location = new System.Drawing.Point(159, 100);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(76, 23);
			this.btnLeft.TabIndex = 2;
			this.btnLeft.Text = "靠左對齊";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
			// 
			// btbIso
			// 
			this.btbIso.Location = new System.Drawing.Point(249, 100);
			this.btbIso.Name = "btbIso";
			this.btbIso.Size = new System.Drawing.Size(76, 23);
			this.btbIso.TabIndex = 3;
			this.btbIso.Text = "等腰";
			this.btbIso.UseVisualStyleBackColor = true;
			this.btbIso.Click += new System.EventHandler(this.btbIso_Click);
			// 
			// btnRight
			// 
			this.btnRight.Location = new System.Drawing.Point(339, 100);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(76, 23);
			this.btnRight.TabIndex = 4;
			this.btnRight.Text = "靠右對齊";
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
			// 
			// txtResult
			// 
			this.txtResult.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtResult.Location = new System.Drawing.Point(159, 144);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResult.Size = new System.Drawing.Size(256, 111);
			this.txtResult.TabIndex = 5;
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblResult.Location = new System.Drawing.Point(159, 278);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(256, 91);
			this.lblResult.TabIndex = 6;
			this.lblResult.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 450);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btbIso);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.rowstxt);
			this.Controls.Add(this.rowslbl);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private Label rowslbl;
        private TextBox rowstxt;
        private Button btnLeft;
        private Button btbIso;
        private Button btnRight;
        private TextBox txtResult;
        private Label lblResult;
    }
}