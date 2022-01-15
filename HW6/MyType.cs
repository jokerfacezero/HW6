class Work
{
    public double F(double x)
    {
        return x * x - 50 * x + 10;
    }

    public double D(double x)
    {
        return (x - 50) / x + 10;
    }

    public double K(double x)
    {
        return x / x + 25;
    }

    public void SaveFunc(string fileName, double a, double b, double h, WorkWithDel Value)
    {
        FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        double x = a;
        while (x <= b)
        {
            bw.Write(Value(x));
            x += h;
        }
        bw.Close();
        fs.Close();
    }
    public double Load(string fileName)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        BinaryReader bw = new BinaryReader(fs);
        double min = double.MaxValue;
        double d;
        for (int i = 0; i < fs.Length / sizeof(double); i++)
        {
            d = bw.ReadDouble();
            if (d < min) min = d;
        }
        bw.Close();
        fs.Close();
        return min;
    }

}
