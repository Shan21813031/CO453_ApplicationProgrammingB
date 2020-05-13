namespace Task1_Greetings
{
    partial class Welcome
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblBrag = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnShow1 = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.BackColor = System.Drawing.Color.Yellow;
            this.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreeting.Font = new System.Drawing.Font("Arial", 16F);
            this.lblGreeting.ForeColor = System.Drawing.Color.Blue;
            this.lblGreeting.Location = new System.Drawing.Point(100, 30);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(370, 40);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Welcome to SuperSoft";
            this.lblGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGreeting.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblBrag
            // 
            this.lblBrag.BackColor = System.Drawing.Color.Yellow;
            this.lblBrag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBrag.Font = new System.Drawing.Font("Arial", 16F);
            this.lblBrag.ForeColor = System.Drawing.Color.Blue;
            this.lblBrag.Location = new System.Drawing.Point(100, 90);
            this.lblBrag.Name = "lblBrag";
            this.lblBrag.Size = new System.Drawing.Size(310, 70);
            this.lblBrag.TabIndex = 1;
            this.lblBrag.Text = "The BEST Prices";
            this.lblBrag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(478, 220);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(71, 43);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnShow1
            // 
            this.btnShow1.Location = new System.Drawing.Point(36, 220);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(195, 43);
            this.btnShow1.TabIndex = 3;
            this.btnShow1.Text = "Best Computer";
            this.btnShow1.UseVisualStyleBackColor = true;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(253, 220);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(182, 43);
            this.btnShow2.TabIndex = 4;
            this.btnShow2.Text = "Best Software";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnShow1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblBrag);
            this.Controls.Add(this.lblGreeting);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Welcome";
            this.Text = "Shan\'s Welcome Form";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblBrag;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Button btnShow2;
    }
}

