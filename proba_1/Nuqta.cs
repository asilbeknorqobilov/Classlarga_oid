namespace proba_1;

public class Nuqta
{
    public double x = 0;
    public double y = 0;

    public Nuqta(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double masofa(Nuqta n)
    {
        double d = Math.Sqrt(Math.Pow(this.x - n.x, 2) + Math.Pow(y - n.y, 2));
        return d;
    }
}