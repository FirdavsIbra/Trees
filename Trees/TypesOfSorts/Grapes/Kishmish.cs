using Trees.TypesOfSorts.Apples;
using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Grapes
{
    public sealed class Kishmish : IGrape
    {
        /// <summary>
        /// Gets the name of sort of tree.
        /// </summary>
        public string SortName => nameof(Kishmish);

        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInMetre => 8;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square => 21;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY => 2.4D;
    }
}
