using Trees.Base;

namespace Trees.Models
{
    public sealed class TreeInfo
    {
        public double Capacity { get; set; }
        public IList<ITree> Trees { get; set; } = new List<ITree>();
    }
}
