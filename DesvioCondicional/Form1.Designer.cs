namespace DesvioCondicional
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iFELSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iFELSEIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iFToolStripMenuItem,
            this.iFELSEToolStripMenuItem,
            this.iFELSEIFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // iFToolStripMenuItem
            // 
            this.iFToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iFToolStripMenuItem.Image = global::DesvioCondicional.Properties.Resources.FESTA_NA_J_A__3_;
            this.iFToolStripMenuItem.Name = "iFToolStripMenuItem";
            this.iFToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.iFToolStripMenuItem.Text = "CODIGO";
            this.iFToolStripMenuItem.Click += new System.EventHandler(this.iFToolStripMenuItem_Click);
            // 
            // iFELSEToolStripMenuItem
            // 
            this.iFELSEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iFELSEToolStripMenuItem.Image = global::DesvioCondicional.Properties.Resources.FESTA_NA_J_A__3_;
            this.iFELSEToolStripMenuItem.Name = "iFELSEToolStripMenuItem";
            this.iFELSEToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.iFELSEToolStripMenuItem.Text = "IDADE";
            this.iFELSEToolStripMenuItem.Click += new System.EventHandler(this.iFELSEToolStripMenuItem_Click);
            // 
            // iFELSEIFToolStripMenuItem
            // 
            this.iFELSEIFToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iFELSEIFToolStripMenuItem.Image = global::DesvioCondicional.Properties.Resources.FESTA_NA_J_A__3_;
            this.iFELSEIFToolStripMenuItem.Name = "iFELSEIFToolStripMenuItem";
            this.iFELSEIFToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.iFELSEIFToolStripMenuItem.Text = "ENTRADA";
            this.iFELSEIFToolStripMenuItem.Click += new System.EventHandler(this.iFELSEIFToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(676, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesvioCondicional.Properties.Resources.FESTA_NA_J4;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iFELSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iFELSEIFToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}

