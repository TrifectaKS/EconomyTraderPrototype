using System.Runtime.CompilerServices;

namespace EconomyTraderPrototype
{
    public static class Randomizer
    {
        private static Random random = new Random();

        private static Random Random => random;

        public static void SetSeed(int seed)
        {
            random = new Random(seed);
        }

        /// <summary>
        /// Random.Next(min,max+1)
        /// </summary>
        /// <param name="min">Inclusive Minimum</param>
        /// <param name="max">Inclusive Maximum</param>
        public static int GetNumber(int min, int max)
        {
            return random.Next(min, max);
        }

        /// <summary>
        /// Random.Next(min,max+1)
        /// </summary>
        /// <param name="min">Inclusive Minimum</param>
        /// <param name="max">Exclusive Maximum</param>
        public static double GetNumber(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }
    }
}
