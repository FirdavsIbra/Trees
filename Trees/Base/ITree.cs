namespace Trees.Base
{
    public interface ITree
    {
        /// <summary>
        /// Gets height of tree in metre.
        /// </summary>
        public double HeightInM { get; }

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
