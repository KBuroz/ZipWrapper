using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZipWrapper
{
    public interface IParser<T>
    {
        T Parse(string arg);
    }
}