using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_27_Homework
{
    interface IGarage
    {
        void AddCar(Car car);
        void TakeOutCar(Car car);
        void FixCar(Car car);
    }
}
