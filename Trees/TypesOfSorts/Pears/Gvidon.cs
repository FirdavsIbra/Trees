using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Pears
{
    public sealed class Gvidon : Pear
    {
        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public override double HeightInM { get; } = 3.65D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public override double Square { get; } = 12.4D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public override double BeginingOfTheHarvestInY { get; } = 2;
    }
}
