using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_App.Classes
{
    /// <summary>
    /// Objekt um die Filtereinstellungen für Kunden zu speichern und zu prüfen
    /// </summary>
    class CustomerFilter
    {
        string vagueFilter = "";
        int id = -1;

        bool toggleId;
        
        /// <summary>
        /// Gibt zurück ob der Kunde den Filtern entspricht
        /// </summary>
        /// <param name="c">Der zu prüfende Kunde</param>
        /// <returns>Entspricht der Kunde dem Filter?</returns>
        public bool MatchesFilter(Customer c)
        {
            if (toggleId)
            {
                if (c.Number != Id) return false;
            }
            
            // Erstellt einen Superstring und prüft ob der zu Suchende string enthalten ist
            string super = c.Surname + c.Lastname + c.Phone + c.Number;
            if (super.ToLower().Contains(vagueFilter.ToLower()))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Setzt den string der groben textsuche
        /// </summary>
        public string VagueFilter { get => vagueFilter; set => vagueFilter = value; }
        /// <summary>
        /// Schaltet das filtern nach der Kunennummer um
        /// </summary>
        public bool ToggleId { get => toggleId; set => toggleId = value; }
        /// <summary>
        /// Die Kundennummer
        /// </summary>
        public int Id { get => id; set => id = value; }
    }
}
