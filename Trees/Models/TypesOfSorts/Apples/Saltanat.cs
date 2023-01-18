using Trees.TypesOfTrees;

namespace Trees.Models.TypesOfSorts.Apples
{
    public sealed class Saltanat : IApple
    {
        /// <summary>
        /// Gets the name of sort of tree.
        /// </summary>
        public string SortName => nameof(Saltanat);

        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInMetre => 3.12D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square => 3.65D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY => 4.5D;
    }
}
