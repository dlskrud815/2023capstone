namespace EUV.Views
{
    partial class RouteSave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteSave));
            this.txtRouteSaveName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnRouteDelete = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRouteAdd = new MaterialSkin.Controls.MaterialFlatButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDown = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnUp = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRouteSet = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtRouteSaveName
            // 
            this.txtRouteSaveName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRouteSaveName.Depth = 0;
            this.txtRouteSaveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtRouteSaveName.Hint = "";
            this.txtRouteSaveName.Location = new System.Drawing.Point(30, 546);
            this.txtRouteSaveName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRouteSaveName.MaxLength = 32767;
            this.txtRouteSaveName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRouteSaveName.Name = "txtRouteSaveName";
            this.txtRouteSaveName.PasswordChar = '\0';
            this.txtRouteSaveName.ReadOnly = false;
            this.txtRouteSaveName.SelectedText = "";
            this.txtRouteSaveName.SelectionLength = 0;
            this.txtRouteSaveName.SelectionStart = 0;
            this.txtRouteSaveName.Size = new System.Drawing.Size(435, 37);
            this.txtRouteSaveName.TabIndex = 10;
            this.txtRouteSaveName.TabStop = false;
            this.txtRouteSaveName.Text = "- 저장 경로명 - ";
            this.txtRouteSaveName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRouteSaveName.UseSystemPasswordChar = false;
            // 
            // btnRouteDelete
            // 
            this.btnRouteDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRouteDelete.Depth = 0;
            this.btnRouteDelete.Icon = ((System.Drawing.Image)(resources.GetObject("btnRouteDelete.Icon")));
            this.btnRouteDelete.Location = new System.Drawing.Point(384, 487);
            this.btnRouteDelete.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnRouteDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRouteDelete.Name = "btnRouteDelete";
            this.btnRouteDelete.Primary = true;
            this.btnRouteDelete.Size = new System.Drawing.Size(45, 45);
            this.btnRouteDelete.TabIndex = 12;
            this.btnRouteDelete.UseVisualStyleBackColor = true;
            this.btnRouteDelete.Click += new System.EventHandler(this.btnRouteDelete_Click);
            // 
            // btnRouteAdd
            // 
            this.btnRouteAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRouteAdd.Depth = 0;
            this.btnRouteAdd.Icon = ((System.Drawing.Image)(resources.GetObject("btnRouteAdd.Icon")));
            this.btnRouteAdd.Location = new System.Drawing.Point(440, 487);
            this.btnRouteAdd.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnRouteAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRouteAdd.Name = "btnRouteAdd";
            this.btnRouteAdd.Primary = true;
            this.btnRouteAdd.Size = new System.Drawing.Size(45, 45);
            this.btnRouteAdd.TabIndex = 11;
            this.btnRouteAdd.UseVisualStyleBackColor = true;
            this.btnRouteAdd.Click += new System.EventHandler(this.btnRouteAdd_Click);
            // 
            // listView2
            // 
            this.listView2.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(8, 161);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(478, 302);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 315;
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Depth = 0;
            this.btnDown.Icon = ((System.Drawing.Image)(resources.GetObject("btnDown.Icon")));
            this.btnDown.Location = new System.Drawing.Point(18, 487);
            this.btnDown.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDown.Name = "btnDown";
            this.btnDown.Primary = true;
            this.btnDown.Size = new System.Drawing.Size(45, 45);
            this.btnDown.TabIndex = 15;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Depth = 0;
            this.btnUp.Icon = ((System.Drawing.Image)(resources.GetObject("btnUp.Icon")));
            this.btnUp.Location = new System.Drawing.Point(74, 487);
            this.btnUp.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.btnUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUp.Name = "btnUp";
            this.btnUp.Primary = true;
            this.btnUp.Size = new System.Drawing.Size(45, 45);
            this.btnUp.TabIndex = 14;
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnRouteSet
            // 
            this.btnRouteSet.Depth = 0;
            this.btnRouteSet.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.btnRouteSet.Icon = null;
            this.btnRouteSet.Location = new System.Drawing.Point(115, 629);
            this.btnRouteSet.Margin = new System.Windows.Forms.Padding(2);
            this.btnRouteSet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRouteSet.Name = "btnRouteSet";
            this.btnRouteSet.Primary = true;
            this.btnRouteSet.Size = new System.Drawing.Size(292, 47);
            this.btnRouteSet.TabIndex = 16;
            this.btnRouteSet.Text = "경로 저장";
            this.btnRouteSet.UseVisualStyleBackColor = true;
            this.btnRouteSet.Click += new System.EventHandler(this.btnRouteSet_Click);
            // 
            // RouteSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 754);
            this.Controls.Add(this.btnRouteSet);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnRouteDelete);
            this.Controls.Add(this.btnRouteAdd);
            this.Controls.Add(this.txtRouteSaveName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RouteSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "경로 저장";
            this.Load += new System.EventHandler(this.RouteSave_Load);
            this.Controls.SetChildIndex(this.txtRouteSaveName, 0);
            this.Controls.SetChildIndex(this.btnRouteAdd, 0);
            this.Controls.SetChildIndex(this.btnRouteDelete, 0);
            this.Controls.SetChildIndex(this.listView2, 0);
            this.Controls.SetChildIndex(this.btnUp, 0);
            this.Controls.SetChildIndex(this.btnDown, 0);
            this.Controls.SetChildIndex(this.btnRouteSet, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtRouteSaveName;
        private MaterialSkin.Controls.MaterialFlatButton btnRouteDelete;
        private MaterialSkin.Controls.MaterialFlatButton btnRouteAdd;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private MaterialSkin.Controls.MaterialFlatButton btnDown;
        private MaterialSkin.Controls.MaterialFlatButton btnUp;
        private MaterialSkin.Controls.MaterialRaisedButton btnRouteSet;
    }
}