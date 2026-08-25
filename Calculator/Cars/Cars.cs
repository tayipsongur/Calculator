namespace Calculator.Cars
{
    public abstract class Cars
    {
        public abstract int TekerSayısı();
        public abstract string Renk();
        public abstract decimal Fiyat();
    }

    public class Volvo : Cars
    {
        public override decimal Fiyat()
        {
            decimal price = 100000000;
            return price;
        }
        public override string Renk()
        {
            var response = "Sarı";
            return response;
        }
        public override int TekerSayısı()
        {
            int teker = 4;
            return teker;
        }
    }

    public class BMW : Cars
    {
        public override decimal Fiyat()
        {
            decimal price = 500000000;
            return price;
        }

        public override string Renk()
        {
            throw new NotImplementedException();
        }

        public override int TekerSayısı()
        {
            throw new NotImplementedException();
        }
    }

    public class Audi : Cars
    {
        public override decimal Fiyat()
        {
            throw new NotImplementedException();
        }

        public override string Renk()
        {
            throw new NotImplementedException();
        }

        public override int TekerSayısı()
        {
            throw new NotImplementedException();
        }
    }

}
