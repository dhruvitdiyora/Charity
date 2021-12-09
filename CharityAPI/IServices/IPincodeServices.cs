using CharityAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.IServices
{
    public interface IPincodeServices
    {
        public IEnumerable GetAllPincode();
        public IEnumerable GetPincodeByPincodeId(int PincodeId);
        public IEnumerable GetPincodeByCityId(int CityId);
        public IEnumerable GetPincodeByStateId(int StateId);
        public IEnumerable GetPincodeByPostOfficeName(string PostofficeName);
        public IEnumerable GetPincodeByDistric(string District);
        public IEnumerable GetDistrictByPincodeId(int PincodeId);
        public void AddPincode(Pincode pincode);
        public void EditPincode(Pincode pincode);
        public void DeletePincode(int PincodeId);

    }
}
