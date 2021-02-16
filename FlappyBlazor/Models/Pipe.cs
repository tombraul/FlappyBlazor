using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBlazor.Models
{
    public class Pipe
    {
        public int DistanceFromLeft { get; private set; } = 500;
        public int DistanceFromBottom { get; private set; } = new Random().Next(0, 60);
    }
}
