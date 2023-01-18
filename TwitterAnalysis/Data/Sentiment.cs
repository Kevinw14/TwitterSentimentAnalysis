using System;
using ChartJs.Blazor;
using ChartJs.Blazor.PieChart;

namespace TwitterAnalysis.Data
{
	public class Sentiment
	{
        public Chart Chart { get; set; }
        public PieConfig Config { get; set; }
        public double Processed { get; set; }
        public string PositivePercentage { get; set; }
        public string NeutralPercentage { get; set; }
        public string NegativePercentage { get; set; }

        public Sentiment(PieConfig Config)
        {
            this.Chart = null;
            this.Config = Config;
            this.Processed = 0;
            this.PositivePercentage = "0.00";
            this.NeutralPercentage = "0.00";
            this.NegativePercentage = "0.00";
        }
    }
}

