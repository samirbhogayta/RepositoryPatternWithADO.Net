using RepositoryPatternWithADO.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternWithADO.Net.Repository
{
    interface IEmployee
    {
        IList<Employee> GetEmployees();        
    }
}
