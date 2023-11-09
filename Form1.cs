
using System;
using System.Drawing;
using System.Windows.Forms;
using ScottPlot;


namespace WinFormsAppdollar1
{
    public partial class Form1 : Form
    {
        private readonly ScottPlot.FormsPlot formsPlot;

        public Form1()
        {
            InitializeComponent();
            formsPlot = new ScottPlot.FormsPlot();
            formsPlot.Location = new Point(10, 10);
            formsPlot.Size = new Size(800, 400);
            this.Controls.Add(formsPlot);
            double[] dates = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            double[] dollarRates = new double[] { 28.14, 28.49, 30.16, 31.13, 34.92, 35.48, 37.76, 40.10, 41.64, 40.58, 40.34, 40.19 };
            formsPlot.Plot.AddScatter(dates, dollarRates);
            formsPlot.Plot.SetAxisLimits(0, dates.Length, 60, 100);
            formsPlot.Plot.XLabel("ћес€ц 2022 года");
            formsPlot.Plot.YLabel(" урс доллара");
            formsPlot.Plot.AxisAuto();
            formsPlot.Render();
        }
    }
}

