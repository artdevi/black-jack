namespace Black_Jack
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_play = new System.Windows.Forms.Button();
            this.button_pass = new System.Windows.Forms.Button();
            this.button_get = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_dealer = new System.Windows.Forms.PictureBox();
            this.pictureBox_player = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dealer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).BeginInit();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(9, 305);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(116, 37);
            this.button_play.TabIndex = 0;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // button_pass
            // 
            this.button_pass.Location = new System.Drawing.Point(9, 387);
            this.button_pass.Name = "button_pass";
            this.button_pass.Size = new System.Drawing.Size(116, 34);
            this.button_pass.TabIndex = 0;
            this.button_pass.Text = "Done";
            this.button_pass.UseVisualStyleBackColor = true;
            this.button_pass.Click += new System.EventHandler(this.button_pass_Click);
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(9, 348);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(116, 33);
            this.button_get.TabIndex = 0;
            this.button_get.Text = "Get";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox_player);
            this.panel1.Controls.Add(this.pictureBox_dealer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(134, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 426);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(567, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(72, 97);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox_dealer
            // 
            this.pictureBox_dealer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_dealer.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_dealer.Name = "pictureBox_dealer";
            this.pictureBox_dealer.Size = new System.Drawing.Size(648, 130);
            this.pictureBox_dealer.TabIndex = 1;
            this.pictureBox_dealer.TabStop = false;
            this.pictureBox_dealer.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_dealer_Paint);
            // 
            // pictureBox_player
            // 
            this.pictureBox_player.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_player.Location = new System.Drawing.Point(3, 293);
            this.pictureBox_player.Name = "pictureBox_player";
            this.pictureBox_player.Size = new System.Drawing.Size(648, 130);
            this.pictureBox_player.TabIndex = 1;
            this.pictureBox_player.TabStop = false;
            this.pictureBox_player.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_player_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.button_pass);
            this.Controls.Add(this.button_play);
            this.Name = "Form1";
            this.Text = "Black Jack";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dealer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_pass;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox_player;
        private System.Windows.Forms.PictureBox pictureBox_dealer;
    }
}

