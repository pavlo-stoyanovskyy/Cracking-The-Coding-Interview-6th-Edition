namespace _1._1_Is_Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            IsUniqueChars("HelloWorld".ToLower());
        }

        static bool IsUniqueChars(string str)
        {
            int checker = 0;

            for (int i = 0; i < str.Length; i++)
            {
                int val = str[i] - 'a';               //make it start with 0 to 25
                if ((checker & (1 << val)) > 0)
                {
                    return false;
                }
                checker = checker | (1 << val);
            }

            return true;
        }

        //a	97	0
        //b	98	1
        //c	99	2
        //d	100	3
        //e	101	4
        //f	102	5
        //g	103	6
        //h	104	7
        //i	105	8
        //j	106	9
        //k	107	10
        //l	108	11
        //m	109	12
        //n	110	13
        //o	111	14
        //p	112	15
        //q	113	16
        //r	114	17
        //s	115	18
        //t	116	19
        //u	117	20
        //v	118	21
        //w	119	22
        //x	120	23
        //y	121	24
        //z	122	25

    }
}
