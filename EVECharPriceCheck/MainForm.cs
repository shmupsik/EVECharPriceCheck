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

            ////Устанавливаем текст на кнопке, которая была изображена на скриншоте раньше название локализации
            //TSDD_Language.Text = newCultureInfo.NativeName;

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

            List<ItemPrice> ItemPricesList = EveCentralApi.GetPrices(new String[] { EveCentralApi.typeid_SKILLEXT, EveCentralApi.typeid_SKILLINJ, EveCentralApi.typeid_PLEX }, new string[] { }, new string[] { (selectRegionBox.SelectedItem as ComboBoxRegionItem).Value });
            foreach (ItemPrice item in ItemPricesList)
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



        private void PC_CalculationCompleted(object sender, EventArgs e)
        {
            UpdateControls(sender as EveCharPriceCalculator);
        }

        private String Plural(int Value, String Set)
        {
            String[] SetValues = Set.Split('/');

            if (SetValues.Count() != 3)
            {
                return Set;
            }

            int AbsValue = Math.Abs(Value);
            if (AbsValue == 0)
            {
                return SetValues[2];
            }
            else if (AbsValue == 1)
            {
                return SetValues[0];
            }
            else if ((AbsValue > 1) && (AbsValue <= 4))
            {
                return SetValues[1];
            }
            else if (AbsValue > 4)
            {
                return SetValues[2];
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
                result.AppendFormat(LocRM.GetString("detailed_s2_template"), new object[]
                    {
                    EveCharPriceCalculator.FormatValue(calculator.ResultIskMaxPrice),
                    calculator.ResultSkillInjectorsItemsRequired,
                    EveCharPriceCalculator.FormatValue(calculator.SkillInjectorMinSellPrice),
                    Plural(calculator.ResultSkillInjectorsItemsRequired, LocRM.GetString("item_SkillInjector")),
                    }
                );
                result.AppendLine();
                result.Append(LocRM.GetString("detailed_s3_template"));

                if (calculator.ResultIskMinPrice > 0)
                {
                    result.AppendLine();
                    result.AppendFormat(LocRM.GetString("detailed_s4_template"), new object[]
                        {
                        EveCharPriceCalculator.FormatValue(calculator.ResultIskMinPrice),
                        EveCharPriceCalculator.FormatValue(calculator.ResultIskToTrainToMinExtractPoints),
                        EveCharPriceCalculator.FormatValue(calculator.ResultIskMinPrice + calculator.ResultIskToTrainToMinExtractPoints),
                        calculator.ResultSkillInjectorsExtraItemsRequired,
                        EveCharPriceCalculator.FormatValue(EveConstant.MinSkillPointsAfterExtraction, 0)
                        }
                    );
                }
                result.AppendLine();
                result.Append(LocRM.GetString("detailed_s5_template"));
            }
            else
            {
                result.Append(detailed_empty_template);
            }

            return result.ToString();
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
    }


}
