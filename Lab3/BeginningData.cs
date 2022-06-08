using System.Collections.Generic;
using Menu.Interfaces;
using Menu.Factories;

namespace Application
{
    public static class BeginningData
    {
        public static Dictionary<string, IFactory> Factories { get; } = new()
        {
            { "Breakfast", new BreakfastFactory() },
            { "Dinner", new DinnerFactory() },
            { "Supper", new SupperFactory() }
        };
    }
}
