using System.Numerics;

namespace PolynomialCalculator;

public partial class Form1 : Form
{
    
    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        TypeChecker(PolynomialInput.Text);
    }

    // -1,3+128-2
    // (-2x^3+2x^2-2x+1)*5

    private void TypeChecker(string wholePolynomial)
    {
        if (wholePolynomial.Contains('.'))
        {
            PolynomialHandler<double>(wholePolynomial);
        }
        else
        {
            PolynomialHandler<int>(wholePolynomial);
        }
    }


//2*3
    private void PolynomialHandler<T>(string polynomial) where T : INumber<T>
    {
        var poly = MonomialParser<T>(polynomial);
        for (var i = 0; i < poly.Count(); i++)
        {
            if (!poly[i].IsMultiplication) continue;
            poly[i - 1] *= poly[i];
            poly.Remove(poly[i]);
            i--;

        }
        
        for (var i = 0; i < poly.Count; i++)
        {
            for (var j = i + 1; j < poly.Count  ; j++)
            {
                if (!poly[i].HaveSameNomial(poly[j])) continue;
                poly[i] += poly[j];
                poly.Remove(poly[j]);
                j--;
            }
        }
        Print(poly);
    }

    private void Print<T>(List<Monomial<T>> poly) where T : INumber<T>
    {
        var result = "";
        foreach (var monomial in poly)
        {
            result += monomial.ToString();
        }

        if (result[0] == '+')
        {
            result= result.TrimStart('+');
        }
        SaveToFile(result);
        textBox1.Text = result;
    }

    private void SaveToFile(string poly)
    {
        string saveVersion = poly + Environment.NewLine;
        File.AppendAllText("history.txt", saveVersion);
    }
    
    

    // -1,3+128-2
    // -2x^3+2x^2-2x+1
    private static (T coef, int lenght, bool isMultiplication) ParseCoefficient<T>(string polynomial, int pos) where T : INumber<T>
    {
        var coef = "";
        var lenght = 0;
        var isMultiplication = false;
        if (polynomial[pos] == 'x')
        {
            var cValue = (T)Convert.ChangeType(1, typeof(T));
            return (cValue, lenght, isMultiplication);
        }
        while (coef.Length == 0 || coef.Length >= 1 &&
               (polynomial[pos] != '+' && polynomial[pos] != '-' && polynomial[pos] != 'x' && polynomial[pos] != '*'
                &&  polynomial[pos] != '^'))
        {
            if (polynomial[pos] == '*')
            {
                isMultiplication = true;
                pos++;
                lenght++;
                continue;
            }
            coef += polynomial[pos];
            lenght++;
            pos++;
            if (pos == polynomial.Length)
                break;
        }
        return coef switch
        {
            "x" => (T.Parse("1", null), 1,isMultiplication),
            "+" => (T.Parse("1", null), 1,isMultiplication),
            "-" => (T.Parse("-1", null), 1,isMultiplication),
            _ => (T.Parse(coef, null), lenght,isMultiplication)
        };
    }

    // 3+1,28-2
    // -2x^3+2x^2-2x+1
    private (string nomial, int lenght) ParseNomial(string polynomial, int pos)
    {
        if (pos == polynomial.Length)
            pos -= 1;
        if (polynomial[pos] == 'x')
            return ("x", 1);
        return ("", 0);
    }

    private (int exp, int length) ParseExp(string polynomial, int pos)
    {
        var exp = "";
        var lenght = 0;
        if (pos == polynomial.Length)
            pos -= 1;
        if (polynomial[pos] == '^')
        {
            pos++;
            lenght++;
            while (polynomial[pos] != '+' && polynomial[pos] != '-' && polynomial[pos] != '*' && pos != polynomial.Length )
            {
                exp += polynomial[pos];
                lenght++;
                pos++;
                if (pos == polynomial.Length)
                    break;
            }
        }
        else
        {
            return (1, 0);
        }
        return (int.Parse(exp), lenght);
    }
    // 3+1,28-2
    // -2x^3+2x^2-2x+1
    private List<Monomial<T>> MonomialParser<T>(string polynomial) where T : INumber<T>
    {
        var monomials = new List<Monomial<T>>();
        var pos = 0;
        while (pos < polynomial.Length)
        {
            var (coef, coefLength,isMultiplication) = ParseCoefficient<T>(polynomial, pos);
            pos += coefLength;
            var (nomial, nomialLength) = ParseNomial(polynomial, pos);
            pos += nomialLength;
            var (exp, expLength) = ParseExp(polynomial, pos);
            pos += expLength;
            var monomial = new Monomial<T>(coef, nomial, exp,isMultiplication);
            monomials.Add(monomial);
        }
        return monomials;
    }
}