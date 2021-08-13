using System.Collections.Generic;

namespace AStar.Collections.MultiDimensional
{
    public interface IModelAGrid<T>
    {
        int Height { get; }
        int Width { get; }
        T this[int row, int column] { get; }
        T this[Position position] { get; }
        IEnumerable<Position> GetSuccessorPositions(Position node, bool optionsUseDiagonals = false);
    }
}