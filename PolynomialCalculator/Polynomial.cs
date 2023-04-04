using System.Numerics;

namespace PolynomialCalculator;

public class Polynomial<T> where T : INumber<T>
{
    //TODO Use method if can we make action monomial and return this as the result
    public List<Monomial<T>> Polinomial { get; } = new List<Monomial<T>>();

    public Monomial<T> Add(Monomial<T> mnR, Monomial<T> mnL)
    {
        return mnR + mnL;
    }
    
}