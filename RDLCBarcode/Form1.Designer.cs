namespace RDLCBarcode
{
    partial class Form1
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
            this.btnBenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.appData1 = new RDLCBarcode.AppData();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBenerate
            // 
            this.btnBenerate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBenerate.Location = new System.Drawing.Point(394, 121);
            this.btnBenerate.Name = "btnBenerate";
            this.btnBenerate.Size = new System.Drawing.Size(86, 32);
            this.btnBenerate.TabIndex = 0;
            this.btnBenerate.Text = "Generate";
            this.btnBenerate.UseVisualStyleBackColor = true;
            this.btnBenerate.Click += new System.EventHandler(this.btnBenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barcode :";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBarcode.Location = new System.Drawing.Point(124, 28);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(356, 26);
            this.txtBarcode.TabIndex = 2;
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.number.Location = new System.Drawing.Point(124, 80);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(356, 26);
            this.number.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(42, 176);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(332, 78);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number :";
            // 
            // appData1
            // 
            this.appData1.DataSetName = "AppData";
            this.appData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 279);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.number);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBenerate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDLC Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private AppData appData1;
    }
}

