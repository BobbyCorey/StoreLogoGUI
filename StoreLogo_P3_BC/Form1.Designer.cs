namespace StoreLogo_P3_BC
{
    partial class LogoStore
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
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.lblItemNum = new System.Windows.Forms.Label();
            this.txtbxOrderNum = new System.Windows.Forms.TextBox();
            this.txtbxNumItems = new System.Windows.Forms.TextBox();
            this.grpbxItemType = new System.Windows.Forms.GroupBox();
            this.lblEngrave = new System.Windows.Forms.Label();
            this.txtbxEngravement = new System.Windows.Forms.TextBox();
            this.chkbxLogo = new System.Windows.Forms.CheckBox();
            this.lblColorNum = new System.Windows.Forms.Label();
            this.txtbxNumColors = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtbxResult = new System.Windows.Forms.TextBox();
            this.rdbtnUsb = new System.Windows.Forms.RadioButton();
            this.rdbtnMug = new System.Windows.Forms.RadioButton();
            this.rdbtnPen = new System.Windows.Forms.RadioButton();
            this.grpbxItemType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.AutoSize = true;
            this.lblOrderNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNum.Location = new System.Drawing.Point(25, 30);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(104, 16);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "Order Number";
            // 
            // lblItemNum
            // 
            this.lblItemNum.AutoSize = true;
            this.lblItemNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNum.Location = new System.Drawing.Point(25, 64);
            this.lblItemNum.Name = "lblItemNum";
            this.lblItemNum.Size = new System.Drawing.Size(119, 16);
            this.lblItemNum.TabIndex = 1;
            this.lblItemNum.Text = "Number of Items";
            // 
            // txtbxOrderNum
            // 
            this.txtbxOrderNum.Location = new System.Drawing.Point(174, 30);
            this.txtbxOrderNum.Name = "txtbxOrderNum";
            this.txtbxOrderNum.Size = new System.Drawing.Size(151, 20);
            this.txtbxOrderNum.TabIndex = 2;
            // 
            // txtbxNumItems
            // 
            this.txtbxNumItems.Location = new System.Drawing.Point(174, 60);
            this.txtbxNumItems.Name = "txtbxNumItems";
            this.txtbxNumItems.Size = new System.Drawing.Size(151, 20);
            this.txtbxNumItems.TabIndex = 3;
            // 
            // grpbxItemType
            // 
            this.grpbxItemType.Controls.Add(this.rdbtnPen);
            this.grpbxItemType.Controls.Add(this.rdbtnMug);
            this.grpbxItemType.Controls.Add(this.rdbtnUsb);
            this.grpbxItemType.Location = new System.Drawing.Point(174, 100);
            this.grpbxItemType.Name = "grpbxItemType";
            this.grpbxItemType.Size = new System.Drawing.Size(118, 90);
            this.grpbxItemType.TabIndex = 4;
            this.grpbxItemType.TabStop = false;
            this.grpbxItemType.Text = "Item Type";
            // 
            // lblEngrave
            // 
            this.lblEngrave.AutoSize = true;
            this.lblEngrave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngrave.Location = new System.Drawing.Point(25, 205);
            this.lblEngrave.Name = "lblEngrave";
            this.lblEngrave.Size = new System.Drawing.Size(150, 16);
            this.lblEngrave.TabIndex = 5;
            this.lblEngrave.Text = "Text to engrave/print";
            // 
            // txtbxEngravement
            // 
            this.txtbxEngravement.Location = new System.Drawing.Point(28, 224);
            this.txtbxEngravement.Multiline = true;
            this.txtbxEngravement.Name = "txtbxEngravement";
            this.txtbxEngravement.Size = new System.Drawing.Size(294, 45);
            this.txtbxEngravement.TabIndex = 6;
            // 
            // chkbxLogo
            // 
            this.chkbxLogo.AutoSize = true;
            this.chkbxLogo.Location = new System.Drawing.Point(133, 275);
            this.chkbxLogo.Name = "chkbxLogo";
            this.chkbxLogo.Size = new System.Drawing.Size(56, 17);
            this.chkbxLogo.TabIndex = 7;
            this.chkbxLogo.Text = "Logo?";
            this.chkbxLogo.UseVisualStyleBackColor = true;
            // 
            // lblColorNum
            // 
            this.lblColorNum.AutoSize = true;
            this.lblColorNum.Location = new System.Drawing.Point(25, 304);
            this.lblColorNum.Name = "lblColorNum";
            this.lblColorNum.Size = new System.Drawing.Size(90, 13);
            this.lblColorNum.TabIndex = 8;
            this.lblColorNum.Text = "Number of colors:";
            // 
            // txtbxNumColors
            // 
            this.txtbxNumColors.Location = new System.Drawing.Point(121, 304);
            this.txtbxNumColors.Name = "txtbxNumColors";
            this.txtbxNumColors.Size = new System.Drawing.Size(201, 20);
            this.txtbxNumColors.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(80, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(181, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtbxResult
            // 
            this.txtbxResult.Location = new System.Drawing.Point(12, 387);
            this.txtbxResult.Multiline = true;
            this.txtbxResult.Name = "txtbxResult";
            this.txtbxResult.ReadOnly = true;
            this.txtbxResult.Size = new System.Drawing.Size(310, 61);
            this.txtbxResult.TabIndex = 12;
            // 
            // rdbtnUsb
            // 
            this.rdbtnUsb.AutoSize = true;
            this.rdbtnUsb.Location = new System.Drawing.Point(7, 20);
            this.rdbtnUsb.Name = "rdbtnUsb";
            this.rdbtnUsb.Size = new System.Drawing.Size(47, 17);
            this.rdbtnUsb.TabIndex = 0;
            this.rdbtnUsb.TabStop = true;
            this.rdbtnUsb.Text = "USB";
            this.rdbtnUsb.UseVisualStyleBackColor = true;
            // 
            // rdbtnMug
            // 
            this.rdbtnMug.AutoSize = true;
            this.rdbtnMug.Location = new System.Drawing.Point(7, 43);
            this.rdbtnMug.Name = "rdbtnMug";
            this.rdbtnMug.Size = new System.Drawing.Size(46, 17);
            this.rdbtnMug.TabIndex = 1;
            this.rdbtnMug.TabStop = true;
            this.rdbtnMug.Text = "Mug";
            this.rdbtnMug.UseVisualStyleBackColor = true;
            // 
            // rdbtnPen
            // 
            this.rdbtnPen.AutoSize = true;
            this.rdbtnPen.Location = new System.Drawing.Point(7, 66);
            this.rdbtnPen.Name = "rdbtnPen";
            this.rdbtnPen.Size = new System.Drawing.Size(44, 17);
            this.rdbtnPen.TabIndex = 2;
            this.rdbtnPen.TabStop = true;
            this.rdbtnPen.Text = "Pen";
            this.rdbtnPen.UseVisualStyleBackColor = true;
            // 
            // txtbxEngrave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 460);
            this.Controls.Add(this.txtbxResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbxNumColors);
            this.Controls.Add(this.lblColorNum);
            this.Controls.Add(this.chkbxLogo);
            this.Controls.Add(this.txtbxEngravement);
            this.Controls.Add(this.lblEngrave);
            this.Controls.Add(this.grpbxItemType);
            this.Controls.Add(this.txtbxNumItems);
            this.Controls.Add(this.txtbxOrderNum);
            this.Controls.Add(this.lblItemNum);
            this.Controls.Add(this.lblOrderNum);
            this.Name = "txtbxEngrave";
            this.Text = "Logo Items Order Page";
            this.grpbxItemType.ResumeLayout(false);
            this.grpbxItemType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.Label lblItemNum;
        private System.Windows.Forms.TextBox txtbxOrderNum;
        private System.Windows.Forms.TextBox txtbxNumItems;
        private System.Windows.Forms.GroupBox grpbxItemType;
        private System.Windows.Forms.Label lblEngrave;
        private System.Windows.Forms.TextBox txtbxEngravement;
        private System.Windows.Forms.CheckBox chkbxLogo;
        private System.Windows.Forms.Label lblColorNum;
        private System.Windows.Forms.TextBox txtbxNumColors;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtbxResult;
        private System.Windows.Forms.RadioButton rdbtnPen;
        private System.Windows.Forms.RadioButton rdbtnMug;
        private System.Windows.Forms.RadioButton rdbtnUsb;
    }
}

