namespace Calculator
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
            this.clr = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.res = new System.Windows.Forms.TextBox();
            this.div = new System.Windows.Forms.Button();
            this.perc = new System.Windows.Forms.Button();
            this.sqr = new System.Windows.Forms.Button();
            this.sqrroot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clr
            // 
            this.clr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clr.Location = new System.Drawing.Point(2, 295);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(75, 40);
            this.clr.TabIndex = 0;
            this.clr.Text = "C";
            this.clr.UseVisualStyleBackColor = true;
            this.clr.Click += new System.EventHandler(this.Clr);
            // 
            // num0
            // 
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(83, 295);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(75, 40);
            this.num0.TabIndex = 1;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.AddNum);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(245, 295);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 40);
            this.equal.TabIndex = 2;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.Eql);
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(2, 249);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(75, 40);
            this.num1.TabIndex = 3;
            this.num1.TabStop = false;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.AddNum);
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(83, 249);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(75, 40);
            this.num2.TabIndex = 4;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.AddNum);
            // 
            // num3
            // 
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(164, 249);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(75, 40);
            this.num3.TabIndex = 5;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.AddNum);
            // 
            // num4
            // 
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(2, 203);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(75, 40);
            this.num4.TabIndex = 6;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.AddNum);
            // 
            // num5
            // 
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(83, 203);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(75, 40);
            this.num5.TabIndex = 7;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.AddNum);
            // 
            // num6
            // 
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(164, 203);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(75, 40);
            this.num6.TabIndex = 8;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.AddNum);
            // 
            // num7
            // 
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(2, 161);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(75, 40);
            this.num7.TabIndex = 9;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.AddNum);
            // 
            // num8
            // 
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(83, 157);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(75, 40);
            this.num8.TabIndex = 10;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.AddNum);
            // 
            // num9
            // 
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(164, 157);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(75, 40);
            this.num9.TabIndex = 11;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.AddNum);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(245, 249);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(75, 40);
            this.sum.TabIndex = 12;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.AddOperator);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(245, 203);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(75, 40);
            this.sub.TabIndex = 13;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.AddOperator);
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(245, 157);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(75, 40);
            this.mul.TabIndex = 14;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.AddOperator);
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dec.Location = new System.Drawing.Point(164, 295);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(75, 40);
            this.dec.TabIndex = 15;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.AddDec);
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.res.Location = new System.Drawing.Point(2, 2);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(318, 107);
            this.res.TabIndex = 16;
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(245, 115);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(75, 40);
            this.div.TabIndex = 17;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.AddOperator);
            // 
            // perc
            // 
            this.perc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perc.Location = new System.Drawing.Point(164, 115);
            this.perc.Name = "perc";
            this.perc.Size = new System.Drawing.Size(75, 40);
            this.perc.TabIndex = 18;
            this.perc.Text = "%";
            this.perc.UseVisualStyleBackColor = true;
            this.perc.Click += new System.EventHandler(this.Dev);
            // 
            // sqr
            // 
            this.sqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqr.Location = new System.Drawing.Point(83, 115);
            this.sqr.Name = "sqr";
            this.sqr.Size = new System.Drawing.Size(75, 40);
            this.sqr.TabIndex = 19;
            this.sqr.Text = "X²";
            this.sqr.UseVisualStyleBackColor = true;
            this.sqr.Click += new System.EventHandler(this.Dev);
            // 
            // sqrroot
            // 
            this.sqrroot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqrroot.Location = new System.Drawing.Point(2, 115);
            this.sqrroot.Name = "sqrroot";
            this.sqrroot.Size = new System.Drawing.Size(75, 40);
            this.sqrroot.TabIndex = 20;
            this.sqrroot.Text = "√\r\n";
            this.sqrroot.UseVisualStyleBackColor = true;
            this.sqrroot.Click += new System.EventHandler(this.Dev);
            // 
            // Form1
            // 
            this.AcceptButton = this.equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 339);
            this.Controls.Add(this.sqrroot);
            this.Controls.Add(this.sqr);
            this.Controls.Add(this.perc);
            this.Controls.Add(this.div);
            this.Controls.Add(this.res);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.clr);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button perc;
        private System.Windows.Forms.Button sqr;
        private System.Windows.Forms.Button sqrroot;
    }
}

