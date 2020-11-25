namespace CoffeeShop
{
    partial class DialogChangeOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewShowOrdertoChange = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonMenuChangeDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelChangeMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonChangeOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewShowOrdertoChange
            // 
            this.listViewShowOrdertoChange.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9});
            this.listViewShowOrdertoChange.FullRowSelect = true;
            this.listViewShowOrdertoChange.HideSelection = false;
            this.listViewShowOrdertoChange.Location = new System.Drawing.Point(324, 60);
            this.listViewShowOrdertoChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewShowOrdertoChange.Name = "listViewShowOrdertoChange";
            this.listViewShowOrdertoChange.Size = new System.Drawing.Size(292, 296);
            this.listViewShowOrdertoChange.TabIndex = 30;
            this.listViewShowOrdertoChange.UseCompatibleStateImageBehavior = false;
            this.listViewShowOrdertoChange.View = System.Windows.Forms.View.Details;
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
            // buttonMenuChangeDelete
            // 
            this.buttonMenuChangeDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenuChangeDelete.Location = new System.Drawing.Point(645, 227);
            this.buttonMenuChangeDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonMenuChangeDelete.Name = "buttonMenuChangeDelete";
            this.buttonMenuChangeDelete.Size = new System.Drawing.Size(113, 69);
            this.buttonMenuChangeDelete.TabIndex = 29;
            this.buttonMenuChangeDelete.Text = "삭제하기";
            this.buttonMenuChangeDelete.UseVisualStyleBackColor = true;
            this.buttonMenuChangeDelete.Click += new System.EventHandler(this.buttonMenuChangeDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "커피 목록";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "주문내역";
            // 
            // flowLayoutPanelChangeMenu
            // 
            this.flowLayoutPanelChangeMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelChangeMenu.AutoScroll = true;
            this.flowLayoutPanelChangeMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanelChangeMenu.Location = new System.Drawing.Point(32, 60);
            this.flowLayoutPanelChangeMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanelChangeMenu.Name = "flowLayoutPanelChangeMenu";
            this.flowLayoutPanelChangeMenu.Size = new System.Drawing.Size(259, 298);
            this.flowLayoutPanelChangeMenu.TabIndex = 26;
            // 
            // buttonChangeOK
            // 
            this.buttonChangeOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChangeOK.Location = new System.Drawing.Point(645, 115);
            this.buttonChangeOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChangeOK.Name = "buttonChangeOK";
            this.buttonChangeOK.Size = new System.Drawing.Size(113, 69);
            this.buttonChangeOK.TabIndex = 25;
            this.buttonChangeOK.Text = "주문하기";
            this.buttonChangeOK.UseVisualStyleBackColor = true;
            this.buttonChangeOK.Click += new System.EventHandler(this.buttonChangeOK_Click);
            // 
            // DialogChangeOrder
            // 
            this.ClientSize = new System.Drawing.Size(790, 394);
            this.Controls.Add(this.listViewShowOrdertoChange);
            this.Controls.Add(this.buttonMenuChangeDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanelChangeMenu);
            this.Controls.Add(this.buttonChangeOK);
            this.Name = "DialogChangeOrder";
            this.Text = "주문수정";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ListView listViewShowOrdertoChange;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button buttonMenuChangeDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChangeMenu;
        private System.Windows.Forms.Button buttonChangeOK;
    }
    #endregion
}