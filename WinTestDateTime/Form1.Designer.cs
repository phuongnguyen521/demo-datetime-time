
namespace WinTestDateTime
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
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnGet = new System.Windows.Forms.Button();
            this.dgv_DateTime = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.mtbShipping = new System.Windows.Forms.MaskedTextBox();
            this.btnShipping = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DateTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(33, 92);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(250, 27);
            this.dtpDateTime.TabIndex = 0;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(99, 154);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(94, 29);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Get Date";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // dgv_DateTime
            // 
            this.dgv_DateTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DateTime.Location = new System.Drawing.Point(344, 44);
            this.dgv_DateTime.Name = "dgv_DateTime";
            this.dgv_DateTime.RowHeadersWidth = 51;
            this.dgv_DateTime.RowTemplate.Height = 29;
            this.dgv_DateTime.Size = new System.Drawing.Size(427, 188);
            this.dgv_DateTime.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(509, 271);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // mtbShipping
            // 
            this.mtbShipping.Location = new System.Drawing.Point(33, 256);
            this.mtbShipping.Mask = "00/00/0000 90:00";
            this.mtbShipping.Name = "mtbShipping";
            this.mtbShipping.Size = new System.Drawing.Size(250, 27);
            this.mtbShipping.TabIndex = 4;
            this.mtbShipping.ValidatingType = typeof(System.DateTime);
            // 
            // btnShipping
            // 
            this.btnShipping.Location = new System.Drawing.Point(99, 309);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(94, 29);
            this.btnShipping.TabIndex = 5;
            this.btnShipping.Text = "Shipping";
            this.btnShipping.UseVisualStyleBackColor = true;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShipping);
            this.Controls.Add(this.mtbShipping);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dgv_DateTime);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.dtpDateTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DateTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.DataGridView dgv_DateTime;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.MaskedTextBox mtbShipping;
        private System.Windows.Forms.Button btnShipping;
    }
}

