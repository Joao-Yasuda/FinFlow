using MarketData.Domain.Entities;

namespace MarketData.Domain.Interfaces;

public interface IMarketDataRepository
{
    Task<MarketPrice> GetLatestPrice();
    Task<IEnumerable<MarketPrice>> GetLatestPricesasync();
    
    Task AddPrice(MarketPrice marketPrice);
    Task AddPriceHistory (PriceHistory priceHistory);
    
    Task <IEnumerable<MarketPrice>> GetPricesBySymbol(IEnumerable<string> symbols);
}