using LogisticsDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsBLL.Services
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int id);
        IEnumerable<Customer> GetAllCustomers();
    }
}
