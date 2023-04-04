using System.Numerics;
using System.Reflection;

namespace PolynomialCalculator;

public class Polynomial<T> where T : INumber<T>
{
    //TODO Use method if can we make action monomial and return this as the result
    public Dictionary<int, Monomial<T>> Monomials { get; } = new Dictionary<int, Monomial<T>>();

    

    public Polynomial(Dictionary<int, Monomial<T>> monomials)
    {
        this.Monomials = monomials;
    }




    public Monomial<T> Add(Monomial<T> mnR, Monomial<T> mnL)
    {
        return mnR + mnL;
    }
    
}