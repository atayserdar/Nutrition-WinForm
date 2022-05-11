namespace Nutrition.UI
{
    partial class DailyRoutine
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbHighActivity = new System.Windows.Forms.CheckBox();
            this.cbNormal = new System.Windows.Forms.CheckBox();
            this.cbLowActivity = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Günlük Hareket Durumunuzu Seçiniz.";
            // 
            // cbHighActivity
            // 
            this.cbHighActivity.AutoSize = true;
            this.cbHighActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbHighActivity.Location = new System.Drawing.Point(16, 194);
            this.cbHighActivity.Name = "cbHighActivity";
            this.cbHighActivity.Size = new System.Drawing.Size(140, 28);
            this.cbHighActivity.TabIndex = 6;
            this.cbHighActivity.Text = "Çok Hareketli";
            this.cbHighActivity.UseVisualStyleBackColor = true;
            // 
            // cbNormal
            // 
            this.cbNormal.AutoSize = true;
            this.cbNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbNormal.Location = new System.Drawing.Point(16, 132);
            this.cbNormal.Name = "cbNormal";
            this.cbNormal.Size = new System.Drawing.Size(90, 28);
            this.cbNormal.TabIndex = 5;
            this.cbNormal.Text = "Normal";
            this.cbNormal.UseVisualStyleBackColor = true;
            // 
            // cbLowActivity
            // 
            this.cbLowActivity.AutoSize = true;
            this.cbLowActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbLowActivity.Location = new System.Drawing.Point(16, 70);
            this.cbLowActivity.Name = "cbLowActivity";
            this.cbLowActivity.Size = new System.Drawing.Size(129, 28);
            this.cbLowActivity.TabIndex = 4;
            this.cbLowActivity.Text = "Az Hareketli";
            this.cbLowActivity.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Location = new System.Drawing.Point(263, 359);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 28);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Sonraki";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // DailyRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 399);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbHighActivity);
            this.Controls.Add(this.cbNormal);
            this.Controls.Add(this.cbLowActivity);
            this.Controls.Add(this.label1);
            this.Name = "DailyRoutine";
            this.Text = "DailyRoutine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbHighActivity;
        private System.Windows.Forms.CheckBox cbNormal;
        private System.Windows.Forms.CheckBox cbLowActivity;
        private System.Windows.Forms.Button btnNext;
    }
}