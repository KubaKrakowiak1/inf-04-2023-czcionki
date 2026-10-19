class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] tab = new int[100];

        for(int i  = 0; i < tab.Length; i++)
        {
            tab[i] = rand.Next();
        }

        Sortowanie(tab);
    }

    static void Sortowanie(int[] tab)
    {
        for(int i = 0; i < tab.Length - 1; i++)
        {
            bool bylaZmiana = false;
            for(int j = 0; j < tab.Length - i - 1; j++)
            {
                if(tab[j] > tab[j + 1])
                {
                    int temp = tab[j];
                    tab[j] = tab[j + 1];
                    tab[j + 1] = temp;

                    bylaZmiana = true;
                }

            }
                if (!bylaZmiana)    
                {
                    break;
                }
        }

        foreach(int i in tab)
        {
            Console.WriteLine(i);
        }
    }
}