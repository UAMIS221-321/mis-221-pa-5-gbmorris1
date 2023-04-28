namespace mis_221_pa_5_gbmorris1
{
    public class RevenueReport
    {
        private const int NUM_YEARS = 10;
        private decimal[,] yearlyRevenue = new decimal[NUM_YEARS, 1];
        private decimal[,] monthlyRevenue = new decimal[NUM_YEARS, 12];

        public RevenueReport() {

        }

        private void ProcessTransaction(string line)
        {
            string[] data = line.Split('#');
            int yearIndex = int.Parse(data[2].Split('/')[2]) - 2014;
            decimal revenue = decimal.Parse(data[4]);
            int monthIndex = int.Parse(data[2].Split('/')[0]) - 1;
            yearlyRevenue[yearIndex, 0] += revenue;
            monthlyRevenue[yearIndex, monthIndex] += revenue;
        }

        public void GenerateReports()
        {
            using (StreamReader reader = new StreamReader("listings.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    ProcessTransaction(line);
                }
            }

            for (int i = 0; i < NUM_YEARS; i++)
            {
                Console.WriteLine($"Monthly Revenue Report for {2014 + i}\n");
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine($"Month {(j + 1).ToString("00")}: {monthlyRevenue[i, j]}");
                }

                Console.WriteLine("\nYearly Revenue Report\n");
                Console.WriteLine($"Total Revenue: ${yearlyRevenue[i, 0]}\n");
            }
        }

        public void SaveReports(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < NUM_YEARS; i++)
                {
                    writer.WriteLine($"Monthly Revenue Report for {2014 + i}\n");
                    for (int j = 0; j < 12; j++)
                    {
                        writer.WriteLine($"Month {(j + 1).ToString("00")}: {monthlyRevenue[i, j]}");
                    }

                    writer.WriteLine("\nYearly Revenue Report\n");
                    writer.WriteLine($"Total Revenue: ${yearlyRevenue[i, 0]}\n");
                }
            }
        }
    }
}


