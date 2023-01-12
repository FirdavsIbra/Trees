using Trees.Base;

namespace Trees.Solution
{
    public sealed class Calculator
    {
        /// <summary>
        /// Get results.
        /// </summary>
        public Result GetResult(IEnumerable<Tree> trees)
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
        private double GetMaximumYearOfHarvest(IEnumerable<Tree> trees)
        {
            var maxYearOfHarvest = trees.Select(trees => trees.BeginingOfTheHarvestInY).Max();

            return maxYearOfHarvest;
        }

        /// <summary>
        /// Get total occupying area of the tree.
        /// </summary>
        private double GetTotalOccupyingArea(IEnumerable<Tree> trees)
        {
            var totalOccupyingArea = trees.Select(trees => trees.Square).Sum();

            return totalOccupyingArea;
        }

        /// <summary>
        /// Get average height of the tree.
        /// </summary>
        private double GetAverageHeight(IEnumerable<Tree> trees)
        {
            var averageMaxHeight = trees.Select(trees => trees.HeightInM).Average();

            return averageMaxHeight;
        }
    }
}
