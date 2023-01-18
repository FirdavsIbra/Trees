using Trees.TypesOfTrees;

namespace Trees.Models.TypesOfSorts.Grapes
{
    public sealed class Xusein : IGrape
    {
        /// <summary>
        /// Gets the name of sort of tree.
        /// </summary>
        public string SortName => nameof(Xusein);

        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInMetre => 2.3D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square => 23.423D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY => 4;
    }
}
