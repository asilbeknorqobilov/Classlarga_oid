namespace proba_1;

public class Arifmetik
{
    public double a;
    public double b;

    public Arifmetik(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public double arifmetik()
    {
        return (a + b) / 2;
    }

    public double geometrik()
    {
        return Math.Sqrt(a * b);
    }
}