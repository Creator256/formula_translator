namespace Equation
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
			this.equationEnter = new System.Windows.Forms.TextBox();
			this.plainText = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.equationOutput = new System.Windows.Forms.RichTextBox();
			this.convert = new System.Windows.Forms.Button();
			this.fontSize = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.offset = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.offset)).BeginInit();
			this.SuspendLayout();
			// 
			// equationEnter
			// 
			this.equationEnter.BackColor = System.Drawing.Color.Silver;
			this.equationEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equationEnter.Location = new System.Drawing.Point(12, 39);
			this.equationEnter.Name = "equationEnter";
			this.equationEnter.Size = new System.Drawing.Size(604, 26);
			this.equationEnter.TabIndex = 0;
			this.equationEnter.TextChanged += new System.EventHandler(this.equationEnter_TextChanged);
			// 
			// plainText
			// 
			this.plainText.AutoSize = true;
			this.plainText.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plainText.Location = new System.Drawing.Point(12, 17);
			this.plainText.Name = "plainText";
			this.plainText.Size = new System.Drawing.Size(109, 19);
			this.plainText.TabIndex = 2;
			this.plainText.Text = "Plain Text";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "Equation Output";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(649, 76);
			this.label2.TabIndex = 4;
			this.label2.Text = "Type any greek symbol by name to get its symbol\r\nType ^ with any number, +, -, =," +
    " (, or ) to get its super script\r\nType $ followed by any number to get its subsc" +
    "ript\r\n\r\n";
			// 
			// equationOutput
			// 
			this.equationOutput.BackColor = System.Drawing.Color.Silver;
			this.equationOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.equationOutput.Location = new System.Drawing.Point(12, 101);
			this.equationOutput.Margin = new System.Windows.Forms.Padding(2);
			this.equationOutput.Name = "equationOutput";
			this.equationOutput.Size = new System.Drawing.Size(606, 41);
			this.equationOutput.TabIndex = 5;
			this.equationOutput.Text = "";
			// 
			// convert
			// 
			this.convert.BackColor = System.Drawing.Color.Silver;
			this.convert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.convert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.convert.Location = new System.Drawing.Point(626, 39);
			this.convert.Name = "convert";
			this.convert.Size = new System.Drawing.Size(109, 25);
			this.convert.TabIndex = 6;
			this.convert.Text = "Convert";
			this.convert.UseVisualStyleBackColor = false;
			this.convert.Click += new System.EventHandler(this.convert_Click);
			// 
			// fontSize
			// 
			this.fontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fontSize.Location = new System.Drawing.Point(237, 212);
			this.fontSize.Name = "fontSize";
			this.fontSize.Size = new System.Drawing.Size(43, 22);
			this.fontSize.TabIndex = 7;
			this.fontSize.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(219, 19);
			this.label3.TabIndex = 8;
			this.label3.Text = "Super|Sub Script Size";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Noto Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(308, 212);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 19);
			this.label4.TabIndex = 10;
			this.label4.Text = "Super|Sub Offset";
			// 
			// offset
			// 
			this.offset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.offset.Location = new System.Drawing.Point(483, 209);
			this.offset.Name = "offset";
			this.offset.Size = new System.Drawing.Size(43, 22);
			this.offset.TabIndex = 9;
			this.offset.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(787, 249);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.offset);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.fontSize);
			this.Controls.Add(this.convert);
			this.Controls.Add(this.equationOutput);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.plainText);
			this.Controls.Add(this.equationEnter);
			this.Name = "Form1";
			this.Text = "Equation Creator";
			((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.offset)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox equationEnter;
		private System.Windows.Forms.Label plainText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox equationOutput;
		private System.Windows.Forms.Button convert;
		private System.Windows.Forms.NumericUpDown fontSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown offset;
	}
}

