using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Grapes
{
    public sealed class Xusein : IGrape
    {
        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInM { get; } = 2.3D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square { get; } = 23.423D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY { get; } = 4;
    }
}
