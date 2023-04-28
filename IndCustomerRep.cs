namespace mis_221_pa_5_gbmorris1
{
    public class IndCustomerRep
    {
        private string customerEmail;
        private string[] lines;

        public IndCustomerRep(string customerEmail) {
            this.customerEmail = customerEmail;
        }

        public void GenerateReport() {
            int count = 0;
            lines = File.ReadAllLines("transactions.txt");
            System.Console.WriteLine($"Training Session Report for {customerEmail}");
            System.Console.WriteLine("===========================================");
            System.Console.WriteLine("Session ID\tDate\t\tTime\tTrainer Name");
            foreach(string line in lines) {
                string[] temp = line.Split('#');
                if(temp[2] == customerEmail) {
                        System.Console.WriteLine($"{temp[0]}\t\t{temp[3]}\t{temp[4]}\t{temp[6]}");
                        count++;
                }
            }
            if(count==0) {
                System.Console.WriteLine("ERROR: No data found");
            }

        }
        public void SaveReport(string fileName) {
            int count = 0;
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine($"Training Session Report for {customerEmail}");
            writer.WriteLine("===========================================");
            writer.WriteLine("Session ID\tDate\t\tTime\tTrainer Name");
            foreach(string line in lines) {
                string[] temp = line.Split('#');
                if(temp[2] == customerEmail) {
                        writer.WriteLine($"{temp[0]}\t\t{temp[3]}\t{temp[4]}\t\t{temp[6]}");
                        count++;
                }
            }
            writer.Close();
        } 
    }
}