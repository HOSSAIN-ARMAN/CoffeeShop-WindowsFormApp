using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using WindowsTestApp.Repository;
using WindowsTestApp.Model;

namespace WindowsTestApp.BLL
{
    public class CustomerInfoManager
    {
        CustomerInfoRepository _customerInfoRepository = new CustomerInfoRepository();
        public bool Save(CustomerInfoModel customerInfoModel)
        {
            return _customerInfoRepository.Save(customerInfoModel);
        }
        public DataTable Display()
        {
            return _customerInfoRepository.Display();
        }
        public List<CustomerInfoModel> delete(CustomerInfoModel customerInfoModel)
        {
            return _customerInfoRepository.delete(customerInfoModel);
        }
        public List<CustomerInfoModel> Upddate(CustomerInfoModel customerInfoModel)
        {
            return _customerInfoRepository.Upddate(customerInfoModel);
        }
        public List<CustomerInfoModel> Search(CustomerInfoModel customerInfoModel)
        {
            return _customerInfoRepository.Search(customerInfoModel);
        }
    }
}
