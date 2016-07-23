namespace EVECharPriceCheck
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.inputSkillPoints = new System.Windows.Forms.NumericUpDown();
            this.lbSkillPoints = new System.Windows.Forms.Label();
            this.inputSkillInjectorMaxBuy = new System.Windows.Forms.NumericUpDown();
            this.picturePlex = new System.Windows.Forms.PictureBox();
            this.pictureSkillExtractor = new System.Windows.Forms.PictureBox();
            this.pictureSkillInjector = new System.Windows.Forms.PictureBox();
            this.inputSkillInjectorMinSell = new System.Windows.Forms.NumericUpDown();
            this.inputSkillExtractorMinSell = new System.Windows.Forms.NumericUpDown();
            this.inputPlexMinSell = new System.Windows.Forms.NumericUpDown();
            this.lbSkillInjMaxBuy = new System.Windows.Forms.Label();
            this.lbSkillInjMinSell = new System.Windows.Forms.Label();
            this.lbSkillExMinSell = new System.Windows.Forms.Label();
            this.lbPlexMinSell = new System.Windows.Forms.Label();
            this.buttonGetPrices = new System.Windows.Forms.Button();
            this.textSkillExtractorMinSellValue = new System.Windows.Forms.Label();
            this.textSkillInjectorMaxBuyValue = new System.Windows.Forms.Label();
            this.textSkillInjectorMinSellValue = new System.Windows.Forms.Label();
            this.textPlexMinSellValue = new System.Windows.Forms.Label();
            this.textSkillPointsValue = new System.Windows.Forms.Label();
            this.rtbShortDescription = new System.Windows.Forms.RichTextBox();
            this.rtbDetailedDescriprion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRegionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillInjectorMaxBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSkillExtractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSkillInjector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillInjectorMinSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillExtractorMinSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPlexMinSell)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(457, 225);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculate.TabIndex = 7;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // inputSkillPoints
            // 
            this.inputSkillPoints.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.inputSkillPoints.Location = new System.Drawing.Point(457, 28);
            this.inputSkillPoints.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.inputSkillPoints.Name = "inputSkillPoints";
            this.inputSkillPoints.Size = new System.Drawing.Size(120, 20);
            this.inputSkillPoints.TabIndex = 1;
            this.inputSkillPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputSkillPoints.ValueChanged += new System.EventHandler(this.tbSkillPoints_ValueChanged);
            // 
            // lbSkillPoints
            // 
            this.lbSkillPoints.AutoSize = true;
            this.lbSkillPoints.Location = new System.Drawing.Point(9, 30);
            this.lbSkillPoints.Name = "lbSkillPoints";
            this.lbSkillPoints.Size = new System.Drawing.Size(107, 13);
            this.lbSkillPoints.TabIndex = 3;
            this.lbSkillPoints.Text = "Character skill points:";
            // 
            // inputSkillInjectorMaxBuy
            // 
            this.inputSkillInjectorMaxBuy.DecimalPlaces = 2;
            this.inputSkillInjectorMaxBuy.Location = new System.Drawing.Point(457, 112);
            this.inputSkillInjectorMaxBuy.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputSkillInjectorMaxBuy.Name = "inputSkillInjectorMaxBuy";
            this.inputSkillInjectorMaxBuy.Size = new System.Drawing.Size(120, 20);
            this.inputSkillInjectorMaxBuy.TabIndex = 3;
            this.inputSkillInjectorMaxBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputSkillInjectorMaxBuy.ValueChanged += new System.EventHandler(this.tbSkillInjMaxBuy_ValueChanged);
            // 
            // picturePlex
            // 
            this.picturePlex.Image = global::EVECharPriceCheck.Properties.Resources.Plex;
            this.picturePlex.Location = new System.Drawing.Point(12, 170);
            this.picturePlex.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.picturePlex.Name = "picturePlex";
            this.picturePlex.Size = new System.Drawing.Size(46, 46);
            this.picturePlex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlex.TabIndex = 6;
            this.picturePlex.TabStop = false;
            // 
            // pictureSkillExtractor
            // 
            this.pictureSkillExtractor.Image = global::EVECharPriceCheck.Properties.Resources.SkillExtractor;
            this.pictureSkillExtractor.Location = new System.Drawing.Point(12, 54);
            this.pictureSkillExtractor.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureSkillExtractor.Name = "pictureSkillExtractor";
            this.pictureSkillExtractor.Size = new System.Drawing.Size(46, 46);
            this.pictureSkillExtractor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSkillExtractor.TabIndex = 5;
            this.pictureSkillExtractor.TabStop = false;
            // 
            // pictureSkillInjector
            // 
            this.pictureSkillInjector.Image = global::EVECharPriceCheck.Properties.Resources.SkillInjector;
            this.pictureSkillInjector.Location = new System.Drawing.Point(12, 112);
            this.pictureSkillInjector.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pictureSkillInjector.Name = "pictureSkillInjector";
            this.pictureSkillInjector.Size = new System.Drawing.Size(46, 46);
            this.pictureSkillInjector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSkillInjector.TabIndex = 4;
            this.pictureSkillInjector.TabStop = false;
            // 
            // inputSkillInjectorMinSell
            // 
            this.inputSkillInjectorMinSell.DecimalPlaces = 2;
            this.inputSkillInjectorMinSell.Location = new System.Drawing.Point(457, 138);
            this.inputSkillInjectorMinSell.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputSkillInjectorMinSell.Name = "inputSkillInjectorMinSell";
            this.inputSkillInjectorMinSell.Size = new System.Drawing.Size(120, 20);
            this.inputSkillInjectorMinSell.TabIndex = 4;
            this.inputSkillInjectorMinSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputSkillInjectorMinSell.ValueChanged += new System.EventHandler(this.tbSkillInjMinSell_ValueChanged);
            // 
            // inputSkillExtractorMinSell
            // 
            this.inputSkillExtractorMinSell.DecimalPlaces = 2;
            this.inputSkillExtractorMinSell.Location = new System.Drawing.Point(457, 67);
            this.inputSkillExtractorMinSell.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputSkillExtractorMinSell.Name = "inputSkillExtractorMinSell";
            this.inputSkillExtractorMinSell.Size = new System.Drawing.Size(120, 20);
            this.inputSkillExtractorMinSell.TabIndex = 2;
            this.inputSkillExtractorMinSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputSkillExtractorMinSell.ValueChanged += new System.EventHandler(this.tbSkillExMinSell_ValueChanged);
            // 
            // inputPlexMinSell
            // 
            this.inputPlexMinSell.DecimalPlaces = 2;
            this.inputPlexMinSell.Location = new System.Drawing.Point(457, 183);
            this.inputPlexMinSell.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputPlexMinSell.Name = "inputPlexMinSell";
            this.inputPlexMinSell.Size = new System.Drawing.Size(120, 20);
            this.inputPlexMinSell.TabIndex = 5;
            this.inputPlexMinSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.inputPlexMinSell.ValueChanged += new System.EventHandler(this.tbPlexMinSell_ValueChanged);
            // 
            // lbSkillInjMaxBuy
            // 
            this.lbSkillInjMaxBuy.AutoSize = true;
            this.lbSkillInjMaxBuy.Location = new System.Drawing.Point(64, 114);
            this.lbSkillInjMaxBuy.Name = "lbSkillInjMaxBuy";
            this.lbSkillInjMaxBuy.Size = new System.Drawing.Size(381, 13);
            this.lbSkillInjMaxBuy.TabIndex = 11;
            this.lbSkillInjMaxBuy.Text = "Skill Injector MaxBuy market price (the price at which you can sell Skill Injecto" +
    "r):";
            // 
            // lbSkillInjMinSell
            // 
            this.lbSkillInjMinSell.AutoSize = true;
            this.lbSkillInjMinSell.Location = new System.Drawing.Point(64, 140);
            this.lbSkillInjMinSell.Name = "lbSkillInjMinSell";
            this.lbSkillInjMinSell.Size = new System.Drawing.Size(379, 13);
            this.lbSkillInjMinSell.TabIndex = 12;
            this.lbSkillInjMinSell.Text = "Skill Injector MinSell market price (the price at which you can buy Skill Injecto" +
    "r):";
            // 
            // lbSkillExMinSell
            // 
            this.lbSkillExMinSell.AutoSize = true;
            this.lbSkillExMinSell.Location = new System.Drawing.Point(64, 69);
            this.lbSkillExMinSell.Name = "lbSkillExMinSell";
            this.lbSkillExMinSell.Size = new System.Drawing.Size(393, 13);
            this.lbSkillExMinSell.TabIndex = 13;
            this.lbSkillExMinSell.Text = "Skill Extractor MinSell market price (the price at which you can buy Skill Extrac" +
    "tor):";
            // 
            // lbPlexMinSell
            // 
            this.lbPlexMinSell.AutoSize = true;
            this.lbPlexMinSell.Location = new System.Drawing.Point(64, 185);
            this.lbPlexMinSell.Name = "lbPlexMinSell";
            this.lbPlexMinSell.Size = new System.Drawing.Size(319, 13);
            this.lbPlexMinSell.TabIndex = 14;
            this.lbPlexMinSell.Text = "PLEX MinSell market price (the price at which you can buy PLEX):";
            // 
            // buttonGetPrices
            // 
            this.buttonGetPrices.Location = new System.Drawing.Point(153, 225);
            this.buttonGetPrices.Name = "buttonGetPrices";
            this.buttonGetPrices.Size = new System.Drawing.Size(76, 23);
            this.buttonGetPrices.TabIndex = 6;
            this.buttonGetPrices.Text = "Get prices";
            this.buttonGetPrices.UseVisualStyleBackColor = true;
            this.buttonGetPrices.Click += new System.EventHandler(this.buttonGetPrices_Click);
            // 
            // textSkillExtractorMinSellValue
            // 
            this.textSkillExtractorMinSellValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.textSkillExtractorMinSellValue.Location = new System.Drawing.Point(583, 69);
            this.textSkillExtractorMinSellValue.Name = "textSkillExtractorMinSellValue";
            this.textSkillExtractorMinSellValue.Size = new System.Drawing.Size(56, 13);
            this.textSkillExtractorMinSellValue.TabIndex = 16;
            this.textSkillExtractorMinSellValue.Text = "0";
            // 
            // textSkillInjectorMaxBuyValue
            // 
            this.textSkillInjectorMaxBuyValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.textSkillInjectorMaxBuyValue.Location = new System.Drawing.Point(583, 114);
            this.textSkillInjectorMaxBuyValue.Name = "textSkillInjectorMaxBuyValue";
            this.textSkillInjectorMaxBuyValue.Size = new System.Drawing.Size(56, 13);
            this.textSkillInjectorMaxBuyValue.TabIndex = 17;
            this.textSkillInjectorMaxBuyValue.Text = "0";
            // 
            // textSkillInjectorMinSellValue
            // 
            this.textSkillInjectorMinSellValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.textSkillInjectorMinSellValue.Location = new System.Drawing.Point(583, 140);
            this.textSkillInjectorMinSellValue.Name = "textSkillInjectorMinSellValue";
            this.textSkillInjectorMinSellValue.Size = new System.Drawing.Size(56, 13);
            this.textSkillInjectorMinSellValue.TabIndex = 18;
            this.textSkillInjectorMinSellValue.Text = "0";
            // 
            // textPlexMinSellValue
            // 
            this.textPlexMinSellValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.textPlexMinSellValue.Location = new System.Drawing.Point(583, 185);
            this.textPlexMinSellValue.Name = "textPlexMinSellValue";
            this.textPlexMinSellValue.Size = new System.Drawing.Size(56, 13);
            this.textPlexMinSellValue.TabIndex = 19;
            this.textPlexMinSellValue.Text = "0";
            // 
            // textSkillPointsValue
            // 
            this.textSkillPointsValue.ForeColor = System.Drawing.Color.ForestGreen;
            this.textSkillPointsValue.Location = new System.Drawing.Point(583, 30);
            this.textSkillPointsValue.Name = "textSkillPointsValue";
            this.textSkillPointsValue.Size = new System.Drawing.Size(56, 13);
            this.textSkillPointsValue.TabIndex = 20;
            this.textSkillPointsValue.Text = "0";
            // 
            // rtbShortDescription
            // 
            this.rtbShortDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbShortDescription.Location = new System.Drawing.Point(12, 267);
            this.rtbShortDescription.Name = "rtbShortDescription";
            this.rtbShortDescription.ReadOnly = true;
            this.rtbShortDescription.ShortcutsEnabled = false;
            this.rtbShortDescription.Size = new System.Drawing.Size(627, 39);
            this.rtbShortDescription.TabIndex = 21;
            this.rtbShortDescription.TabStop = false;
            this.rtbShortDescription.Text = "";
            // 
            // rtbDetailedDescriprion
            // 
            this.rtbDetailedDescriprion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDetailedDescriprion.Location = new System.Drawing.Point(12, 325);
            this.rtbDetailedDescriprion.Name = "rtbDetailedDescriprion";
            this.rtbDetailedDescriprion.ReadOnly = true;
            this.rtbDetailedDescriprion.ShortcutsEnabled = false;
            this.rtbDetailedDescriprion.Size = new System.Drawing.Size(627, 168);
            this.rtbDetailedDescriprion.TabIndex = 22;
            this.rtbDetailedDescriprion.TabStop = false;
            this.rtbDetailedDescriprion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Short description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Detailed description:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // selectRegionBox
            // 
            this.selectRegionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRegionBox.FormattingEnabled = true;
            this.selectRegionBox.Location = new System.Drawing.Point(59, 227);
            this.selectRegionBox.Name = "selectRegionBox";
            this.selectRegionBox.Size = new System.Drawing.Size(88, 21);
            this.selectRegionBox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Region:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectRegionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDetailedDescriprion);
            this.Controls.Add(this.rtbShortDescription);
            this.Controls.Add(this.textSkillPointsValue);
            this.Controls.Add(this.textPlexMinSellValue);
            this.Controls.Add(this.textSkillInjectorMinSellValue);
            this.Controls.Add(this.textSkillInjectorMaxBuyValue);
            this.Controls.Add(this.textSkillExtractorMinSellValue);
            this.Controls.Add(this.buttonGetPrices);
            this.Controls.Add(this.lbPlexMinSell);
            this.Controls.Add(this.lbSkillExMinSell);
            this.Controls.Add(this.lbSkillInjMinSell);
            this.Controls.Add(this.lbSkillInjMaxBuy);
            this.Controls.Add(this.inputPlexMinSell);
            this.Controls.Add(this.inputSkillExtractorMinSell);
            this.Controls.Add(this.inputSkillInjectorMinSell);
            this.Controls.Add(this.inputSkillInjectorMaxBuy);
            this.Controls.Add(this.picturePlex);
            this.Controls.Add(this.pictureSkillExtractor);
            this.Controls.Add(this.pictureSkillInjector);
            this.Controls.Add(this.lbSkillPoints);
            this.Controls.Add(this.inputSkillPoints);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EVE Character price check";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillInjectorMaxBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSkillExtractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSkillInjector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillInjectorMinSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillExtractorMinSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPlexMinSell)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.NumericUpDown inputSkillPoints;
        private System.Windows.Forms.Label lbSkillPoints;
        private System.Windows.Forms.PictureBox pictureSkillInjector;
        private System.Windows.Forms.PictureBox pictureSkillExtractor;
        private System.Windows.Forms.PictureBox picturePlex;
        private System.Windows.Forms.NumericUpDown inputSkillInjectorMaxBuy;
        private System.Windows.Forms.NumericUpDown inputSkillInjectorMinSell;
        private System.Windows.Forms.NumericUpDown inputSkillExtractorMinSell;
        private System.Windows.Forms.NumericUpDown inputPlexMinSell;
        private System.Windows.Forms.Label lbSkillInjMaxBuy;
        private System.Windows.Forms.Label lbSkillInjMinSell;
        private System.Windows.Forms.Label lbSkillExMinSell;
        private System.Windows.Forms.Label lbPlexMinSell;
        private System.Windows.Forms.Button buttonGetPrices;
        private System.Windows.Forms.Label textSkillExtractorMinSellValue;
        private System.Windows.Forms.Label textSkillInjectorMaxBuyValue;
        private System.Windows.Forms.Label textSkillInjectorMinSellValue;
        private System.Windows.Forms.Label textPlexMinSellValue;
        private System.Windows.Forms.Label textSkillPointsValue;
        private System.Windows.Forms.RichTextBox rtbShortDescription;
        private System.Windows.Forms.RichTextBox rtbDetailedDescriprion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox selectRegionBox;
        private System.Windows.Forms.Label label3;
    }
}

