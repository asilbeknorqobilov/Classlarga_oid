namespace proba_1;

public class Aylana
{
        public double r;

        public Aylana(double r)
        {
                this.r = r;
        }

        public double aylanauzunlik()
        {
                double l = 2 * Math.PI * r;
                return l;
        }
        public double doirayuzi()
        {
                double s = Math.PI * r * r;
                return s;
        }
}