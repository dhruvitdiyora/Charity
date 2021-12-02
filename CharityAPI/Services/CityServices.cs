using CharityAPI.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharityAPI.IServices;
using CharityAPI.Models;

namespace CharityAPI.Services
{
    public class CityServices : ICityServices
    {
        private readonly CharityContext _context;
        public CityServices(CharityContext context)
        {
            _context = context;
        }

        public void AddCity(Cities city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();
        }


        public void DeleteCity(int cityId)
        {
            var city = _context.Cities
                .Where(s => s.CityId == cityId)
                .SingleOrDefault();

            //context.EventVenues.Remove(eventVenue);
            city.IsPublished = false;
            _context.SaveChanges();
        }

        public void EditCity(Cities city)
        {
            //var city = _context.Cities
            //    .Where(s => s.CityId == cityId)
            //    .SingleOrDefault();
            //_context.Entry(city).State = EntityState.Modified;
            _context.Cities.Update(city);
            _context.SaveChanges();
        }
        public IEnumerable GetCityById(int cityId)
        {
            var city = _context.Cities.Where(x => x.IsPublished == true && x.CityId == cityId);
            return city;
        }

        public IEnumerable GetByStateId(int stateId)
        {
            var city = _context.Cities.Where(x => x.IsPublished == true && x.StateId == stateId);
            return city;
        }

        public IEnumerable GetAllCities()
        {
            var cities = _context.Cities.Where(x => x.IsPublished == true);
            return cities;
        }
    }
}
