namespace DataEntry
{
    partial class frmDataEntry
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblSname = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnChangeMessage = new System.Windows.Forms.Button();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.BackColor = System.Drawing.Color.Yellow;
            this.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMain.Font = new System.Drawing.Font("Arial", 24F);
            this.lblMain.Location = new System.Drawing.Point(50, 10);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(432, 47);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "User Details Data Entry";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Arial", 14F);
            this.lblFname.Location = new System.Drawing.Point(50, 70);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(136, 27);
            this.lblFname.TabIndex = 1;
            this.lblFname.Text = "First Name:";
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.Font = new System.Drawing.Font("Arial", 14F);
            this.lblSname.Location = new System.Drawing.Point(50, 110);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(117, 27);
            this.lblSname.TabIndex = 2;
            this.lblSname.Text = "Surname:";
            this.lblSname.Click += new System.EventHandler(this.lblSname_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Yellow;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 14F);
            this.lblMessage.Location = new System.Drawing.Point(200, 200);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(2, 29);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.White;
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname.Font = new System.Drawing.Font("Arial", 14F);
            this.txtFname.Location = new System.Drawing.Point(200, 70);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(215, 34);
            this.txtFname.TabIndex = 4;
            // 
            // txtSname
            // 
            this.txtSname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSname.Font = new System.Drawing.Font("Arial", 14F);
            this.txtSname.Location = new System.Drawing.Point(200, 110);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(215, 34);
            this.txtSname.TabIndex = 5;
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(50, 300);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(91, 31);
            this.btnMessage.TabIndex = 6;
            this.btnMessage.Text = "&Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(220, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 31);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear Message";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(430, 280);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 31);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(35, 265);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(117, 31);
            this.btnUpper.TabIndex = 9;
            this.btnUpper.Text = "&Upper Case";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(35, 230);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(117, 31);
            this.btnLower.TabIndex = 10;
            this.btnLower.Text = "&Lower Case";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnChangeMessage
            // 
            this.btnChangeMessage.Location = new System.Drawing.Point(200, 310);
            this.btnChangeMessage.Name = "btnChangeMessage";
            this.btnChangeMessage.Size = new System.Drawing.Size(149, 31);
            this.btnChangeMessage.TabIndex = 11;
            this.btnChangeMessage.Text = "Change Message";
            this.btnChangeMessage.UseVisualStyleBackColor = true;
            this.btnChangeMessage.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Font = new System.Drawing.Font("Arial", 14F);
            this.lblTown.Location = new System.Drawing.Point(50, 150);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(74, 27);
            this.lblTown.TabIndex = 12;
            this.lblTown.Text = "Town:";
            // 
            // txtTown
            // 
            this.txtTown.Font = new System.Drawing.Font("Arial", 14F);
            this.txtTown.Location = new System.Drawing.Point(200, 150);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(149, 34);
            this.txtTown.TabIndex = 13;
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(562, 353);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.btnChangeMessage);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMessage);
            this.Controls.Add(this.txtSname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblSname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry Form";
            this.Load += new System.EventHandler(this.frmDataEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnChangeMessage;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtTown;
    }
}

