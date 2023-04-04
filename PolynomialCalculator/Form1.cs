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
        PolynomialHandler(PolynomialInput.Text);
    }

    // -1,3+128-2
    // (-2x^3+2x^2-2x+1)*5

    private void PolynomialHandler(string wholePolynomial) 
    {
        if (wholePolynomial.Contains(','))
        {
            var dPoly = MonomialParser<double>(wholePolynomial);
            textBox1.Text = dPoly.ToString();


        }
        else
        {
            var iPoly = MonomialParser<int>(wholePolynomial);
            foreach (var monomial in iPoly)
            {
                textBox1.AppendText(monomial.ToString());
            }
    
        }


    }

    // -1,3+128-2
    // -2x^3+2x^2-2x+1
    private (T coef, int lenght) ParseCoefficient<T>(string polynomial, int pos) where T : INumber<T>
    {
        string coef = "";
        int lenght = 0;
        if (polynomial[pos] == 'x')
        {
            var gValue = (T)Convert.ChangeType(1, typeof(T));
            return (gValue, lenght);
        }

        while (coef.Length == 0 || coef.Length >= 1 &&
               (polynomial[pos] != '+' && polynomial[pos] != '-' && polynomial[pos] != 'x' &&  polynomial[pos] != '^'))
        {
            coef += polynomial[pos];
            lenght++;
            pos++;
            if (pos == polynomial.Length)
                break;
        }
        return (T.Parse(coef, null), lenght);
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
        string exp = "";
        int lenght = 0;
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
    //TODO handle that exp add like coef!.
    public Dictionary<int,Monomial<T>> MonomialParser<T>(string polynomial) where T : INumber<T>
    {
        //List<Monomial<T>> monomials = new List<Monomial<T>>();
        Dictionary<int, Monomial<T>> monomials = new Dictionary<int, Monomial<T>>();
        int pos = 0;
        while (pos < polynomial.Length)
        {
            var (coef, coefLength) = ParseCoefficient<T>(polynomial, pos);
            pos += coefLength;
            var (nomial, nomialLength) = ParseNomial(polynomial, pos);
            pos += nomialLength;
            var (exp, expLength) = ParseExp(polynomial, pos);
            pos += expLength;
            Monomial<T> monomial = new Monomial<T>(coef, nomial, exp);
            if (monomial.GetNomial() == "x")
                monomials.Add(monomial.GetExp(), monomial);
            else if (monomial.GetNomial() == "")
                monomials.Add(0, monomial);

        }

        Polynomial<T> p1 = new Polynomial<T>(monomials);
        return monomials;
    }
}