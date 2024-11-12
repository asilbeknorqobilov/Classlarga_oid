namespace proba_1;

public class Kordinatauchburchak
{
    public Nuqta A, B, C;

    public Kordinatauchburchak(Nuqta A, Nuqta B, Nuqta C)
    {
        this.A = A;
        this.B = B;
        this.C = C;
    }

    public double yuz()
    {
        double a = A.masofa(B);
        double b = A.masofa(C);
        double c = C.masofa(B);
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

}