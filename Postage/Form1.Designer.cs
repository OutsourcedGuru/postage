namespace Postage
{
    partial class FormPostage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPostage));
            this.labelPounds = new System.Windows.Forms.Label();
            this.labelOunces = new System.Windows.Forms.Label();
            this.textBoxPounds = new System.Windows.Forms.TextBox();
            this.textBoxOunces = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxTareHint = new System.Windows.Forms.TextBox();
            this.labelPostage = new System.Windows.Forms.Label();
            this.textBoxPostage = new System.Windows.Forms.TextBox();
            this.labelNumStamps = new System.Windows.Forms.Label();
            this.textBoxNum49Stamps = new System.Windows.Forms.TextBox();
            this.labelNum21Stamps = new System.Windows.Forms.Label();
            this.textBoxNum21Stamps = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelPounds
            // 
            this.labelPounds.AutoSize = true;
            this.labelPounds.Location = new System.Drawing.Point(73, 38);
            this.labelPounds.Name = "labelPounds";
            this.labelPounds.Size = new System.Drawing.Size(23, 13);
            this.labelPounds.TabIndex = 1;
            this.labelPounds.Text = "lbs.";
            // 
            // labelOunces
            // 
            this.labelOunces.AutoSize = true;
            this.labelOunces.Location = new System.Drawing.Point(216, 37);
            this.labelOunces.Name = "labelOunces";
            this.labelOunces.Size = new System.Drawing.Size(21, 13);
            this.labelOunces.TabIndex = 2;
            this.labelOunces.Text = "oz.";
            // 
            // textBoxPounds
            // 
            this.textBoxPounds.Location = new System.Drawing.Point(102, 34);
            this.textBoxPounds.Name = "textBoxPounds";
            this.textBoxPounds.Size = new System.Drawing.Size(100, 20);
            this.textBoxPounds.TabIndex = 3;
            // 
            // textBoxOunces
            // 
            this.textBoxOunces.Location = new System.Drawing.Point(243, 34);
            this.textBoxOunces.Name = "textBoxOunces";
            this.textBoxOunces.Size = new System.Drawing.Size(100, 20);
            this.textBoxOunces.TabIndex = 4;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(60, 11);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(136, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status:  Looking for scale...";
            // 
            // textBoxTareHint
            // 
            this.textBoxTareHint.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTareHint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTareHint.Location = new System.Drawing.Point(26, 147);
            this.textBoxTareHint.Multiline = true;
            this.textBoxTareHint.Name = "textBoxTareHint";
            this.textBoxTareHint.Size = new System.Drawing.Size(378, 109);
            this.textBoxTareHint.TabIndex = 6;
            this.textBoxTareHint.Text = resources.GetString("textBoxTareHint.Text");
            // 
            // labelPostage
            // 
            this.labelPostage.AutoSize = true;
            this.labelPostage.Location = new System.Drawing.Point(35, 67);
            this.labelPostage.Name = "labelPostage";
            this.labelPostage.Size = new System.Drawing.Size(61, 13);
            this.labelPostage.TabIndex = 7;
            this.labelPostage.Text = "Postage ($)";
            // 
            // textBoxPostage
            // 
            this.textBoxPostage.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPostage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPostage.Location = new System.Drawing.Point(102, 67);
            this.textBoxPostage.Name = "textBoxPostage";
            this.textBoxPostage.Size = new System.Drawing.Size(241, 13);
            this.textBoxPostage.TabIndex = 8;
            // 
            // labelNumStamps
            // 
            this.labelNumStamps.AutoSize = true;
            this.labelNumStamps.Location = new System.Drawing.Point(13, 91);
            this.labelNumStamps.Name = "labelNumStamps";
            this.labelNumStamps.Size = new System.Drawing.Size(83, 13);
            this.labelNumStamps.TabIndex = 9;
            this.labelNumStamps.Text = "# of 49¢ stamps";
            // 
            // textBoxNum49Stamps
            // 
            this.textBoxNum49Stamps.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNum49Stamps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNum49Stamps.Location = new System.Drawing.Point(102, 91);
            this.textBoxNum49Stamps.Name = "textBoxNum49Stamps";
            this.textBoxNum49Stamps.Size = new System.Drawing.Size(53, 13);
            this.textBoxNum49Stamps.TabIndex = 10;
            // 
            // labelNum21Stamps
            // 
            this.labelNum21Stamps.AutoSize = true;
            this.labelNum21Stamps.Location = new System.Drawing.Point(13, 116);
            this.labelNum21Stamps.Name = "labelNum21Stamps";
            this.labelNum21Stamps.Size = new System.Drawing.Size(83, 13);
            this.labelNum21Stamps.TabIndex = 11;
            this.labelNum21Stamps.Text = "# of 21¢ stamps";
            // 
            // textBoxNum21Stamps
            // 
            this.textBoxNum21Stamps.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNum21Stamps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNum21Stamps.Location = new System.Drawing.Point(102, 116);
            this.textBoxNum21Stamps.Name = "textBoxNum21Stamps";
            this.textBoxNum21Stamps.Size = new System.Drawing.Size(53, 13);
            this.textBoxNum21Stamps.TabIndex = 12;
            // 
            // FormPostage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(428, 263);
            this.Controls.Add(this.textBoxNum21Stamps);
            this.Controls.Add(this.labelNum21Stamps);
            this.Controls.Add(this.textBoxNum49Stamps);
            this.Controls.Add(this.labelNumStamps);
            this.Controls.Add(this.textBoxPostage);
            this.Controls.Add(this.labelPostage);
            this.Controls.Add(this.textBoxTareHint);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.textBoxOunces);
            this.Controls.Add(this.textBoxPounds);
            this.Controls.Add(this.labelOunces);
            this.Controls.Add(this.labelPounds);
            this.Name = "FormPostage";
            this.Text = "Postage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPounds;
        private System.Windows.Forms.Label labelOunces;
        private System.Windows.Forms.TextBox textBoxPounds;
        private System.Windows.Forms.TextBox textBoxOunces;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxTareHint;
        private System.Windows.Forms.Label labelPostage;
        private System.Windows.Forms.TextBox textBoxPostage;
        private System.Windows.Forms.Label labelNumStamps;
        private System.Windows.Forms.TextBox textBoxNum49Stamps;
        private System.Windows.Forms.Label labelNum21Stamps;
        private System.Windows.Forms.TextBox textBoxNum21Stamps;
    }
}

