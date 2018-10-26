using System;


namespace NupskouProject.Utils {

    public static class DifficultyExt {

        public static T Choose <T> (this Difficulty d, T onEasy, T onNormal, T onHard, T onLunatic) {
            switch (d) {
                case Difficulty.Easy:    return onEasy;
                case Difficulty.Normal:  return onNormal;
                case Difficulty.Hard:    return onHard;
                case Difficulty.Lunatic: return onLunatic;
                default:                 throw new ArgumentOutOfRangeException (nameof (d), d, null);
            }
        }

    }

}'n