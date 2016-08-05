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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCalculate = new System.Windows.Forms.Button();
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
            this.rtbShortDescription = new System.Windows.Forms.RichTextBox();
            this.rtbDetailedDescriprion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.russianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRegionBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAPIKeyExpires = new System.Windows.Forms.Label();
            this.buttonFillFromEveboard = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputEveboardPass = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.inputEveboardUrl = new System.Windows.Forms.TextBox();
            this.textSkillPointsValue = new System.Windows.Forms.Label();
            this.inputSkillPoints = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillInjectorMaxBuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSkillExtractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSkillInjector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillInjectorMinSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillExtractorMinSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPlexMinSell)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            resources.ApplyResources(this.buttonCalculate, "buttonCalculate");
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // inputSkillInjectorMaxBuy
            // 
            this.inputSkillInjectorMaxBuy.DecimalPlaces = 2;
            resources.ApplyResources(this.inputSkillInjectorMaxBuy, "inputSkillInjectorMaxBuy");
            this.inputSkillInjectorMaxBuy.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputSkillInjectorMaxBuy.Name = "inputSkillInjectorMaxBuy";
            this.inputSkillInjectorMaxBuy.ValueChanged += new System.EventHandler(this.tbSkillInjMaxBuy_ValueChanged);
            // 
            // picturePlex
            // 
            this.picturePlex.Image = global::EVECharPriceCheck.Properties.Resources.Plex;
            resources.ApplyResources(this.picturePlex, "picturePlex");
            this.picturePlex.Name = "picturePlex";
            this.picturePlex.TabStop = false;
            // 
            // pictureSkillExtractor
            // 
            this.pictureSkillExtractor.Image = global::EVECharPriceCheck.Properties.Resources.SkillExtractor;
            resources.ApplyResources(this.pictureSkillExtractor, "pictureSkillExtractor");
            this.pictureSkillExtractor.Name = "pictureSkillExtractor";
            this.pictureSkillExtractor.TabStop = false;
            // 
            // pictureSkillInjector
            // 
            this.pictureSkillInjector.Image = global::EVECharPriceCheck.Properties.Resources.SkillInjector;
            resources.ApplyResources(this.pictureSkillInjector, "pictureSkillInjector");
            this.pictureSkillInjector.Name = "pictureSkillInjector";
            this.pictureSkillInjector.TabStop = false;
            // 
            // inputSkillInjectorMinSell
            // 
            this.inputSkillInjectorMinSell.DecimalPlaces = 2;
            resources.ApplyResources(this.inputSkillInjectorMinSell, "inputSkillInjectorMinSell");
            this.inputSkillInjectorMinSell.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputSkillInjectorMinSell.Name = "inputSkillInjectorMinSell";
            this.inputSkillInjectorMinSell.ValueChanged += new System.EventHandler(this.tbSkillInjMinSell_ValueChanged);
            // 
            // inputSkillExtractorMinSell
            // 
            this.inputSkillExtractorMinSell.DecimalPlaces = 2;
            resources.ApplyResources(this.inputSkillExtractorMinSell, "inputSkillExtractorMinSell");
            this.inputSkillExtractorMinSell.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputSkillExtractorMinSell.Name = "inputSkillExtractorMinSell";
            this.inputSkillExtractorMinSell.ValueChanged += new System.EventHandler(this.tbSkillExMinSell_ValueChanged);
            // 
            // inputPlexMinSell
            // 
            this.inputPlexMinSell.DecimalPlaces = 2;
            resources.ApplyResources(this.inputPlexMinSell, "inputPlexMinSell");
            this.inputPlexMinSell.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.inputPlexMinSell.Name = "inputPlexMinSell";
            this.inputPlexMinSell.ValueChanged += new System.EventHandler(this.tbPlexMinSell_ValueChanged);
            // 
            // lbSkillInjMaxBuy
            // 
            resources.ApplyResources(this.lbSkillInjMaxBuy, "lbSkillInjMaxBuy");
            this.lbSkillInjMaxBuy.Name = "lbSkillInjMaxBuy";
            // 
            // lbSkillInjMinSell
            // 
            resources.ApplyResources(this.lbSkillInjMinSell, "lbSkillInjMinSell");
            this.lbSkillInjMinSell.Name = "lbSkillInjMinSell";
            // 
            // lbSkillExMinSell
            // 
            resources.ApplyResources(this.lbSkillExMinSell, "lbSkillExMinSell");
            this.lbSkillExMinSell.Name = "lbSkillExMinSell";
            // 
            // lbPlexMinSell
            // 
            resources.ApplyResources(this.lbPlexMinSell, "lbPlexMinSell");
            this.lbPlexMinSell.Name = "lbPlexMinSell";
            // 
            // buttonGetPrices
            // 
            resources.ApplyResources(this.buttonGetPrices, "buttonGetPrices");
            this.buttonGetPrices.Name = "buttonGetPrices";
            this.buttonGetPrices.UseVisualStyleBackColor = true;
            this.buttonGetPrices.Click += new System.EventHandler(this.buttonGetPrices_Click);
            // 
            // textSkillExtractorMinSellValue
            // 
            this.textSkillExtractorMinSellValue.ForeColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.textSkillExtractorMinSellValue, "textSkillExtractorMinSellValue");
            this.textSkillExtractorMinSellValue.Name = "textSkillExtractorMinSellValue";
            // 
            // textSkillInjectorMaxBuyValue
            // 
            this.textSkillInjectorMaxBuyValue.ForeColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.textSkillInjectorMaxBuyValue, "textSkillInjectorMaxBuyValue");
            this.textSkillInjectorMaxBuyValue.Name = "textSkillInjectorMaxBuyValue";
            // 
            // textSkillInjectorMinSellValue
            // 
            this.textSkillInjectorMinSellValue.ForeColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.textSkillInjectorMinSellValue, "textSkillInjectorMinSellValue");
            this.textSkillInjectorMinSellValue.Name = "textSkillInjectorMinSellValue";
            // 
            // textPlexMinSellValue
            // 
            this.textPlexMinSellValue.ForeColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.textPlexMinSellValue, "textPlexMinSellValue");
            this.textPlexMinSellValue.Name = "textPlexMinSellValue";
            // 
            // rtbShortDescription
            // 
            this.rtbShortDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbShortDescription, "rtbShortDescription");
            this.rtbShortDescription.Name = "rtbShortDescription";
            this.rtbShortDescription.ReadOnly = true;
            this.rtbShortDescription.ShortcutsEnabled = false;
            this.rtbShortDescription.TabStop = false;
            // 
            // rtbDetailedDescriprion
            // 
            this.rtbDetailedDescriprion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.rtbDetailedDescriprion, "rtbDetailedDescriprion");
            this.rtbDetailedDescriprion.Name = "rtbDetailedDescriprion";
            this.rtbDetailedDescriprion.ReadOnly = true;
            this.rtbDetailedDescriprion.ShortcutsEnabled = false;
            this.rtbDetailedDescriprion.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.russianToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Tag = "en";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // russianToolStripMenuItem
            // 
            this.russianToolStripMenuItem.Name = "russianToolStripMenuItem";
            resources.ApplyResources(this.russianToolStripMenuItem, "russianToolStripMenuItem");
            this.russianToolStripMenuItem.Tag = "ru";
            this.russianToolStripMenuItem.Click += new System.EventHandler(this.russianToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // selectRegionBox
            // 
            this.selectRegionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectRegionBox.FormattingEnabled = true;
            resources.ApplyResources(this.selectRegionBox, "selectRegionBox");
            this.selectRegionBox.Name = "selectRegionBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAPIKeyExpires);
            this.groupBox1.Controls.Add(this.buttonFillFromEveboard);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.inputEveboardPass);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.inputEveboardUrl);
            this.groupBox1.Controls.Add(this.textSkillPointsValue);
            this.groupBox1.Controls.Add(this.inputSkillPoints);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // labelAPIKeyExpires
            // 
            resources.ApplyResources(this.labelAPIKeyExpires, "labelAPIKeyExpires");
            this.labelAPIKeyExpires.ForeColor = System.Drawing.Color.Red;
            this.labelAPIKeyExpires.Name = "labelAPIKeyExpires";
            // 
            // buttonFillFromEveboard
            // 
            resources.ApplyResources(this.buttonFillFromEveboard, "buttonFillFromEveboard");
            this.buttonFillFromEveboard.Name = "buttonFillFromEveboard";
            this.buttonFillFromEveboard.UseVisualStyleBackColor = true;
            this.buttonFillFromEveboard.Click += new System.EventHandler(this.buttonFillFromEveboard_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // inputEveboardPass
            // 
            resources.ApplyResources(this.inputEveboardPass, "inputEveboardPass");
            this.inputEveboardPass.Name = "inputEveboardPass";
            this.toolTip1.SetToolTip(this.inputEveboardPass, resources.GetString("inputEveboardPass.ToolTip"));
            // 
            // radioButton2
            // 
            resources.ApplyResources(this.radioButton2, "radioButton2");
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButtonCharacter_CheckedChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Checked = true;
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButtonCharacter_CheckedChanged);
            // 
            // inputEveboardUrl
            // 
            resources.ApplyResources(this.inputEveboardUrl, "inputEveboardUrl");
            this.inputEveboardUrl.Name = "inputEveboardUrl";
            this.toolTip1.SetToolTip(this.inputEveboardUrl, resources.GetString("inputEveboardUrl.ToolTip"));
            this.inputEveboardUrl.TextChanged += new System.EventHandler(this.inputEveboardUrl_TextChanged);
            this.inputEveboardUrl.Leave += new System.EventHandler(this.inputEveboardUrl_Leave);
            // 
            // textSkillPointsValue
            // 
            this.textSkillPointsValue.ForeColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.textSkillPointsValue, "textSkillPointsValue");
            this.textSkillPointsValue.Name = "textSkillPointsValue";
            // 
            // inputSkillPoints
            // 
            this.inputSkillPoints.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            resources.ApplyResources(this.inputSkillPoints, "inputSkillPoints");
            this.inputSkillPoints.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.inputSkillPoints.Name = "inputSkillPoints";
            this.inputSkillPoints.ValueChanged += new System.EventHandler(this.tbSkillPoints_ValueChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectRegionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbDetailedDescriprion);
            this.Controls.Add(this.rtbShortDescription);
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
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillInjectorMaxBuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSkillExtractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSkillInjector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillInjectorMinSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillExtractorMinSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputPlexMinSell)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputSkillPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
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
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem russianToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFillFromEveboard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputEveboardPass;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox inputEveboardUrl;
        private System.Windows.Forms.Label textSkillPointsValue;
        private System.Windows.Forms.NumericUpDown inputSkillPoints;
        private System.Windows.Forms.Label labelAPIKeyExpires;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

