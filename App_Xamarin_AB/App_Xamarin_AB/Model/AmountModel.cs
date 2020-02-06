using System;
using System.Collections.Generic;
using System.Text;

namespace App_Xamarin_AB.Model
{
    public  class AmountModel: ClaseBase
    {
        private int _Cantidad;

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; OnPropertyChanged();

                if (Amount != null)
                {
                    if (Amount >= 0)
                    {
                        Resultado = Amount / value;
                    }
                }
            
            }
        }

        private double _Amount;

        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; OnPropertyChanged(); }
        }

        private double _Resultado;

        public double Resultado
        {
            get { return _Resultado; }
            set { _Resultado = value; OnPropertyChanged(); }
        }



    }
}
