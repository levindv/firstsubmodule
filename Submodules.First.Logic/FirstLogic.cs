using Submodules.First.Contracts;
using System;

namespace Submodules.First.Logic
{
    public class FirstLogic : IFirstLogic
    {
        public string ExecuteAndGetStatus(FirstContract data)
        {
            Console.Write(data.FirstStringParam);
            return data.FirstStringParam;
        }
    }
}