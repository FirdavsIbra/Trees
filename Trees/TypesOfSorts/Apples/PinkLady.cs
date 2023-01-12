using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class PinkLady : Apple
    {
        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public override double HeightInM { get; } = 2.2D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public override double Square { get; } = 8.68D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public override double BeginingOfTheHarvestInY { get; } = 4.6D;
    }
}
