using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CatManager : ICatService
    {
        private readonly Animal _animal;
        private readonly Cat _cat;

        public CatManager(Cat cat)
        {
            _animal = new Animal { Id = 3, Color = Entities.Color.Black, Size = 30 };
            _cat = cat;
        }

        public Cat Color()
        {
            try
            {
                _cat.Color = _animal.Color;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _cat;
        }

        public Cat Feature(string feature)
        {
            throw new NotImplementedException();
        }

        public Cat Leg(int leg)
        {
            throw new NotImplementedException();
        }

        public Cat Size()
        {
            try
            {
                _cat.Size = _animal.Size;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _cat;
        }
    }
}
