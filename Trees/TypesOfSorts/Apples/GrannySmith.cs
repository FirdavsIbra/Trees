using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class GrannySmith : IApple
    {
        /// <summary>
        /// Gets the name of sort of tree.
        /// </summary>
        public string SortName => nameof(GrannySmith);

        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInMetre => 6.43D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square => 8.65D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY => 4.5D;
    }
}
