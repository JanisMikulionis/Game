namespace FinalGame2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.start = new System.Windows.Forms.Button();
            this.score = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.start.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.start.ForeColor = System.Drawing.Color.Green;
            this.start.Location = new System.Drawing.Point(77, 218);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(206, 50);
            this.start.TabIndex = 1;
            this.start.Text = "RACE";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.SystemColors.ControlText;
            this.score.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.score.ForeColor = System.Drawing.Color.Green;
            this.score.Location = new System.Drawing.Point(77, 330);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(206, 50);
            this.score.TabIndex = 1;
            this.score.Text = "HIGH SCORES";
            this.score.UseVisualStyleBackColor = false;
            this.score.Click += new System.EventHandler(this.score_Click);
            // 
            // rules
            // 
            this.rules.BackColor = System.Drawing.SystemColors.ControlText;
            this.rules.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rules.ForeColor = System.Drawing.Color.Green;
            this.rules.Location = new System.Drawing.Point(77, 274);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(206, 50);
            this.rules.TabIndex = 1;
            this.rules.Text = "RULES";
            this.rules.UseVisualStyleBackColor = false;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 421);
            this.Controls.Add(this.score);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "City scrambler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button score;
        private System.Windows.Forms.Button rules;
    }
}