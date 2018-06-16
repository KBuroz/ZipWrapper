using System.Collections.Generic;

namespace ZipWrapper
{
    public interface IValidateCLI
    {
        bool Validate(string[] args);
        List<string> Errors { get; }
    }
}
