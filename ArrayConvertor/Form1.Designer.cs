namespace ArrayConvertor
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCArray = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.txtBinLineNo = new System.Windows.Forms.TextBox();
            this.txtBinLineOffset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numDataNumberInLine = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnToBinary = new System.Windows.Forms.Button();
            this.btnToCArray = new System.Windows.Forms.Button();
            this.btnSaveBinary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDataNumberInLine)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCArray
            // 
            this.txtCArray.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCArray.Location = new System.Drawing.Point(12, 55);
            this.txtCArray.Multiline = true;
            this.txtCArray.Name = "txtCArray";
            this.txtCArray.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCArray.Size = new System.Drawing.Size(432, 550);
            this.txtCArray.TabIndex = 3;
            this.txtCArray.WordWrap = false;
            this.txtCArray.TextChanged += new System.EventHandler(this.txtCArray_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "C配列";
            // 
            // txtBinary
            // 
            this.txtBinary.AllowDrop = true;
            this.txtBinary.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBinary.Location = new System.Drawing.Point(622, 55);
            this.txtBinary.Multiline = true;
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBinary.Size = new System.Drawing.Size(418, 550);
            this.txtBinary.TabIndex = 6;
            this.txtBinary.WordWrap = false;
            this.txtBinary.TextChanged += new System.EventHandler(this.txtBinary_TextChanged);
            this.txtBinary.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtBinary_DragDrop);
            this.txtBinary.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtBinary_DragEnter);
            // 
            // txtBinLineNo
            // 
            this.txtBinLineNo.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBinLineNo.Location = new System.Drawing.Point(535, 55);
            this.txtBinLineNo.Multiline = true;
            this.txtBinLineNo.Name = "txtBinLineNo";
            this.txtBinLineNo.ReadOnly = true;
            this.txtBinLineNo.Size = new System.Drawing.Size(81, 550);
            this.txtBinLineNo.TabIndex = 0;
            this.txtBinLineNo.TabStop = false;
            this.txtBinLineNo.Text = "00";
            this.txtBinLineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBinLineOffset
            // 
            this.txtBinLineOffset.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBinLineOffset.Location = new System.Drawing.Point(622, 27);
            this.txtBinLineOffset.Name = "txtBinLineOffset";
            this.txtBinLineOffset.ReadOnly = true;
            this.txtBinLineOffset.Size = new System.Drawing.Size(396, 22);
            this.txtBinLineOffset.TabIndex = 2;
            this.txtBinLineOffset.TabStop = false;
            this.txtBinLineOffset.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "バイナリ";
            // 
            // numDataNumberInLine
            // 
            this.numDataNumberInLine.Location = new System.Drawing.Point(383, 28);
            this.numDataNumberInLine.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numDataNumberInLine.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDataNumberInLine.Name = "numDataNumberInLine";
            this.numDataNumberInLine.Size = new System.Drawing.Size(61, 22);
            this.numDataNumberInLine.TabIndex = 4;
            this.numDataNumberInLine.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numDataNumberInLine.ValueChanged += new System.EventHandler(this.numDataNumberInLine_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "一行当たりのデータ数：";
            // 
            // btnToBinary
            // 
            this.btnToBinary.Location = new System.Drawing.Point(450, 55);
            this.btnToBinary.Name = "btnToBinary";
            this.btnToBinary.Size = new System.Drawing.Size(79, 56);
            this.btnToBinary.TabIndex = 0;
            this.btnToBinary.Text = "＞＞＞";
            this.btnToBinary.UseVisualStyleBackColor = true;
            this.btnToBinary.Click += new System.EventHandler(this.btnToBinary_Click);
            // 
            // btnToCArray
            // 
            this.btnToCArray.Location = new System.Drawing.Point(450, 143);
            this.btnToCArray.Name = "btnToCArray";
            this.btnToCArray.Size = new System.Drawing.Size(79, 56);
            this.btnToCArray.TabIndex = 1;
            this.btnToCArray.Text = "＜＜＜";
            this.btnToCArray.UseVisualStyleBackColor = true;
            this.btnToCArray.Click += new System.EventHandler(this.btnToCArray_Click);
            // 
            // btnSaveBinary
            // 
            this.btnSaveBinary.Location = new System.Drawing.Point(450, 238);
            this.btnSaveBinary.Name = "btnSaveBinary";
            this.btnSaveBinary.Size = new System.Drawing.Size(79, 56);
            this.btnSaveBinary.TabIndex = 2;
            this.btnSaveBinary.Text = "ファイル保存";
            this.btnSaveBinary.UseVisualStyleBackColor = true;
            this.btnSaveBinary.Click += new System.EventHandler(this.btnSaveBinary_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 617);
            this.Controls.Add(this.btnSaveBinary);
            this.Controls.Add(this.btnToCArray);
            this.Controls.Add(this.btnToBinary);
            this.Controls.Add(this.numDataNumberInLine);
            this.Controls.Add(this.txtBinLineOffset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBinLineNo);
            this.Controls.Add(this.txtBinary);
            this.Controls.Add(this.txtCArray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "配列←→バイナリ変換ツール";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDataNumberInLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBinary;
        private System.Windows.Forms.TextBox txtBinLineNo;
        private System.Windows.Forms.TextBox txtBinLineOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDataNumberInLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnToBinary;
        private System.Windows.Forms.Button btnToCArray;
        private System.Windows.Forms.Button btnSaveBinary;
    }
}

