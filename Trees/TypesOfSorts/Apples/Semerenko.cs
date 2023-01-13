using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class Semerenko : IApple
    {
        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInM { get; } = 3.5D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square { get; } = 5.21D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY { get; } = 5;
    }
}
