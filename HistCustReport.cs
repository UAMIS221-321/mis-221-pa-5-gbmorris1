namespace mis_221_pa_5_gbmorris1 
{


class HistCustReport
{
    private string fileName;

    public HistCustReport()
    {
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating Historical Customer Sessions Report...");

        string[] lines = File.ReadAllLines("transactions.txt");

        if (lines.Length == 0)
        {
            Console.WriteLine("No sessions found.");
            return;
        }
        SelectionSort(lines);

        string currentCustomer = "";
        int numSessions = 0;

        foreach (string line in lines)
        {
            string[] fields = line.Split('#');
            string email = fields[2];

            if (email != currentCustomer)
            {
                if (currentCustomer != "")
                {
                    Console.WriteLine($"{currentCustomer}: {numSessions} sessions");
                }

                currentCustomer = email;
                numSessions = 0;
            }
            Console.WriteLine($"{fields[2]} on {fields[3]} with trainer {fields[5]}");

            numSessions++;
        }
        Console.WriteLine($"{currentCustomer}: {numSessions} sessions");
    }

    private void SelectionSort(string[] temp)
    {
        int n = temp.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (CompareLines(temp[j], temp[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                Swap(temp, i, minIndex);
            }
        }
    }

    private int CompareLines(string line1, string line2)
    {
        string[] email1 = line1.Split('#');
        string[] email2 = line2.Split('#');

        int compare = email1[2].CompareTo(email2[2]); 

        if (compare == 0)
        {
            compare = email1[3].CompareTo(email2[3]);
        }

        return compare;
    }

    private void Swap(string[] arr, int i, int j)
    {
        string temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    public void SaveReport(string fileName)
    {
       StreamWriter writer = new StreamWriter(fileName);

        string[] lines = File.ReadAllLines("transactions.txt");

        if (lines.Length == 0)
        {
            writer.WriteLine("No sessions found.");
            return;
        }
        SelectionSort(lines);

        string currentCustomer = "";
        int numSessions = 0;

        foreach (string line in lines)
        {
            string[] fields = line.Split('#');
            string email = fields[2];

            if (email != currentCustomer)
            {
                if (currentCustomer != "")
                {
                    writer.WriteLine($"{currentCustomer}: {numSessions} sessions");
                }

                currentCustomer = email;
                numSessions = 0;
            }
            writer.WriteLine($"{fields[2]} on {fields[3]} with trainer {fields[5]}");

            numSessions++;
        }
        writer.WriteLine($"{currentCustomer}: {numSessions} sessions");
        writer.Close();
    }

    }
}
