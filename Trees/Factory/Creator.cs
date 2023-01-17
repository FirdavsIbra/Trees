using Trees.Base;
using Trees.Enums;
using Trees.TypesOfSorts.Apples;
using Trees.TypesOfSorts.Grapes;
using Trees.TypesOfSorts.Pears;

namespace Trees.Factory
{
    public sealed class Creator
    {
        public string[] TreeFactory(TypeOfTree typeOfTree)
        {
            return typeOfTree switch
            {
                TypeOfTree.Grape => new[] { "Kishmish", "Xusein" },
                TypeOfTree.Apple => new[] { "Golden", "Semerenko", "Saltanat", "GrannySmith", "PinkLady" },
                TypeOfTree.Pear => new[] { "Gvidon" },
                _ => throw new ArgumentException("Tree sort not found")
            };
        }
        public ITree TreeFactory(SortOfTree sortOfTree)
        {
            return sortOfTree switch
            {
                SortOfTree.Semerenko => new Semerenko(),
                SortOfTree.Golden => new Golden(),
                SortOfTree.GrannySmith => new GrannySmith(),
                SortOfTree.Kishmish => new Kishmish(),
                SortOfTree.PinkLady => new PinkLady(),
                SortOfTree.Saltanat => new Saltanat(),
                SortOfTree.Gvidon => new Gvidon(),
                SortOfTree.Xusein => new Xusein(),
                _ => throw new ArgumentException("Tree sort not found!")
            };
        }
    }
}
