using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject_App
{
    public partial class ReportsForm : Form
    {
        /// <summary>
        /// Erstellt ein neues Report-Fomular mit dem gegebenen Typen und der Datenbankverbindung
        /// </summary>
        /// <param name="_type">Der zu zeigende Bericht</param>
        /// <param name="_conn">Die Datenbankverbindung</param>
        public ReportsForm(ReportType _type, OracleConnector _conn)
        {
            InitializeComponent();
            conn = _conn;
            type = _type;

            // Ruft die initialisierung der Tabelle auf
            initialize();
        }

        #region Variablen

        //
        // Variablen
        //

        // Die Datenbankschnittstelle
        OracleConnector conn;

        // Die Tabelle die gefüllt wird
        DataTable table;

        // Die ansicht die ggf. gefiltert oder sortiert wird
        DataView view;

        /// <summary>
        /// Enum um den richtigen Bericht-Typen mit dem Formular zu initialisieren
        /// </summary>
        public enum ReportType
        {
            Orders,
            CustomerInvoices,
            CustomerData,
            VehicleData,
            DaylyReport,
            WeeklyReport
        }

        ReportType type;

        #endregion
        #region Methoden

        //
        // Methoden
        //

        /// <summary>
        /// Zeichnet den Übergebenen DataTable auf das ListView und passt alle Speltenbreiten und beschriftungen automatisch an
        /// </summary>
        /// <param name="table"></param>
        void drawTable(DataTable table)
        {
            listView.Columns.Clear();
            listView.Items.Clear();

            // Graphics Objekt um die string-Breite zu messen
            Graphics g = Graphics.FromImage(new Bitmap(1, 1));

            List<int> colWidths = new List<int>();

            // Iteriert über die Spalten und weist sie dem ListView zu und legt die ersten werte für die breite jeder Spalte fest
            foreach (DataColumn item in table.Columns)
            {
                // Ersetzt alle vorkommen vom Word 'nummer' im Spaltennamen und ersetzt er durch ' #' um Platz zu sparen
                string colName = item.ColumnName.Replace("nummer", " #");

                // Fügt eine neue Spaltenbreite in die Liste anhand der MeasureSting Methode und addiert einen puffer von 10px
                colWidths.Add((int)g.MeasureString(colName, listView.Font).Width + 10);
                ColumnHeader ch = new ColumnHeader();
                ch.Text = colName;
                ch.Width = (int)g.MeasureString(colName, listView.Font).Width + 10;
                ch.Tag = item.ColumnName;
                listView.Columns.Add(ch);
            }

            // Iteriert über die Reihen im Table und trägt sie in die ListView ein. 
            // Erhöht zudem die Spaltenbreite falls der Text breiter als die jetzige Spalte ist
            foreach (DataRow row in table.Rows)
            {
                DateTime dateT = new DateTime();
                string text = "";

                // Falls der eintrag ein Datum ist auf die Verkürzte schreibweise Kürzen
                if (row.ItemArray[0].ToString().Contains("00:00:00"))
                {
                    dateT = DateTime.Parse(row.ItemArray[0].ToString());
                    text = dateT.ToShortDateString();
                }
                else
                {
                    text = row.ItemArray[0].ToString();
                }
                ListViewItem lvi = new ListViewItem(text);
                lvi.UseItemStyleForSubItems = false;

                // Prüft, ob der neue Zellentext größer als die vorhandene Spaltenbreite ist und passt diese ggf. an
                if ((int)g.MeasureString(text, listView.Font).Width > colWidths[0]) colWidths[0] = (int)g.MeasureString(text, listView.Font).Width + 7;

                for (int i = 1; i < row.ItemArray.Length; i++)
                {
                    dateT = new DateTime();
                    text = "";
                    // siehe Z. 94
                    if (row.ItemArray[i].ToString().Contains("00:00:00"))
                    {
                        dateT = DateTime.Parse(row.ItemArray[i].ToString());
                        text = dateT.ToShortDateString();
                    }
                    else
                    {
                        text = row.ItemArray[i].ToString();
                    }
                    lvi.SubItems.Add(text);

                    // Siehe Z. 107
                    if ((int)g.MeasureString(text, listView.Font).Width > colWidths[i]) colWidths[i] = (int)g.MeasureString(text, listView.Font).Width + 7;
                }
                listView.Items.Add(lvi);
            }

            // Weist die ggf. neuen Spaltenbereiten den Spalten zu
            for (int i = 0; i < listView.Columns.Count; i++)
            {
                listView.Columns[i].Width = colWidths[i];
            }

            // Gibt den vom Graphic Object verbrauchten Speicher frei
            g.Dispose();
        }

        /// <summary>
        /// Prüft ob das Datum bei der Eingabe Relevant ist und zeigt dementsprechend die Datums-Kontrollelemente an
        /// </summary>
        /// <param name="viewname">Der Name der View in der Datenbank</param>
        /// <param name="dateRelevant">Ist eine Spalte vorhanden die ein Datum enthält?</param>
        /// <param name="dateColName">Der Spaltenname des Datums, Standartmäßig 'Datum'</param>
        void loadData(string viewname, bool dateRelevant, string dateColName = "Datum")
        {
            view = table.DefaultView;
            if (dateRelevant)
            {
                date_from.Show();
                date_to.Show();
                lbl_dateText.Show();

                // Setzt den Filter der Ansicht auf die Bedingung, das das Datum zwischen den ausgewählten Grenzwerten sein muss
                view.RowFilter = string.Format(dateColName + " > '{0}' and " + dateColName + " < '{1}'", date_from.Value, date_to.Value);
            }
            
            // Zeichnet die Ansicht auf die ListView
            drawTable(view.ToTable());
        }

        /// <summary>
        /// Prüft ob das Datum bei der Eingabe Relevant ist und zeigt dementsprechend die Datums-Kontrollelemente an.
        /// Initialisiert zudem die Klickevents für die Spalten-Header
        /// </summary>
        /// <param name="viewname">Der Name der View in der Datenbank</param>
        /// <param name="dateRelevant">Ist eine Spalte vorhanden die ein Datum enthält?</param>
        /// <param name="dateColName">Der Spaltenname des Datums, Standartmäßig 'Datum'</param>
        void loadDataCreateEvent(string viewname, bool dateRelevant, string dateColName = "Datum")
        {
            table = conn.GetResultTable("select * from " + viewname);
            view = table.DefaultView;
            if (dateRelevant)
            {
                date_from.Show();
                date_to.Show();
                lbl_dateText.Show();
                cb_toggleRange.Hide();
                view.RowFilter = string.Format(dateColName + " > '{0}' and "+ dateColName + " < '{1}'", date_from.Value, date_to.Value);
            }
            else
            {
                date_from.Hide();
                date_to.Hide();
                lbl_dateText.Hide();
                cb_toggleRange.Hide();
            }
            
            drawTable(view.ToTable());

            // Fügt dynamisch für jede Spalte ein ColumnClick Event hinzu und sortiert die Spalten beim Auslösen aufsteigend
            listView.ColumnClick += (s, e) =>
            {
                view = table.DefaultView;
                view.Sort = listView.Columns[e.Column].Tag + " asc";
                drawTable(view.ToTable());
            };
        }

        /// <summary>
        /// Geht über alle Zellen des ListViews und färbt die entsprechend des Inhalts & der Spalte
        /// </summary>
        void paintCells()
        {
            foreach (ColumnHeader col in listView.Columns)
            {
                if (col.Text.ToLower().Contains("kosten") || col.Text.ToLower().Contains("ausgaben"))
                {
                    foreach (ListViewItem item in listView.Items)
                    {
                        item.SubItems[col.DisplayIndex].ForeColor = Color.Red;
                    }
                }else if (col.Text.ToLower().Contains("einnahmen"))
                {
                    foreach (ListViewItem item in listView.Items)
                    {
                        item.SubItems[col.DisplayIndex].ForeColor = Color.Green;
                    }
                }
                else if (col.Text.ToLower().Contains("umsatz"))
                {
                    foreach (ListViewItem item in listView.Items)
                    {
                        double d = double.Parse(item.SubItems[col.DisplayIndex].Text);
                        if (d >= 0) item.SubItems[col.DisplayIndex].ForeColor = Color.Green;
                        else item.SubItems[col.DisplayIndex].ForeColor = Color.Red;

                    }
                }
            }
        }

        /// <summary>
        /// Initialisierungs-Methode zum ersten Laden der Tabellendaten
        /// </summary>
        void initialize()
        {
            date_from.Value = DateTime.Today;
            date_to.Value = DateTime.Today.AddYears(2);
            switch (type)
            {
                case ReportType.Orders:
                    Text = "Bestellungen";
                    loadDataCreateEvent("bestellungen", true);
                    break;
                case ReportType.CustomerInvoices:
                    Text = "Kundenrechnungen";
                    loadDataCreateEvent("rechnungen", true);
                    break;
                case ReportType.CustomerData:
                    Text = "Kundendaten";
                    loadDataCreateEvent("kundendaten", false);
                    break;
                case ReportType.VehicleData:
                    Text = "Fuhrpark";
                    loadDataCreateEvent("fuhrparkdaten", true, "TÜV");
                    break;
                case ReportType.DaylyReport:
                    Text = "Tägliche Kostenkalkulation";

                    // Datenladen für den täglichen Bericht exklusiv zu den anderen da geringfügig andere Prozesse durchgeführt werden müssen

                    lbl_dateText.Hide();
                    date_to.Enabled = false;
                    date_to.Hide();
                    cb_toggleRange.Show();

                    table = conn.GetResultTable("select * from taeglichekalk");
                    view = table.DefaultView;
                    view.RowFilter = string.Format("Datum = '{0}'", date_from.Value);
                    
                    drawTable(view.ToTable());

                    // Schaltet das Filtern nach Daten und den Bereichsfilter um
                    cb_toggleRange.CheckedChanged += (s, e) =>
                    {
                        date_to.Visible = cb_toggleRange.Checked;
                        date_to.Enabled = cb_toggleRange.Checked;
                        lbl_dateText.Visible = cb_toggleRange.Checked;

                        if (cb_toggleRange.Checked)
                        {
                            view = table.DefaultView;
                            view.RowFilter = string.Format("Datum > '{0}' and Datum < '{1}'", date_from.Value, date_to.Value);
                            drawTable(view.ToTable());
                        }
                    };
                    listView.ColumnClick += (s, e) =>
                    {
                        view = table.DefaultView;
                        view.Sort = listView.Columns[e.Column].Tag + " asc";
                        drawTable(view.ToTable());
                    };
                    paintCells();
                    break;
                case ReportType.WeeklyReport:
                    Text = "Wöchentliche Kostenkalkulation";

                    // Datenladen für den wöchentlichen Bericht exklusiv zu den anderen da geringfügig andere Prozesse durchgeführt werden müssen

                    lbl_dateText.Hide();
                    date_to.Enabled = false;
                    date_to.Hide();
                    cb_toggleRange.Show();

                    table = conn.GetResultTable("select * from woechentlichekalk");
                    view = table.DefaultView;
                    view.RowFilter = string.Format("Woche_von < '{0}' and Woche_bis > '{0}'", date_from.Value);

                    drawTable(view.ToTable());

                    // Schaltet das Filtern nach Daten und den Bereichsfilter um
                    cb_toggleRange.CheckedChanged += (s, e) =>
                    {
                        date_to.Visible = cb_toggleRange.Checked;
                        date_to.Enabled = cb_toggleRange.Checked;
                        lbl_dateText.Visible = cb_toggleRange.Checked;

                        if (cb_toggleRange.Checked)
                        {
                            view = table.DefaultView;
                            view.RowFilter = string.Format("Woche_von > '{0}' and Woche_bis < '{1}'", date_from.Value, date_to.Value);
                            drawTable(view.ToTable());
                        }
                    };
                    listView.ColumnClick += (s, e) =>
                    {
                        view = table.DefaultView;
                        view.Sort = listView.Columns[e.Column].Tag + " asc";
                        drawTable(view.ToTable());
                    };
                    paintCells();
                    break;
            }
        }

        /// <summary>
        /// Aktualisiert die ListView falls ein Spalten-Header angeklickt wurde oder wenn nach Daten gefiltert wird
        /// </summary>
        void refresh()
        {
            if (table != null)
            {
                switch (type)
                {
                    case ReportType.Orders:

                        loadData("bestellungen", true);
                        break;
                    case ReportType.CustomerInvoices:
                        loadData("rechnungen", true);
                        break;
                    case ReportType.CustomerData:
                        loadData("kundendaten", false);
                        break;
                    case ReportType.VehicleData:
                        loadData("fuhrparkdaten", true, "TÜV");
                        break;
                    case ReportType.DaylyReport:
                        table = conn.GetResultTable("select * from taeglichekalk");
                        view = table.DefaultView;
                        if (!cb_toggleRange.Checked) view.RowFilter = string.Format("Datum = '{0}'", date_from.Value);
                        else view.RowFilter = string.Format("Datum > '{0}' and Datum < '{1}'", date_from.Value, date_to.Value);
                        drawTable(view.ToTable());
                        paintCells();
                        break;
                    case ReportType.WeeklyReport:
                        table = conn.GetResultTable("select * from woechentlichekalk");
                        view = table.DefaultView;
                        if (!cb_toggleRange.Checked) view.RowFilter = string.Format("Woche_von < '{0}' and Woche_bis > '{0}'", date_from.Value);
                        else view.RowFilter = string.Format("Woche_von > '{0}' and Woche_bis < '{1}'", date_from.Value, date_to.Value);
                        drawTable(view.ToTable());
                        paintCells();
                        break;
                }
            }
        }

        #endregion
        #region Generierte Methoden

        private void date_from_ValueChanged(object sender, EventArgs e) => refresh();

        #endregion
    }
}
