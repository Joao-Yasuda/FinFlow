using System.ComponentModel.DataAnnotations;

namespace MarketData.Domain.Entities;

public class PriceHistory
{
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength(10)]
    public string Symbol { get; set; }
    
    [Required]
    public decimal Price{ get; set; }
    
    public decimal PriceChange { get; set; }
    public decimal PriceChangePercent { get; set; }
    
    public long Volume { get; set; }
    
    public DateTime Timestamp { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    public string TimeFrame { get; set; } = "1m";
    
}