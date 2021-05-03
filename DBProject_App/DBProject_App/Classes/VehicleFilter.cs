using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_App.Classes
{
    /// <summary>
    /// Objekt um die Filtereinstellungen für Fahrzeuge zu speichern und zu prüfen
    /// </summary>
    class VehicleFilter
    {
        string vagueFilter = "";
        int buildingId = -1;
        int tireId = -1;
        double totalKmLower = -1;
        double totalKmUpper = -1;
        double fuelUsage = -1;
        DateTime tuvLower = DateTime.Today;
        DateTime tuvUpper = DateTime.Today;
        bool toggleBuilding, toggleTire, toggleTotal, toggleUsage, toggleTuv;

        public VehicleFilter() { }
        public VehicleFilter(string filterString)
        {
            VagueFilter = filterString;
        }

        /// <summary>
        /// Grober Textfilter
        /// </summary>
        public string VagueFilter { get => vagueFilter; set => vagueFilter = value; }
        /// <summary>
        /// Gebäude ID
        /// </summary>
        public int BuildingId { get => buildingId; set => buildingId = value; }
        /// <summary>
        /// Reifentyp ID
        /// </summary>
        public int TireId { get => tireId; set => tireId = value; }
        /// <summary>
        /// Untere Grenze des Kilometerstandes
        /// </summary>
        public double TotalKmLower { get => totalKmLower; set => totalKmLower = value; }
        /// <summary>
        /// Obere Grenze des Kilometerstandes
        /// </summary>
        public double TotalKmUpper { get => totalKmUpper; set => totalKmUpper = value; }
        /// <summary>
        /// Spritverbrauch
        /// </summary>
        public double FuelUsage { get => fuelUsage; set => fuelUsage = value; }
        /// <summary>
        /// Untere Grenze der TÜV Suche
        /// </summary>
        public DateTime TuvLower { get => tuvLower; set => tuvLower = value; }
        /// <summary>
        /// Obere Grenze der TÜV Suche
        /// </summary>
        public DateTime TuvUpper { get => tuvUpper; set => tuvUpper = value; }
        /// <summary>
        /// Schaltet das filtern nach der GebäudeId um
        /// </summary>
        public bool ToggleBuilding { get => toggleBuilding; set => toggleBuilding = value; }
        /// <summary>
        /// Schaltet das filtern nach der ReifenId um
        /// </summary>
        public bool ToggleTire { get => toggleTire; set => toggleTire = value; }
        /// <summary>
        /// Schaltet das filtern nach dem Kilometerstand um
        /// </summary>
        public bool ToggleTotal { get => toggleTotal; set => toggleTotal = value; }
        /// <summary>
        /// Schaltet das filtern nach dem Spritverbrauch um
        /// </summary>
        public bool ToggleUsage { get => toggleUsage; set => toggleUsage = value; }
        /// <summary>
        /// Schaltet das filtern nach dem TÜV um
        /// </summary>
        public bool ToggleTuv { get => toggleTuv; set => toggleTuv = value; }

        /// <summary>
        /// Gibt zurück ob das Object dem Filter entspricht
        /// </summary>
        /// <param name="v">Das zu prüfende Objekt</param>
        /// <returns>Ob es dem Filter entspricht</returns>
        public bool MatchesFilters(Vehicle v)
        {
            bool isMatch = true;
            if (ToggleBuilding && BuildingId > 0)
            {
                if (BuildingId != v.BuildingId) isMatch = false;
            }
            if (ToggleTire && TireId > 0)
            {
                if (TireId != v.TireId) isMatch = false;
            }
            if (ToggleTotal)
            {
                if (TotalKmLower > v.TotalKm || TotalKmUpper < v.TotalKm) isMatch = false;
            }
            if (ToggleUsage)
            {
                if (FuelUsage != v.FuelUsage) isMatch = false;
            }
            if (ToggleTuv)
            {
                if (TuvLower > v.Tuv || TuvUpper < v.Tuv) isMatch = false;
            }

            // Erstellt einen Superstring und prüft ob der zu Suchende string enthalten ist
            string super = v.NumberPlateString + v.Brand + v.BuildingId + v.FuelUsage + v.TireId + v.TotalKm + v.Tuv.ToShortDateString();
            if (VagueFilter.Length > 0)
            {
                if (!super.ToLower().Contains(VagueFilter.ToLower())) isMatch = false; 
            }

            return isMatch;
        }
    }
}
