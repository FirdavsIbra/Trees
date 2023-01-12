using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Grapes
{
    public sealed class Kishmish : Grape
    {
        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public override double HeightInM { get; } = 8;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public override double Square { get; } = 21;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public override double BeginingOfTheHarvestInY { get; } = 2.4D;
    }
}
