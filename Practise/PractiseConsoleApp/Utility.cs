
namespace PractiseConsoleApp
{
    public static class Utility
    {

        // By default, records generate useful methods like Equals, GetHashCode, and ToString based on their properties.
        // This eliminates the need for manual implementation, enhancing code maintainability.
        // Records are often used for data transfer objects (DTOs), messages, or simple data containers
        // where immutability and equality are critical.
        public record Employee(int Id, string Name, string Major);

        // Structs are commonly used for lightweight data structures, numerical types,
        // and scenarios where performance is paramount.
        public struct Currency
        {
            public decimal Amount;
            public string Symbol;
        }

        // Convert currency amount based on the conversion rate
        public static Currency ConvertCurrency(Currency currency, decimal conversionRate)
        {
            Currency convertedCurrency = currency;
            convertedCurrency.Amount *= conversionRate;
            return convertedCurrency;
        }
    }
}
