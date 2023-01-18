namespace Trees.Service
{
    public interface ITreeService
    {
        /// <summary>
        /// Change capacity of plot.
        /// </summary>
        public void ChangeCapacityOfPlot();

        /// <summary>
        /// Create a new plot.
        /// </summary>
        public void CreatePlot();

        /// <summary>
        /// Create tree.
        /// </summary>
        public void CreateTree();

        /// <summary>
        /// Print total area, maximum average height, maximum years after all trees give fruits.
        /// </summary>
        public void PrintResult();
        
        /// <summary>
        /// Show capacity.
        /// </summary>
        public void ShowCapacity();

        /// <summary>
        /// Show main menu.
        /// </summary>
        public void ShowMainMenu();

        /// <summary>
        /// Show all trees and counts.
        /// </summary>
        public void ShowAllTrees();
    }
}
