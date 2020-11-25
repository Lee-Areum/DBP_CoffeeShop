namespace CoffeeShop
{
    partial class DialogChangePW
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
            this.buttonchangepwOK = new System.Windows.Forms.Button();
            this.textBoxchangepw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonchangepwOK
            // 
            this.buttonchangepwOK.Location = new System.Drawing.Point(92, 146);
            this.buttonchangepwOK.Name = "buttonchangepwOK";
            this.buttonchangepwOK.Size = new System.Drawing.Size(92, 42);
            this.buttonchangepwOK.TabIndex = 0;
            this.buttonchangepwOK.Text = "확인";
            this.buttonchangepwOK.UseVisualStyleBackColor = true;
            this.buttonchangepwOK.Click += new System.EventHandler(this.buttonchangepwOK_Click);
            // 
            // textBoxchangepw
            // 
            this.textBoxchangepw.Location = new System.Drawing.Point(29, 92);
            this.textBoxchangepw.Name = "textBoxchangepw";
            this.textBoxchangepw.Size = new System.Drawing.Size(218, 21);
            this.textBoxchangepw.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "변경할 비밀번호";
            // 
            // DialogChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 220);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxchangepw);
            this.Controls.Add(this.buttonchangepwOK);
            this.Name = "DialogChangePW";
            this.Text = "비밀번호 변경";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonchangepwOK;
        private System.Windows.Forms.TextBox textBoxchangepw;
        private System.Windows.Forms.Label label1;
    }
}