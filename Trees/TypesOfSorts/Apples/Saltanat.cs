using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class Saltanat : IApple
    {
        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInM { get; } = 3.12D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square { get; } = 3.65D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY { get; } = 4.5D;
    }
}
