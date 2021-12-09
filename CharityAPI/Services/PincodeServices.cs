using CharityAPI.IServices;
using CharityAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityAPI.Services
{
    public class PincodeServices: IPincodeServices
    {
        private readonly CharityContext _context;
        public PincodeServices(CharityContext context)
        {
            _context = context;
        }

        //Get all pincode method
        public IEnumerable GetAllPincode()
        {
            var pincode = _context.Pincode.Where(x => x.IsPublished == true);
            return pincode;
        }


        //Get pincode by pincodeid
        public IEnumerable GetPincodeByPincodeId(int PincodeId)
        {
            var pincode = _context.Pincode.Where(x => x.IsPublished == true && x.PincodeId == PincodeId);
            return pincode;
        }


        //Get pincode by cityid
        public IEnumerable GetPincodeByCityId(int CityId)
        {
            var pincode = _context.Pincode.Where(x => x.IsPublished == true && x.CityId == CityId);
            return pincode;
        }


        //get pincode by stateid
        public IEnumerable GetPincodeByStateId(int StateId)
        {
            var pincode = _context.Pincode.Where(x => x.IsPublished == true && x.StateId == StateId);
            return pincode;
        }


        //get pincode by postoffice name
        public IEnumerable GetPincodeByPostOfficeName(string PostofficeName)
        {
            var pincode = _context.Pincode.Where(x => x.IsPublished == true && x.PostOfficeName == PostofficeName);
            return pincode;
        }


        //get pincode by distric name
        public IEnumerable GetPincodeByDistric(string District)
        {
            var pincode = _context.Pincode.Where(x => x.IsPublished == true && x.District == District);
            return pincode;
        }

        //get distric by pincode id 
        public IEnumerable GetDistrictByPincodeId(int PincodeId)
        {
            var pincode = _context.Pincode.Where(x => x.IsPublished == true && x.PincodeId == PincodeId);
            return pincode;
        }

        //add pincode
        public void AddPincode(Pincode pincode)
        {
            _context.Pincode.Add(pincode);
            _context.SaveChanges();
        }


        //edit pincode
        public void EditPincode(Pincode pincode)
        {
            _context.Pincode.Update(pincode);
            _context.SaveChanges();
        }


        //delete pincode
        public void DeletePincode(int PincodeId)
        {
            var pincode = _context.Pincode
                .Where(s => s.PincodeId == PincodeId)
                .SingleOrDefault();


            pincode.IsPublished = false;
            _context.SaveChanges();
        }

    }
}
