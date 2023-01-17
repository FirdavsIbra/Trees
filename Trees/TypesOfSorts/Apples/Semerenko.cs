using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class Semerenko : IApple
    {
        /// <summary>
        /// Gets the name of sort of tree.
        /// </summary>
        public string SortName => nameof(Semerenko);

        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInMetre => 3.5D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square => 5.21D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY => 5;
    }
}
