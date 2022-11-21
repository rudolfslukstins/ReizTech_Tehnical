using System.Collections.Generic;
using System.Linq;
using Hierarchial_structure.Interfaces;

namespace Hierarchial_structure.Model
{
    public class DepthCalculation : IDepthCalculation
    {
        public int DepthCalculator(List<Branch> branchList, int depth = 1)
        {
            if (branchList == null)
            {
                return depth;
            }
            depth++;

            var depthResult = branchList.Select(branch => DepthCalculator(branch.Branches, depth)).ToList();
            return depthResult.Max();
        }
    }
}