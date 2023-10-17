public class Car
{
    private string _model;
    private int _topSpeed;
    private double _engine;
    private double _km;
    private int _hp;

    public string Model
    {
        get => _model;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length > 10)
            {
                Console.WriteLine(" Model boş ola bilməz maksimum uzunluğu 10-dur ");
            }
            else 
                _model = value;
        }
    }
    public int TopSpeed
    {
        get => _topSpeed;
        set
        {
            if (value >= 10 && value <= 1000)
            {
                _topSpeed = value;
            }
            else 
                Console.WriteLine(" Topspeed minimum 10 maksimum 1000 ola bilər ");
        }
    }
    public double Engine
    {
        get => _engine;
        set
        {
            if (value >= 0.3 &&  value<= 10)
            {
                _engine = value;
            }
            else 
                Console.WriteLine("Engine  minimum 0.3 maksimum 10 ola bilər");
        }
    }
    public double Km
    {
        get => _km;
        set
        {
            if (value >= 0)
            {
                _km = value;
            }
            else 
                Console.WriteLine("km minimum 0 ola bilər");
        }
    }
    public int Hp
    {
        get => _hp;
        set
        {
            if (value >= 50 && value <= 1000)
            {
                _hp = value;
            }
            else 
                Console.WriteLine("Hp minimum 50 maksimum 1000 ola bilər");
        }

    }


}