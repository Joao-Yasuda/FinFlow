using System.ComponentModel.DataAnnotations;

namespace MarketData.Domain.Entities;

public class MarketPrice
{
    public Guid Id { get; set; }
    
    [Required]
    [MaxLength (10)]
    public string Symbol { get; set; }
    
    [Required]
    public decimal Price { get; set; }
    
    public decimal? OpenPrice { get; set; }
    public decimal? HighPrice { get; set; }
    public decimal? LowPrice { get; set; }
    public decimal? ClosePrice { get; set; }
    
    public long Volume { get; set; }
    
    public DateTime Timestamp { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string source { get; set; }
}