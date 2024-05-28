namespace Quiz
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.Ans5 = new System.Windows.Forms.RadioButton();
            this.Ans4 = new System.Windows.Forms.RadioButton();
            this.Ans3 = new System.Windows.Forms.RadioButton();
            this.Ans2 = new System.Windows.Forms.RadioButton();
            this.Ans1 = new System.Windows.Forms.RadioButton();
            this.cbNext = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Controls.Add(this.Ans5);
            this.groupBox1.Controls.Add(this.Ans4);
            this.groupBox1.Controls.Add(this.Ans3);
            this.groupBox1.Controls.Add(this.Ans2);
            this.groupBox1.Controls.Add(this.Ans1);
            this.groupBox1.Location = new System.Drawing.Point(36, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQuestion.Location = new System.Drawing.Point(35, 16);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(57, 20);
            this.lblQuestion.TabIndex = 5;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // Ans5
            // 
            this.Ans5.AutoSize = true;
            this.Ans5.Location = new System.Drawing.Point(28, 250);
            this.Ans5.Name = "Ans5";
            this.Ans5.Size = new System.Drawing.Size(85, 17);
            this.Ans5.TabIndex = 4;
            this.Ans5.TabStop = true;
            this.Ans5.Text = "radioButton1";
            this.Ans5.UseVisualStyleBackColor = true;
            // 
            // Ans4
            // 
            this.Ans4.AutoSize = true;
            this.Ans4.Location = new System.Drawing.Point(28, 206);
            this.Ans4.Name = "Ans4";
            this.Ans4.Size = new System.Drawing.Size(85, 17);
            this.Ans4.TabIndex = 3;
            this.Ans4.TabStop = true;
            this.Ans4.Text = "radioButton1";
            this.Ans4.UseVisualStyleBackColor = true;
            // 
            // Ans3
            // 
            this.Ans3.AutoSize = true;
            this.Ans3.Location = new System.Drawing.Point(28, 162);
            this.Ans3.Name = "Ans3";
            this.Ans3.Size = new System.Drawing.Size(85, 17);
            this.Ans3.TabIndex = 2;
            this.Ans3.TabStop = true;
            this.Ans3.Text = "radioButton1";
            this.Ans3.UseVisualStyleBackColor = true;
            // 
            // Ans2
            // 
            this.Ans2.AutoSize = true;
            this.Ans2.Location = new System.Drawing.Point(28, 118);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(85, 17);
            this.Ans2.TabIndex = 1;
            this.Ans2.TabStop = true;
            this.Ans2.Text = "radioButton1";
            this.Ans2.UseVisualStyleBackColor = true;
            this.Ans2.CheckedChanged += new System.EventHandler(this.Ans2_CheckedChanged);
            // 
            // Ans1
            // 
            this.Ans1.AutoSize = true;
            this.Ans1.Location = new System.Drawing.Point(28, 74);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(85, 17);
            this.Ans1.TabIndex = 0;
            this.Ans1.Text = "radioButton1";
            this.Ans1.UseVisualStyleBackColor = true;
            this.Ans1.CheckedChanged += new System.EventHandler(this.Ans1_CheckedChanged);
            // 
            // cbNext
            // 
            this.cbNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cbNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNext.Location = new System.Drawing.Point(238, 389);
            this.cbNext.Name = "cbNext";
            this.cbNext.Size = new System.Drawing.Size(148, 32);
            this.cbNext.TabIndex = 2;
            this.cbNext.Text = "Next";
            this.cbNext.UseVisualStyleBackColor = false;
            this.cbNext.Click += new System.EventHandler(this.cbNext_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(547, 395);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(18, 20);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "0";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponse.Location = new System.Drawing.Point(427, 391);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(0, 25);
            this.lblResponse.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.cbNext);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton Ans5;
        private System.Windows.Forms.RadioButton Ans4;
        private System.Windows.Forms.RadioButton Ans3;
        private System.Windows.Forms.RadioButton Ans2;
        private System.Windows.Forms.RadioButton Ans1;
        private System.Windows.Forms.Button cbNext;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblResponse;
    }
}

