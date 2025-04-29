using System.Drawing;

namespace System.Windows.Forms
{
    internal class DataVisualization
    {
        internal class Charting
        {
            internal class Chart
            {
                internal string Text;
                internal int TabIndex;

                public Size Size { get; internal set; }
                public object Series { get; internal set; }
                public string Name { get; internal set; }
                public Point Location { get; internal set; }
                public object Legends { get; internal set; }
                public object ChartAreas { get; internal set; }
                public bool Visible { get; internal set; }
            }

            internal class ChartArea
            {
                public string Name { get; internal set; }
            }

            internal class Legend
            {
                public string Name { get; internal set; }
            }

            internal class Series
            {
                public string Name { get; internal set; }
                public string Legend { get; internal set; }
                public string ChartArea { get; internal set; }
            }
        }
    }
}