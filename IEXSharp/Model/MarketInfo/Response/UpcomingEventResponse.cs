using System.Collections.Generic;
using VSLee.IEXSharp.Model.Shared.Response;
using VSLee.IEXSharp.Model.Stock.Response;
using VSLee.IEXSharp.Model.StockFundamentals.Response;

namespace VSLee.IEXSharp.Model.MarketInfo.Response
{
	public class UpcomingEventSymbolResponse
	{
		public List<Estimate> earnings { get; set; }
		public List<Dividend> dividends { get; set; }
		public List<Split> splits { get; set; }
	}

	public class UpcomingEventMarketResponse
	{
		public IPOCalendarResponse ipos { get; set; }
		public List<Estimate> earnings { get; set; }
		public List<Dividend> dividends { get; set; }
		public List<Split> splits { get; set; }
	}
}