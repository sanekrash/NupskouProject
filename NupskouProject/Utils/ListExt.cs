using System;
using System.Collections.Generic;


namespace NupskouProject.Utils {

    public static class ListExt {

        public static void Shuffle <T> (this IList <T> list, Random random) {
            for (int n = list.Count; n > 1;) {
                int k    = random.Next (n--);
                var temp = list[n];
                list[n] = list[k];
                list[k] = temp;
            }
        }

    }

}