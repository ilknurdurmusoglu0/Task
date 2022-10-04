using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BirdManager : IBirdService
    {
        private readonly Animal _animal;
        private readonly Bird _bird;
        public BirdManager(Bird bird)
        {
            _animal = new Animal { Id = 2, Color = Entities.Color.Yellow, Size = 20 };
            _bird = bird;
        }
        public Bird Color()
        {
            try
            {
                _bird.Color = _animal.Color;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _bird;
        }

        public Bird Feature(string feature)
        {
            throw new NotImplementedException();
        }

        public Bird Leg(int leg)
        {
            throw new NotImplementedException();
        }

        public Bird Size()
        {
            try
            {
                _bird.Size = _animal.Size;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return _bird;
        }
    }
}
