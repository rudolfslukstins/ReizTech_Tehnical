using System;
using System.Collections.Generic;

namespace Hierarchy
{
    public class Branch
    {
        public Branch()
        {

        }
        public List<Branch> Branches { get; set; }
        public Branch(List<Branch> branches)
        {
            if (branches.Count == 0)
            {
                throw new InvalidOperationException();
            }
            Branches = branches;
        }
    }
}
