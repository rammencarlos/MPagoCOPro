using Mpago.Domain.Product;
using MPago.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mpago.Service
{
    public class SmartPhoneService
    {
        public SmartPhoneDTO GetSmartPhone(string id) 
        { 
            var smartPhone = (from s in SmartPhoneData.Instance._products 
                             where s.Id == id select s).SingleOrDefault();

            return smartPhone;
        }
    }
}
