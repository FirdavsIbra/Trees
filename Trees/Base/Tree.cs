namespace Trees.Base
{
    public abstract class Tree
    {
        /// <summary>
        /// Gets height of tree in metre.
        /// </summary>
        public virtual double HeightInM { get; }

        /// <summary>
        /// Gets ocupying area of the tree.
        /// </summary>
        public virtual double Square { get; }

        /// <summary>
        /// Gets begining year of the harvest.
        /// </summary>
        public virtual double BeginingOfTheHarvestInY { get; }
    }
}
