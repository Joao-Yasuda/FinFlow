using System;
namespace MarketData.Application.DTOs;

    public class MarketPriceDto
    {
        public string Symbol { get; set; }
        public decimal Price { get; set; }
        public decimal? OpenPrice { get; set; }
        public decimal? ClosePrice { get; set; }
        public decimal? HighPrice { get; set; }
        public decimal? LowPrice { get; set; }
        public long Volume { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal PriceChange { get; set; }
        public decimal PriceChangePercent { get; set; }
    }
