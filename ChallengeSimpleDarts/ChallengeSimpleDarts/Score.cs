using Darts;

namespace ChallengeSimpleDarts
{
    public static class Score
    {
        public static int CalcDartThrow(Dart dart)
        {
            int throwScore = dart.ThrowScore;

            // calc non-bullseye
            if (throwScore != 0)
            {
                if (dart.ThrowInRing == "inner") throwScore *= 3;
                else if (dart.ThrowInRing == "outer") throwScore *= 2;                
            } else
            {
                //calc bullseye
                if (dart.ThrowInRing == "inner") throwScore = 50;
                else throwScore = 25;
            }
            return throwScore;
        }

    }
}