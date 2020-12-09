using System;

namespace Car
{
    class Program
    {
        class Car
        {
            string mark;
            string model;
            string color;
            string regNumber;
            int fuelTank;
            int odo;

            public Car(string _mark, string _model, string _color, string _regNumber)
            {
                mark = _mark;
                model = _model;
                color = _color;

                if (_regNumber.Length != 6)
                {
                    regnumber = "undefined";
                }
                else
                {
                    regNumber = _regNumber;


                }
                fuelTank = 60;
                odo = 0;
            }
                public string Model

            {
                get { return mark; }
            }
               {

               }
            
                
            

            }



        }

    }

}

