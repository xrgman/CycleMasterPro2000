using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Network;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Graph
    {
        // Bijbehorende gebruiker
        public Session session { get; private set; }

        // Wat laat de grafiek zien
        private SearchTypes CurrentSearchType { get; set; }

        public enum SearchTypes
        {
            DEFAULT,
            BETWEEN_VALUES,
            BETWEEN_DATES
        }

        public Graph()
        {
            InitializeComponent();
            CurrentSearchType = SearchTypes.DEFAULT;       // Standaard plotten (Wachten op signalen)
            setup();
        }

        public void setSession(Session s)
        {
            this.session = s;
            CurrentSearchType = SearchTypes.DEFAULT;
            plot();
        }

        // Initiele opzet van de chart
        public void plot()
        {
            foreach (Series obj in chart1.Series)
                obj.Points.Clear();

            int min = 0;
            int max = 0;
            // Series gaan vullen met onze items en waarden
            IEnumerator<Measurement> measurements;
            if (valueMinBox.Text.Length > 0)
                min = int.Parse(valueMinBox.Text);
            if (valueMaxBox.Text.Length > 0)
                max = int.Parse(valueMaxBox.Text);

            if (CurrentSearchType.Equals(SearchTypes.DEFAULT))
                measurements = session.getMeasurement().GetEnumerator();
            else
                measurements = session.getMeasurement().Where(signal => 
                    signal.actual_power > min && signal.actual_power < max ||
                    signal.distance > min && signal.distance < max ||
                    signal.energy > min && signal.energy < max ||
                    signal.rpm > min && signal.rpm < max ||
                    signal.pulse > min && signal.pulse < max ||
                    signal.speed > min && signal.speed < max
                ).GetEnumerator();

            while (measurements.MoveNext())
            {
                Measurement item = (Measurement)measurements.Current;
                plotMeasurement(item);                
            }
        }

        // Per measurement een plot uitvoeren, in plaats van steeds weer rijen opnieuw erdoorheen jassen
        private void plotMeasurement(Measurement m)
        {
            DateTime t = DateTime.Now;
            
            chart1.Series["pulse"].Points.AddXY(t.ToString("hh:mm:ss"), m.pulse);
            chart1.Series["rpm"].Points.AddXY(t.ToString("hh:mm:ss"), m.rpm);
            chart1.Series["actualpower"].Points.AddXY(t.ToString("hh:mm:ss"), m.actual_power);
            chart1.Series["requestedpower"].Points.AddXY(t.ToString("hh:mm:ss"), m.requested_power);
            chart1.Series["speed"].Points.AddXY(t.ToString("hh:mm:ss"), m.speed);
            chart1.Series["energy"].Points.AddXY(t.ToString("hh:mm:ss"), m.energy);
        }
    }
}