
using System;
using System.Collections.Generic;
using System.Numerics;

namespace PolynomialCalculator
{
    //TODO write method ifmonomiel has same coef
    public class Monomial<T> where T : INumber<T>
    {
        private string _nomial;
        private T _coefficient;
        private int _exponent ;

        public Monomial(T coefficient, string nomial = "", int exponent = 1)
        {
            _nomial = nomial;
            _coefficient = coefficient;
            _exponent = exponent;

        }
        
        public static Monomial<T> operator +(Monomial<T> mnLeft, Monomial<T> mnRight)
        {
            return new Monomial<T>(mnLeft._coefficient + mnRight._coefficient,
                    mnLeft._nomial,
                    mnLeft._exponent);
        }

        public static Monomial<T> operator -(Monomial<T> mnLeft, Monomial<T> mnRight)
        {
            {
                return new Monomial<T>(mnLeft._coefficient - mnRight._coefficient,
                    mnLeft._nomial,
                    mnLeft._exponent);
            }
        }

        public override string ToString()
        {
            return $"coefficient {_coefficient}" +
                   $"nomial {_nomial}" +
                   $"exponent {_exponent}";
        }
    }
}