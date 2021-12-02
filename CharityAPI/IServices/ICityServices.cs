using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.Models;

namespace CharityAPI.IServices
{
    public interface ICityServices
    {
        public IEnumerable GetAllCities();
        public IEnumerable GetCityById(int cityId);
        public IEnumerable GetByStateId(int stateId);
        public void AddCity(Cities city);
        public void EditCity(Cities city);
        public void DeleteCity(int cityId);
    }
}
