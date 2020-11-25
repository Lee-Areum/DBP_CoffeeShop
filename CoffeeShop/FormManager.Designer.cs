namespace CoffeeShop
{
    partial class FormManager
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelState = new System.Windows.Forms.Label();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.groupBoxManager = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOkHow = new System.Windows.Forms.Button();
            this.comboBoxHowShow = new System.Windows.Forms.ComboBox();
            this.dataGridViewShow = new System.Windows.Forms.DataGridView();
            this.groupBoxUserLog = new System.Windows.Forms.GroupBox();
            this.listViewShowUser = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewUserLog = new System.Windows.Forms.DataGridView();
            this.buttonUserChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxMenuManage = new System.Windows.Forms.GroupBox();
            this.listViewShowMenu = new System.Windows.Forms.ListView();
            this.ColumnCoffeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCoffeePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxMenuPrice = new System.Windows.Forms.TextBox();
            this.textBoxMenuName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAddMenu = new System.Windows.Forms.Button();
            this.buttonChangeMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlManager = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).BeginInit();
            this.groupBoxUserLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserLog)).BeginInit();
            this.groupBoxMenuManage.SuspendLayout();
            this.tabControlManager.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(577, 34);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(152, 15);
            this.labelState.TabIndex = 5;
            this.labelState.Text = "로그인이 필요합니다.";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(750, 28);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(86, 29);
            this.buttonLogOut.TabIndex = 6;
            this.buttonLogOut.Text = "로그아웃";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // groupBoxManager
            // 
            this.groupBoxManager.Controls.Add(this.label4);
            this.groupBoxManager.Controls.Add(this.buttonOkHow);
            this.groupBoxManager.Controls.Add(this.comboBoxHowShow);
            this.groupBoxManager.Controls.Add(this.dataGridViewShow);
            this.groupBoxManager.Location = new System.Drawing.Point(25, 58);
            this.groupBoxManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxManager.Name = "groupBoxManager";
            this.groupBoxManager.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxManager.Size = new System.Drawing.Size(805, 304);
            this.groupBoxManager.TabIndex = 11;
            this.groupBoxManager.TabStop = false;
            this.groupBoxManager.Text = "커피판매 확인";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "통계 방식 선택";
            // 
            // buttonOkHow
            // 
            this.buttonOkHow.Location = new System.Drawing.Point(333, 25);
            this.buttonOkHow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonOkHow.Name = "buttonOkHow";
            this.buttonOkHow.Size = new System.Drawing.Size(86, 29);
            this.buttonOkHow.TabIndex = 12;
            this.buttonOkHow.Text = "확인";
            this.buttonOkHow.UseVisualStyleBackColor = true;
            this.buttonOkHow.Click += new System.EventHandler(this.buttonOkHow_Click);
            // 
            // comboBoxHowShow
            // 
            this.comboBoxHowShow.FormattingEnabled = true;
            this.comboBoxHowShow.Items.AddRange(new object[] {
            "사용자별 일일 판매",
            "커피종류별 일일 판매",
            "커피종류별 월별 판매",
            "시간별 커피종류 판매"});
            this.comboBoxHowShow.Location = new System.Drawing.Point(138, 25);
            this.comboBoxHowShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxHowShow.Name = "comboBoxHowShow";
            this.comboBoxHowShow.Size = new System.Drawing.Size(171, 23);
            this.comboBoxHowShow.TabIndex = 1;
            // 
            // dataGridViewShow
            // 
            this.dataGridViewShow.AllowUserToAddRows = false;
            this.dataGridViewShow.AllowUserToDeleteRows = false;
            this.dataGridViewShow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShow.Location = new System.Drawing.Point(8, 75);
            this.dataGridViewShow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewShow.Name = "dataGridViewShow";
            this.dataGridViewShow.ReadOnly = true;
            this.dataGridViewShow.RowHeadersVisible = false;
            this.dataGridViewShow.RowTemplate.Height = 23;
            this.dataGridViewShow.Size = new System.Drawing.Size(790, 210);
            this.dataGridViewShow.TabIndex = 0;
            // 
            // groupBoxUserLog
            // 
            this.groupBoxUserLog.Controls.Add(this.listViewShowUser);
            this.groupBoxUserLog.Controls.Add(this.label2);
            this.groupBoxUserLog.Controls.Add(this.dataGridViewUserLog);
            this.groupBoxUserLog.Controls.Add(this.buttonUserChoose);
            this.groupBoxUserLog.Controls.Add(this.label1);
            this.groupBoxUserLog.Location = new System.Drawing.Point(7, 38);
            this.groupBoxUserLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxUserLog.Name = "groupBoxUserLog";
            this.groupBoxUserLog.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxUserLog.Size = new System.Drawing.Size(839, 336);
            this.groupBoxUserLog.TabIndex = 13;
            this.groupBoxUserLog.TabStop = false;
            this.groupBoxUserLog.Text = "유저로그 조회";
            // 
            // listViewShowUser
            // 
            this.listViewShowUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewShowUser.FullRowSelect = true;
            this.listViewShowUser.HideSelection = false;
            this.listViewShowUser.Location = new System.Drawing.Point(19, 64);
            this.listViewShowUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewShowUser.Name = "listViewShowUser";
            this.listViewShowUser.Size = new System.Drawing.Size(155, 244);
            this.listViewShowUser.TabIndex = 17;
            this.listViewShowUser.UseCompatibleStateImageBehavior = false;
            this.listViewShowUser.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "커피이름";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "커피가격";
            this.columnHeader2.Width = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "로그인/로그아웃 기록";
            // 
            // dataGridViewUserLog
            // 
            this.dataGridViewUserLog.AllowUserToAddRows = false;
            this.dataGridViewUserLog.AllowUserToDeleteRows = false;
            this.dataGridViewUserLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUserLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserLog.Location = new System.Drawing.Point(298, 75);
            this.dataGridViewUserLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewUserLog.Name = "dataGridViewUserLog";
            this.dataGridViewUserLog.ReadOnly = true;
            this.dataGridViewUserLog.RowHeadersVisible = false;
            this.dataGridViewUserLog.RowTemplate.Height = 23;
            this.dataGridViewUserLog.Size = new System.Drawing.Size(525, 234);
            this.dataGridViewUserLog.TabIndex = 13;
            // 
            // buttonUserChoose
            // 
            this.buttonUserChoose.Location = new System.Drawing.Point(195, 145);
            this.buttonUserChoose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonUserChoose.Name = "buttonUserChoose";
            this.buttonUserChoose.Size = new System.Drawing.Size(86, 29);
            this.buttonUserChoose.TabIndex = 2;
            this.buttonUserChoose.Text = "확인";
            this.buttonUserChoose.UseVisualStyleBackColor = true;
            this.buttonUserChoose.Click += new System.EventHandler(this.buttonUserChoose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "User 목록";
            // 
            // groupBoxMenuManage
            // 
            this.groupBoxMenuManage.Controls.Add(this.listViewShowMenu);
            this.groupBoxMenuManage.Controls.Add(this.textBoxMenuPrice);
            this.groupBoxMenuManage.Controls.Add(this.textBoxMenuName);
            this.groupBoxMenuManage.Controls.Add(this.label6);
            this.groupBoxMenuManage.Controls.Add(this.label5);
            this.groupBoxMenuManage.Controls.Add(this.buttonAddMenu);
            this.groupBoxMenuManage.Controls.Add(this.buttonChangeMenu);
            this.groupBoxMenuManage.Controls.Add(this.label3);
            this.groupBoxMenuManage.Location = new System.Drawing.Point(19, 44);
            this.groupBoxMenuManage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMenuManage.Name = "groupBoxMenuManage";
            this.groupBoxMenuManage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxMenuManage.Size = new System.Drawing.Size(798, 311);
            this.groupBoxMenuManage.TabIndex = 14;
            this.groupBoxMenuManage.TabStop = false;
            this.groupBoxMenuManage.Text = "메뉴관리";
            // 
            // listViewShowMenu
            // 
            this.listViewShowMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCoffeeName,
            this.ColumnCoffeePrice});
            this.listViewShowMenu.FullRowSelect = true;
            this.listViewShowMenu.HideSelection = false;
            this.listViewShowMenu.Location = new System.Drawing.Point(37, 40);
            this.listViewShowMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewShowMenu.Name = "listViewShowMenu";
            this.listViewShowMenu.Size = new System.Drawing.Size(245, 244);
            this.listViewShowMenu.TabIndex = 16;
            this.listViewShowMenu.UseCompatibleStateImageBehavior = false;
            this.listViewShowMenu.View = System.Windows.Forms.View.Details;
            this.listViewShowMenu.SelectedIndexChanged += new System.EventHandler(this.listViewShowMenu_SelectedIndexChanged);
            // 
            // ColumnCoffeeName
            // 
            this.ColumnCoffeeName.Text = "커피이름";
            // 
            // ColumnCoffeePrice
            // 
            this.ColumnCoffeePrice.Text = "커피가격";
            this.ColumnCoffeePrice.Width = 77;
            // 
            // textBoxMenuPrice
            // 
            this.textBoxMenuPrice.Location = new System.Drawing.Point(511, 138);
            this.textBoxMenuPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMenuPrice.Name = "textBoxMenuPrice";
            this.textBoxMenuPrice.Size = new System.Drawing.Size(114, 25);
            this.textBoxMenuPrice.TabIndex = 7;
            // 
            // textBoxMenuName
            // 
            this.textBoxMenuName.Location = new System.Drawing.Point(511, 65);
            this.textBoxMenuName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMenuName.Name = "textBoxMenuName";
            this.textBoxMenuName.Size = new System.Drawing.Size(114, 25);
            this.textBoxMenuName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "메뉴명";
            // 
            // buttonAddMenu
            // 
            this.buttonAddMenu.Location = new System.Drawing.Point(562, 240);
            this.buttonAddMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMenu.Name = "buttonAddMenu";
            this.buttonAddMenu.Size = new System.Drawing.Size(96, 45);
            this.buttonAddMenu.TabIndex = 3;
            this.buttonAddMenu.Text = "추가";
            this.buttonAddMenu.UseVisualStyleBackColor = true;
            this.buttonAddMenu.Click += new System.EventHandler(this.buttonAddMenu_Click);
            // 
            // buttonChangeMenu
            // 
            this.buttonChangeMenu.Location = new System.Drawing.Point(394, 240);
            this.buttonChangeMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChangeMenu.Name = "buttonChangeMenu";
            this.buttonChangeMenu.Size = new System.Drawing.Size(96, 41);
            this.buttonChangeMenu.TabIndex = 2;
            this.buttonChangeMenu.Text = "수정";
            this.buttonChangeMenu.UseVisualStyleBackColor = true;
            this.buttonChangeMenu.Click += new System.EventHandler(this.buttonChangeMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "메뉴";
            // 
            // tabControlManager
            // 
            this.tabControlManager.Controls.Add(this.tabPage1);
            this.tabControlManager.Controls.Add(this.tabPage3);
            this.tabControlManager.Controls.Add(this.tabPage2);
            this.tabControlManager.Location = new System.Drawing.Point(14, 64);
            this.tabControlManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlManager.Name = "tabControlManager";
            this.tabControlManager.SelectedIndex = 0;
            this.tabControlManager.Size = new System.Drawing.Size(862, 445);
            this.tabControlManager.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBoxUserLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(854, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "사용자로그";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.groupBoxMenuManage);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(854, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "메뉴관리";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBoxManager);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(854, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "커피판매 확인";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 538);
            this.Controls.Add(this.tabControlManager);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelState);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormManager_FormClosing);
            this.groupBoxManager.ResumeLayout(false);
            this.groupBoxManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShow)).EndInit();
            this.groupBoxUserLog.ResumeLayout(false);
            this.groupBoxUserLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserLog)).EndInit();
            this.groupBoxMenuManage.ResumeLayout(false);
            this.groupBoxMenuManage.PerformLayout();
            this.tabControlManager.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.GroupBox groupBoxManager;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOkHow;
        private System.Windows.Forms.ComboBox comboBoxHowShow;
        private System.Windows.Forms.DataGridView dataGridViewShow;
        private System.Windows.Forms.GroupBox groupBoxUserLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewUserLog;
        private System.Windows.Forms.Button buttonUserChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxMenuManage;
        private System.Windows.Forms.TextBox textBoxMenuPrice;
        private System.Windows.Forms.TextBox textBoxMenuName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAddMenu;
        private System.Windows.Forms.Button buttonChangeMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControlManager;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewShowMenu;
        private System.Windows.Forms.ColumnHeader ColumnCoffeeName;
        private System.Windows.Forms.ColumnHeader ColumnCoffeePrice;
        private System.Windows.Forms.ListView listViewShowUser;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

