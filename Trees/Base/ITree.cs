namespace Trees.Base
{
    public interface ITree
    {
        /// <summary>
        /// Gets the name of sort.
        /// </summary>
        public string SortName { get; }
        /// <summary>
        /// Gets height of tree in metre.
        /// </summary>
        public double HeightInMetre { get; }

        /// <summary>
        /// Gets ocupying area of the tree.
        /// </summary>
        public double Square { get; }

        /// <summary>
        /// Gets begining year of the harvest.
        /// </summary>
        public double BeginingOfTheHarvestInY { get; }
    }
}
