using System;

internal class Program
{

    class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T angka1, T angka2, T angka3)
        {
            dynamic temp = (dynamic)angka1;
            dynamic temp2 = (dynamic)angka2;
            dynamic temp3 = (dynamic)angka3;
            dynamic terbesar = temp;

            if (temp2 > terbesar)
            {
                terbesar = temp2;
            }
            if (temp3 > terbesar)
            {
                terbesar = temp3;
            }

            return terbesar;

        }
        static void Main()
        {
            PemrosesData pemrosesandata = new PemrosesData();
            Console.WriteLine($"Nilai terbesar adalah :  {pemrosesandata.DapatkanNilaiTerbesar(10.00, 30.00, 22.00)}");

        }
    }
}