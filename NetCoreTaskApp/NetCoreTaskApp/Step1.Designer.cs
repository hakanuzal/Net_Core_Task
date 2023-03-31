
namespace NetCoreTaskApp
{
    partial class Step1
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
            this.StepA1 = new System.Windows.Forms.TextBox();
            this.StepA2 = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StepA1
            // 
            this.StepA1.Location = new System.Drawing.Point(51, 35);
            this.StepA1.Name = "StepA1";
            this.StepA1.Size = new System.Drawing.Size(100, 20);
            this.StepA1.TabIndex = 0;
            // 
            // StepA2
            // 
            this.StepA2.Location = new System.Drawing.Point(214, 35);
            this.StepA2.Name = "StepA2";
            this.StepA2.Size = new System.Drawing.Size(100, 20);
            this.StepA2.TabIndex = 1;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(145, 74);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 2;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(173, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "C1";
            // 
            // Step1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 156);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.StepA2);
            this.Controls.Add(this.StepA1);
            this.Name = "Step1";
            this.Text = "Step1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StepA1;
        private System.Windows.Forms.TextBox StepA2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label label1;
    }
}