namespace _16_Indexer.Models
{
    internal class Number
    {
        public int[] arr;
        public int Capasity { get; set; } = 5;
        public int Count { get; set; }
        public Number()
        {
            arr = new int[Capasity];
        }

        public int this[int id]
        {
            get
            {
                if (id >= Count)
                {
                    throw new IndexOutOfRangeException("Arrayda bu parametrde deyer yoxdur");
                }
                return arr[id];
            }
            set
            { 
                arr[id] = value;
            }
        }

        public void Add(int value)
        {
            if(Count == arr.Length)
            {
                Array.Resize(ref arr, Count + Capasity);
            }
            arr[Count] = value;
            Count++;
        }

        public void RemoveAt(int id)
        {
            int[] newArr = new int[arr.Length];
            int j = 0;
            for (int i = 0 ; i < Count; i++)
            {
                if (i != id)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            arr = newArr;
        }

        public void IndexOf(int value)
        {
            for (int i = 0 ; i < Count;i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }

        public void LastIndexOf(int value)
        {
            for (int i = Count; i > 0; i--)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }

        public void GetElement()
        {
            for (int i = 0 ;i < Count;i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
