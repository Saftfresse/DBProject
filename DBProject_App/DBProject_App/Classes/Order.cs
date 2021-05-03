using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_App.Classes
{
    /// <summary>
    /// Das Bestellungs-Object
    /// </summary>
    class Order
    {
        int id;
        int customerId;
        int empId;
        string vehicleNum;
        string startPoint, startStreet;
        string destPoint, destStreet;
        DateTime date = DateTime.Today;
        double distance;
        int duration;
        double amount;
        
        /// <summary>
        /// Gibt den das Sekundenäquivalent der TextEingabe durch den Nutzer zurück
        /// </summary>
        /// <param name="_value">Der Zeit-String</param>
        /// <returns>Die Zeit in Sekunden</returns>
        int setAmountString(string _value)
        {
            int seconds = 0;
            string[] values = _value.Split(':');
            if (values[2].Replace(" ", "").Length > 0) seconds = int.Parse(values[2]);
            if (values[1].Replace(" ", "").Length > 0) seconds += int.Parse(values[1]) * 60;
            if (values[0].Replace(" ", "").Length > 0) seconds += int.Parse(values[0]) * 3600;
            return seconds;
        }

        /// <summary>
        /// Gibt die Sekundenzeit als string formatiert aus
        /// </summary>
        /// <param name="dur">Die Zeit in Sekunden</param>
        /// <returns>Der formatierte String</returns>
        string formatDuration(int dur)
        {
            int hours = dur / 3600;
            dur -= hours * 3600;
            int minutes = dur / 60;
            dur -= minutes * 60;
            return string.Format("{0:000}:{1:00}:{2:00}", hours, minutes, dur);
        }

        /// <summary>
        /// Setzt und gibt die Bestellnummer zurück
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// Setzt und gibt die Kundennummer zurück
        /// </summary>
        public int CustomerId { get => customerId; set => customerId = value; }
        /// <summary>
        /// Setzt und gibt die Personalnummer des Fahrers zurück
        /// </summary>
        public int EmpId { get => empId; set => empId = value; }
        /// <summary>
        /// Setzt und gibt das Kennzeichen des Fahrzeugs zurück
        /// </summary>
        public string VehicleNum { get => vehicleNum; set => vehicleNum = value; }
        /// <summary>
        /// Setzt und gibt die Start-Stadt zurück
        /// </summary>
        public string StartPoint { get => startPoint; set => startPoint = value; }
        /// <summary>
        /// Setzt und gibt die Start-Straße zurück
        /// </summary>
        public string StartStreet { get => startStreet; set => startStreet = value; }
        /// <summary>
        /// Setzt und gibt den Ziel-Ort zurück
        /// </summary>
        public string DestPoint { get => destPoint; set => destPoint = value; }
        /// <summary>
        /// Setzt und gibt die Zielstraße zurück
        /// </summary>
        public string DestStreet { get => destStreet; set => destStreet = value; }
        /// <summary>
        /// Setzt und gibt das Bestelldatum zurück
        /// </summary>
        public DateTime Date { get => date; set => date = value; }
        /// <summary>
        /// Setzt und gibt die Entfernung zurück
        /// </summary>
        public double Distance { get => distance; set => distance = value; }
        /// <summary>
        /// Setzt und gibt die Dauer als ganze Sekunde zurück
        /// </summary>
        public int Duration { get => duration; set => duration = value; }
        /// <summary>
        /// Setzt und gibt die Dauer als formatierter String zurück
        /// </summary>
        public string DurationString { get => formatDuration(duration); set => duration = setAmountString(value); }
        /// <summary>
        /// Setzt und gibt den Betrag in € zurück
        /// </summary>
        public double Amount { get => amount; set => amount = value; }
    }
}
