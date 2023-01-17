using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class Golden : IApple
    {
        /// <summary>
        /// Gets the name of sort of tree.
        /// </summary>
        public string SortName => nameof(Golden);

        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInMetre => 5.12D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square => 12.43D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY => 4.5D;
    }
}
