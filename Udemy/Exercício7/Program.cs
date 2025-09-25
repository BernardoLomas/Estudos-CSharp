public class Program
{
    public static void Main()
    {
        double mediaSetembro = 0;
        double mediaNovembro = 0;
        double contSetembro = 0;
        double contNovembro = 0;
        double[] temperaturasSetembro = new double[30]
        {
            27.0, 30.0, 27.5, 28.5, 28.2, 28.8, 28.3, 27.7, 28.4, 27.6,
            28.1, 27.9, 28.6, 27.4, 30.2, 28.8, 28.3, 27.7, 28.4, 27.6,
            29.1, 28.7, 31.0, 27.4, 30.2, 27.8, 28.3, 28.7, 28.4, 28.6
        };

        double[] temperaturasNovembro = new double[30]
            {
            26.0, 27.2, 28.5, 29.0, 26.5, 27.8, 28.1, 29.2, 26.3, 27.6,
            28.4, 29.1, 26.7, 27.9, 28.3, 29.5, 26.9, 27.1, 28.7, 29.3,
            26.8, 27.4, 28.2, 29.4, 20.6, 27.3, 28.6, 29.7, 20.4, 27.7
        };

        foreach (double temp in temperaturasSetembro)
        {
            contSetembro += temp;
            mediaSetembro = contSetembro / temperaturasSetembro;
        }
    }
}