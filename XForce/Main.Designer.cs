namespace XForce
{
    partial class XForce
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XForce));
            this.panelTop = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.activationBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.requestBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.patchButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.AccessibleName = "panelTop";
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.textBox3);
            this.panelTop.Controls.Add(this.activationBox);
            this.panelTop.Controls.Add(this.textBox2);
            this.panelTop.Controls.Add(this.requestBox);
            this.panelTop.Controls.Add(this.closeButton);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(550, 272);
            this.panelTop.TabIndex = 0;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("SF Compact Text", 8.25F);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(42, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(60, 14);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Activation:";
            // 
            // activationBox
            // 
            this.activationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.activationBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.activationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.activationBox.Font = new System.Drawing.Font("SF Compact Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activationBox.ForeColor = System.Drawing.Color.White;
            this.activationBox.Location = new System.Drawing.Point(101, 190);
            this.activationBox.MaxLength = 60;
            this.activationBox.Name = "activationBox";
            this.activationBox.Size = new System.Drawing.Size(402, 14);
            this.activationBox.TabIndex = 3;
            this.activationBox.Text = "And press Generate";
            this.activationBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.activationBox.TextChanged += new System.EventHandler(this.activationBox_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("SF Compact Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(42, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(60, 14);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Request:";
            // 
            // requestBox
            // 
            this.requestBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.requestBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.requestBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestBox.Font = new System.Drawing.Font("SF Compact Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestBox.ForeColor = System.Drawing.Color.White;
            this.requestBox.Location = new System.Drawing.Point(101, 165);
            this.requestBox.MaxLength = 60;
            this.requestBox.Name = "requestBox";
            this.requestBox.Size = new System.Drawing.Size(402, 14);
            this.requestBox.TabIndex = 1;
            this.requestBox.Text = "Paste Request here";
            this.requestBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.requestBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::XForce.Properties.Resources._111;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::XForce.Properties.Resources._111;
            this.closeButton.Location = new System.Drawing.Point(528, 6);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 16);
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.mouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.mouseLeave);
            // 
            // fadeTimer
            // 
            this.fadeTimer.Interval = 25;
            this.fadeTimer.Tick += new System.EventHandler(this.fadeTimer_Tick);
            // 
            // patchButton
            // 
            this.patchButton.BackColor = System.Drawing.Color.Black;
            this.patchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.patchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.patchButton.FlatAppearance.BorderSize = 0;
            this.patchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.patchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.patchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patchButton.ForeColor = System.Drawing.Color.Black;
            this.patchButton.Image = global::XForce.Properties.Resources._113;
            this.patchButton.Location = new System.Drawing.Point(58, 222);
            this.patchButton.Name = "patchButton";
            this.patchButton.Size = new System.Drawing.Size(113, 24);
            this.patchButton.TabIndex = 1;
            this.patchButton.UseVisualStyleBackColor = false;
            this.patchButton.Click += new System.EventHandler(this.patchButton_Click);
            this.patchButton.MouseEnter += new System.EventHandler(this.patchButton_MouseEnter);
            this.patchButton.MouseLeave += new System.EventHandler(this.patchButton_MouseLeave);
            // 
            // generateButton
            // 
            this.generateButton.BackColor = System.Drawing.Color.Black;
            this.generateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.generateButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.generateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Image = global::XForce.Properties.Resources._107;
            this.generateButton.Location = new System.Drawing.Point(223, 222);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(113, 24);
            this.generateButton.TabIndex = 2;
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            this.generateButton.MouseEnter += new System.EventHandler(this.generateButton_MouseEnter);
            this.generateButton.MouseLeave += new System.EventHandler(this.generateButton_MouseLeave);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Black;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.quitButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Image = global::XForce.Properties.Resources._105;
            this.quitButton.Location = new System.Drawing.Point(390, 222);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(113, 24);
            this.quitButton.TabIndex = 3;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.MouseEnter += new System.EventHandler(this.quitButton_MouseEnter);
            this.quitButton.MouseLeave += new System.EventHandler(this.quitButton_MouseLeave);
            // 
            // XForce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::XForce.Properties.Resources._102;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(550, 304);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.patchButton);
            this.Controls.Add(this.panelTop);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XForce";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XForce";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button closeButton;
        private object timer2;
        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.Button patchButton;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.TextBox requestBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox activationBox;
        private System.Windows.Forms.TextBox textBox2;
    }
}

