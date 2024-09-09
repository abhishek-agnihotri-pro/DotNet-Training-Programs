    public static class StringExtension{
        public static int WordCount(this string str){
            return str.Split(new char[]{' ','.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }
        public static int MulBy2(this int num){
            return num*2;
        }
    }


    // public static class IntegerExtension{
    //     public static int MulBy2(this int num){
    //         return num*2;
    //     }
    // }
