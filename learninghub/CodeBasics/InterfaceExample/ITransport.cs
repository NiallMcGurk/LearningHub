using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHub.CodeBasics.Interface
{
    // Only Signatures
    // Classes that implement this interface must provide their own implementation of these methods
    public interface ITransport
    {
        int Wheels { get; }
        void Move();
    }
}
