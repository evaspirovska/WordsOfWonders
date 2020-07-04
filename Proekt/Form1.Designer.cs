namespace Proekt
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
            this.components = new System.ComponentModel.Container();
            this.checkFood = new System.Windows.Forms.CheckBox();
            this.checkPeople = new System.Windows.Forms.CheckBox();
            this.checkOther = new System.Windows.Forms.CheckBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkFood
            // 
            this.checkFood.AutoSize = true;
            this.checkFood.BackColor = System.Drawing.Color.Transparent;
            this.checkFood.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkFood.Location = new System.Drawing.Point(168, 98);
            this.checkFood.Name = "checkFood";
            this.checkFood.Size = new System.Drawing.Size(60, 17);
            this.checkFood.TabIndex = 1;
            this.checkFood.Text = "FOOD";
            this.checkFood.UseVisualStyleBackColor = false;
            this.checkFood.CheckedChanged += new System.EventHandler(this.checkFood_CheckedChanged);
            // 
            // checkPeople
            // 
            this.checkPeople.AutoSize = true;
            this.checkPeople.BackColor = System.Drawing.Color.Transparent;
            this.checkPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPeople.Location = new System.Drawing.Point(168, 134);
            this.checkPeople.Name = "checkPeople";
            this.checkPeople.Size = new System.Drawing.Size(129, 17);
            this.checkPeople.TabIndex = 2;
            this.checkPeople.Text = "FAMOUS PEOPLE";
            this.checkPeople.UseVisualStyleBackColor = false;
            this.checkPeople.CheckedChanged += new System.EventHandler(this.checkPeople_CheckedChanged);
            // 
            // checkOther
            // 
            this.checkOther.AutoSize = true;
            this.checkOther.BackColor = System.Drawing.Color.Transparent;
            this.checkOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOther.Location = new System.Drawing.Point(168, 169);
            this.checkOther.Name = "checkOther";
            this.checkOther.Size = new System.Drawing.Size(69, 17);
            this.checkOther.TabIndex = 3;
            this.checkOther.Text = "OTHER";
            this.checkOther.UseVisualStyleBackColor = false;
            this.checkOther.CheckedChanged += new System.EventHandler(this.checkOther_CheckedChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::Proekt.Properties.Resources.button_img;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(143, 216);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(154, 53);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Proekt.Properties.Resources.button_img;
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHOOSE A CATEGORY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::Proekt.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(443, 308);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.checkOther);
            this.Controls.Add(this.checkPeople);
            this.Controls.Add(this.checkFood);
            this.Name = "Form1";
            this.Text = "Start Menu";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkFood;
        private System.Windows.Forms.CheckBox checkPeople;
        private System.Windows.Forms.CheckBox checkOther;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
    }
}

