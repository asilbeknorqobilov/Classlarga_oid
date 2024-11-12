namespace proba_1;

public class SPUchburchak
{
    
    public double a;
    public double b;

    public SPUchburchak(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public double yuza()
    {
        double d = (a * b) / 2;
        return d;
    }
    public double perimetr()
    {
        double c = a + b + Math.Sqrt(a * a + b * b);
        return c;
    }
}