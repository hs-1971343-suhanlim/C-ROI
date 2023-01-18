namespace HomeWork3Update
{
    partial class RoiForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.labelImageSize = new System.Windows.Forms.Label();
            this.labelHight = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.groupBoxOption = new System.Windows.Forms.GroupBox();
            this.inputHight = new System.Windows.Forms.TextBox();
            this.inputWidth = new System.Windows.Forms.TextBox();
            this.inputY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.inputX = new System.Windows.Forms.TextBox();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.btnInit = new System.Windows.Forms.Button();
            this.notice = new System.Windows.Forms.Label();
            this.noticeSub = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxOption.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSave.Location = new System.Drawing.Point(573, 213);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(66, 32);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoad.Location = new System.Drawing.Point(573, 105);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(66, 32);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnCut
            // 
            this.btnCut.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCut.Location = new System.Drawing.Point(573, 158);
            this.btnCut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(66, 32);
            this.btnCut.TabIndex = 2;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.BtnCut_Click);
            // 
            // labelImageSize
            // 
            this.labelImageSize.AutoSize = true;
            this.labelImageSize.Font = new System.Drawing.Font("맑은 고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelImageSize.Location = new System.Drawing.Point(60, 17);
            this.labelImageSize.Name = "labelImageSize";
            this.labelImageSize.Size = new System.Drawing.Size(110, 25);
            this.labelImageSize.TabIndex = 4;
            this.labelImageSize.Text = "Image Size";
            // 
            // labelHight
            // 
            this.labelHight.AutoSize = true;
            this.labelHight.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelHight.Location = new System.Drawing.Point(23, 98);
            this.labelHight.Name = "labelHight";
            this.labelHight.Size = new System.Drawing.Size(67, 22);
            this.labelHight.TabIndex = 6;
            this.labelHight.Text = "hight :";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelWidth.Location = new System.Drawing.Point(18, 63);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(72, 22);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "width :";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelX.Location = new System.Drawing.Point(122, 98);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(0, 22);
            this.labelX.TabIndex = 8;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelY.Location = new System.Drawing.Point(122, 63);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(0, 22);
            this.labelY.TabIndex = 9;
            // 
            // groupBoxOption
            // 
            this.groupBoxOption.Controls.Add(this.inputHight);
            this.groupBoxOption.Controls.Add(this.inputWidth);
            this.groupBoxOption.Controls.Add(this.inputY);
            this.groupBoxOption.Controls.Add(this.label3);
            this.groupBoxOption.Controls.Add(this.label2);
            this.groupBoxOption.Controls.Add(this.label1);
            this.groupBoxOption.Controls.Add(this.label);
            this.groupBoxOption.Controls.Add(this.inputX);
            this.groupBoxOption.Location = new System.Drawing.Point(655, 105);
            this.groupBoxOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOption.Name = "groupBoxOption";
            this.groupBoxOption.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOption.Size = new System.Drawing.Size(155, 139);
            this.groupBoxOption.TabIndex = 10;
            this.groupBoxOption.TabStop = false;
            this.groupBoxOption.Text = "ROIArea";
            // 
            // inputHight
            // 
            this.inputHight.Location = new System.Drawing.Point(62, 104);
            this.inputHight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputHight.Name = "inputHight";
            this.inputHight.Size = new System.Drawing.Size(88, 21);
            this.inputHight.TabIndex = 6;
            // 
            // inputWidth
            // 
            this.inputWidth.Location = new System.Drawing.Point(62, 78);
            this.inputWidth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputWidth.Name = "inputWidth";
            this.inputWidth.Size = new System.Drawing.Size(88, 21);
            this.inputWidth.TabIndex = 5;
            // 
            // inputY
            // 
            this.inputY.Location = new System.Drawing.Point(62, 53);
            this.inputY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputY.Name = "inputY";
            this.inputY.Size = new System.Drawing.Size(88, 21);
            this.inputY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hight :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(25, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Y :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(4, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Width :";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(24, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(22, 15);
            this.label.TabIndex = 13;
            this.label.Text = "X :";
            // 
            // inputX
            // 
            this.inputX.Location = new System.Drawing.Point(62, 27);
            this.inputX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputX.Name = "inputX";
            this.inputX.Size = new System.Drawing.Size(88, 21);
            this.inputX.TabIndex = 3;
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.labelImageSize);
            this.groupBoxSize.Controls.Add(this.labelWidth);
            this.groupBoxSize.Controls.Add(this.labelY);
            this.groupBoxSize.Controls.Add(this.labelHight);
            this.groupBoxSize.Controls.Add(this.labelX);
            this.groupBoxSize.Location = new System.Drawing.Point(573, 288);
            this.groupBoxSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxSize.Size = new System.Drawing.Size(236, 146);
            this.groupBoxSize.TabIndex = 11;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // btnInit
            // 
            this.btnInit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInit.Location = new System.Drawing.Point(717, 252);
            this.btnInit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(80, 32);
            this.btnInit.TabIndex = 12;
            this.btnInit.Text = "원상 복구";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.BtnInit_Click);
            // 
            // notice
            // 
            this.notice.AutoSize = true;
            this.notice.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.notice.Location = new System.Drawing.Point(559, 28);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(250, 25);
            this.notice.TabIndex = 14;
            this.notice.Text = "이미지의 최대 px 허용값은 ";
            // 
            // noticeSub
            // 
            this.noticeSub.AutoSize = true;
            this.noticeSub.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noticeSub.Location = new System.Drawing.Point(578, 64);
            this.noticeSub.Name = "noticeSub";
            this.noticeSub.Size = new System.Drawing.Size(208, 25);
            this.noticeSub.TabIndex = 15;
            this.noticeSub.Text = "000 x 000 까지 입니다.";
            // 
            // RoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 525);
            this.Controls.Add(this.noticeSub);
            this.Controls.Add(this.notice);
            this.Controls.Add(this.btnInit);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxOption);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RoiForm";
            this.Text = "ROI Application";
            this.Load += new System.EventHandler(this.RoiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxOption.ResumeLayout(false);
            this.groupBoxOption.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Label labelImageSize;
        private System.Windows.Forms.Label labelHight;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.GroupBox groupBoxOption;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox inputX;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.TextBox inputHight;
        private System.Windows.Forms.TextBox inputWidth;
        private System.Windows.Forms.TextBox inputY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Label notice;
        private System.Windows.Forms.Label noticeSub;
    }
}

