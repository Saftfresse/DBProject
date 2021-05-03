using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_App
{
    /// <summary>
    /// Container für ComboBox Elemente um ihnen einen Wert zuzuweisen
    /// </summary>
    class ComboBoxItem
    {
        string text;
        object value;

        public ComboBoxItem() { }

        public ComboBoxItem(string _text)
        {
            text = _text;
        }

        public ComboBoxItem(string _text, object _value)
        {
            text = _text;
            value = _value;
        }

        /// <summary>
        /// Überschreibt die ToString Methode um die Ausgabe in der ComboBox richtig zu formatieren
        /// </summary>
        /// <returns>Der ComboBoxItem Text</returns>
        public override string ToString()
        {
            return text;
        }

        /// <summary>
        /// Der Text der in der ComboBox angezeigt wird
        /// </summary>
        public string Text { get => text; set => text = value; }
        /// <summary>
        /// Der Wert der dem Element zugewiesen wird
        /// </summary>
        public object Value { get => value; set => this.value = value; }
    }
}
