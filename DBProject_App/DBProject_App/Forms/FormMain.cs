using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Oracle.ManagedDataAccess.Client;
using DBProject_App.Classes;

namespace DBProject_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ///
        /// 
        /// Alle wichtigen oder komplexeren Sachverhalten wurden mit einem Kommentar versehen
        ///// Region Bestellungen & Kundendaten wurden nur teilweise detailliert beschrieben, da sie im Grunde die gleichen Sachverhalte wie
        ///// in der Region Fuhrpark enthalten
        /// Die Wichtigen Bereiche wurden in Regions Gruppier um die Übersicht zu erhalten
        /// 
        ///

        #region Variablen

        ///
        /// Variablen
        ///

        OracleConnector connection = new OracleConnector();
        
        // Fuhrpark

        /// <summary>
        /// Der Zustand des Fuhrpark Filterpanels
        /// </summary>
        bool vehiclesFilterExpanded = false;
        VehicleFilter vehicleFilter = new VehicleFilter();

        // Bestellungen

        /// <summary>
        /// Der Zustand des Bestellungs Filterpanels
        /// </summary>
        bool ordersFilterExpanded = false;
        OrderFilter orderFilter = new OrderFilter();

        // Kunden
        CustomerFilter customerFilter = new CustomerFilter();

        #endregion
        #region Methoden

        ///
        /// Methoden
        ///

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialisiert alle Tabellendaten
            initializeVehicleData();
            initializeCustomerData();
            initializeOrderData();
        }

        private void toolStrip_close_Click(object sender, EventArgs e) => this.Close();

        /// <summary>
        /// Funktion um das Filterpanel im View-Bereich in der größe zu ändern
        /// </summary>
        /// <param name="panelState">Die Variable die den derzeitigen zustand des Panels wiedergibt</param>
        /// <param name="_pan">Das Panel das geändert werden soll</param>
        /// <param name="_btn">Der Button der die Größenänderung triggert, um das Symbol zu ändern</param>
        /// <param name="expand">Die höhe auf die das Panel erweitert werden soll</param>
        void resizeBottomPanel(ref bool panelState, Panel _pan, Button _btn, int expand)
        {
            if (panelState)
            {
                panelState = false;
                _pan.Height = 43;
                // Ändert das Symbol der Orientierung entsprechend
                _btn.Text = _btn.Text.Replace('▼', '▲');
            }
            else
            {
                panelState = true;
                _pan.Height = expand;
                // Ändert das Symbol der Orientierung entsprechend
                _btn.Text = _btn.Text.Replace('▲', '▼');
            }
        }

        #endregion
        #region Fuhrpark

        //////////////////////////////////
        //                              //
        //           Fuhrpark           //
        //                              //
        //////////////////////////////////


        /// <summary>
        /// Läd die daten der Garagen sowie der Reifenarten für das Filter Panel
        /// </summary>
        void loadFilterComboBoxData()
        {
            combo_vehicles_filter_building.Items.Clear();
            OracleDataReader read = connection.GetResult("select * from gebaeude where name = 'Garage'");
            while (read.Read())
            {
                // Erstellt ein neues ComboBoxItem und setzt den text sowie den Wert des Objekts
                ComboBoxItem cbi = new ComboBoxItem(string.Format("{0}, {1}", read["name"], read["strasse"]), int.Parse(read["gebaeude_id"].ToString()));
                combo_vehicles_filter_building.Items.Add(cbi);
            }
            read.Close();

            // Sezt den ausgewählten Index der ComboBox auf 0 wenn er nicht gesetzt ist und lässt ihn so, wenn er schon ausgewählt ist
            combo_vehicles_filter_building.SelectedIndex = combo_vehicles_filter_building.SelectedIndex < 0 ? 0 : combo_vehicles_filter_building.SelectedIndex;

            combo_vehicles_filter_tire.Items.Clear();
            OracleDataReader read2 = connection.GetResult("select * from reifentyp");
            while (read2.Read())
            {
                ComboBoxItem cbi = new ComboBoxItem(read2["reifentyp"].ToString(), int.Parse(read2["reifentyp_id"].ToString()));
                combo_vehicles_filter_tire.Items.Add(cbi);
            }
            read2.Close();
            combo_vehicles_filter_tire.SelectedIndex = combo_vehicles_filter_tire.SelectedIndex < 0 ? 0 : combo_vehicles_filter_tire.SelectedIndex;
        }
        /// <summary>
        /// Initialisiert die Fuhrpark-liste,
        /// Die Filterdaten für die Garagen- und Reifenauswahl,
        /// Sämtliche änderungs-Events der Filter-Feld-Schalter
        /// und des Reset button im Filter Panel
        /// </summary>
        void initializeVehicleData()
        {
            loadFilterComboBoxData();
            loadVehicleList();

            // Erstellt einen IndexChanged Eventlistener für die ComboBox und setzt sie BuildingId auf den Wert
            // Läd danach die Liste neu um die Filter änderungen anzuzeigen
            combo_vehicles_filter_building.SelectedIndexChanged += (s, e) =>
            {
                vehicleFilter.BuildingId = (int)((ComboBoxItem)combo_vehicles_filter_building.SelectedItem).Value;
                loadVehicleList();
            };
            combo_vehicles_filter_tire.SelectedIndexChanged += (s, e) =>
            {
                vehicleFilter.TireId = (int)((ComboBoxItem)combo_vehicles_filter_tire.SelectedItem).Value;
                loadVehicleList();
            };

            num_vehicles_filter_usage.ValueChanged += (s, e) =>
            {
                vehicleFilter.FuelUsage = (double)((NumericUpDown)s).Value;
                loadVehicleList();
            };

            num_vehicles_filter_totalLower.ValueChanged += (s, e) =>
            {
                vehicleFilter.TotalKmLower = (double)((NumericUpDown)s).Value;
                loadVehicleList();
            };
            num_vehicles_filter_totalUpper.ValueChanged += (s, e) =>
            {
                vehicleFilter.TotalKmUpper = (double)((NumericUpDown)s).Value;
                loadVehicleList();
            };

            date_vehicles_filter_tuvLower.ValueChanged += (s, e) =>
            {
                vehicleFilter.TuvLower = ((DateTimePicker)s).Value;
                loadVehicleList();
            };
            date_vehicles_filter_tuvUpper.ValueChanged += (s, e) =>
            {
                vehicleFilter.TuvUpper = ((DateTimePicker)s).Value;
                loadVehicleList();
            };

            // EventListener für die CheckedChanged events der CheckBoxen der filter, setzt diese auf den Wert der Checkbox
            cb_vehicles_filter_toggleBuilding.CheckedChanged += (s, e) => { vehicleFilter.ToggleBuilding = ((CheckBox)s).Checked; loadVehicleList(); };
            cb_vehicles_filter_toggleTire.CheckedChanged += (s, e) => { vehicleFilter.ToggleTire = ((CheckBox)s).Checked; loadVehicleList(); };
            cb_vehicles_filter_toggleTotal.CheckedChanged += (s, e) => { vehicleFilter.ToggleTotal = ((CheckBox)s).Checked; loadVehicleList(); };
            cb_vehicles_filter_toggleTuv.CheckedChanged += (s, e) => { vehicleFilter.ToggleTuv = ((CheckBox)s).Checked; loadVehicleList(); };
            cb_vehicles_filter_toggleUsage.CheckedChanged += (s, e) => { vehicleFilter.ToggleUsage = ((CheckBox)s).Checked; loadVehicleList(); };

            // Löscht alle filter
            btn_vehicle_filter_reset.Click += (s, e) =>
            {
                combo_vehicles_filter_building.SelectedIndex = 0;
                combo_vehicles_filter_tire.SelectedIndex = 0;
                num_vehicles_filter_usage.Value = 0;
                num_vehicles_filter_totalLower.Value = 0;
                num_vehicles_filter_totalUpper.Value = 0;
                date_vehicles_filter_tuvLower.Value = DateTime.Today;
                date_vehicles_filter_tuvUpper.Value = DateTime.Today;
                cb_vehicles_filter_toggleBuilding.Checked = false;
                cb_vehicles_filter_toggleTire.Checked = false;
                cb_vehicles_filter_toggleTotal.Checked = false;
                cb_vehicles_filter_toggleTuv.Checked = false;
                cb_vehicles_filter_toggleUsage.Checked = false;
                tb_vehicles_filterText.Text = "";
            };
        }

        /// <summary>
        /// Gibt eine Auflistung aller Fahrzeuge zurück in Form von Vehicle Objecten
        /// </summary>
        /// <returns>Liste mit alles Fahrzeugen</returns>
        List<Vehicle> getAllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            OracleDataReader read = connection.GetResult("select * from taxi");
            while (read.Read())
            {
                Vehicle v = new Vehicle() {
                    NumberPlate = read["kennzeichen"].ToString().Split('-'),
                    BuildingId = int.Parse(read["gebaeude_id"].ToString()),
                    TireId = int.Parse(read["reifentyp_id"].ToString()),
                    Brand = read["marke"].ToString(),
                    TotalKm = double.Parse(read["kilometerstand"].ToString()),
                    Tuv = DateTime.Parse(read["tuv"].ToString()),
                    FuelUsage = double.Parse(read["verbrauch"].ToString()),
                    InUse = read["inverwendung"].ToString() == "0" ? false : true
                };
                vehicles.Add(v);
            }
            return vehicles;
        }

        /// <summary>
        /// Gibt das Fahrzeug zurück das dem Kennzeichen entspricht
        /// </summary>
        /// <param name="numberPlate">Fahrzeug Kennzeichen</param>
        /// <returns>Das passende Fahrzeug</returns>
        Vehicle getVehicle(string[] numberPlate)
        {
            Vehicle v = new Vehicle();

            OracleDataReader read = connection.GetResult("select * from taxi where kennzeichen = '" + string.Format("{0}-{1}-{2}'", numberPlate[0], numberPlate[1], numberPlate[2]));
            while (read.Read())
            {
                v = new Vehicle()
                {
                    NumberPlate = read["kennzeichen"].ToString().Split('-'),
                    BuildingId = int.Parse(read["gebaeude_id"].ToString()),
                    TireId = int.Parse(read["reifentyp_id"].ToString()),
                    Brand = read["marke"].ToString(),
                    TotalKm = double.Parse(read["kilometerstand"].ToString()),
                    Tuv = DateTime.Parse(read["tuv"].ToString()),
                    FuelUsage = double.Parse(read["verbrauch"].ToString()),
                    InUse = read["inverwendung"].ToString() == "0" ? false : true
                };
            }
            return v;
        }

        /// <summary>
        /// Läd alle Fahrzeuge in die view_vehicle
        /// </summary>
        void loadVehicleList()
        {
            view_vehicles.Items.Clear();

            foreach (var v in getAllVehicles())
            {
                ListViewItem lvi = new ListViewItem(v.NumberPlateString);

                // Läd den text der zu der GebäudeId gehört
                string garage = "";
                OracleDataReader read2 = connection.GetResult("select * from gebaeude where gebaeude_id = " + v.BuildingId);
                while (read2.Read())
                {
                    garage = string.Format("{0}, {1}", read2["name"], read2["strasse"]);
                }
                read2.Close();

                lvi.SubItems.Add(garage);

                // Läd den text der zu der ReifenId gehört
                string tire = "";
                OracleDataReader read3 = connection.GetResult("select * from reifentyp where reifentyp_id = " + v.TireId);
                while (read3.Read())
                {
                    tire = string.Format("{0}", read3["reifentyp"]);
                }
                read3.Close();

                lvi.SubItems.Add(tire);

                lvi.SubItems.Add(v.Brand);
                lvi.SubItems.Add(v.TotalKm + " km");
                lvi.SubItems.Add(v.Tuv.ToShortDateString());
                lvi.SubItems.Add(v.FuelUsage + " l");
                lvi.SubItems.Add(v.InUse ? "Ja" : "Nein");

                // Fügt das Listenelement hinzu wenn alle Filter durchgehen
                if (vehicleFilter.MatchesFilters(v))
                {
                    view_vehicles.Items.Add(lvi);
                }
            }
        }

        /// <summary>
        /// Macht das erstellen oder bearbeiten eines Fahrzeugs möglich.
        /// </summary>
        /// <param name="v">Das zu bearbeitende Fahrzeug; Wenn ein leeres Fahrzeug übergeben wird, erstellt man ein neues Fahrzeug.</param>
        void editVehicle(Vehicle v)
        {
            // Deaktiviert das bearbeiten des Nummernschilds, wenn das Fahrzeug schon existiert
            if (v.NumberPlateString.Length > 5)
            {
                tb_vehicles_numPlate_p1.Enabled = false;
                tb_vehicles_numPlate_p2.Enabled = false;
                tb_vehicles_numPlate_p3.Enabled = false;
            }
            else
            {
                tb_vehicles_numPlate_p1.Enabled = true;
                tb_vehicles_numPlate_p2.Enabled = true;
                tb_vehicles_numPlate_p3.Enabled = true;
            }

            // Fügt alle vorhandenen Daten in die Steuerelemente ein
            tb_vehicles_numPlate_p1.Text = v.NumberPlate[0];
            tb_vehicles_numPlate_p2.Text = v.NumberPlate[1];
            tb_vehicles_numPlate_p3.Text = v.NumberPlate[2];
            tb_vehicles_brand.Text = v.Brand;
            num_vehicles_totalDist.Value = (decimal)v.TotalKm;
            date_vehicles_tuv.Value = v.Tuv;
            num_vehicles_usage.Value = (decimal)v.FuelUsage;

            // Füllt die ComboBox mit alles verfügbaren Werten die einer Garage entsprechen
            combo_vehicles_garage.Items.Clear();
            OracleDataReader read = connection.GetResult("select * from gebaeude where name = 'Garage'");
            while (read.Read())
            {
                ComboBoxItem cbi = new ComboBoxItem(string.Format("{0}, {1}", read["name"], read["strasse"]), int.Parse(read["gebaeude_id"].ToString()));
                combo_vehicles_garage.Items.Add(cbi);
                if (v.BuildingId == int.Parse(read["gebaeude_id"].ToString())) combo_vehicles_garage.SelectedIndex = combo_vehicles_garage.Items.Count - 1;
            }
            read.Close();
            // Ähnlich wie Z. 111
            combo_vehicles_garage.SelectedIndex = combo_vehicles_garage.SelectedIndex < 0 ? 0 : combo_vehicles_garage.SelectedIndex;

            combo_vehicles_tireType.Items.Clear();
            OracleDataReader read2 = connection.GetResult("select * from reifentyp");
            while (read2.Read())
            {
                ComboBoxItem cbi = new ComboBoxItem(read2["reifentyp"].ToString(), int.Parse(read2["reifentyp_id"].ToString()));
                combo_vehicles_tireType.Items.Add(cbi);
                if (v.TireId == int.Parse(read2["reifentyp_id"].ToString())) combo_vehicles_tireType.SelectedIndex = combo_vehicles_tireType.Items.Count - 1;
            }
            read2.Close();
            combo_vehicles_tireType.SelectedIndex = combo_vehicles_tireType.SelectedIndex < 0 ? 0 : combo_vehicles_tireType.SelectedIndex;

            // Zeigt das Ausgefüllte Formularpanel an
            panel_vehicles_form.Show();
        }

        /// <summary>
        /// Schreibt das neue Fahrzeug oder die gemachten änderungen in die Datenbank
        /// </summary>
        /// <param name="v">Das zu persistierende Fahrzeug</param>
        void persistVehicle(Vehicle v)
        {
            OracleDataReader readNum = connection.GetResult("select * from taxi where kennzeichen = '" + v.NumberPlateString + "'");
            // Prüft ob das Element schon vorhanden ist
            if (readNum.HasRows)
            {
                string cmd = string.Format("update taxi set " +
                    "gebaeude_id = {0}, " +
                    "reifentyp_id = {1}, " +
                    "marke = '{2}', " +
                    "kilometerstand = {3}, " +
                    "tuv = '{4}', " +
                    "verbrauch = {5}, " +
                    "inverwendung = {6} " +
                    "where kennzeichen = '{7}'", 
                    v.BuildingId, 
                    v.TireId, 
                    v.Brand, 
                    v.TotalKm.ToString().Replace(",", "."), 
                    v.Tuv.ToString("dd.MM.yy"), 
                    v.FuelUsage.ToString().Replace(",", "."), 
                    v.InUse ? 1 : 0, 
                    v.NumberPlateString);
                connection.SendStatement(cmd);
            }
            else
            {
                string cmd = string.Format("insert into taxi values('{0}', {1}, {2}, '{3}', {4}, '{5}', {6}, {7})",
                    v.NumberPlateString,
                    v.BuildingId,
                    v.TireId,
                    v.Brand,
                    v.TotalKm.ToString().Replace(",", "."),
                    v.Tuv.ToString("dd.MM.yy"),
                    v.FuelUsage.ToString().Replace(",", "."),
                    v.InUse ? 1 : 0);
                connection.SendStatement(cmd);
            }
            panel_vehicles_form.Hide();
            loadVehicleList();
        }

        /// <summary>
        /// Entfernt das übergebene Fahrzeug aus der Datenbank
        /// </summary>
        /// <param name="v"></param>
        void removeVehicle(Vehicle v)
        {
            connection.SendStatement("delete from taxi where kennzeichen = '" + v.NumberPlateString + "'");
            panel_vehicles_form.Hide();
            loadVehicleList();
        }
        
        private void btn_vehicles_addVehicle_Click(object sender, EventArgs e)
        {
            // Ruft die edit-MEthode mit einem Leeren Fahrzeug auf um einenues hinzuzufügen
            editVehicle(new Vehicle());
        }

        private void context_vehicles_editEntry_Click(object sender, EventArgs e)
        {
            // Wenn ein Element in der Liste ausgewählt ist, wird das zu gearbeitende Element aus der DB gezogen und zum editieren eingegeben
            if (view_vehicles.SelectedItems.Count > 0)
            {
                string numberPlate = view_vehicles.SelectedItems[0].Text;
                editVehicle(getVehicle(numberPlate.Split('-')));
            }
        }

        private void context_vehicles_deleteEntry_Click(object sender, EventArgs e)
        {
            if (view_vehicles.SelectedItems.Count > 0) removeVehicle(getVehicle(view_vehicles.SelectedItems[0].Text.Split('-')));
        }

        private void btn_vehicles_filterExpand_Click(object sender, EventArgs e)
        {
            loadFilterComboBoxData();
            loadVehicleList();
            resizeBottomPanel(ref vehiclesFilterExpanded, panel_vehicles_layoutBottom, btn_vehicles_filterExpand, 128);
        }

        private void tb_vehicles_filterText_TextChanged(object sender, EventArgs e)
        {
            vehicleFilter.VagueFilter = tb_vehicles_filterText.Text;
            loadVehicleList();
        }

        private void view_vehicles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (view_vehicles.SelectedItems.Count > 0)
            {
                string numberPlate = view_vehicles.SelectedItems[0].Text;
                editVehicle(getVehicle(numberPlate.Split('-')));
            }
        }

        private void btn_vehicles_formHide_Click(object sender, EventArgs e)
        {
            panel_vehicles_form.Hide();
        }

        private void btn_vehicles_formSave_Click(object sender, EventArgs e)
        {
            // Speichert alle einegegeben Werte in einem Vehicle Objekt und prüft vorher alle eingaben und setzt sie ggf. auf Default Werte
            Vehicle v = new Vehicle();
            v.NumberPlate[0] = tb_vehicles_numPlate_p1.Text.Length <= 0 ? "GÖ" : tb_vehicles_numPlate_p1.Text;
            v.NumberPlate[1] = tb_vehicles_numPlate_p2.Text.Length <= 0 ? "AA" : tb_vehicles_numPlate_p2.Text;
            v.NumberPlate[2] = tb_vehicles_numPlate_p3.Text.Length <= 0 ? "1" : tb_vehicles_numPlate_p3.Text;
            v.Brand = tb_vehicles_brand.Text.Length <= 0 ? "NaN" : tb_vehicles_brand.Text;
            v.TotalKm = (double)num_vehicles_totalDist.Value;
            v.FuelUsage = (double)num_vehicles_usage.Value;
            v.Tuv = date_vehicles_tuv.Value;
            v.BuildingId = (int)((ComboBoxItem)combo_vehicles_garage.SelectedItem).Value;
            v.TireId = (int)((ComboBoxItem)combo_vehicles_tireType.SelectedItem).Value;

            persistVehicle(v);
        }

        private void btn_vehicle_reloadList_Click(object sender, EventArgs e)
        {
            loadVehicleList();
        }

        #endregion
        #region Bestellungen

        //////////////////////////////////
        //                              //
        //         Bestellungen         //
        //                              //
        //////////////////////////////////

        /// <summary>
        /// Initialisiert die Bestellungen-liste,
        /// Sämtliche änderungs-Events der Filter-Feld-Schalter
        /// und die Mitarbeiten-Namens-Anzeige im Bearbeiten-Panel
        /// </summary>
        void initializeOrderData()
        {
            // Fügt das ValueChanged Element zur Kundennummer Eingabe hinzu und ändert den Text der TextBox dahinter auf den Kunden namen
            num_orders_customerId.ValueChanged += (s, e) =>
            {
                OracleDataReader read = connection.GetResult("select * from kunde where kunden_id = " + (int)((NumericUpDown)s).Value);
                if (!read.HasRows) tb_orders_customerData.Text = "< Kunde nicht vorhanden! >";
                while (read.Read())
                {
                    tb_orders_customerData.Text = string.Format("{0} {1}", read["vorname"], read["nachname"]);
                }
            };

            num_orders_filter_customer.ValueChanged += (s, e) => {
                orderFilter.CustomerId = (int)((NumericUpDown)s).Value;
                if (cb_orders_filter_customerId.Checked) loadOrderList();
            };
            num_orders_filter_driver.ValueChanged += (s, e) => {
                orderFilter.EmpId = (int)((NumericUpDown)s).Value;
                if (cb_orders_filter_driverId.Checked) loadOrderList();
            };
            tb_orders_filter_numPlate.TextChanged += (s, e) => {
                orderFilter.VehicleNum = ((TextBox)s).Text;
                if (cb_orders_filter_numPlate.Checked) loadOrderList();
            };
            num_orders_filter_distanceFrom.ValueChanged += (s, e) => {
                orderFilter.DistanceFrom = (double)((NumericUpDown)s).Value;
                if (cb_orders_filter_distance.Checked) loadOrderList();
            };
            num_orders_filter_distanceTo.ValueChanged += (s, e) => {
                orderFilter.DistanceTo = (double)((NumericUpDown)s).Value;
                if (cb_orders_filter_distance.Checked) loadOrderList();
            };
            num_orders_filter_amountFrom.ValueChanged += (s, e) => {
                orderFilter.AmountFrom = (double)((NumericUpDown)s).Value;
                if (cb_orders_filter_amount.Checked) loadOrderList();
            };
            num_orders_filter_amountTo.ValueChanged += (s, e) => {
                orderFilter.AmountTo = (double)((NumericUpDown)s).Value;
                if (cb_orders_filter_amount.Checked) loadOrderList();
            };
            tb_orders_filter_durationFrom.TextChanged += (s, e) => {
                orderFilter.DurationFromString = ((MaskedTextBox)s).Text;
                if (cb_orders_filter_duration.Checked) loadOrderList();
            };
            tb_orders_filter_durationTo.TextChanged += (s, e) => {
                orderFilter.DurationToString = ((MaskedTextBox)s).Text;
                if (cb_orders_filter_duration.Checked) loadOrderList();
            };
            date_orders_filter_from.ValueChanged += (s, e) => {
                orderFilter.DateFrom = ((DateTimePicker)s).Value;
                if (cb_orders_filter_date.Checked) loadOrderList();
            };
            date_orders_filter_to.ValueChanged += (s, e) => {
                orderFilter.DateTo = ((DateTimePicker)s).Value;
                if (cb_orders_filter_date.Checked) loadOrderList();
            };


            cb_orders_filter_amount.CheckedChanged += (s, e) =>     { orderFilter.ToggleAmount = ((CheckBox)s).Checked; loadOrderList(); };
            cb_orders_filter_customerId.CheckedChanged += (s, e) => { orderFilter.ToggleCustomerId = ((CheckBox)s).Checked; loadOrderList(); };
            cb_orders_filter_date.CheckedChanged += (s, e) =>       { orderFilter.ToggleDate = ((CheckBox)s).Checked; loadOrderList(); };
            cb_orders_filter_distance.CheckedChanged += (s, e) =>   { orderFilter.ToggleDistance = ((CheckBox)s).Checked; loadOrderList(); };
            cb_orders_filter_driverId.CheckedChanged += (s, e) =>   { orderFilter.ToggleEmpId = ((CheckBox)s).Checked; loadOrderList(); };
            cb_orders_filter_duration.CheckedChanged += (s, e) =>   { orderFilter.ToggleDuration = ((CheckBox)s).Checked; loadOrderList(); };
            cb_orders_filter_numPlate.CheckedChanged += (s, e) =>   { orderFilter.ToggleVehicleNum = ((CheckBox)s).Checked; loadOrderList(); };


            loadOrderList();
        }

        /// <summary>
        /// Schreibt die Bestellungsdaten in die Datenbank.
        /// </summary>
        /// <param name="o">Die BEstellung die in die Datenbank zu persistieren ist.</param>
        void persistOrder(Order o)
        {
            OracleDataReader readCheck = connection.GetResult("select * from taxibestellung where bestellung_id = " + o.Id);
            if (readCheck.HasRows)
            {
                string cmd = string.Format("update taxibestellung set " +
                    "kunden_id = {0}, " +
                    "personal_id = {1}, " +
                    "taxi_kennzeichen = '{2}', " +
                    "abholort = '{3}', " +
                    "abholstrasse = '{4}', " +
                    "zielort = '{5}', " +
                    "zielstrasse = '{6}', " +
                    "datum = '{7}', " +
                    "entfernung = {8}, " +
                    "fahrtdauer = {9}, " +
                    "betrag = {10} " +
                    "where bestellung_id = {11}", 
                    o.CustomerId,
                    o.EmpId,
                    o.VehicleNum,
                    o.StartPoint,
                    o.StartStreet,
                    o.DestPoint,
                    o.DestStreet,
                    o.Date.ToString("dd.MM.yy"),
                    o.Distance.ToString().Replace(",", "."),
                    o.Duration,
                    o.Amount.ToString().Replace(",", "."),
                    o.Id);
                connection.SendStatement(cmd);
            }
            else
            {
                string cmd = string.Format("insert into taxibestellung(" +
                    "kunden_id, " +
                    "personal_id, " +
                    "taxi_kennzeichen, " +
                    "abholort, " +
                    "abholstrasse, " +
                    "zielort, " +
                    "zielstrasse, " +
                    "datum, " +
                    "entfernung, " +
                    "fahrtdauer, " +
                    "betrag) values({0},{1},'{2}','{3}','{4}','{5}','{6}','{7}',{8},{9},{10})",
                    o.CustomerId,
                    o.EmpId,
                    o.VehicleNum,
                    o.StartPoint,
                    o.StartStreet,
                    o.DestPoint,
                    o.DestStreet,
                    o.Date.ToString("dd.MM.yy"),
                    o.Distance.ToString().Replace(",", "."),
                    o.Duration,
                    o.Amount.ToString().Replace(",", "."));
                connection.SendStatement(cmd);
            }
            panel_orders_form.Hide();
        }

        /// <summary>
        /// Gibt die zur Bestellnummer passende Bestellung zurück.
        /// </summary>
        /// <param name="order_id">Die Bestellungs ID</param>
        /// <returns>Die passende Bestellung</returns>
        Order getOrder(int order_id)
        {
            Order o = new Order();
            OracleDataReader read = connection.GetResult("select * from taxibestellung where bestellung_id = " + order_id);
            while (read.Read())
            {
                o = new Order()
                {
                    Id = int.Parse(read["bestellung_id"].ToString()),
                    CustomerId = int.Parse(read["kunden_id"].ToString()),
                    EmpId = int.Parse(read["personal_id"].ToString()),
                    VehicleNum = read["taxi_kennzeichen"].ToString(),
                    StartPoint = read["abholort"].ToString(),
                    StartStreet = read["abholstrasse"].ToString(),
                    DestPoint = read["zielort"].ToString(),
                    DestStreet = read["zielstrasse"].ToString(),
                    Date = DateTime.Parse(read["datum"].ToString()),
                    Distance = double.Parse(read["entfernung"].ToString()),
                    Duration = int.Parse(read["fahrtdauer"].ToString()),
                    Amount = double.Parse(read["betrag"].ToString())
                };
            }
            return o;
        }

        /// <summary>
        /// Gibt eine Auflistung aller Bestellungen zurück in form einer Liste aus Order Objekten
        /// </summary>
        /// <returns>Die Order-Liste</returns>
        List<Order> getAllOrders()
        {
            List<Order> list = new List<Order>();
            OracleDataReader read = connection.GetResult("select * from taxibestellung order by bestellung_id asc");
            while (read.Read())
            {
                Order o = new Order()
                {
                    Id = int.Parse(read["bestellung_id"].ToString()),
                    CustomerId = int.Parse(read["kunden_id"].ToString()),
                    EmpId = int.Parse(read["personal_id"].ToString()),
                    VehicleNum = read["taxi_kennzeichen"].ToString(),
                    StartPoint = read["abholort"].ToString(),
                    StartStreet = read["abholstrasse"].ToString(),
                    DestPoint = read["zielort"].ToString(),
                    DestStreet = read["zielstrasse"].ToString(),
                    Date = DateTime.Parse(read["datum"].ToString()),
                    Distance = double.Parse(read["entfernung"].ToString()),
                    Duration = int.Parse(read["fahrtdauer"].ToString()),
                    Amount = double.Parse(read["betrag"].ToString())
                };
                list.Add(o);
            }
            return list;
        }

        /// <summary>
        /// Macht das erstellen oder bearbeiten einer Bestellung möglich.
        /// </summary>
        /// <param name="o">Die zu bearbeitende Bestellung; Wenn eine leere Bestellung übergeben wird, erstellt man eine neue.</param>
        void editOrder(Order o)
        {
            combo_orders_driver.Items.Clear();
            combo_orders_vehicle.Items.Clear();

            if (o.Id > 0)
            {
                lbl_orders_numberText.Show();
                lbl_orders_number.Show();
                lbl_orders_number.Text = o.Id.ToString();
            }
            else
            {
                lbl_orders_number.Hide();
                lbl_orders_numberText.Hide();
            }
            OracleDataReader read = connection.GetResult("select count(*) from kunde");
            while (read.Read()) { num_orders_customerId.Maximum = int.Parse(read[0].ToString()); }
            if (o.CustomerId > 0) num_orders_customerId.Value = o.CustomerId;
            else num_orders_customerId.Value = 1;

            OracleDataReader read_drivers = connection.GetResult("select * from personal where TAETIGKEIT_ID = 1");
            while (read_drivers.Read()) {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Text = string.Format("{0}: {1} {2}", read_drivers["personal_id"], read_drivers["vorname"], read_drivers["nachname"]);
                cbi.Value = int.Parse(read_drivers["personal_id"].ToString());
                combo_orders_driver.Items.Add(cbi);
                if ((int)cbi.Value == o.EmpId) combo_orders_driver.SelectedIndex = combo_orders_driver.Items.Count - 1;
            }
            if (combo_orders_driver.Items.Count > 0 && combo_orders_driver.SelectedIndex <= 0) combo_orders_driver.SelectedIndex = 0;

            OracleDataReader read_vehicle = connection.GetResult("select * from taxi");
            while (read_vehicle.Read())
            {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Text = string.Format("{0}  |  {1}", read_vehicle["kennzeichen"], read_vehicle["marke"]);
                cbi.Value = read_vehicle["kennzeichen"].ToString();
                combo_orders_vehicle.Items.Add(cbi);
                if ((string)cbi.Value == o.VehicleNum) combo_orders_vehicle.SelectedIndex = combo_orders_vehicle.Items.Count - 1;
            }
            if (combo_orders_vehicle.Items.Count > 0 && combo_orders_vehicle.SelectedIndex <= 0) combo_orders_vehicle.SelectedIndex = 0;

            tb_orders_startPoint.Text = o.StartPoint;
            tb_orders_startStreet.Text = o.StartStreet;
            tb_orders_destPoint.Text = o.DestPoint;
            tb_orders_destStreet.Text = o.DestStreet;
            date_orders_date.Value = o.Date;
            num_orders_distance.Value = (decimal)o.Distance;
            tb_orders_duration.Text = o.DurationString;
            Console.WriteLine(o.DurationString);
            num_orders_amount.Value = (decimal)o.Amount;

            panel_orders_form.Show();
        }

        /// <summary>
        /// Läd alle vorhandenen Bestellungen in die view_orders
        /// </summary>
        void loadOrderList()
        {
            view_orders.Items.Clear();

            foreach (var o in getAllOrders())
            {
                ListViewItem lvi = new ListViewItem(o.Id.ToString());

                lvi.Tag = o.Id;

                lvi.SubItems.Add(o.CustomerId.ToString());
                string driver = "";
                OracleDataReader read2 = connection.GetResult("select * from personal where personal_id = " + o.EmpId);
                while (read2.Read())
                {
                    driver = string.Format("{0} {1}", read2["vorname"], read2["nachname"]);
                }
                read2.Close();

                lvi.SubItems.Add(driver);
                lvi.SubItems.Add(o.VehicleNum);
                lvi.SubItems.Add(o.StartPoint);
                lvi.SubItems.Add(o.StartStreet);
                lvi.SubItems.Add(o.DestPoint);
                lvi.SubItems.Add(o.DestStreet);
                lvi.SubItems.Add(o.Date.ToShortDateString());
                lvi.SubItems.Add(o.Distance + " km");
                lvi.SubItems.Add(o.DurationString);
                lvi.SubItems.Add(o.Amount + " €");
                
                if (orderFilter.MatchesFilters(o))
                {
                    view_orders.Items.Add(lvi);
                }
            }
        }

        /// <summary>
        /// Entfernt die Bestellung die zur Bestellnummer passt
        /// </summary>
        /// <param name="order_id">Die Bestellnummer der zu entfernenden Bestellung</param>
        void removeOrder(int order_id)
        {
            connection.SendStatement("delete from taxibestellung where bestellung_id = " + order_id);
            panel_orders_form.Hide();
            loadOrderList();
        }

        private void btn_orders_addOrder_Click(object sender, EventArgs e)
        {
            editOrder(new Order());
        }

        private void context_orders_editOrder_Click(object sender, EventArgs e)
        {
            if (view_orders.SelectedItems.Count > 0) editOrder(getOrder((int)view_orders.SelectedItems[0].Tag));
        }

        private void context_orders_deleteOrder_Click(object sender, EventArgs e)
        {
            if (view_orders.SelectedItems.Count > 0) removeOrder((int)view_orders.SelectedItems[0].Tag);
        }

        private void context_orders_showCustomer_Click(object sender, EventArgs e)
        {
            if (view_orders.SelectedItems.Count > 0)
            {
                num_customer_filter_num.Value = int.Parse(view_orders.SelectedItems[0].SubItems[1].Text);
                cb_customer_filterId.Checked = true;
                tc_main.SelectedIndex = 2;
            }
        }

        private void btn_orders_filterExpand_Click(object sender, EventArgs e)
        {
            resizeBottomPanel(ref ordersFilterExpanded, panel_orders_layoutBottom, btn_orders_filterExpand, 162);
        }

        private void view_orders_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (view_orders.SelectedItems.Count > 0) editOrder(getOrder((int)view_orders.SelectedItems[0].Tag));
        }

        private void btn_orders_formSave_Click(object sender, EventArgs e)
        {
            Order o = new Order() {
                CustomerId = (int)num_orders_customerId.Value,
                EmpId = (int)((ComboBoxItem)combo_orders_driver.SelectedItem).Value,
                VehicleNum = (string)((ComboBoxItem)combo_orders_vehicle.SelectedItem).Value,
                Amount = (double)num_orders_amount.Value,
                Distance = (double)num_orders_distance.Value,
                Date = date_orders_date.Value,
                StartPoint = tb_orders_startPoint.Text,
                StartStreet = tb_orders_startStreet.Text,
                DestPoint = tb_orders_destPoint.Text,
                DestStreet = tb_orders_destStreet.Text,
                DurationString = tb_orders_duration.Text
            };

            if (lbl_orders_number.Visible) o.Id = int.Parse(lbl_orders_number.Text);
            persistOrder(o);
            loadOrderList();
        }

        private void btn_orders_formHide_Click(object sender, EventArgs e)
        {
            panel_orders_form.Hide();
        }

        private void tb_orders_filterText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                orderFilter.VagueString = tb_orders_filterText.Text;
                loadOrderList();
            }
        }

        private void btn_orders_refreshList_Click(object sender, EventArgs e)
        {
            loadOrderList();
        }

        #endregion
        #region Kundendaten

        //////////////////////////////////
        //                              //
        //         Kundendaten          //
        //                              //
        //////////////////////////////////

        /// <summary>
        /// Läd alle Kundendaten und initialisiert die Kundennummer-Filter und den Schalter dafür.
        /// </summary>
        void initializeCustomerData()
        {
            num_customer_filter_num.ValueChanged += (s, e) => {
                customerFilter.Id = (int)((NumericUpDown)s).Value;
                loadCustomerList();
            };
            cb_customer_filterId.CheckedChanged += (s, e) => {
                customerFilter.ToggleId = ((CheckBox)s).Checked;
                loadCustomerList();
            };

            loadCustomerList();
        }

        /// <summary>
        /// Gibt eine auflistung aller Kunden zurück
        /// </summary>
        /// <returns>Die Liste mit Customer Objekten</returns>
        List<Customer> getAllCustomers()
        {
            List<Customer> c = new List<Customer>();

            OracleDataReader read = connection.GetResult("select * from kunde");
            while (read.Read())
            {
                Customer cu = new Customer() {
                    Surname = read["vorname"].ToString(),
                    Lastname = read["nachname"].ToString(),
                    Number = int.Parse(read["kunden_id"].ToString()),
                    Phone = read["telefonnummer"].ToString()
                };
                c.Add(cu);
            }
            return c;
        }

        /// <summary>
        /// Gibt den Kudnen mit der angebenen Kundennummer zurück
        /// </summary>
        /// <param name="customer_id">Die Kundennummer</param>
        /// <returns>Der gewünschte Kunde</returns>
        Customer getCustomer(int customer_id)
        {
            Customer c = new Customer();

            OracleDataReader read = connection.GetResult("select * from kunde where kunden_id = " + customer_id);
            while (read.Read())
            {
                c = new Customer()
                {
                    Surname = read["vorname"].ToString(),
                    Lastname = read["nachname"].ToString(),
                    Number = int.Parse(read["kunden_id"].ToString()),
                    Phone = read["telefonnummer"].ToString()
                };
            }
            return c;
        }

        /// <summary>
        /// Läd alle Kundendaten in die view_customer
        /// </summary>
        void loadCustomerList()
        {
            view_customers.Items.Clear();
            foreach (var item in getAllCustomers())
            {
                ListViewItem lvi = new ListViewItem()
                {
                    Text = item.Number.ToString()
                };
                lvi.Tag = item.Number;
                lvi.SubItems.Add(item.Surname);
                lvi.SubItems.Add(item.Lastname);
                lvi.SubItems.Add(item.Phone);
                if(customerFilter.MatchesFilter(item)) view_customers.Items.Add(lvi);
            }
        }

        /// <summary>
        /// Speichert den übergebenen Kunden oder überschribt den Vorhandenen
        /// </summary>
        /// <param name="c">Der zu persistierende Kunde</param>
        void persistCustomer(Customer c)
        {
            OracleDataReader readNum = connection.GetResult("select * from kunde where kunden_id = " + c.Number);
            if (readNum.HasRows)
            {
                string cmd = string.Format("update kunde set " +
                    "vorname = '{0}', " +
                    "nachname = '{1}', " +
                    "telefonnummer = '{2}' " +
                    "where kunden_id = {3}",
                    c.Surname,
                    c.Lastname,
                    c.Phone,
                    c.Number);
                connection.SendStatement(cmd);
            }
            else
            {
                string cmd = string.Format("insert into kunde(vorname, nachname, telefonnummer) values('{0}', '{1}', '{2}')",
                    c.Surname,
                    c.Lastname,
                    c.Phone);
                connection.SendStatement(cmd);
            }
            panel_customer_form.Hide();
            lbl_customer_numberText.Hide();
            lbl_customer_numer.Hide();
            loadCustomerList();
        }

        /// <summary>
        /// Entfernt den Kunden enhand der Kudnennummer
        /// </summary>
        /// <param name="kunden_id">Die Kundennummer</param>
        void removeCustomer(int kunden_id)
        {
            string cmd = string.Format("delete from kunde where kunden_id = " + kunden_id);
            connection.SendStatement(cmd);
            loadCustomerList();
        }

        /// <summary>
        /// Bearbeitet den Kunden der übergeben wird
        /// </summary>
        /// <param name="c">Der Kunde der bearbeitet werden soll</param>
        void editCustomer(Customer c)
        {
            if (c.Number >= 0)
            {
                lbl_customer_numberText.Show();
                lbl_customer_numer.Show();
                lbl_customer_numer.Text = c.Number.ToString();
            }
            tb_customer_surname.Text = c.Surname;
            tb_customer_lastname.Text = c.Lastname;
            tb_customer_phone.Text = c.Phone;
            panel_customer_form.Show();
        }

        /// <summary>
        /// Öffnet das Fenter für das hinzufügen eines Kunden
        /// </summary>
        void addCustomer()
        {
            editCustomer(new Customer());
        }

        private void btn_customers_addCustomer_Click(object sender, EventArgs e)
        {
            addCustomer();
        }

        private void context_customer_editCustomer_Click(object sender, EventArgs e)
        {
            if (view_customers.SelectedItems.Count > 0)
            {
                ListViewItem lvi = view_customers.SelectedItems[0];
                editCustomer(getCustomer(int.Parse(lvi.Text)));
            }
        }

        private void context_customer_deleteCustomer_Click(object sender, EventArgs e)
        {
            if (view_customers.SelectedItems.Count > 0)
            {
                int id = (int)view_customers.SelectedItems[0].Tag;
                OracleDataReader read_orders = connection.GetResult("select * from taxibestellung where kunden_id = " + id);
                if (read_orders.HasRows) MessageBox.Show("Löschaktion nicht möglich! Es gibt noch Bestellungen die auf diesen Kunden verweisen!","Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else removeCustomer(id);
            }
        }

        private void tb_customer_filterText_TextChanged(object sender, EventArgs e)
        {
            customerFilter.VagueFilter = tb_customer_filterText.Text;
            loadCustomerList();
        }

        private void view_customers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (view_customers.SelectedItems.Count > 0)
            {
                ListViewItem lvi = view_customers.SelectedItems[0];
                editCustomer(getCustomer(int.Parse(lvi.Text)));
            }
        }

        private void btn_customer_reloadList_Click(object sender, EventArgs e)
        {
            loadCustomerList();
        }

        private void btn_customer_hideForm_Click(object sender, EventArgs e)
        {
            lbl_customer_numberText.Hide();
            lbl_customer_numer.Hide();
            panel_customer_form.Hide();
        }

        private void btn_customer_saveForm_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.Surname = tb_customer_surname.Text.Length <= 0 ? "NaN" : tb_customer_surname.Text;
            c.Lastname = tb_customer_lastname.Text.Length <= 0 ? "NaN" : tb_customer_lastname.Text;
            c.Phone = tb_customer_phone.Text.Length <= 0 ? "NaN" : tb_customer_phone.Text;
            if (lbl_customer_numer.Visible) c.Number = int.Parse(lbl_customer_numer.Text);
            persistCustomer(c);
        }

        private void context_customer_viewCustomerOrders_Click(object sender, EventArgs e)
        {
            if (view_customers.SelectedItems.Count > 0)
            {
                num_orders_filter_customer.Value = (int)view_customers.SelectedItems[0].Tag;
                cb_orders_filter_customerId.Checked = true;

                if (!ordersFilterExpanded) btn_orders_filterExpand_Click(btn_orders_filterExpand, new EventArgs());
                tc_main.SelectedIndex = 1;
            }
        }

        #endregion
        #region Berichte
        
        //////////////////////////////////
        //                              //
        //           Berichte           //
        //                              //
        //////////////////////////////////

        private void btn_reports_openOrders_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm(ReportsForm.ReportType.Orders, connection);
            rep.Show();
        }

        private void btn_reports_openCustomerInvoices_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm(ReportsForm.ReportType.CustomerInvoices, connection);
            rep.Show();
        }

        private void btn_reports_openCustomerData_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm(ReportsForm.ReportType.CustomerData, connection);
            rep.Show();
        }

        private void btn_reports_openVehicles_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm(ReportsForm.ReportType.VehicleData, connection);
            rep.Show();
        }

        private void btn_reports_openDayly_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm(ReportsForm.ReportType.DaylyReport, connection);
            rep.Show();
        }

        private void btn_reports_openWeekly_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm(ReportsForm.ReportType.WeeklyReport, connection);
            rep.Show();
        }

        #endregion
        #region Navigation
        private void btn_navigation_vehicles_Click(object sender, EventArgs e) => tc_main.SelectedIndex = 0;

        private void btn_navigation_orders_Click(object sender, EventArgs e) => tc_main.SelectedIndex = 1;

        private void btn_navigation_customers_Click(object sender, EventArgs e) => tc_main.SelectedIndex = 2;

        private void btn_navigation_reports_Click(object sender, EventArgs e) => tc_main.SelectedIndex = 3;

        private void tc_main_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Markiert die Ausgewählte TabSeite mit einem Rand um den Button
            btn_navigation_vehicles.FlatAppearance.BorderSize = tc_main.SelectedIndex == 0 ? 1 : 0;
            btn_navigation_orders.FlatAppearance.BorderSize = tc_main.SelectedIndex == 1 ? 1 : 0;
            btn_navigation_customers.FlatAppearance.BorderSize = tc_main.SelectedIndex == 2 ? 1 : 0;
            btn_navigation_reports.FlatAppearance.BorderSize = tc_main.SelectedIndex == 3 ? 1 : 0;
        }

        private void toolStip_btn_refresh_Click(object sender, EventArgs e)
        {
            // Läd all Tabellen neu
            loadVehicleList();
            loadOrderList();
            loadCustomerList();
        }
        #endregion
    }
}
