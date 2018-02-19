using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
  class AccountantEmployee : Employee
  {

    public void disposedTrash() {
      Console.WriteLine("disposing trash...");
    }

    public void ConnectToDB() {
      Console.WriteLine("connecting to DB...");
    }

    public void CalculateTaxes() {
      Console.WriteLine("Calculating taxes...");
    }
  }
}
