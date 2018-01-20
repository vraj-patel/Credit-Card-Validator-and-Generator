namespace Credit_Card_Validation
{
    partial class Form1
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
            this.InputNumberTextbox = new System.Windows.Forms.TextBox();
            this.IsValidButton = new System.Windows.Forms.Button();
            this.IsCardValidTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GenerateNumberButton = new System.Windows.Forms.Button();
            this.OutputNumberTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VisaCard = new System.Windows.Forms.RadioButton();
            this.MasterCard = new System.Windows.Forms.RadioButton();
            this.AmericanExpress = new System.Windows.Forms.RadioButton();
            this.Discover = new System.Windows.Forms.RadioButton();
            this.DinerClub = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.BillGatesPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClickPic = new System.Windows.Forms.PictureBox();
            this.RobberPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillGatesPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobberPic)).BeginInit();
            this.SuspendLayout();
            // 
            // InputNumberTextbox
            // 
            this.InputNumberTextbox.Location = new System.Drawing.Point(42, 62);
            this.InputNumberTextbox.Name = "InputNumberTextbox";
            this.InputNumberTextbox.Size = new System.Drawing.Size(223, 20);
            this.InputNumberTextbox.TabIndex = 0;
            // 
            // IsValidButton
            // 
            this.IsValidButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsValidButton.Location = new System.Drawing.Point(99, 98);
            this.IsValidButton.Name = "IsValidButton";
            this.IsValidButton.Size = new System.Drawing.Size(99, 29);
            this.IsValidButton.TabIndex = 1;
            this.IsValidButton.Text = "Is It Valid?";
            this.IsValidButton.UseVisualStyleBackColor = true;
            this.IsValidButton.Click += new System.EventHandler(this.IsValidButton_Click);
            // 
            // IsCardValidTextbox
            // 
            this.IsCardValidTextbox.Location = new System.Drawing.Point(124, 214);
            this.IsCardValidTextbox.Name = "IsCardValidTextbox";
            this.IsCardValidTextbox.ReadOnly = true;
            this.IsCardValidTextbox.Size = new System.Drawing.Size(132, 20);
            this.IsCardValidTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Your Credit Card Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type of Card:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose Your Card Type:";
            // 
            // GenerateNumberButton
            // 
            this.GenerateNumberButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateNumberButton.Location = new System.Drawing.Point(436, 149);
            this.GenerateNumberButton.Name = "GenerateNumberButton";
            this.GenerateNumberButton.Size = new System.Drawing.Size(102, 38);
            this.GenerateNumberButton.TabIndex = 10;
            this.GenerateNumberButton.Text = "Generate Number";
            this.GenerateNumberButton.UseVisualStyleBackColor = true;
            this.GenerateNumberButton.Click += new System.EventHandler(this.GenerateNumberButton_Click);
            // 
            // OutputNumberTextbox
            // 
            this.OutputNumberTextbox.Location = new System.Drawing.Point(399, 293);
            this.OutputNumberTextbox.Name = "OutputNumberTextbox";
            this.OutputNumberTextbox.ReadOnly = true;
            this.OutputNumberTextbox.Size = new System.Drawing.Size(188, 20);
            this.OutputNumberTextbox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(454, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Card Number:";
            // 
            // VisaCard
            // 
            this.VisaCard.AutoSize = true;
            this.VisaCard.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VisaCard.Location = new System.Drawing.Point(372, 65);
            this.VisaCard.Name = "VisaCard";
            this.VisaCard.Size = new System.Drawing.Size(85, 22);
            this.VisaCard.TabIndex = 14;
            this.VisaCard.TabStop = true;
            this.VisaCard.Text = "Visa Card";
            this.VisaCard.UseVisualStyleBackColor = true;
            // 
            // MasterCard
            // 
            this.MasterCard.AutoSize = true;
            this.MasterCard.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterCard.Location = new System.Drawing.Point(372, 93);
            this.MasterCard.Name = "MasterCard";
            this.MasterCard.Size = new System.Drawing.Size(100, 22);
            this.MasterCard.TabIndex = 15;
            this.MasterCard.TabStop = true;
            this.MasterCard.Text = "Master Card";
            this.MasterCard.UseVisualStyleBackColor = true;
            // 
            // AmericanExpress
            // 
            this.AmericanExpress.AutoSize = true;
            this.AmericanExpress.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmericanExpress.Location = new System.Drawing.Point(475, 65);
            this.AmericanExpress.Name = "AmericanExpress";
            this.AmericanExpress.Size = new System.Drawing.Size(134, 22);
            this.AmericanExpress.TabIndex = 16;
            this.AmericanExpress.TabStop = true;
            this.AmericanExpress.Text = "American Express";
            this.AmericanExpress.UseVisualStyleBackColor = true;
            // 
            // Discover
            // 
            this.Discover.AutoSize = true;
            this.Discover.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discover.Location = new System.Drawing.Point(475, 93);
            this.Discover.Name = "Discover";
            this.Discover.Size = new System.Drawing.Size(80, 22);
            this.Discover.TabIndex = 17;
            this.Discover.TabStop = true;
            this.Discover.Text = "Discover";
            this.Discover.UseVisualStyleBackColor = true;
            // 
            // DinerClub
            // 
            this.DinerClub.AutoSize = true;
            this.DinerClub.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DinerClub.Location = new System.Drawing.Point(372, 121);
            this.DinerClub.Name = "DinerClub";
            this.DinerClub.Size = new System.Drawing.Size(99, 22);
            this.DinerClub.TabIndex = 18;
            this.DinerClub.TabStop = true;
            this.DinerClub.Text = "Diners Club";
            this.DinerClub.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "* Please turn on your sound when using this  program";
            // 
            // BillGatesPic
            // 
            this.BillGatesPic.Image = global::Credit_Card_Validation.Properties.Resources.Bill_Gates;
            this.BillGatesPic.Location = new System.Drawing.Point(69, 257);
            this.BillGatesPic.Name = "BillGatesPic";
            this.BillGatesPic.Size = new System.Drawing.Size(165, 123);
            this.BillGatesPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BillGatesPic.TabIndex = 20;
            this.BillGatesPic.TabStop = false;
            this.BillGatesPic.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Credit_Card_Validation.Properties.Resources.click_pic;
            this.pictureBox1.Location = new System.Drawing.Point(465, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ClickPic
            // 
            this.ClickPic.Image = global::Credit_Card_Validation.Properties.Resources.click_pic;
            this.ClickPic.Location = new System.Drawing.Point(124, 133);
            this.ClickPic.Name = "ClickPic";
            this.ClickPic.Size = new System.Drawing.Size(46, 54);
            this.ClickPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClickPic.TabIndex = 5;
            this.ClickPic.TabStop = false;
            // 
            // RobberPic
            // 
            this.RobberPic.Image = global::Credit_Card_Validation.Properties.Resources.robber;
            this.RobberPic.Location = new System.Drawing.Point(66, 240);
            this.RobberPic.Name = "RobberPic";
            this.RobberPic.Size = new System.Drawing.Size(168, 155);
            this.RobberPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RobberPic.TabIndex = 21;
            this.RobberPic.TabStop = false;
            this.RobberPic.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 407);
            this.Controls.Add(this.RobberPic);
            this.Controls.Add(this.BillGatesPic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DinerClub);
            this.Controls.Add(this.Discover);
            this.Controls.Add(this.AmericanExpress);
            this.Controls.Add(this.MasterCard);
            this.Controls.Add(this.VisaCard);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OutputNumberTextbox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GenerateNumberButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClickPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsCardValidTextbox);
            this.Controls.Add(this.IsValidButton);
            this.Controls.Add(this.InputNumberTextbox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "he";
            ((System.ComponentModel.ISupportInitialize)(this.BillGatesPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClickPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RobberPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNumberTextbox;
        private System.Windows.Forms.Button IsValidButton;
        private System.Windows.Forms.TextBox IsCardValidTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ClickPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GenerateNumberButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox OutputNumberTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton VisaCard;
        private System.Windows.Forms.RadioButton MasterCard;
        private System.Windows.Forms.RadioButton AmericanExpress;
        private System.Windows.Forms.RadioButton Discover;
        private System.Windows.Forms.RadioButton DinerClub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox BillGatesPic;
        private System.Windows.Forms.PictureBox RobberPic;
    }
}

