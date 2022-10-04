using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DogManager : IDogService
    {
        private readonly Animal _animal;
        private readonly Dog _dog;

        public DogManager(Dog dog)
        {
            _animal = new Animal { Id = 1, Color = Entities.Color.White, Size = 40 };
            _dog = dog;
        }

        public Dog Color()
        {
            try
            {
                _dog.Color = _animal.Color;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _dog;
        }

        public Dog Feature(string feature)
        {
            throw new NotImplementedException();
        }

        public Dog Leg(int leg)
        {
            throw new NotImplementedException();
        }

        public Dog Size()
        {
            try
            {
                _dog.Size = _animal.Size;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _dog;
        }
    }
}
