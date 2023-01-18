using System;
namespace TwitterAnalysis.Data
{
	public class Page
	{
		public int PageNumber { get; set; }
		public int Min { get; set; }
		public int Max { get; set; }

		public Page(int PageNumber, int Min, int Max)
		{
			this.PageNumber = PageNumber;
			this.Min = Min;
			this.Max = Max;
		}

		public Page()
		{
			this.PageNumber = 0;
			this.Min = 0;
			this.Max = 0;
		}
	}
}

