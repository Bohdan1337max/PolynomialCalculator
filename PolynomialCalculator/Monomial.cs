﻿
using System;
using System.Collections.Generic;
using System.Numerics;

namespace PolynomialCalculator
{
    public class Monomial<T> where T : INumber<T>
    {
        public string Nomial { get; }
        public T Coefficient { get; }
        public int Exponent { get; }
        public bool IsMultiplication { get; }
        //add checking!!!

        public Monomial(T coefficient, string nomial = "", int exponent = 1, bool isMultiplication = false)
        {
            Nomial = nomial;
            Coefficient = coefficient;
            IsMultiplication = isMultiplication;
            Exponent = exponent;

        }
        
        public bool HaveSameNomial(Monomial<T> monomial)
        {
            var isSameNomial = this.Nomial == monomial.Nomial && this.Exponent == monomial.Exponent;
            return isSameNomial;
        }
        
        public static Monomial<T> operator +(Monomial<T> mnLeft, Monomial<T> mnRight)
        {
            return new Monomial<T>(mnLeft.Coefficient + mnRight.Coefficient,
                mnLeft.Nomial,mnLeft.Exponent,mnLeft.IsMultiplication );
        }

        public static Monomial<T> operator -(Monomial<T> mnLeft, Monomial<T> mnRight)
        {
            return new Monomial<T>(mnLeft.Coefficient + mnRight.Coefficient,
                mnLeft.Nomial,mnLeft.Exponent,mnLeft.IsMultiplication);
        }

        public static Monomial<T> operator *(Monomial<T> mnLeft, Monomial<T> mnRight)
        {
            if ((mnLeft.Coefficient.ToString().Contains('1') && mnLeft.Nomial == ""))
                return new Monomial<T>(mnRight.Coefficient, mnRight.Nomial, mnRight.Exponent, mnRight.IsMultiplication);
            else if ((mnRight.Coefficient.ToString().Contains('1') && mnRight.Nomial == ""))
                return new Monomial<T>(mnLeft.Coefficient, mnLeft.Nomial, mnLeft.Exponent, mnLeft.IsMultiplication);
            else
                return new Monomial<T>(mnRight.Coefficient * mnLeft.Coefficient, mnLeft.Nomial, mnLeft.Exponent + mnRight.Exponent, mnRight.IsMultiplication);
        }

        public override string ToString()
        {
            if (!Coefficient.ToString().Contains('0'))
            {
                if (Exponent == 1)
                {
                    if (!Coefficient.ToString()!.Contains('-'))
                    {
                        return $"+{Coefficient}" +
                       $"{Nomial}";
                    }
                    return $"{Coefficient}" +
                           $"{Nomial}";
                }
                if (!Coefficient.ToString()!.Contains('-'))
                {
                    return $"+{Coefficient}" +
                           $"{Nomial}" +
                           $"^{Exponent}";
                }
                else
                {
                    return $"{Coefficient}" +
                           $"{Nomial}" +
                           $"^{Exponent}";
                }
            }
            else
            {
                return "";
            }
        }
    }
}