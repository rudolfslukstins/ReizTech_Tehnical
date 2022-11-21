using System.Collections.Generic;
using Hierarchial_structure.Model;

namespace Hierarchial_structure.Interfaces
{
    public interface IDepthCalculation
    {
        int DepthCalculator(List<Branch> branchList, int depth = 1);
    }
}