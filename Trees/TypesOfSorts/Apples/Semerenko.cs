using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class Semerenko : Apple
    {
        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public override double HeightInM { get; } = 3.5D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public override double Square { get; } = 5.21D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public override double BeginingOfTheHarvestInY { get; } = 5;
    }
}
