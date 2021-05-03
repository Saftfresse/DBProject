using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_App
{
    /// <summary>
    /// Das Fahrzeug Objekt
    /// </summary>
    class Vehicle
    {
        string[] numberPlate;
        int buildingId;
        int tireId;
        string brand;
        double totalKm;
        DateTime tuv;
        double fuelUsage;
        bool inUse;

        /// <summary>
        /// Konstruktor der Fahrzeug-Klasse das diese mit einem Kennzeichen-Array und mit einem TÜV Datum erstellt
        /// </summary>
        public Vehicle()
        {
            numberPlate = new string[3];
            tuv = new DateTime(2019,06,01);
        }

        /// <summary>
        /// Setzt und gibt das Kennzeichen als zusammengesetzten String zurück
        /// </summary>
        public string NumberPlateString { get => numberPlate[0] + "-" + numberPlate[1] + "-" + numberPlate[2]; }
        /// <summary>
        /// Setzt und gibt das Array des Kennzeichens zurück
        /// </summary>
        public string[] NumberPlate { get => numberPlate; set => numberPlate = value; }
        /// <summary>
        /// Setzt und gibt die GebäudeId zurück
        /// </summary>
        public int BuildingId { get => buildingId; set => buildingId = value; }
        /// <summary>
        /// Setzt und gibt die ReifenId zurück
        /// </summary>
        public int TireId { get => tireId; set => tireId = value; }
        /// <summary>
        /// Setzt und gibt die Automarke zurück
        /// </summary>
        public string Brand { get => brand; set => brand = value; }
        /// <summary>
        /// Setzt und gibt den Kilometerstand zurück
        /// </summary>
        public double TotalKm { get => totalKm; set => totalKm = value; }
        /// <summary>
        /// Setzt und gibt das TÜV-Ablaufdatum zurück
        /// </summary>
        public DateTime Tuv { get => tuv; set => tuv = value; }
        /// <summary>
        /// Setzt und gibt den Spritverbrauch zurück
        /// </summary>
        public double FuelUsage { get => fuelUsage; set => fuelUsage = value; }
        /// <summary>
        /// Setzt und gibt zurück, ob das Fahrzeugderzeit in gebrauch ist
        /// </summary>
        public bool InUse { get => inUse; set => inUse = value; }
    }
}
