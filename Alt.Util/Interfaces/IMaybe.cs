using System.Collections.Generic;

namespace Alt.Util.Interfaces
{
    public interface IMaybe<out T>
    {
        bool HasValue { get; }
        T Value { get; }
        IEnumerable<string> Errors { get; }
        string Error { get; }
    }
}