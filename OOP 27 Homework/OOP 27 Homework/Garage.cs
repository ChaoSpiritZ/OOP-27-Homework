using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_27_Homework
{
    public class Garage : IGarage
    {
        private List<Car> _cars;
        private List<string> _carTypes;

        public Garage(List<string> carTypes)
        {
            _cars = new List<Car>();
            _carTypes = carTypes;
        }

        public void AddCar(Car car)
        {
            if(car is null)
            {
                throw new CarNullException($"failed adding car: the car sent is null [{car}]");
            }
            if (_cars.Contains(car))
            {
                throw new CarAlreadyHereException($"failed adding car: car [{car}] is already in the garage");
            }
            if(car.TotalLost)
            {
                throw new WeDoNotFixTotalLostException($"failed adding car: car [{car}] is beyond repair, we do not deal with those");
            }
            if (!_carTypes.Contains(car.Brand))
            {
                throw new WrongGarageException($"failed adding car: this garage doesn't fix cars with brand [{car.Brand}]");
            }
            if (!car.NeedsRepair)
            {
                throw new RepairMismatchException($"failed adding car: car [{car}] doesn't need repair");
            }
            _cars.Add(car);
        }

        public void TakeOutCar(Car car)
        {
            if(car is null)
            {
                throw new CarNullException($"failed taking out car: the car sent is null [{car}]");
            }
            if (!_cars.Contains(car))
            {
                throw new CarNotInGarageException($"failed taking out car: car [{car}] is was not found in the garage");
            }
            if (car.NeedsRepair)
            {
                throw new CarNotReadyException($"failed taking out car: car [{car}] still needs to be repaired");
            }
            _cars.Remove(car);
        }

        public void FixCar(Car car)
        {
            if(car is null)
            {
                throw new CarNullException($"failed fixing car: the car sent is null [{car}]");
            }
            if (!_cars.Contains(car))
            {
                throw new CarNotInGarageException($"failed fixing car: car [{car}] is was not found in the garage");
            }
            if (!car.NeedsRepair)
            {
                throw new RepairMismatchException($"failed fixing car: car [{car}] is already fixed");
            }
            car.NeedsRepair = false;
        }
    }
}
