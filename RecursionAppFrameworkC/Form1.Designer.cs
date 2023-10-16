namespace RecursionAppFrameworkC
{
	partial class Form1
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
			this.cmdCountUsingString = new System.Windows.Forms.Button();
			this.cmdCountUsingXSLT = new System.Windows.Forms.Button();
			this.cmdCountUsingRecursion = new System.Windows.Forms.Button();
			this.cmdOpenFile = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtFileName = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmdCountUsingString
			// 
			this.cmdCountUsingString.Location = new System.Drawing.Point(399, 156);
			this.cmdCountUsingString.Name = "cmdCountUsingString";
			this.cmdCountUsingString.Size = new System.Drawing.Size(174, 33);
			this.cmdCountUsingString.TabIndex = 7;
			this.cmdCountUsingString.Text = "Count using String Functions";
			this.cmdCountUsingString.UseVisualStyleBackColor = true;
			this.cmdCountUsingString.Click += new System.EventHandler(this.cmdCountUsingString_Click);
			// 
			// cmdCountUsingXSLT
			// 
			this.cmdCountUsingXSLT.Location = new System.Drawing.Point(204, 156);
			this.cmdCountUsingXSLT.Name = "cmdCountUsingXSLT";
			this.cmdCountUsingXSLT.Size = new System.Drawing.Size(150, 33);
			this.cmdCountUsingXSLT.TabIndex = 8;
			this.cmdCountUsingXSLT.Text = "Count using XSLT";
			this.cmdCountUsingXSLT.UseVisualStyleBackColor = true;
			this.cmdCountUsingXSLT.Click += new System.EventHandler(this.cmdCountUsingXSLT_Click);
			// 
			// cmdCountUsingRecursion
			// 
			this.cmdCountUsingRecursion.Location = new System.Drawing.Point(25, 156);
			this.cmdCountUsingRecursion.Name = "cmdCountUsingRecursion";
			this.cmdCountUsingRecursion.Size = new System.Drawing.Size(150, 33);
			this.cmdCountUsingRecursion.TabIndex = 9;
			this.cmdCountUsingRecursion.Text = "Count using Recursion";
			this.cmdCountUsingRecursion.UseVisualStyleBackColor = true;
			this.cmdCountUsingRecursion.Click += new System.EventHandler(this.cmdCountUsingRecursion_Click);
			// orm
			// cmdOpenFile
			// 
			this.cmdOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmdOpenFile.Location = new System.Drawing.Point(553, 39);
			this.cmdOpenFile.Name = "cmdOpenFile";
			this.cmdOpenFile.Size = new System.Drawing.Size(31, 23);
			this.cmdOpenFile.TabIndex = 6;
			this.cmdOpenFile.Text = "...";
			this.cmdOpenFile.UseVisualStyleBackColor = true;
			this.cmdOpenFile.Click += new System.EventHandler(this.cmdOpenFile_Click);
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(38, 44);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(29, 13);
			this.Label1.TabIndex = 5;
			this.Label1.Text = "File :";
			// 
			// txtFileName
			// 
			this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFileName.Enabled = false;
			this.txtFileName.Location = new System.Drawing.Point(73, 41);
			this.txtFileName.Name = "txtFileName";
			this.txtFileName.Size = new System.Drawing.Size(474, 20);
			this.txtFileName.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 233);
			this.Controls.Add(this.cmdCountUsingString);
			this.Controls.Add(this.cmdCountUsingXSLT);
			this.Controls.Add(this.cmdCountUsingRecursion);
			this.Controls.Add(this.cmdOpenFile);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtFileName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button cmdCountUsingString;
		internal System.Windows.Forms.Button cmdCountUsingXSLT;
		internal System.Windows.Forms.Button cmdCountUsingRecursion;
		internal System.Windows.Forms.Button cmdOpenFile;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox txtFileName;
	}
}

