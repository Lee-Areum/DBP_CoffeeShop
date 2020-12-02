namespace CoffeeShop
{
    partial class FormSign
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
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxpw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelOK = new System.Windows.Forms.Label();
            this.buttonCheckID = new System.Windows.Forms.Button();
            this.labelidok = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // textBoxid
            // 
            this.textBoxid.Location = new System.Drawing.Point(84, 37);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(100, 21);
            this.textBoxid.TabIndex = 1;
            // 
            // textBoxpw
            // 
            this.textBoxpw.Location = new System.Drawing.Point(84, 83);
            this.textBoxpw.Name = "textBoxpw";
            this.textBoxpw.Size = new System.Drawing.Size(100, 21);
            this.textBoxpw.TabIndex = 3;
            this.textBoxpw.TextChanged += new System.EventHandler(this.textBoxpw_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "pw";
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(84, 130);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(100, 21);
            this.textBoxname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "이름";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(118, 246);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "확인";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelOK
            // 
            this.labelOK.AutoSize = true;
            this.labelOK.Location = new System.Drawing.Point(208, 92);
            this.labelOK.Name = "labelOK";
            this.labelOK.Size = new System.Drawing.Size(53, 12);
            this.labelOK.TabIndex = 7;
            this.labelOK.Text = "사용가능";
            // 
            // buttonCheckID
            // 
            this.buttonCheckID.Location = new System.Drawing.Point(200, 35);
            this.buttonCheckID.Name = "buttonCheckID";
            this.buttonCheckID.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckID.TabIndex = 8;
            this.buttonCheckID.Text = "중복확인";
            this.buttonCheckID.UseVisualStyleBackColor = true;
            this.buttonCheckID.Click += new System.EventHandler(this.buttonCheckID_Click);
            // 
            // labelidok
            // 
            this.labelidok.AutoSize = true;
            this.labelidok.Location = new System.Drawing.Point(208, 40);
            this.labelidok.Name = "labelidok";
            this.labelidok.Size = new System.Drawing.Size(53, 12);
            this.labelidok.TabIndex = 9;
            this.labelidok.Text = "사용가능";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "직책";
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Items.AddRange(new object[] {
            "점원",
            "관리자"});
            this.comboBoxManager.Location = new System.Drawing.Point(84, 177);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(121, 20);
            this.comboBoxManager.TabIndex = 12;
            // 
            // FormSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 298);
            this.Controls.Add(this.comboBoxManager);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelidok);
            this.Controls.Add(this.buttonCheckID);
            this.Controls.Add(this.labelOK);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxid);
            this.Controls.Add(this.label1);
            this.Name = "FormSign";
            this.Text = "회원가입";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxpw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelOK;
        private System.Windows.Forms.Button buttonCheckID;
        private System.Windows.Forms.Label labelidok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxManager;
    }
}