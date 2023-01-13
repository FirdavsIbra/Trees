using Trees.Base;

namespace Trees.Solution
{
    public sealed class Calculator
    {
        /// <summary>
        /// Get results.
        /// </summary>
        public Result GetResult(IEnumerable<ITree> trees)
        {
            double year = GetMaximumYearOfHarvest(trees);
            double totalArea = GetTotalOccupyingArea(trees);
            double avgMaxHeight = GetAverageHeight(trees);

            return new Result()
            {
                MaxHeight = avgMaxHeight,
                TotalArea = totalArea,
                Year = year
            };
        }

        /// <summary>
        /// Get maximum year of the harvest.
        /// </summary>
        private double GetMaximumYearOfHarvest(IEnumerable<ITree> trees)
        {
            var maxYearOfHarvest = trees.Max(trees => trees.BeginingOfTheHarvestInY);

            return maxYearOfHarvest;
        }

        /// <summary>
        /// Get total occupying area of the tree.
        /// </summary>
        private double GetTotalOccupyingArea(IEnumerable<ITree> trees)
        {
            var totalOccupyingArea = trees.Sum(trees => trees.Square);

            return totalOccupyingArea;
        }

        /// <summary>
        /// Get average height of the tree.
        /// </summary>
        private double GetAverageHeight(IEnumerable<ITree> trees)
        {
            var averageMaxHeight = trees.Average(trees => trees.HeightInM);

            return averageMaxHeight;
        }
    }
}
