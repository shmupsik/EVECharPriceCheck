﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EVECharPriceCheck {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class WinFormStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal WinFormStrings() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EVECharPriceCheck.WinFormStrings", typeof(WinFormStrings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   The lowest character price starting from 0 ISK. That is not great character, the real price on it will depend on actual trained skills..
        /// </summary>
        internal static string detailed_s0_template {
            get {
                return ResourceManager.GetString("detailed_s0_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   The lowest character price {0} ISK is price, below which the seller does not make sense to sell his character. It calculated as one can buy {1} {6} by {2} ISK {8} ({1} * {2} ≈ {3}), extract skill points from character and then sold resulting {1} {7} by {4} ISK {8}, that will bring him ({1} * {4} ≈ {5}). So profit will be {5} - {3} ≈ {0} ISK..
        /// </summary>
        internal static string detailed_s1_template {
            get {
                return ResourceManager.GetString("detailed_s1_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   The highest character price {0} ISK is price, above which the buyer does not make sense to pay. It calculated as one can buy {1} {3} {2} ISK each ({1} * {2} ≈ {0}) and train such character himself..
        /// </summary>
        internal static string detailed_s2_template {
            get {
                return ResourceManager.GetString("detailed_s2_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   The highest character price {0} ISK is price, above which the buyer does not make sense to pay. It calculated as one can buy {1} {3} {2} ISK each, also he will need to buy required Skill Books which cost about {4} ({1} * {2} + {4} ≈ {0}) and train such character himself..
        /// </summary>
        internal static string detailed_s2_template_skillbooks {
            get {
                return ResourceManager.GetString("detailed_s2_template_skillbooks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   Note, this is only techical price check..
        /// </summary>
        internal static string detailed_s3_template {
            get {
                return ResourceManager.GetString("detailed_s3_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   While selling this character the started ask price should be higher and may start from about {0} + {1} = {2} ISK. That {1} sum is the price of {3} Skill Injectors, required to train the new character to approx. {4} skill points..
        /// </summary>
        internal static string detailed_s4_template {
            get {
                return ResourceManager.GetString("detailed_s4_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   While selling this character the started ask price should be higher and may start from about {0} + {1} + {5} = {2} ISK. Where the {1} sum - is the price of {3} Skill Injectors, required to train the new character to approx. {4} skill points, the {5} sum - is the cost of skill books, injected into character..
        /// </summary>
        internal static string detailed_s4_template_skillbooks {
            get {
                return ResourceManager.GetString("detailed_s4_template_skillbooks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   The upper price may vary due to skillboks required to inject skills, character name, corp history, faction standings, character stuff etc. Also don&apos;t forget to consider your trade skills (while buying/selling skill extractors/injectors from market) and availability of the required amount of items on the appropriate price..
        /// </summary>
        internal static string detailed_s5_template {
            get {
                return ResourceManager.GetString("detailed_s5_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на   The character price may vary due to character name, corp history, faction standings, character stuff etc. Also don&apos;t forget to consider your trade skills (while buying/selling skill extractors/injectors from market) and availability of the required amount of items on the appropriate price..
        /// </summary>
        internal static string detailed_s5_template_skillbooks {
            get {
                return ResourceManager.GetString("detailed_s5_template_skillbooks", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на s.
        /// </summary>
        internal static string eng_multi_1 {
            get {
                return ResourceManager.GetString("eng_multi_1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на  each.
        /// </summary>
        internal static string eng_multi_2 {
            get {
                return ResourceManager.GetString("eng_multi_2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на PLEX/PLEX.
        /// </summary>
        internal static string item_Plex {
            get {
                return ResourceManager.GetString("item_Plex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Skill Extractor/Skill Extractors.
        /// </summary>
        internal static string item_SkillExtractor {
            get {
                return ResourceManager.GetString("item_SkillExtractor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Skill Injector/Skill Injectors.
        /// </summary>
        internal static string item_SkillInjector {
            get {
                return ResourceManager.GetString("item_SkillInjector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Seems that character costs nothing..
        /// </summary>
        internal static string short_empty_template {
            get {
                return ResourceManager.GetString("short_empty_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на The character price is from {0} to {1} ISK..
        /// </summary>
        internal static string short_s1_template {
            get {
                return ResourceManager.GetString("short_s1_template", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Which is equivalent to approx. {0} to {1} PLEX..
        /// </summary>
        internal static string short_s2_template {
            get {
                return ResourceManager.GetString("short_s2_template", resourceCulture);
            }
        }
    }
}
