using System.Numerics;
using System.Reflection;

namespace PolynomialCalculator;

public class Polynomial<T> where T : INumber<T>
{
    private List<Monomial<T>> _monomials;
    
    public Polynomial(List<Monomial<T>> poly)
    {
        _monomials = poly;
    }
    
    
    public static Polynomial<T> operator +(Polynomial<T> a, Polynomial<T>b)
    {
        return a;
    }
    
    public static Polynomial<T> operator -(Polynomial<T> a, Polynomial<T> b)
    {
        return a;
    }
    
    public static Polynomial<T> operator *(Polynomial<T> a, Polynomial<T> b)
    {
        return a;
    }
    
}