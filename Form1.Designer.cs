namespace MediaPlayer
{
    partial class MediaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaForm));
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.rixFm_Button = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Lime;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(326, 263);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(128, 45);
            this.Play.TabIndex = 2;
            this.Play.Text = "Star FM";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.buttonStarFM_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Yellow;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(326, 316);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(128, 45);
            this.Pause.TabIndex = 3;
            this.Pause.Text = "Pause";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Default;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(161, 316);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(128, 45);
            this.Stop.TabIndex = 4;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // rixFm_Button
            // 
            this.rixFm_Button.BackColor = System.Drawing.Color.Lime;
            this.rixFm_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rixFm_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rixFm_Button.Location = new System.Drawing.Point(478, 263);
            this.rixFm_Button.Name = "rixFm_Button";
            this.rixFm_Button.Size = new System.Drawing.Size(128, 45);
            this.rixFm_Button.TabIndex = 5;
            this.rixFm_Button.Text = "Rix FM";
            this.rixFm_Button.UseVisualStyleBackColor = false;
            this.rixFm_Button.Click += new System.EventHandler(this.buttonRixFm_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(0, 0);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(631, 257);
            this.Player.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Vrsac - Antena";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonAntenaRadio_Click);
            // 
            // MediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rixFm_Button);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Player);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 400);
            this.MinimumSize = new System.Drawing.Size(649, 399);
            this.Name = "MediaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player - codedByMadi.NET";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button rixFm_Button;
        private System.Windows.Forms.Button button1;
    }
}

