namespace EUV.Views
{
    partial class AlgorithmsForm
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAlgorithms = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnDroneMoving = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(40, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1040, 511);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnAlgorithms
            // 
            this.btnAlgorithms.Depth = 0;
            this.btnAlgorithms.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.btnAlgorithms.Icon = null;
            this.btnAlgorithms.Location = new System.Drawing.Point(394, 636);
            this.btnAlgorithms.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlgorithms.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAlgorithms.Name = "btnAlgorithms";
            this.btnAlgorithms.Primary = true;
            this.btnAlgorithms.Size = new System.Drawing.Size(133, 41);
            this.btnAlgorithms.TabIndex = 10;
            this.btnAlgorithms.Text = "알고리즘 적용";
            this.btnAlgorithms.UseVisualStyleBackColor = true;
            this.btnAlgorithms.Click += new System.EventHandler(this.btnAlgorithms_Click);
            // 
            // btnDroneMoving
            // 
            this.btnDroneMoving.Depth = 0;
            this.btnDroneMoving.Font = new System.Drawing.Font("나눔스퀘어", 9.999999F);
            this.btnDroneMoving.Icon = null;
            this.btnDroneMoving.Location = new System.Drawing.Point(590, 636);
            this.btnDroneMoving.Margin = new System.Windows.Forms.Padding(2);
            this.btnDroneMoving.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDroneMoving.Name = "btnDroneMoving";
            this.btnDroneMoving.Primary = true;
            this.btnDroneMoving.Size = new System.Drawing.Size(133, 41);
            this.btnDroneMoving.TabIndex = 11;
            this.btnDroneMoving.Text = "드론이동";
            this.btnDroneMoving.UseVisualStyleBackColor = true;
            this.btnDroneMoving.Click += new System.EventHandler(this.btnDroneMove_Click);
            // 
            // AlgorithmsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 706);
            this.Controls.Add(this.btnDroneMoving);
            this.Controls.Add(this.btnAlgorithms);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("나눔스퀘어", 15F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AlgorithmsForm";
            this.Text = "알고리즘";
            this.Load += new System.EventHandler(this.AlgorithmsForm_Load);
            this.Controls.SetChildIndex(this.richTextBox1, 0);
            this.Controls.SetChildIndex(this.btnAlgorithms, 0);
            this.Controls.SetChildIndex(this.btnDroneMoving, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAlgorithms;
        private MaterialSkin.Controls.MaterialRaisedButton btnDroneMoving;
    }
}