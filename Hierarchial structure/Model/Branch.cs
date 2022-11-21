using System;
using System.Collections.Generic;

namespace Hierarchial_structure.Model
{
    public class Branch
    {
        public List<Branch> Branches { get; set; }
        public Branch(List<Branch> branches)
        {
            if (branches.Count == 0)
            {
                throw new InvalidOperationException();
            }
            Branches = branches;
        }

        public Branch()
        {

        }
    }
}
