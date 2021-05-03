using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_App.Classes
{
    /// <summary>
    /// Objekt um die Filtereinstellungen für Bestellungen zu speichern und zu prüfen
    /// </summary>
    class OrderFilter
    {
        string vagueString = "";

        int customerId = -1;
        int empId = -1;
        string vehicleNum = "";
        DateTime dateFrom = new DateTime();
        DateTime dateTo = new DateTime();
        double distanceFrom = 0;
        double distanceTo = 0;
        int durationFrom = 0;
        int durationTo = 0;
        double amountFrom = 0;
        double amountTo = 0;

        bool 
            toggleCustomerId, 
            toggleEmpId, 
            toggleVehicleNum,
            toggleDate,
            toggleDistance,
            toggleDuration,
            toggleAmount;

        /// <summary>
        /// Wandelt den durch die TextBox vorhandenen formatierten Zeit-Text in das sekunden äquivalent um
        /// </summary>
        /// <param name="_value">Der Zeit-Wert der TextBox</param>
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
        /// Die Kundennummer
        /// </summary>
        public int CustomerId { get => customerId; set => customerId = value; }
        /// <summary>
        /// Die Personalnummer
        /// </summary>
        public int EmpId { get => empId; set => empId = value; }
        /// <summary>
        /// Das Kennzeichen
        /// </summary>
        public string VehicleNum { get => vehicleNum; set => vehicleNum = value; }
        /// <summary>
        /// Die untere Datumsgrenze
        /// </summary>
        public DateTime DateFrom { get => dateFrom; set => dateFrom = value; }
        /// <summary>
        /// Die obere Datumsgrenze
        /// </summary>
        public DateTime DateTo { get => dateTo; set => dateTo = value; }
        /// <summary>
        /// Die untere Entfernungsgrenze
        /// </summary>
        public double DistanceFrom { get => distanceFrom; set => distanceFrom = value; }
        /// <summary>
        /// Die obere Entfernungsgrenze
        /// </summary>
        public double DistanceTo { get => distanceTo; set => distanceTo = value; }
        /// <summary>
        /// Die untere Dauergrenze
        /// </summary>
        public int DurationFrom { get => durationFrom; set => durationFrom = value; }
        /// <summary>
        /// Die obere Dauergrenze
        /// </summary>
        public int DurationTo { get => durationTo; set => durationTo = value; }
        /// <summary>
        /// Die untere Dauergrenze als String Übergeben
        /// </summary>
        public string DurationToString {  set => durationTo = setAmountString(value); }
        /// <summary>
        /// Die obere Dauergrenze als String Übergeben
        /// </summary>
        public string DurationFromString { set => durationFrom = setAmountString(value); }
        /// <summary>
        /// Die untere Betragsgrenze in €
        /// </summary>
        public double AmountFrom { get => amountFrom; set => amountFrom = value; }
        /// <summary>
        /// Die obere Betragsgrenze in €
        /// </summary>
        public double AmountTo { get => amountTo; set => amountTo = value; }
        /// <summary>
        /// Schaltet das filtern nach der Kundennummer um
        /// </summary>
        public bool ToggleCustomerId { get => toggleCustomerId; set => toggleCustomerId = value; }
        /// <summary>
        /// Schaltet das filtern nach der PErsonalnummer um
        /// </summary>
        public bool ToggleEmpId { get => toggleEmpId; set => toggleEmpId = value; }
        /// <summary>
        /// Schaltet das filtern nach dem Kennzeichen um
        /// </summary>
        public bool ToggleVehicleNum { get => toggleVehicleNum; set => toggleVehicleNum = value; }
        /// <summary>
        /// Schaltet das filtern nach dem Datum um
        /// </summary>
        public bool ToggleDate { get => toggleDate; set => toggleDate = value; }
        /// <summary>
        /// Schaltet das filtern nach der Entfernung um
        /// </summary>
        public bool ToggleDistance { get => toggleDistance; set => toggleDistance = value; }
        /// <summary>
        /// Schaltet das filtern nach der Distanz um
        /// </summary>
        public bool ToggleDuration { get => toggleDuration; set => toggleDuration = value; }
        /// <summary>
        /// Schaltet das filtern nach dem Betrag in € um
        /// </summary>
        public bool ToggleAmount { get => toggleAmount; set => toggleAmount = value; }
        /// <summary>
        /// Setzt den string der groben textsuche
        /// </summary>
        public string VagueString { get => vagueString; set => vagueString = value; }

        /// <summary>
        /// Gibt zurück ob das Object dem Filter entspricht
        /// </summary>
        /// <param name="o">Das zu prüfende Objekt</param>
        /// <returns>Ob es dem Filter entspricht</returns>
        public bool MatchesFilters(Order o)
        {
            bool isMatch = true;

            if (ToggleCustomerId && customerId > 0)
            {
                if (o.CustomerId != customerId) isMatch = false;
            }
            if (ToggleEmpId && empId > 0)
            {
                if (o.EmpId != empId) isMatch = false;
            }
            if (toggleVehicleNum && vehicleNum.Length > 0)
            {
                if (o.VehicleNum != vehicleNum) isMatch = false;
            }
            if (toggleDate)
            {
                if (o.Date < dateFrom || o.Date > dateTo) isMatch = false;
            }
            if (ToggleDistance && distanceTo > distanceFrom)
            {
                if (o.Distance < distanceFrom || o.Distance > distanceTo) isMatch = false;
            }
            if (ToggleDuration && durationTo > durationFrom)
            {
                if (o.Duration < durationFrom || o.Duration > durationTo) isMatch = false;
            }
            if (ToggleAmount && amountTo > amountFrom)
            {
                if (o.Amount < amountFrom || o.Amount > amountTo) isMatch = false;
            }
            
            // Erstellt einen Superstring und prüft ob der zu Suchende string enthalten ist
            string super = o.VehicleNum + o.StartPoint + o.StartStreet + o.DestPoint + o.DestStreet;
            if (vagueString.Length > 0 && !super.ToLower().Contains(vagueString.ToLower()))
            {
                isMatch = false;
            }

            return isMatch;
        }

    }
}
