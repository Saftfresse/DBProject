using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject_App
{
    /// <summary>
    /// Die Datenbankschnittstelle um mit der DB zu kommunizieren
    /// </summary>
    public class OracleConnector
    {
        /// <summary>
        /// Das Connection Object welches die direkte Schnittstelle darstellt
        /// </summary>
        OracleConnection conn;

        public OracleConnector()
        {
            //Initialisiert die Verbindung mit den gegebenen Werten in Connection-String
            conn = new OracleConnection("DATA SOURCE=172.16.200.30:1522/bbs2orcl;PASSWORD=Gruppe3;USER ID=TAXI");

            // Öffnet die Verbindung
            conn.Open();
        }

        /// <summary>
        /// Gibt das ergebnis der Abfrage als OracleDataReader zurück
        /// </summary>
        /// <param name="query">Die Abfrage</param>
        /// <returns>Das Reader Objekt</returns>
        public OracleDataReader GetResult(string query)
        {
            OracleCommand com = new OracleCommand(query, conn);
            com.CommandType = CommandType.Text;
            return com.ExecuteReader();
        }

        /// <summary>
        /// Gibt das ergebnis der Abfrage als DataTable Objekt zurück
        /// </summary>
        /// <param name="query">Die Abfrage</param>
        /// <returns>Ein DataTable Objekt das mit den Werten gefüllt wurde</returns>
        public DataTable GetResultTable(string query)
        {
            OracleDataAdapter oda = new OracleDataAdapter(query, conn);
            DataTable dt = new DataTable();
            // Füllt das dt DataTable Object mit dem Inhalt der oda Abfrage
            oda.Fill(dt);
            return dt;
        }

        /// <summary>
        /// Sendet einen Befehl an die Datenbank
        /// </summary>
        /// <param name="statement">Der Befehl</param>
        public void SendStatement(string statement)
        {
            OracleCommand cmd = new OracleCommand(statement, conn);
            cmd.ExecuteNonQuery();
        }
    }
}
