using Trees.Base;
using Trees.Models.Enums;
using Trees.Models.TypesOfSorts.Apples;
using Trees.Models.TypesOfSorts.Grapes;
using Trees.Models.TypesOfSorts.Pears;
using Trees.TypesOfSorts.Apples;

namespace Trees.Factory
{
    public sealed class Creator
    {
        /// <summary>
        /// Return string array of sorts.
        /// </summary>
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

        /// <summary>
        /// Return initialized objects of each sorts.
        /// </summary>
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
