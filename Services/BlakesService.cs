using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blakeslist.Services
{
    public class BlakesService
    {

        private readonly BlakesRepository _blakesRepository;

        public BlakesService(BlakesRepository blakesRepository)
        {
            _blakesRepository = blakesRepository;
        }


        internal List<Blake> GetBlakes()
        {
            List<Blake> blakes = _blakesRepository.GetBlakes();
            return blakes;
        }


        internal Blake GetBlakeById(int blakeId)
        {
            Blake blake = _blakesRepository.GetBlakeById(blakeId);
            if (blake == null)
            {
                throw new Exception($"invalid id: {blakeId}");
            }

            return blake;
        }

        internal Blake CreateBlake(Blake blakeData)
        {
            Blake blake = _blakesRepository.CreateBlake(blakeData);
            return blake;
        }

        internal string DestroyBlake(int blakeId)
        {
            Blake blake = GetBlakeById(blakeId);
            _blakesRepository.DestroyBlake(blakeId);
            return $"{blake.Name} has finally been destroyed!";
        }

        internal Blake UpdateBlake(int blakeId, Blake blakeData)
        {
            Blake originalBlake = GetBlakeById(blakeId);

            originalBlake.Name = blakeData.Name ?? originalBlake.Name;
            originalBlake.FavoriteMovie = blakeData.FavoriteMovie ?? originalBlake.FavoriteMovie;
            originalBlake.Age = blakeData.Age ?? originalBlake.Age;
            originalBlake.IsBlake = blakeData.IsBlake ?? originalBlake.IsBlake;
            originalBlake.IsFlexible = blakeData.IsFlexible ?? originalBlake.IsFlexible;

            _blakesRepository.UpdateBlake(originalBlake);

            return originalBlake;
        }
    }
}