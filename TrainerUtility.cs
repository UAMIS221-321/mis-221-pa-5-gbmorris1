namespace mis_221_pa_5_gbmorris1
{
    public class TrainerUtility
    {
        private string file = "trainers.txt";

        public void AddTrainer(Trainer trainer) {
            StreamWriter writer = new StreamWriter("trainers.txt", true);
            writer.WriteLine($"{trainer.GetTrainerId()}#{trainer.GetTrainerName()}#{trainer.GetMailingAddress()}#{trainer.GetTrainerEmail()}");
            writer.Close();
        }

        public void EditTrainer(int trainerId, Trainer editedTrainer)
        {
            string[] lines = File.ReadAllLines("trainers.txt");
            bool trainerFound = false;
            
            StreamWriter writer = new StreamWriter("trainers.txt");
            
            foreach (string line in lines)
            {
                string[] data = line.Split('#');
                    
                if (int.Parse(data[0]) == trainerId)
                {
                    writer.WriteLine($"{editedTrainer.GetTrainerId()}#{editedTrainer.GetTrainerName()}#{editedTrainer.GetMailingAddress()}#{editedTrainer.GetTrainerEmail()}");
                    trainerFound = true;
                }
                else
                {
                    writer.WriteLine(line);
                }
            }
            
            writer.Close();
            
            if (!trainerFound)
            {
                Console.WriteLine($"Trainer ID: {trainerId} not found.");
            }
        }


        public void DeleteTrainer(int trainerId)
        {
            string[] lines = File.ReadAllLines("trainers.txt");
            bool trainerFound = false;
    
            StreamWriter writer = new StreamWriter("trainers.txt");
    
            foreach (string line in lines)
            {
                string[] data = line.Split('#');
        
                if (int.Parse(data[0]) != trainerId)
                {
                    writer.WriteLine(line);
                }
                else
                {
                    trainerFound = true;
                }
            }
    
            writer.Close();
    
            if (!trainerFound)
            {
                Console.WriteLine($"Trainer ID: {trainerId} not found.");
            }
        }

    }
}
