namespace proba_1;

public class Raqam
{
    public int a;

    public Raqam(int a)
    {
        this.a = a;
    }

    public int raqamy()
    {
        return a / 100 + a % 10 + (a / 10) % 10;
    }
    
    public int raqamk()
    {
        return ((a / 100) * (a % 10) * ((a / 10) % 10));
    }
}   