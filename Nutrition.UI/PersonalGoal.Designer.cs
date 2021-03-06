namespace Nutrition.UI
{
    partial class PersonalGoal
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
            this.cbLooseWeight = new System.Windows.Forms.CheckBox();
            this.cbGetWeight = new System.Windows.Forms.CheckBox();
            this.cbKeepForm = new System.Windows.Forms.CheckBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişisel hedefinizi belirleyiniz.";
            // 
            // cbLooseWeight
            // 
            this.cbLooseWeight.AutoSize = true;
            this.cbLooseWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbLooseWeight.Location = new System.Drawing.Point(16, 77);
            this.cbLooseWeight.Name = "cbLooseWeight";
            this.cbLooseWeight.Size = new System.Drawing.Size(131, 28);
            this.cbLooseWeight.TabIndex = 1;
            this.cbLooseWeight.Text = "Kilo Vermek";
            this.cbLooseWeight.UseVisualStyleBackColor = true;
            // 
            // cbGetWeight
            // 
            this.cbGetWeight.AutoSize = true;
            this.cbGetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGetWeight.Location = new System.Drawing.Point(16, 139);
            this.cbGetWeight.Name = "cbGetWeight";
            this.cbGetWeight.Size = new System.Drawing.Size(117, 28);
            this.cbGetWeight.TabIndex = 2;
            this.cbGetWeight.Text = "Kilo Almak";
            this.cbGetWeight.UseVisualStyleBackColor = true;
            // 
            // cbKeepForm
            // 
            this.cbKeepForm.AutoSize = true;
            this.cbKeepForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKeepForm.Location = new System.Drawing.Point(16, 201);
            this.cbKeepForm.Name = "cbKeepForm";
            this.cbKeepForm.Size = new System.Drawing.Size(192, 28);
            this.cbKeepForm.TabIndex = 3;
            this.cbKeepForm.Text = "Formumu Korumak";
            this.cbKeepForm.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(198, 322);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Sonraki";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // PersonalGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 357);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbKeepForm);
            this.Controls.Add(this.cbGetWeight);
            this.Controls.Add(this.cbLooseWeight);
            this.Controls.Add(this.label1);
            this.Name = "PersonalGoal";
            this.Text = "PersonalGoal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLooseWeight;
        private System.Windows.Forms.CheckBox cbGetWeight;
        private System.Windows.Forms.CheckBox cbKeepForm;
        private System.Windows.Forms.Button btnNext;
    }
}