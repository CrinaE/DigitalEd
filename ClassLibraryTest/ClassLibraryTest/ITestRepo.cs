using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public interface ITestRepo
    {
        bool TestConnection();
        string GetTestConnectionString();
    }
}
