using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Apples
{
    public sealed class Golden : Apple
    {
        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public override double HeightInM { get; } = 5.12D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public override double Square { get; } = 12.43D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public override double BeginingOfTheHarvestInY { get; } = 4.5D;
    }
}
