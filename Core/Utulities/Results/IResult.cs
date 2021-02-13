using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utulities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
