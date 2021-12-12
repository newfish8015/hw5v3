
namespace hw5v3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.vehical = new System.Windows.Forms.TabPage();
            this.service = new System.Windows.Forms.TabPage();
            this.driver = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.vehical);
            this.tabControl1.Controls.Add(this.service);
            this.tabControl1.Controls.Add(this.driver);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // vehical
            // 
            this.vehical.Location = new System.Drawing.Point(4, 22);
            this.vehical.Name = "vehical";
            this.vehical.Padding = new System.Windows.Forms.Padding(3);
            this.vehical.Size = new System.Drawing.Size(789, 423);
            this.vehical.TabIndex = 0;
            this.vehical.Text = "vehical";
            this.vehical.UseVisualStyleBackColor = true;
            // 
            // service
            // 
            this.service.Location = new System.Drawing.Point(4, 22);
            this.service.Name = "service";
            this.service.Padding = new System.Windows.Forms.Padding(3);
            this.service.Size = new System.Drawing.Size(789, 423);
            this.service.TabIndex = 1;
            this.service.Text = "service";
            this.service.UseVisualStyleBackColor = true;
            // 
            // driver
            // 
            this.driver.Location = new System.Drawing.Point(4, 22);
            this.driver.Name = "driver";
            this.driver.Padding = new System.Windows.Forms.Padding(3);
            this.driver.Size = new System.Drawing.Size(789, 423);
            this.driver.TabIndex = 2;
            this.driver.Text = "driver";
            this.driver.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage vehical;
        private System.Windows.Forms.TabPage service;
        private System.Windows.Forms.TabPage driver;
    }
}

