using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class PinkLady : IApple
    {
        /// <summary>
        /// Gets the name of sort of tree.
        /// </summary>
        public string SortName => nameof(PinkLady);

        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInMetre => 2.2D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square => 8.68D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY => 4.6D;
    }
}
