using System;

namespace Darts
{
    public class Dart
    {
        private Random _randomSeed;
        public int ThrowScore { get; set; }
        public string ThrowInRing { get; set; }    // for bullseye, "inner" or "outer". For non-bullseye, "none", "inner", or "outer".

        // construct a new Dart
        public Dart(Random random)
        {
            _randomSeed = random;
        }

        //populate throwScore and throwInRing
        public void ThrowDart()
        {
            // get throwScore, the section of the dart board in which the throw landed. Bullseye is 0.
            this.ThrowScore = _randomSeed.Next(0,21);

            // determine whether the throw fell into a ring
            double ringRandom = _randomSeed.NextDouble();

            // for non-bullseyes (90% chance no ring, 5% chance inner ring, 5% chance outer ring)
            if (this.ThrowScore != 0)
            {
                if (ringRandom >= .10) this.ThrowInRing = "none";
                else if (ringRandom < .05) this.ThrowInRing = "inner";
                else this.ThrowInRing = "outer";
            } else
            {   // for a bullseye (5% chance inner bullseye, otherwise, outer ring of bullseye) 
                if (ringRandom >= .05) this.ThrowInRing = "outer";
                else this.ThrowInRing = "inner";
            }
        }
    }
}