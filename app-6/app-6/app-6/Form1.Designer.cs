namespace app_6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_TestNoneAsync = new System.Windows.Forms.Button();
            this.btn_TestAsync = new System.Windows.Forms.Button();
            this.btn_btnGetInfo = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btn_DoWorkAsync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_TestNoneAsync
            // 
            this.btn_TestNoneAsync.Location = new System.Drawing.Point(73, 42);
            this.btn_TestNoneAsync.Name = "btn_TestNoneAsync";
            this.btn_TestNoneAsync.Size = new System.Drawing.Size(140, 23);
            this.btn_TestNoneAsync.TabIndex = 0;
            this.btn_TestNoneAsync.Text = "TestNoneAsync";
            this.btn_TestNoneAsync.UseVisualStyleBackColor = true;
            this.btn_TestNoneAsync.Click += new System.EventHandler(this.btn_TestNoneAsync_Click);
            // 
            // btn_TestAsync
            // 
            this.btn_TestAsync.Location = new System.Drawing.Point(73, 82);
            this.btn_TestAsync.Name = "btn_TestAsync";
            this.btn_TestAsync.Size = new System.Drawing.Size(140, 23);
            this.btn_TestAsync.TabIndex = 1;
            this.btn_TestAsync.Text = "TestAsync";
            this.btn_TestAsync.UseVisualStyleBackColor = true;
            this.btn_TestAsync.Click += new System.EventHandler(this.btn_TestAsync_Click);
            // 
            // btn_btnGetInfo
            // 
            this.btn_btnGetInfo.Location = new System.Drawing.Point(73, 130);
            this.btn_btnGetInfo.Name = "btn_btnGetInfo";
            this.btn_btnGetInfo.Size = new System.Drawing.Size(140, 23);
            this.btn_btnGetInfo.TabIndex = 2;
            this.btn_btnGetInfo.Text = "btnGetInfo ";
            this.btn_btnGetInfo.UseVisualStyleBackColor = true;
            this.btn_btnGetInfo.Click += new System.EventHandler(this.btn_btnGetInfo_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(245, 130);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(280, 23);
            this.txtResults.TabIndex = 3;
            // 
            // btn_DoWorkAsync
            // 
            this.btn_DoWorkAsync.Location = new System.Drawing.Point(73, 185);
            this.btn_DoWorkAsync.Name = "btn_DoWorkAsync";
            this.btn_DoWorkAsync.Size = new System.Drawing.Size(140, 23);
            this.btn_DoWorkAsync.TabIndex = 4;
            this.btn_DoWorkAsync.Text = "DoWorkAsync";
            this.btn_DoWorkAsync.UseVisualStyleBackColor = true;
            this.btn_DoWorkAsync.Click += new System.EventHandler(this.btn_DoWorkAsync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_DoWorkAsync);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btn_btnGetInfo);
            this.Controls.Add(this.btn_TestAsync);
            this.Controls.Add(this.btn_TestNoneAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_TestNoneAsync;
        private Button btn_TestAsync;
        private Button btn_btnGetInfo;
        private TextBox txtResults;
        private Button btn_DoWorkAsync;
    }
}