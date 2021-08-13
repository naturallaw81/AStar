using AStar.Options;

namespace AStar
{
    public class PathFinder : PathFinderBase<short>
    {
        public PathFinder(WorldGrid worldGrid, PathFinderOptions pathFinderOptions = null) : base(worldGrid, pathFinderOptions)
        {
        }
    }
}