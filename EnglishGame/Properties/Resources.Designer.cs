﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnglishGame.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EnglishGame.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Icon, аналогичного (Значок).
        /// </summary>
        public static System.Drawing.Icon icons {
            get {
                object obj = ResourceManager.GetObject("icons", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Не выходи на работу это ошибка
        ///Язык враг мой, обязан знать ты это
        ///Дома мы можем жить спокойно
        ///Обязанность каждого это знание
        ///Даже не знаю
        ///Верного ответа нет.
        /// </summary>
        public static string TextFailedOneTupe {
            get {
                return ResourceManager.GetString("TextFailedOneTupe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на s
        ///q
        ///nn
        ///o
        ///e
        ///p
        ///pp.
        /// </summary>
        public static string TextFailedZeroTupe {
            get {
                return ResourceManager.GetString("TextFailedZeroTupe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        public static System.Drawing.Bitmap unated {
            get {
                object obj = ResourceManager.GetObject("unated", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ///Created by xHamelion
        ///	Для добавления новых заданий необходимо обозначить (тип задания-задание-ответ)
        ///	Типы заданий:
        ///	0 = вставить букву
        ///	1 = перевети текст с английского на русский
        ///	2 = перевести текст с руссского на английский и правильно записать
        ///	3 = вписать правильное слово на английском
        ///	В заданиях не допускються пропуски. Это поломает работу приложения
        ///	Вы можете изменить здания, добавить или у [остаток строки не уместился]&quot;;.
        /// </summary>
        public static string ZadanText {
            get {
                return ResourceManager.GetString("ZadanText", resourceCulture);
            }
        }
    }
}