namespace proba_1;

public class Tortburchak
{
    public Nuqta A, B, C, D;

    public Tortburchak(Nuqta A, Nuqta B, Nuqta C, Nuqta D)
    {
        this.A = A;
        this.B = B;
        this.C = C;
        this.D = D;
    }

    public double yuza()
    {
        double a = A.masofa(B);
        double b = B.masofa(C);
        double s = a * b;
        return s;
    }
}