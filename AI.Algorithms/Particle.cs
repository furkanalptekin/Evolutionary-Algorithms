namespace AI.Algorithms
{
    public class Particle
    {
        public Particle pBest;
        public System.Windows.Point Values { get; set; }
        public System.Windows.Point Velocity { get; set; }

        public Particle(System.Windows.Point point)
        {
            Values = point;
        }
    }
}