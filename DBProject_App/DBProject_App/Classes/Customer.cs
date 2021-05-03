using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_App.Classes
{
    /// <summary>
    /// Das Kunden Objekt
    /// </summary>
    class Customer
    {
        string surname, lastname, phone;
        int number = -1;

        public Customer()
        {

        }

        /// <summary>
        /// Setzt und gibt den Vornamen zurück
        /// </summary>
        public string Surname { get => surname; set => surname = value; }
        /// <summary>
        /// Setzt und gibt den Nachnamen zurück
        /// </summary>
        public string Lastname { get => lastname; set => lastname = value; }
        /// <summary>
        /// Setzt und gibt die Telefonnummer zurück
        /// </summary>
        public string Phone { get => phone; set => phone = value; }
        /// <summary>
        /// Setzt und gibt die Kundennummer zurück
        /// </summary>
        public int Number { get => number; set => number = value; }
    }
}
