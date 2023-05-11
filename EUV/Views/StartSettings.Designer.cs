namespace EUV.Views
{
    partial class StartSettings
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
            this.panel = new MaterialSkin.Controls.MaterialPanel();
            this.pnlSetButton = new MaterialSkin.Controls.MaterialPanel();
            this.btnSetting = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlBoatSet = new MaterialSkin.Controls.MaterialPanel();
            this.grpShipId = new System.Windows.Forms.GroupBox();
            this.chkAllBoat = new MaterialSkin.Controls.MaterialCheckBox();
            this.cboRoute = new MetroFramework.Controls.MetroComboBox();
            this.lblRoute = new MaterialSkin.Controls.MaterialLabel();
            this.btnSetRoute = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cboShipID = new MetroFramework.Controls.MetroComboBox();
            this.pnlTime = new MaterialSkin.Controls.MaterialPanel();
            this.grpMusicTimeSetting = new System.Windows.Forms.GroupBox();
            this.lblCountDown2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCountDown2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnMinPlus2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTimeSet2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMinMinus2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtpStartTime2 = new System.Windows.Forms.DateTimePicker();
            this.grpBoatTimeSetting = new System.Windows.Forms.GroupBox();
            this.pnlSetTime = new MaterialSkin.Controls.MaterialPanel();
            this.checkbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblCountDown = new MaterialSkin.Controls.MaterialLabel();
            this.txtCountDown = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnMinPlus = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnTimeSet = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMinMinus = new MaterialSkin.Controls.MaterialRaisedButton();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.pnlRoute = new MaterialSkin.Controls.MaterialPanel();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.materialPanel1 = new MaterialSkin.Controls.MaterialPanel();
            this.btnLocationTag = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMapLocation = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblLat = new MaterialSkin.Controls.MaterialLabel();
            this.lblLong = new MaterialSkin.Controls.MaterialLabel();
            this.txtLat = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLng = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblHeading = new MaterialSkin.Controls.MaterialLabel();
            this.txtHeading = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel.SuspendLayout();
            this.pnlSetButton.SuspendLayout();
            this.pnlBoatSet.SuspendLayout();
            this.grpShipId.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.grpMusicTimeSetting.SuspendLayout();
            this.grpBoatTimeSetting.SuspendLayout();
            this.pnlSetTime.SuspendLayout();
            this.pnlRoute.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.materialPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.pnlSetButton);
            this.panel.Controls.Add(this.pnlBoatSet);
            this.panel.Controls.Add(this.pnlTime);
            this.panel.Controls.Add(this.pnlRoute);
            this.panel.Depth = 0;
            this.panel.Location = new System.Drawing.Point(2, 65);
            this.panel.MouseState = MaterialSkin.MouseState.HOVER;
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(646, 604);
            this.panel.TabIndex = 3;
            // 
            // pnlSetButton
            // 
            this.pnlSetButton.Controls.Add(this.btnSetting);
            this.pnlSetButton.Depth = 0;
            this.pnlSetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSetButton.Location = new System.Drawing.Point(0, 574);
            this.pnlSetButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlSetButton.Name = "pnlSetButton";
            this.pnlSetButton.Size = new System.Drawing.Size(646, 30);
            this.pnlSetButton.TabIndex = 1;
            // 
            // btnSetting
            // 
            this.btnSetting.Depth = 0;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.Font = new System.Drawing.Font("마루 부리OTF 중간", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetting.Icon = null;
            this.btnSetting.Location = new System.Drawing.Point(0, 0);
            this.btnSetting.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Primary = true;
            this.btnSetting.Size = new System.Drawing.Size(646, 30);
            this.btnSetting.TabIndex = 47;
            this.btnSetting.Text = "설정";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pnlBoatSet
            // 
            this.pnlBoatSet.Controls.Add(this.grpShipId);
            this.pnlBoatSet.Depth = 0;
            this.pnlBoatSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBoatSet.Location = new System.Drawing.Point(0, 417);
            this.pnlBoatSet.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlBoatSet.Name = "pnlBoatSet";
            this.pnlBoatSet.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlBoatSet.Size = new System.Drawing.Size(646, 156);
            this.pnlBoatSet.TabIndex = 2;
            // 
            // grpShipId
            // 
            this.grpShipId.Controls.Add(this.chkAllBoat);
            this.grpShipId.Controls.Add(this.cboRoute);
            this.grpShipId.Controls.Add(this.lblRoute);
            this.grpShipId.Controls.Add(this.btnSetRoute);
            this.grpShipId.Controls.Add(this.cboShipID);
            this.grpShipId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpShipId.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpShipId.Location = new System.Drawing.Point(0, 0);
            this.grpShipId.Name = "grpShipId";
            this.grpShipId.Size = new System.Drawing.Size(646, 153);
            this.grpShipId.TabIndex = 37;
            this.grpShipId.TabStop = false;
            this.grpShipId.Text = "운항 경로";
            // 
            // chkAllBoat
            // 
            this.chkAllBoat.Depth = 0;
            this.chkAllBoat.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkAllBoat.Location = new System.Drawing.Point(11, 31);
            this.chkAllBoat.Margin = new System.Windows.Forms.Padding(0);
            this.chkAllBoat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAllBoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAllBoat.Name = "chkAllBoat";
            this.chkAllBoat.Ripple = true;
            this.chkAllBoat.Size = new System.Drawing.Size(187, 19);
            this.chkAllBoat.TabIndex = 37;
            this.chkAllBoat.Text = "모든 선박 지정 경로 자동 등록";
            this.chkAllBoat.UseVisualStyleBackColor = true;
            this.chkAllBoat.CheckedChanged += new System.EventHandler(this.chkAllBoat_CheckedChanged);
            // 
            // cboRoute
            // 
            this.cboRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRoute.FormattingEnabled = true;
            this.cboRoute.ItemHeight = 23;
            this.cboRoute.Location = new System.Drawing.Point(85, 112);
            this.cboRoute.Name = "cboRoute";
            this.cboRoute.Size = new System.Drawing.Size(428, 29);
            this.cboRoute.TabIndex = 33;
            this.cboRoute.UseSelectable = true;
            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Depth = 0;
            this.lblRoute.Font = new System.Drawing.Font("마루 부리OTF 중간", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoute.Location = new System.Drawing.Point(21, 115);
            this.lblRoute.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(58, 26);
            this.lblRoute.TabIndex = 13;
            this.lblRoute.Text = "경로 :";
            // 
            // btnSetRoute
            // 
            this.btnSetRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetRoute.Depth = 0;
            this.btnSetRoute.Font = new System.Drawing.Font("마루 부리OTF 중간", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetRoute.Icon = null;
            this.btnSetRoute.Location = new System.Drawing.Point(519, 111);
            this.btnSetRoute.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSetRoute.Name = "btnSetRoute";
            this.btnSetRoute.Primary = true;
            this.btnSetRoute.Size = new System.Drawing.Size(105, 30);
            this.btnSetRoute.TabIndex = 33;
            this.btnSetRoute.Text = "경로 등록";
            this.btnSetRoute.UseVisualStyleBackColor = true;
            this.btnSetRoute.Click += new System.EventHandler(this.btnSetRoute_Click);
            // 
            // cboShipID
            // 
            this.cboShipID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboShipID.FormattingEnabled = true;
            this.cboShipID.ItemHeight = 23;
            this.cboShipID.Location = new System.Drawing.Point(19, 63);
            this.cboShipID.Name = "cboShipID";
            this.cboShipID.Size = new System.Drawing.Size(605, 29);
            this.cboShipID.TabIndex = 32;
            this.cboShipID.UseSelectable = true;
            this.cboShipID.SelectedIndexChanged += new System.EventHandler(this.cboShipID_SelectedIndexChanged);
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.grpMusicTimeSetting);
            this.pnlTime.Controls.Add(this.grpBoatTimeSetting);
            this.pnlTime.Depth = 0;
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTime.Location = new System.Drawing.Point(0, 216);
            this.pnlTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlTime.Size = new System.Drawing.Size(646, 201);
            this.pnlTime.TabIndex = 1;
            // 
            // grpMusicTimeSetting
            // 
            this.grpMusicTimeSetting.Controls.Add(this.lblCountDown2);
            this.grpMusicTimeSetting.Controls.Add(this.txtCountDown2);
            this.grpMusicTimeSetting.Controls.Add(this.btnMinPlus2);
            this.grpMusicTimeSetting.Controls.Add(this.btnTimeSet2);
            this.grpMusicTimeSetting.Controls.Add(this.btnMinMinus2);
            this.grpMusicTimeSetting.Controls.Add(this.dtpStartTime2);
            this.grpMusicTimeSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpMusicTimeSetting.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpMusicTimeSetting.Location = new System.Drawing.Point(325, 0);
            this.grpMusicTimeSetting.Name = "grpMusicTimeSetting";
            this.grpMusicTimeSetting.Size = new System.Drawing.Size(321, 198);
            this.grpMusicTimeSetting.TabIndex = 47;
            this.grpMusicTimeSetting.TabStop = false;
            this.grpMusicTimeSetting.Text = "음악 시작 시간";
            this.grpMusicTimeSetting.Visible = false;
            // 
            // lblCountDown2
            // 
            this.lblCountDown2.AutoSize = true;
            this.lblCountDown2.Depth = 0;
            this.lblCountDown2.Font = new System.Drawing.Font("마루 부리OTF 중간", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown2.Location = new System.Drawing.Point(16, 157);
            this.lblCountDown2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCountDown2.Name = "lblCountDown2";
            this.lblCountDown2.Size = new System.Drawing.Size(76, 26);
            this.lblCountDown2.TabIndex = 10;
            this.lblCountDown2.Text = "초읽기 :";
            // 
            // txtCountDown2
            // 
            this.txtCountDown2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountDown2.Depth = 0;
            this.txtCountDown2.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountDown2.Hint = "";
            this.txtCountDown2.Location = new System.Drawing.Point(111, 152);
            this.txtCountDown2.MaxLength = 32767;
            this.txtCountDown2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCountDown2.Name = "txtCountDown2";
            this.txtCountDown2.PasswordChar = '\0';
            this.txtCountDown2.ReadOnly = false;
            this.txtCountDown2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountDown2.SelectedText = "";
            this.txtCountDown2.SelectionLength = 0;
            this.txtCountDown2.SelectionStart = 0;
            this.txtCountDown2.Size = new System.Drawing.Size(190, 31);
            this.txtCountDown2.TabIndex = 13;
            this.txtCountDown2.TabStop = false;
            this.txtCountDown2.Text = "5";
            this.txtCountDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCountDown2.UseSystemPasswordChar = false;
            this.txtCountDown2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInt_KeyPress);
            this.txtCountDown2.Leave += new System.EventHandler(this.txtCountDown2_Leave);
            // 
            // btnMinPlus2
            // 
            this.btnMinPlus2.Depth = 0;
            this.btnMinPlus2.Font = new System.Drawing.Font("마루 부리OTF 중간", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinPlus2.Icon = null;
            this.btnMinPlus2.Location = new System.Drawing.Point(21, 105);
            this.btnMinPlus2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMinPlus2.Name = "btnMinPlus2";
            this.btnMinPlus2.Primary = true;
            this.btnMinPlus2.Size = new System.Drawing.Size(43, 29);
            this.btnMinPlus2.TabIndex = 18;
            this.btnMinPlus2.Text = "+ 분";
            this.btnMinPlus2.UseVisualStyleBackColor = true;
            this.btnMinPlus2.Click += new System.EventHandler(this.btnMinPlus2_Click);
            // 
            // btnTimeSet2
            // 
            this.btnTimeSet2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimeSet2.Depth = 0;
            this.btnTimeSet2.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTimeSet2.Icon = null;
            this.btnTimeSet2.Location = new System.Drawing.Point(170, 108);
            this.btnTimeSet2.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnTimeSet2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimeSet2.Name = "btnTimeSet2";
            this.btnTimeSet2.Primary = false;
            this.btnTimeSet2.Size = new System.Drawing.Size(131, 25);
            this.btnTimeSet2.TabIndex = 15;
            this.btnTimeSet2.Text = "현재 시간으로 설정";
            this.btnTimeSet2.UseVisualStyleBackColor = true;
            this.btnTimeSet2.Click += new System.EventHandler(this.btnTimeSet2_Click);
            // 
            // btnMinMinus2
            // 
            this.btnMinMinus2.Depth = 0;
            this.btnMinMinus2.Font = new System.Drawing.Font("마루 부리OTF 중간", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinMinus2.Icon = null;
            this.btnMinMinus2.Location = new System.Drawing.Point(70, 105);
            this.btnMinMinus2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMinMinus2.Name = "btnMinMinus2";
            this.btnMinMinus2.Primary = true;
            this.btnMinMinus2.Size = new System.Drawing.Size(43, 29);
            this.btnMinMinus2.TabIndex = 17;
            this.btnMinMinus2.Text = "- 분";
            this.btnMinMinus2.UseVisualStyleBackColor = true;
            this.btnMinMinus2.Click += new System.EventHandler(this.btnMinMinus2_Click);
            // 
            // dtpStartTime2
            // 
            this.dtpStartTime2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartTime2.CalendarFont = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime2.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpStartTime2.CustomFormat = "yyyy. MM. dd   HH : mm : ss";
            this.dtpStartTime2.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpStartTime2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime2.Location = new System.Drawing.Point(21, 70);
            this.dtpStartTime2.Name = "dtpStartTime2";
            this.dtpStartTime2.Size = new System.Drawing.Size(280, 29);
            this.dtpStartTime2.TabIndex = 16;
            // 
            // grpBoatTimeSetting
            // 
            this.grpBoatTimeSetting.Controls.Add(this.pnlSetTime);
            this.grpBoatTimeSetting.Controls.Add(this.lblCountDown);
            this.grpBoatTimeSetting.Controls.Add(this.txtCountDown);
            this.grpBoatTimeSetting.Controls.Add(this.btnMinPlus);
            this.grpBoatTimeSetting.Controls.Add(this.btnTimeSet);
            this.grpBoatTimeSetting.Controls.Add(this.btnMinMinus);
            this.grpBoatTimeSetting.Controls.Add(this.dtpStartTime);
            this.grpBoatTimeSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBoatTimeSetting.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpBoatTimeSetting.Location = new System.Drawing.Point(0, 0);
            this.grpBoatTimeSetting.Name = "grpBoatTimeSetting";
            this.grpBoatTimeSetting.Size = new System.Drawing.Size(321, 198);
            this.grpBoatTimeSetting.TabIndex = 46;
            this.grpBoatTimeSetting.TabStop = false;
            this.grpBoatTimeSetting.Text = "경로 이동 시작 시간";
            // 
            // pnlSetTime
            // 
            this.pnlSetTime.BackColor = System.Drawing.Color.White;
            this.pnlSetTime.Controls.Add(this.checkbox);
            this.pnlSetTime.Depth = 0;
            this.pnlSetTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSetTime.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSetTime.Location = new System.Drawing.Point(3, 28);
            this.pnlSetTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlSetTime.Name = "pnlSetTime";
            this.pnlSetTime.Size = new System.Drawing.Size(315, 31);
            this.pnlSetTime.TabIndex = 43;
            // 
            // checkbox
            // 
            this.checkbox.Checked = true;
            this.checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox.Depth = 0;
            this.checkbox.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkbox.Location = new System.Drawing.Point(8, 7);
            this.checkbox.Margin = new System.Windows.Forms.Padding(0);
            this.checkbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkbox.Name = "checkbox";
            this.checkbox.Ripple = true;
            this.checkbox.Size = new System.Drawing.Size(211, 18);
            this.checkbox.TabIndex = 37;
            this.checkbox.Text = "선박 및 음악 시작 시간 동일하게 설정";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // lblCountDown
            // 
            this.lblCountDown.AutoSize = true;
            this.lblCountDown.Depth = 0;
            this.lblCountDown.Font = new System.Drawing.Font("마루 부리OTF 중간", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountDown.Location = new System.Drawing.Point(18, 157);
            this.lblCountDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCountDown.Name = "lblCountDown";
            this.lblCountDown.Size = new System.Drawing.Size(76, 26);
            this.lblCountDown.TabIndex = 10;
            this.lblCountDown.Text = "초읽기 :";
            // 
            // txtCountDown
            // 
            this.txtCountDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountDown.Depth = 0;
            this.txtCountDown.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountDown.Hint = "";
            this.txtCountDown.Location = new System.Drawing.Point(111, 152);
            this.txtCountDown.MaxLength = 32767;
            this.txtCountDown.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.PasswordChar = '\0';
            this.txtCountDown.ReadOnly = false;
            this.txtCountDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCountDown.SelectedText = "";
            this.txtCountDown.SelectionLength = 0;
            this.txtCountDown.SelectionStart = 0;
            this.txtCountDown.Size = new System.Drawing.Size(188, 31);
            this.txtCountDown.TabIndex = 13;
            this.txtCountDown.TabStop = false;
            this.txtCountDown.Text = "5";
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCountDown.UseSystemPasswordChar = false;
            this.txtCountDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInt_KeyPress);
            this.txtCountDown.Leave += new System.EventHandler(this.txtCountDown_Leave);
            // 
            // btnMinPlus
            // 
            this.btnMinPlus.Depth = 0;
            this.btnMinPlus.Font = new System.Drawing.Font("마루 부리OTF 중간", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinPlus.Icon = null;
            this.btnMinPlus.Location = new System.Drawing.Point(19, 105);
            this.btnMinPlus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMinPlus.Name = "btnMinPlus";
            this.btnMinPlus.Primary = true;
            this.btnMinPlus.Size = new System.Drawing.Size(43, 29);
            this.btnMinPlus.TabIndex = 18;
            this.btnMinPlus.Text = "+ 분";
            this.btnMinPlus.UseVisualStyleBackColor = true;
            this.btnMinPlus.Click += new System.EventHandler(this.btnMinPlus_Click);
            // 
            // btnTimeSet
            // 
            this.btnTimeSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimeSet.Depth = 0;
            this.btnTimeSet.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTimeSet.Icon = null;
            this.btnTimeSet.Location = new System.Drawing.Point(171, 108);
            this.btnTimeSet.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnTimeSet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimeSet.Name = "btnTimeSet";
            this.btnTimeSet.Primary = false;
            this.btnTimeSet.Size = new System.Drawing.Size(128, 25);
            this.btnTimeSet.TabIndex = 15;
            this.btnTimeSet.Text = "현재 시간으로 설정";
            this.btnTimeSet.UseVisualStyleBackColor = true;
            this.btnTimeSet.Click += new System.EventHandler(this.btnTimeSet_Click);
            // 
            // btnMinMinus
            // 
            this.btnMinMinus.Depth = 0;
            this.btnMinMinus.Font = new System.Drawing.Font("마루 부리OTF 중간", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMinMinus.Icon = null;
            this.btnMinMinus.Location = new System.Drawing.Point(68, 105);
            this.btnMinMinus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMinMinus.Name = "btnMinMinus";
            this.btnMinMinus.Primary = true;
            this.btnMinMinus.Size = new System.Drawing.Size(43, 29);
            this.btnMinMinus.TabIndex = 17;
            this.btnMinMinus.Text = "- 분";
            this.btnMinMinus.UseVisualStyleBackColor = true;
            this.btnMinMinus.Click += new System.EventHandler(this.btnMinMinus_Click);
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStartTime.CalendarFont = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtpStartTime.CustomFormat = "yyyy. MM. dd   HH : mm : ss";
            this.dtpStartTime.Font = new System.Drawing.Font("나눔스퀘어라운드 Regular", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(19, 70);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(280, 29);
            this.dtpStartTime.TabIndex = 16;
            // 
            // pnlRoute
            // 
            this.pnlRoute.Controls.Add(this.grpLocation);
            this.pnlRoute.Depth = 0;
            this.pnlRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRoute.Location = new System.Drawing.Point(0, 0);
            this.pnlRoute.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlRoute.Name = "pnlRoute";
            this.pnlRoute.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pnlRoute.Size = new System.Drawing.Size(646, 216);
            this.pnlRoute.TabIndex = 0;
            // 
            // grpLocation
            // 
            this.grpLocation.Controls.Add(this.materialPanel1);
            this.grpLocation.Controls.Add(this.lblLat);
            this.grpLocation.Controls.Add(this.lblLong);
            this.grpLocation.Controls.Add(this.txtLat);
            this.grpLocation.Controls.Add(this.txtLng);
            this.grpLocation.Controls.Add(this.lblHeading);
            this.grpLocation.Controls.Add(this.txtHeading);
            this.grpLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLocation.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.grpLocation.Location = new System.Drawing.Point(0, 0);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(646, 213);
            this.grpLocation.TabIndex = 47;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "경로 이동 시작 위치";
            // 
            // materialPanel1
            // 
            this.materialPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPanel1.Controls.Add(this.btnLocationTag);
            this.materialPanel1.Controls.Add(this.btnMapLocation);
            this.materialPanel1.Depth = 0;
            this.materialPanel1.Location = new System.Drawing.Point(26, 128);
            this.materialPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialPanel1.Name = "materialPanel1";
            this.materialPanel1.Size = new System.Drawing.Size(594, 28);
            this.materialPanel1.TabIndex = 14;
            // 
            // btnLocationTag
            // 
            this.btnLocationTag.Depth = 0;
            this.btnLocationTag.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLocationTag.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 14.25F, System.Drawing.FontStyle.Underline);
            this.btnLocationTag.Icon = null;
            this.btnLocationTag.Location = new System.Drawing.Point(464, 0);
            this.btnLocationTag.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLocationTag.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLocationTag.Name = "btnLocationTag";
            this.btnLocationTag.Primary = false;
            this.btnLocationTag.Size = new System.Drawing.Size(130, 28);
            this.btnLocationTag.TabIndex = 13;
            this.btnLocationTag.Text = "위치 태그로";
            this.btnLocationTag.UseVisualStyleBackColor = true;
            this.btnLocationTag.Click += new System.EventHandler(this.btnLocationTag_Click);
            // 
            // btnMapLocation
            // 
            this.btnMapLocation.Depth = 0;
            this.btnMapLocation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMapLocation.Font = new System.Drawing.Font("나눔손글씨 아줌마 자유", 14.25F, System.Drawing.FontStyle.Underline);
            this.btnMapLocation.Icon = null;
            this.btnMapLocation.Location = new System.Drawing.Point(0, 0);
            this.btnMapLocation.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMapLocation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMapLocation.Name = "btnMapLocation";
            this.btnMapLocation.Primary = false;
            this.btnMapLocation.Size = new System.Drawing.Size(130, 28);
            this.btnMapLocation.TabIndex = 8;
            this.btnMapLocation.Text = "지도의 현재 위치로";
            this.btnMapLocation.UseVisualStyleBackColor = true;
            this.btnMapLocation.Click += new System.EventHandler(this.btnMapLocation_Click);
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Depth = 0;
            this.lblLat.Font = new System.Drawing.Font("마루 부리OTF 중간", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLat.Location = new System.Drawing.Point(21, 39);
            this.lblLat.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(58, 26);
            this.lblLat.TabIndex = 3;
            this.lblLat.Text = "위도 :";
            // 
            // lblLong
            // 
            this.lblLong.AutoSize = true;
            this.lblLong.Depth = 0;
            this.lblLong.Font = new System.Drawing.Font("마루 부리OTF 중간", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLong.Location = new System.Drawing.Point(21, 89);
            this.lblLong.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLong.Name = "lblLong";
            this.lblLong.Size = new System.Drawing.Size(58, 26);
            this.lblLong.TabIndex = 4;
            this.lblLong.Text = "경도 :";
            // 
            // txtLat
            // 
            this.txtLat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLat.Depth = 0;
            this.txtLat.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLat.Hint = "";
            this.txtLat.Location = new System.Drawing.Point(92, 34);
            this.txtLat.MaxLength = 32767;
            this.txtLat.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLat.Name = "txtLat";
            this.txtLat.PasswordChar = '\0';
            this.txtLat.ReadOnly = false;
            this.txtLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLat.SelectedText = "";
            this.txtLat.SelectionLength = 0;
            this.txtLat.SelectionStart = 0;
            this.txtLat.Size = new System.Drawing.Size(528, 31);
            this.txtLat.TabIndex = 5;
            this.txtLat.TabStop = false;
            this.txtLat.Text = "35.1563215648";
            this.txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLat.UseSystemPasswordChar = false;
            this.txtLat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            this.txtLat.Leave += new System.EventHandler(this.txtLat_Leave);
            // 
            // txtLng
            // 
            this.txtLng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLng.Depth = 0;
            this.txtLng.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLng.Hint = "";
            this.txtLng.Location = new System.Drawing.Point(92, 84);
            this.txtLng.MaxLength = 32767;
            this.txtLng.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLng.Name = "txtLng";
            this.txtLng.PasswordChar = '\0';
            this.txtLng.ReadOnly = false;
            this.txtLng.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLng.SelectedText = "";
            this.txtLng.SelectionLength = 0;
            this.txtLng.SelectionStart = 0;
            this.txtLng.Size = new System.Drawing.Size(528, 31);
            this.txtLng.TabIndex = 6;
            this.txtLng.TabStop = false;
            this.txtLng.Text = "129.1563215648";
            this.txtLng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLng.UseSystemPasswordChar = false;
            this.txtLng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDouble_KeyPress);
            this.txtLng.Leave += new System.EventHandler(this.txtLng_Leave);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Depth = 0;
            this.lblHeading.Font = new System.Drawing.Font("마루 부리OTF 중간", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(21, 172);
            this.lblHeading.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(99, 26);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "운항 방향 :";
            // 
            // txtHeading
            // 
            this.txtHeading.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHeading.Depth = 0;
            this.txtHeading.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.Hint = "";
            this.txtHeading.Location = new System.Drawing.Point(134, 167);
            this.txtHeading.MaxLength = 32767;
            this.txtHeading.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.PasswordChar = '\0';
            this.txtHeading.ReadOnly = false;
            this.txtHeading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHeading.SelectedText = "";
            this.txtHeading.SelectionLength = 0;
            this.txtHeading.SelectionStart = 0;
            this.txtHeading.Size = new System.Drawing.Size(486, 31);
            this.txtHeading.TabIndex = 12;
            this.txtHeading.TabStop = false;
            this.txtHeading.Text = "345";
            this.txtHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHeading.UseSystemPasswordChar = false;
            // 
            // StartSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(650, 670);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("마루 부리OTF 중간", 15.75F);
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "StartSettings";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "운항 설정";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.SizeChanged += new System.EventHandler(this.StartSettings_SizeChanged);
            this.Controls.SetChildIndex(this.panel, 0);
            this.panel.ResumeLayout(false);
            this.pnlSetButton.ResumeLayout(false);
            this.pnlBoatSet.ResumeLayout(false);
            this.grpShipId.ResumeLayout(false);
            this.grpShipId.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.grpMusicTimeSetting.ResumeLayout(false);
            this.grpMusicTimeSetting.PerformLayout();
            this.grpBoatTimeSetting.ResumeLayout(false);
            this.grpBoatTimeSetting.PerformLayout();
            this.pnlSetTime.ResumeLayout(false);
            this.pnlRoute.ResumeLayout(false);
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.materialPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialPanel panel;
        private MaterialSkin.Controls.MaterialPanel pnlSetButton;
        private MaterialSkin.Controls.MaterialPanel pnlBoatSet;
        private MaterialSkin.Controls.MaterialPanel pnlTime;
        private MaterialSkin.Controls.MaterialPanel pnlRoute;
        private System.Windows.Forms.GroupBox grpLocation;
        private MaterialSkin.Controls.MaterialLabel lblLat;
        private MaterialSkin.Controls.MaterialLabel lblLong;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLat;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLng;
        private MaterialSkin.Controls.MaterialFlatButton btnMapLocation;
        private System.Windows.Forms.GroupBox grpMusicTimeSetting;
        private MaterialSkin.Controls.MaterialLabel lblCountDown2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCountDown2;
        private MaterialSkin.Controls.MaterialRaisedButton btnMinPlus2;
        private MaterialSkin.Controls.MaterialFlatButton btnTimeSet2;
        private MaterialSkin.Controls.MaterialRaisedButton btnMinMinus2;
        private System.Windows.Forms.DateTimePicker dtpStartTime2;
        private System.Windows.Forms.GroupBox grpBoatTimeSetting;
        private MaterialSkin.Controls.MaterialPanel pnlSetTime;
        private MaterialSkin.Controls.MaterialCheckBox checkbox;
        private MaterialSkin.Controls.MaterialLabel lblCountDown;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCountDown;
        private MaterialSkin.Controls.MaterialRaisedButton btnMinPlus;
        private MaterialSkin.Controls.MaterialFlatButton btnTimeSet;
        private MaterialSkin.Controls.MaterialRaisedButton btnMinMinus;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private MetroFramework.Controls.MetroComboBox cboRoute;
        private MaterialSkin.Controls.MaterialLabel lblRoute;
        private MaterialSkin.Controls.MaterialLabel lblHeading;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtHeading;
        private System.Windows.Forms.GroupBox grpShipId;
        private MaterialSkin.Controls.MaterialRaisedButton btnSetRoute;
        private MetroFramework.Controls.MetroComboBox cboShipID;
        private MaterialSkin.Controls.MaterialRaisedButton btnSetting;
        private MaterialSkin.Controls.MaterialFlatButton btnLocationTag;
        private MaterialSkin.Controls.MaterialPanel materialPanel1;
        private MaterialSkin.Controls.MaterialCheckBox chkAllBoat;
    }
}