using System;

internal class Program
{
    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i} berisi: {storedData[i]}, yang disimpan pada waktu WIB: {inputDates[i]}");
            }
        }
    }

    static void Main()
    {

        SimpleDataBase<int> intDB = new SimpleDataBase<int>();
        intDB.AddNewData(10);
        intDB.AddNewData(30);
        intDB.AddNewData(22);
        intDB.PrintAllData();
        SimpleDataBase<string> stringDB = new SimpleDataBase<string>();

        stringDB.PrintAllData();

    }
}
