using Trees.TypesOfTrees;

namespace Trees.TypesOfSorts.Pears
{
    public sealed class Gvidon : IPear
    {
        /// <summary>
        /// Gets the name of sort of tree.
        /// </summary>
        public string SortName => nameof(Gvidon);

        /// <summary>
        /// Get height of tree in metre.
        /// </summary>
        public double HeightInMetre { get; } = 3.65D;

        /// <summary>
        /// Get ocupying area of the tree;
        /// </summary>
        public double Square { get; } = 12.4D;

        /// <summary>
        /// Get begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY { get; } = 2;
    }
}
