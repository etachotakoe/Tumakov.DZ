namespace HeatingSeason
{
    public class Temperament
    {
        public int Scandalous { get; set; } // от 0 до 10
        public int Smart { get; set; } // 1 - умный, 0 - тупой

        public Temperament(int scandalous, int smart)
        {
            Scandalous = scandalous;
            Smart = smart;
        }
    }
}
