﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Part1
    {
        public static int Solve(List<Assignment> assignments)
        {
            int count = 0;

            foreach (Assignment assignment in assignments) if (assignment.IsFullyOverlapping()) count++;

            return count;
        }
    }
}
