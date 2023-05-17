namespace EUV.Views
{
    partial class RouteDraw
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
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.drawSaveBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.droneNum = new System.Windows.Forms.Label();
            this.drawPolygonCheckBox = new System.Windows.Forms.CheckBox();
            this.btnRemoveDraw = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNodeSelect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.labelDroneNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numTest = new System.Windows.Forms.Label();
            this.grpDraw = new System.Windows.Forms.GroupBox();
            this.tlpAudio = new System.Windows.Forms.TableLayoutPanel();
            this.btnPath = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboRoute = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RouteMap = new EUV.Controls.myGMAP();
            this.grpSave.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpDraw.SuspendLayout();
            this.tlpAudio.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSave
            // 
            this.grpSave.Controls.Add(this.tableLayoutPanel2);
            this.grpSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpSave.Location = new System.Drawing.Point(818, 2);
            this.grpSave.Margin = new System.Windows.Forms.Padding(2);
            this.grpSave.Name = "grpSave";
            this.grpSave.Padding = new System.Windows.Forms.Padding(2);
            this.grpSave.Size = new System.Drawing.Size(145, 86);
            this.grpSave.TabIndex = 16;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "경로 저장";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.drawSaveBtn, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 38);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(141, 65);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // drawSaveBtn
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.drawSaveBtn, 2);
            this.drawSaveBtn.Depth = 0;
            this.drawSaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawSaveBtn.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.drawSaveBtn.Icon = null;
            this.drawSaveBtn.Location = new System.Drawing.Point(2, 2);
            this.drawSaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.drawSaveBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.drawSaveBtn.Name = "drawSaveBtn";
            this.drawSaveBtn.Primary = true;
            this.drawSaveBtn.Size = new System.Drawing.Size(137, 41);
            this.drawSaveBtn.TabIndex = 9;
            this.drawSaveBtn.Text = "그리기 저장";
            this.drawSaveBtn.UseVisualStyleBackColor = true;
            this.drawSaveBtn.Click += new System.EventHandler(this.drawSaveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.numTest);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(812, 86);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "그리기 도구";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Controls.Add(this.droneNum, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.drawPolygonCheckBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveDraw, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnNodeSelect, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDroneNum, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 38);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 65);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // droneNum
            // 
            this.droneNum.AutoSize = true;
            this.droneNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.droneNum.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.droneNum.Location = new System.Drawing.Point(600, 0);
            this.droneNum.Name = "droneNum";
            this.droneNum.Size = new System.Drawing.Size(74, 45);
            this.droneNum.TabIndex = 21;
            this.droneNum.Text = "-";
            this.droneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawPolygonCheckBox
            // 
            this.drawPolygonCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawPolygonCheckBox.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.drawPolygonCheckBox.Location = new System.Drawing.Point(67, 3);
            this.drawPolygonCheckBox.Name = "drawPolygonCheckBox";
            this.drawPolygonCheckBox.Size = new System.Drawing.Size(196, 39);
            this.drawPolygonCheckBox.TabIndex = 17;
            this.drawPolygonCheckBox.Text = "다각형 그리기";
            this.drawPolygonCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.drawPolygonCheckBox.UseVisualStyleBackColor = true;
            this.drawPolygonCheckBox.CheckedChanged += new System.EventHandler(this.drawPolygonCheckBox_CheckedChanged);
            // 
            // btnRemoveDraw
            // 
            this.btnRemoveDraw.AutoSize = true;
            this.btnRemoveDraw.Depth = 0;
            this.btnRemoveDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveDraw.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.btnRemoveDraw.Icon = null;
            this.btnRemoveDraw.Location = new System.Drawing.Point(268, 2);
            this.btnRemoveDraw.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDraw.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemoveDraw.Name = "btnRemoveDraw";
            this.btnRemoveDraw.Primary = true;
            this.btnRemoveDraw.Size = new System.Drawing.Size(125, 41);
            this.btnRemoveDraw.TabIndex = 14;
            this.btnRemoveDraw.Text = "지우기";
            this.btnRemoveDraw.UseVisualStyleBackColor = true;
            this.btnRemoveDraw.Click += new System.EventHandler(this.btnRemoveDraw_Click);
            // 
            // btnNodeSelect
            // 
            this.btnNodeSelect.Depth = 0;
            this.btnNodeSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNodeSelect.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNodeSelect.Icon = null;
            this.btnNodeSelect.Location = new System.Drawing.Point(679, 2);
            this.btnNodeSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnNodeSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNodeSelect.Name = "btnNodeSelect";
            this.btnNodeSelect.Primary = true;
            this.btnNodeSelect.Size = new System.Drawing.Size(127, 41);
            this.btnNodeSelect.TabIndex = 18;
            this.btnNodeSelect.Text = "지점 선택";
            this.btnNodeSelect.UseVisualStyleBackColor = true;
            this.btnNodeSelect.Click += new System.EventHandler(this.btnNodeSelect_Click);
            // 
            // labelDroneNum
            // 
            this.labelDroneNum.AutoSize = true;
            this.labelDroneNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDroneNum.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.labelDroneNum.Location = new System.Drawing.Point(398, 0);
            this.labelDroneNum.Name = "labelDroneNum";
            this.labelDroneNum.Size = new System.Drawing.Size(196, 45);
            this.labelDroneNum.TabIndex = 20;
            this.labelDroneNum.Text = "선택 수상드론 갯수";
            this.labelDroneNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::EUV.Properties.Resources.경로그리기;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // numTest
            // 
            this.numTest.AutoSize = true;
            this.numTest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numTest.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.numTest.Location = new System.Drawing.Point(776, 14);
            this.numTest.Name = "numTest";
            this.numTest.Size = new System.Drawing.Size(22, 22);
            this.numTest.TabIndex = 22;
            this.numTest.Text = "6";
            this.numTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpDraw
            // 
            this.grpDraw.Controls.Add(this.tlpAudio);
            this.grpDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpDraw.Location = new System.Drawing.Point(967, 2);
            this.grpDraw.Margin = new System.Windows.Forms.Padding(2);
            this.grpDraw.Name = "grpDraw";
            this.grpDraw.Padding = new System.Windows.Forms.Padding(2);
            this.grpDraw.Size = new System.Drawing.Size(392, 86);
            this.grpDraw.TabIndex = 15;
            this.grpDraw.TabStop = false;
            this.grpDraw.Text = "설정";
            this.grpDraw.Enter += new System.EventHandler(this.grpDraw_Enter);
            // 
            // tlpAudio
            // 
            this.tlpAudio.ColumnCount = 2;
            this.tlpAudio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpAudio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAudio.Controls.Add(this.btnPath, 1, 0);
            this.tlpAudio.Controls.Add(this.cboRoute, 0, 0);
            this.tlpAudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpAudio.Location = new System.Drawing.Point(2, 38);
            this.tlpAudio.Margin = new System.Windows.Forms.Padding(2);
            this.tlpAudio.Name = "tlpAudio";
            this.tlpAudio.RowCount = 2;
            this.tlpAudio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpAudio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpAudio.Size = new System.Drawing.Size(388, 65);
            this.tlpAudio.TabIndex = 0;
            // 
            // btnPath
            // 
            this.btnPath.Depth = 0;
            this.btnPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPath.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.btnPath.Icon = null;
            this.btnPath.Location = new System.Drawing.Point(273, 2);
            this.btnPath.Margin = new System.Windows.Forms.Padding(2);
            this.btnPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPath.Name = "btnPath";
            this.btnPath.Primary = true;
            this.btnPath.Size = new System.Drawing.Size(113, 41);
            this.btnPath.TabIndex = 9;
            this.btnPath.Text = "최단 경로";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // cboRoute
            // 
            this.cboRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.Location = new System.Drawing.Point(3, 3);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(265, 45);
            this.cboRoute.TabIndex = 10;
            this.cboRoute.SelectedIndexChanged += new System.EventHandler(this.cboRoute_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.RouteMap, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.grpSave, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.grpDraw, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1361, 761);
            this.tableLayoutPanel3.TabIndex = 17;
            // 
            // RouteMap
            // 
            this.RouteMap.Bearing = 0F;
            this.RouteMap.CanDragMap = true;
            this.tableLayoutPanel3.SetColumnSpan(this.RouteMap, 3);
            this.RouteMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RouteMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.RouteMap.GrayScaleMode = false;
            this.RouteMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.RouteMap.LevelsKeepInMemmory = 5;
            this.RouteMap.Location = new System.Drawing.Point(3, 93);
            this.RouteMap.MarkersEnabled = true;
            this.RouteMap.MaxZoom = 2;
            this.RouteMap.MinZoom = 2;
            this.RouteMap.MouseWheelZoomEnabled = true;
            this.RouteMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.RouteMap.Name = "RouteMap";
            this.RouteMap.NegativeMode = false;
            this.RouteMap.PolygonsEnabled = true;
            this.RouteMap.RetryLoadTile = 0;
            this.RouteMap.RoutesEnabled = true;
            this.RouteMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.RouteMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.RouteMap.ShowTileGridLines = false;
            this.RouteMap.Size = new System.Drawing.Size(1355, 665);
            this.RouteMap.TabIndex = 0;
            this.RouteMap.Zoom = 0D;
            this.RouteMap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.RouteMap_OnMarkerClick);
            this.RouteMap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.RouteMap_OnMapZoomChanged);
            this.RouteMap.Paint += new System.Windows.Forms.PaintEventHandler(this.RouteMap_Paint);
            this.RouteMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RouteMap_MouseUp);
            // 
            // RouteDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 825);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("나눔스퀘어", 15F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RouteDraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "경로 그리기";
            this.Load += new System.EventHandler(this.RouteDraw_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            this.grpSave.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpDraw.ResumeLayout(false);
            this.tlpAudio.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.myGMAP RouteMap;
        private System.Windows.Forms.GroupBox grpSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialRaisedButton drawSaveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label droneNum;
        private System.Windows.Forms.CheckBox drawPolygonCheckBox;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemoveDraw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnNodeSelect;
        private System.Windows.Forms.Label labelDroneNum;
        private System.Windows.Forms.Label numTest;
        private System.Windows.Forms.GroupBox grpDraw;
        private System.Windows.Forms.TableLayoutPanel tlpAudio;
        private MaterialSkin.Controls.MaterialRaisedButton btnPath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cboRoute;
    }
}