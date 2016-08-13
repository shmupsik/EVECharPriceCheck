using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace EVECharPriceCheck
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        EveCharPriceCalculator PC = new EveCharPriceCalculator();
        ResourceManager LocRM = new ResourceManager("EveCharPriceCheck.WinFormStrings", Assembly.GetExecutingAssembly());


        private class ComboBoxRegionItem
        {
            public string Name;
            public string Value;
            public ComboBoxRegionItem(string name, string value)
            {
                Name = name;
                Value = value;
            }
            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        private void ChangeFormLanguage(string newLanguageString)
        {
            var resources = new ComponentResourceManager(typeof(MainForm));

            CultureInfo newCultureInfo = new CultureInfo(newLanguageString);

            //Thread.CurrentThread.CurrentCulture = newCultureInfo;
            Thread.CurrentThread.CurrentUICulture = newCultureInfo;

            //Применяем для каждого контрола на форме новую культуру
            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, newCultureInfo);
            }
            foreach (Control c in this.groupBox1.Controls)
            {
                resources.ApplyResources(c, c.Name, newCultureInfo);
            }

            ////Отдельно меняем для тайтла самой формы локализацию
            //resources.ApplyResources(this, "$this", newCultureInfo);

            //Для элементов статус стрипа устанавливаем также установки локализации
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                resources.ApplyResources(item, item.Name, newCultureInfo);
                foreach (ToolStripMenuItem subitem in item.DropDownItems)
                {
                    resources.ApplyResources(subitem, subitem.Name, newCultureInfo);
                }
            }

            UpdateSkillPointsControls();
        }

        private void SetCurrenLanguageButtonChecked(object sender)
        {
            foreach (ToolStripMenuItem languageButton in languageToolStripMenuItem.DropDownItems)
            {
                languageButton.Checked = languageButton == sender;
            }
        }

        private void FillRegionComboBox()
        {
            selectRegionBox.Items.Add(new ComboBoxRegionItem("Jita", EveCentralApi.systemid_JITA));
            selectRegionBox.Items.Add(new ComboBoxRegionItem("Amarr", EveCentralApi.systemid_AMARR));
            selectRegionBox.Items.Add(new ComboBoxRegionItem("Rens", EveCentralApi.systemid_RENS));
            selectRegionBox.Items.Add(new ComboBoxRegionItem("Hek", EveCentralApi.systemid_HEK));

            selectRegionBox.SelectedIndex = 0;
        }

        private void GetPricesAndFillControls()
        {
            if (selectRegionBox.SelectedIndex == -1)
            {
                return;
            }

            var ItemPricesList = EveCentralApi.GetPrices(new String[] { EveCentralApi.typeid_SKILLEXT, EveCentralApi.typeid_SKILLINJ, EveCentralApi.typeid_PLEX }, new string[] { }, new string[] { (selectRegionBox.SelectedItem as ComboBoxRegionItem).Value });
            foreach (var item in ItemPricesList)
            {
                if (item.TypeId == EveCentralApi.typeid_SKILLEXT)
                {
                    inputSkillExtractorMinSell.Value = item.MinSell;
                }
                if (item.TypeId == EveCentralApi.typeid_SKILLINJ)
                {
                    inputSkillInjectorMaxBuy.Value = item.MaxBuy;
                    inputSkillInjectorMinSell.Value = item.MinSell;
                }
                if (item.TypeId == EveCentralApi.typeid_PLEX)
                {
                    inputPlexMinSell.Value = item.MinSell;
                }
            }
        }

        private void UpdateSkillPointsControls()
        {
            inputSkillPoints.Enabled = radioButton1.Checked;
            inputEveboardUrl.Enabled = inputEveboardPass.Enabled = buttonFillFromEveboard.Enabled = radioButton2.Checked;
        }

        private void PC_CalculationCompleted(object sender, EventArgs e)
        {
            UpdateControls(sender as EveCharPriceCalculator);
        }

        private String Plural(int Value, String Set)
        {
            String[] SetValues = Set.Split('/');

            if (SetValues.Count() == 3) //russian plural
            {
                int lastdigit = Math.Abs(Value) % 10;
                if (lastdigit == 0)
                {
                    return SetValues[2];
                }
                else if (lastdigit == 1)
                {
                    return SetValues[0];
                }
                else if ((lastdigit > 1) && (lastdigit <= 4))
                {
                    return SetValues[1];
                }
                else if (lastdigit > 4)
                {
                    return SetValues[2];
                }
            }
            else if (SetValues.Count() == 2) //english plural
            {
                int absValue = Math.Abs(Value);
                return absValue == 1 ? SetValues[0] : SetValues[1];
            }

            return Set;
        }

        private String FormatShortDescription(EveCharPriceCalculator calculator)
        {
            StringBuilder result = new StringBuilder();

            if (calculator.ResultIskMaxPrice > 0)
            {
                result.AppendFormat(LocRM.GetString("short_s1_template"), EveCharPriceCalculator.FormatValue(calculator.ResultIskMinPrice), EveCharPriceCalculator.FormatValue(calculator.ResultIskMaxPrice));
                result.AppendLine();
                result.AppendFormat(LocRM.GetString("short_s2_template"), calculator.ResultPlexMinPrice, calculator.ResultPlexMaxPrice);
            }
            else
            {
                result.Append(LocRM.GetString("short_empty_template"));
            }

            return result.ToString();
        }

        private String FormatDetailedDescription(EveCharPriceCalculator calculator)
        {
            String detailed_empty_template = "";

            StringBuilder result = new StringBuilder();

            bool IsSkillBooksLoaded = SkillBooksPriceCalculator.BooksDataLoaded && (calculator.InjectedSkillsPrice > 0);

            if (calculator.ResultIskMaxPrice > 0)
            {
                if (calculator.ResultIskMinPrice > 0)
                {
                    result.AppendFormat(LocRM.GetString("detailed_s1_template"), new object[]
                        {
                        EveCharPriceCalculator.FormatValue(calculator.ResultIskMinPrice),
                        calculator.ResultSkillExtractorsItemsRequired,
                        EveCharPriceCalculator.FormatValue(calculator.SkillExtractorMinSellPrice),
                        EveCharPriceCalculator.FormatValue(calculator.SkillExtractorMinSellPrice * calculator.ResultSkillExtractorsItemsRequired),
                        EveCharPriceCalculator.FormatValue(calculator.SkillInjectorMaxBuyPrice),
                        EveCharPriceCalculator.FormatValue(calculator.SkillInjectorMaxBuyPrice * calculator.ResultSkillExtractorsItemsRequired),
                        Plural(calculator.ResultSkillExtractorsItemsRequired, LocRM.GetString("item_SkillExtractor")),
                        Plural(calculator.ResultSkillExtractorsItemsRequired, LocRM.GetString("item_SkillInjector")),
                        (calculator.ResultSkillExtractorsItemsRequired > 1 ? LocRM.GetString("eng_multi_2") : "")
                        }
                    );
                }
                else
                {
                    result.AppendFormat(LocRM.GetString("detailed_s0_template"), new object[]
                        {
                        EveCharPriceCalculator.FormatValue(calculator.ResultIskMinPrice)
                        }
                    );
                }
                result.AppendLine();
                result.AppendFormat(LocRM.GetString(IsSkillBooksLoaded ? "detailed_s2_template_skillbooks" : "detailed_s2_template"), new object[]
                    {
                    EveCharPriceCalculator.FormatValue(calculator.ResultIskMaxPrice),
                    calculator.ResultSkillInjectorsItemsRequired,
                    EveCharPriceCalculator.FormatValue(calculator.SkillInjectorMinSellPrice),
                    Plural(calculator.ResultSkillInjectorsItemsRequired, LocRM.GetString("item_SkillInjector")),
                    EveCharPriceCalculator.FormatValue(calculator.InjectedSkillsPrice)
                    }
                );
                //result.AppendLine();
                //result.Append(LocRM.GetString("detailed_s3_template"));

                if (calculator.ResultIskMinPrice > 0)
                {
                    result.AppendLine();
                    result.AppendFormat(LocRM.GetString(IsSkillBooksLoaded ? "detailed_s4_template_skillbooks" : "detailed_s4_template"), new object[]
                        {
                        EveCharPriceCalculator.FormatValue(calculator.ResultIskMinPrice),
                        EveCharPriceCalculator.FormatValue(calculator.ResultIskToTrainToMinExtractPoints),
                        EveCharPriceCalculator.FormatValue(calculator.ResultIskMinPrice + calculator.ResultIskToTrainToMinExtractPoints),
                        calculator.ResultSkillInjectorsExtraItemsRequired,
                        EveCharPriceCalculator.FormatValue(EveConstant.MinSkillPointsAfterExtraction, 0),
                        EveCharPriceCalculator.FormatValue(calculator.InjectedSkillsPrice)
                        }
                    );
                }
                result.AppendLine();
                result.Append(LocRM.GetString(IsSkillBooksLoaded ? "detailed_s5_template_skillbooks" : "detailed_s5_template"));
            }
            else
            {
                result.Append(detailed_empty_template);
            }

            return result.ToString();
        }

        private void AnimateDownload(PictureBox picture, bool ShowImage, bool IsDownloading, bool IsSucces = false)
        {
            picture.Visible = ShowImage;

            if (IsDownloading)
            {
                //To use animated gif we need not to block UI thread, so we need to use a separate thread. With .net 4.5 it seems easy (Task/await/async), but we use .net 3.5 so it requires quite a bit work
                //picture.Image = Properties.Resources.downloading;
                picture.Visible = false;
            }
            else
            {
                if (IsSucces)
                {
                    picture.Image = Properties.Resources.resultOk;
                }
                else
                {
                    picture.Image = Properties.Resources.resultError;
                }

            }
            picture.Refresh();

        }


        private void UpdateControls(EveCharPriceCalculator calculator)
        {
            textSkillPointsValue.Text = EveCharPriceCalculator.FormatValue(inputSkillPoints.Value, 0);
            textSkillExtractorMinSellValue.Text = EveCharPriceCalculator.FormatValue(inputSkillExtractorMinSell.Value, 0);
            textSkillInjectorMaxBuyValue.Text = EveCharPriceCalculator.FormatValue(inputSkillInjectorMaxBuy.Value, 0);
            textSkillInjectorMinSellValue.Text = EveCharPriceCalculator.FormatValue(inputSkillInjectorMinSell.Value, 0);
            textPlexMinSellValue.Text = EveCharPriceCalculator.FormatValue(inputPlexMinSell.Value, 0);

            rtbShortDescription.Text = FormatShortDescription(calculator);
            rtbDetailedDescriprion.Text = FormatDetailedDescription(calculator);
        }

        private void UpdateCalculator(EveCharPriceCalculator calculator)
        {
            calculator.BeginUpdate();

            calculator.SkillPoints = (int)inputSkillPoints.Value;
            calculator.SkillInjectorMaxBuyPrice = inputSkillInjectorMaxBuy.Value;
            calculator.SkillInjectorMinSellPrice = inputSkillInjectorMinSell.Value;
            calculator.SkillExtractorMinSellPrice = inputSkillExtractorMinSell.Value;
            calculator.PlexMinSellPrice = inputPlexMinSell.Value;

            calculator.EndUpdate();
            calculator.Calculate();
        }


        private void buttonGetPrices_Click(object sender, EventArgs e)
        {
            GetPricesAndFillControls();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            UpdateCalculator(PC);
        }


        private void tbSkillPoints_ValueChanged(object sender, EventArgs e)
        {
            PC.SkillPoints = (int)(sender as NumericUpDown).Value;
            PC.InjectedSkillsPrice = 0;
            AnimateDownload(pictureBoxEveboardStatus, false, false);
        }

        private void tbSkillExMinSell_ValueChanged(object sender, EventArgs e)
        {
            PC.SkillExtractorMinSellPrice = (sender as NumericUpDown).Value;
        }

        private void tbSkillInjMaxBuy_ValueChanged(object sender, EventArgs e)
        {
            PC.SkillInjectorMaxBuyPrice = (sender as NumericUpDown).Value;
        }

        private void tbSkillInjMinSell_ValueChanged(object sender, EventArgs e)
        {
            PC.SkillInjectorMinSellPrice = (sender as NumericUpDown).Value;
        }

        private void tbPlexMinSell_ValueChanged(object sender, EventArgs e)
        {
            PC.PlexMinSellPrice = (sender as NumericUpDown).Value;
        }


        private void MainForm_Shown(object sender, EventArgs e)
        {
            PC.CalculationCompleted += new EventHandler(PC_CalculationCompleted);
            UpdateCalculator(PC);

            FillRegionComboBox();

            bool IsLanguageFound = false;
            foreach (ToolStripMenuItem languageButton in languageToolStripMenuItem.DropDownItems)
            {
                if (languageButton.Tag.Equals(Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName))
                {
                    languageButton.Checked = true;
                    IsLanguageFound = true;
                }
            }
            if (!IsLanguageFound)
            {
                englishToolStripMenuItem_Click(englishToolStripMenuItem, EventArgs.Empty);
            }

            UpdateSkillPointsControls();

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBox1 a = new AboutBox1())
            {
                a.ShowDialog();
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormLanguage((sender as ToolStripMenuItem).Tag.ToString());
            SetCurrenLanguageButtonChecked(sender);
            UpdateControls(PC);
        }

        private void russianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeFormLanguage((sender as ToolStripMenuItem).Tag.ToString());
            SetCurrenLanguageButtonChecked(sender);
            UpdateControls(PC);
        }

        private void buttonFillFromEveboard_Click(object sender, EventArgs e)
        {
            AnimateDownload(pictureBoxEveboardStatus, true, true);

            SkillDataResponse sdr = EveBoardApi.GetSkillBooksList(inputEveboardUrl.Text, inputEveboardPass.Text);
            if (sdr.IsEmpty())
            {
                if ((sdr.IsRestricted) && String.IsNullOrEmpty(inputEveboardPass.Text))
                {
                    inputEveboardPass.BackColor = Color.Red;
                }
                PC.InjectedSkillsPrice = 0;
            }
            else
            {
                inputEveboardPass.BackColor = Color.FromKnownColor(KnownColor.Window);
                labelAPIKeyExpires.Visible = sdr.ApiKeyExpired;

                inputSkillPoints.Value = sdr.TotalSkillPoints;

                PC.SkillPoints = (int)inputSkillPoints.Value;
                decimal InjectedSkillCost = SkillBooksPriceCalculator.GetSkillBooksPrice(sdr.SkillsList, new string[] { }, new string[] { (selectRegionBox.SelectedItem as ComboBoxRegionItem).Value }) - EveConstant.NewCharInjectedSkillBooksCost;
                if (InjectedSkillCost < 0)
                {
                    InjectedSkillCost = 0;
                }
                PC.InjectedSkillsPrice = InjectedSkillCost;

            }

            AnimateDownload(pictureBoxEveboardStatus, true, false, sdr.IsSuccessful && !sdr.IsEmpty());
        }

        private void radioButtonCharacter_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSkillPointsControls();
        }

        private void inputEveboardUrl_TextChanged(object sender, EventArgs e)
        {
            inputEveboardPass.BackColor = Color.FromKnownColor(KnownColor.Window);
            labelAPIKeyExpires.Visible = false;
            AnimateDownload(pictureBoxEveboardStatus, false, false);
        }

        private void inputEveboardUrl_Leave(object sender, EventArgs e)
        {
            inputEveboardUrl.Text = inputEveboardUrl.Text.Trim();
        }
    }


}
