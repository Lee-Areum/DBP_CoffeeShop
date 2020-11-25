namespace CoffeeShop
{
    partial class FormCasher
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
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.tabControlCasher = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxCasher = new System.Windows.Forms.GroupBox();
            this.listViewShowOrder = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonMenuDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSendOrder = new System.Windows.Forms.Button();
            this.dateTimePickerSellDate = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewShowPastOrder = new System.Windows.Forms.DataGridView();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonChangeOrder = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlCasher.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxCasher.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowPastOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(668, 20);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 10;
            this.buttonLogOut.Text = "로그아웃";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(518, 25);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(121, 12);
            this.labelState.TabIndex = 9;
            this.labelState.Text = "로그인이 필요합니다.";
            // 
            // tabControlCasher
            // 
            this.tabControlCasher.Controls.Add(this.tabPage1);
            this.tabControlCasher.Controls.Add(this.tabPage2);
            this.tabControlCasher.Location = new System.Drawing.Point(23, 46);
            this.tabControlCasher.Name = "tabControlCasher";
            this.tabControlCasher.SelectedIndex = 0;
            this.tabControlCasher.Size = new System.Drawing.Size(724, 351);
            this.tabControlCasher.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.groupBoxCasher);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(716, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "주문화면";
            // 
            // groupBoxCasher
            // 
            this.groupBoxCasher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCasher.Controls.Add(this.listViewShowOrder);
            this.groupBoxCasher.Controls.Add(this.buttonMenuDelete);
            this.groupBoxCasher.Controls.Add(this.label2);
            this.groupBoxCasher.Controls.Add(this.label1);
            this.groupBoxCasher.Controls.Add(this.flowLayoutPanelMenu);
            this.groupBoxCasher.Controls.Add(this.buttonSendOrder);
            this.groupBoxCasher.Controls.Add(this.dateTimePickerSellDate);
            this.groupBoxCasher.Location = new System.Drawing.Point(6, 3);
            this.groupBoxCasher.Name = "groupBoxCasher";
            this.groupBoxCasher.Size = new System.Drawing.Size(704, 333);
            this.groupBoxCasher.TabIndex = 12;
            this.groupBoxCasher.TabStop = false;
            this.groupBoxCasher.Text = "캐셔용 화면";
            // 
            // listViewShowOrder
            // 
            this.listViewShowOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9});
            this.listViewShowOrder.FullRowSelect = true;
            this.listViewShowOrder.Location = new System.Drawing.Point(278, 75);
            this.listViewShowOrder.Name = "listViewShowOrder";
            this.listViewShowOrder.Size = new System.Drawing.Size(256, 238);
            this.listViewShowOrder.TabIndex = 18;
            this.listViewShowOrder.UseCompatibleStateImageBehavior = false;
            this.listViewShowOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "커피id";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "커피이름";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "커피가격";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "개수";
            // 
            // buttonMenuDelete
            // 
            this.buttonMenuDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenuDelete.Location = new System.Drawing.Point(559, 209);
            this.buttonMenuDelete.Name = "buttonMenuDelete";
            this.buttonMenuDelete.Size = new System.Drawing.Size(99, 55);
            this.buttonMenuDelete.TabIndex = 6;
            this.buttonMenuDelete.Text = "삭제하기";
            this.buttonMenuDelete.UseVisualStyleBackColor = true;
            this.buttonMenuDelete.Click += new System.EventHandler(this.buttonMenuDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "커피 목록";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "주문내역";
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelMenu.AutoScroll = true;
            this.flowLayoutPanelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(23, 75);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(227, 238);
            this.flowLayoutPanelMenu.TabIndex = 3;
            // 
            // buttonSendOrder
            // 
            this.buttonSendOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendOrder.Location = new System.Drawing.Point(559, 119);
            this.buttonSendOrder.Name = "buttonSendOrder";
            this.buttonSendOrder.Size = new System.Drawing.Size(99, 55);
            this.buttonSendOrder.TabIndex = 2;
            this.buttonSendOrder.Text = "주문하기";
            this.buttonSendOrder.UseVisualStyleBackColor = true;
            this.buttonSendOrder.Click += new System.EventHandler(this.buttonSendOrder_Click_1);
            // 
            // dateTimePickerSellDate
            // 
            this.dateTimePickerSellDate.Location = new System.Drawing.Point(23, 20);
            this.dateTimePickerSellDate.Name = "dateTimePickerSellDate";
            this.dateTimePickerSellDate.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerSellDate.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.dataGridViewShowPastOrder);
            this.tabPage2.Controls.Add(this.buttonDeleteOrder);
            this.tabPage2.Controls.Add(this.buttonChangeOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 325);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "이전주문";
            // 
            // dataGridViewShowPastOrder
            // 
            this.dataGridViewShowPastOrder.AllowUserToAddRows = false;
            this.dataGridViewShowPastOrder.AllowUserToDeleteRows = false;
            this.dataGridViewShowPastOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewShowPastOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowPastOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5});
            this.dataGridViewShowPastOrder.Location = new System.Drawing.Point(13, 15);
            this.dataGridViewShowPastOrder.Name = "dataGridViewShowPastOrder";
            this.dataGridViewShowPastOrder.ReadOnly = true;
            this.dataGridViewShowPastOrder.RowHeadersVisible = false;
            this.dataGridViewShowPastOrder.RowTemplate.Height = 23;
            this.dataGridViewShowPastOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewShowPastOrder.Size = new System.Drawing.Size(575, 290);
            this.dataGridViewShowPastOrder.TabIndex = 19;
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(604, 169);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(87, 37);
            this.buttonDeleteOrder.TabIndex = 7;
            this.buttonDeleteOrder.Text = "삭제";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonChangeOrder
            // 
            this.buttonChangeOrder.Location = new System.Drawing.Point(604, 97);
            this.buttonChangeOrder.Name = "buttonChangeOrder";
            this.buttonChangeOrder.Size = new System.Drawing.Size(87, 37);
            this.buttonChangeOrder.TabIndex = 6;
            this.buttonChangeOrder.Text = "수정";
            this.buttonChangeOrder.UseVisualStyleBackColor = true;
            this.buttonChangeOrder.Click += new System.EventHandler(this.buttonChangeOrder_Click);
            // 
            // Column6
            // 
            this.Column6.FillWeight = 30F;
            this.Column6.HeaderText = "id";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "주문번호";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "날짜";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "커피이름";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "커피가격";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 80F;
            this.Column7.HeaderText = "커피개수";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 60F;
            this.Column5.HeaderText = "비교";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FormCasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 422);
            this.Controls.Add(this.tabControlCasher);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.labelState);
            this.Name = "FormCasher";
            this.Text = "FormCasher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCasher_FormClosing);
            this.tabControlCasher.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxCasher.ResumeLayout(false);
            this.groupBoxCasher.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowPastOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.TabControl tabControlCasher;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxCasher;
        private System.Windows.Forms.Button buttonMenuDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Button buttonSendOrder;
        private System.Windows.Forms.DateTimePicker dateTimePickerSellDate;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonChangeOrder;
        private System.Windows.Forms.ListView listViewShowOrder;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DataGridView dataGridViewShowPastOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}