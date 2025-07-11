using System;

namespace MarketData.Application.DTOs
{
    public class PriceHistoryDto
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public decimal PriceChange { get; set; }
        public decimal PriceChangePercent { get; set; }
        public long Volume { get; set; }
        public DateTime Timestamp { get; set; }
        public string TimeFrame { get; set; }
    }
}