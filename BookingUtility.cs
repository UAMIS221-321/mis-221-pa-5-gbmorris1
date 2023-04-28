namespace mis_221_pa_5_gbmorris1
{
    public class BookingUtility
    {
        public void ViewAvailableSessions() {
            string[] lines = File.ReadAllLines("sessions.txt");
            System.Console.WriteLine("Available Training Sessions:");
            System.Console.WriteLine("===========================");
            System.Console.WriteLine("Session ID\tTrainer ID\tTrainer Name\tDate\tTime\tStatus");

            foreach(string line in lines) {
                string[] temp = line.Split('#');
                int sessionId = int.Parse(temp[0]);
                int trainerId = int.Parse(temp[1]);
                string trainerName = temp[2];
                string sessionDate = temp[3];
                string sessionTime = temp[4];
                System.Console.WriteLine($"{sessionId}\t\t{trainerId}\t\t{trainerName}\t{sessionDate}\t{sessionTime}\tOpen");
            }
        }
            public void BookSession(Booking booking) {
                StreamWriter writer = new StreamWriter("transactions.txt", true);
                writer.WriteLine($"{booking.GetSessionId()}#{booking.GetCustomerName()}#{booking.GetCustomerEmail()}#{booking.GetSessionDate()}#{booking.GetSessionTime()}#{booking.GetTrainerId()}#{booking.GetTrainerName()}#{booking.GetStatus()}");
                writer.Close();
            }
        

        public void DeleteBooking(int bookingId) {
            {
            string[] lines = File.ReadAllLines("sessions.txt");
            bool bookingFound = false;
    
            StreamWriter writer = new StreamWriter("sessions.txt");
    
            foreach (string line in lines)
            {
                string[] data = line.Split('#');
        
                if (int.Parse(data[0]) != bookingId)
                {
                    writer.WriteLine(line);
                }
                else
                {
                    bookingFound = true;
                }
            }
    
            writer.Close();
            }
        }
        public void UpdateBooking(int bookingId, Booking statusUpdate)
        {
            string[] lines = File.ReadAllLines("transactions.txt");
            bool bookingFound = false;
            
            using (StreamWriter writer = new StreamWriter("transactions.txt"))
            {
                foreach (string line in lines)
                {
                    string[] temp = line.Split('#');
                        
                    if (int.Parse(temp[0]) == bookingId)
                    {
                        writer.WriteLine($"{temp[0]}#{temp[1]}#{temp[2]}#{temp[3]}#{temp[4]}#{temp[5]}#{temp[6]}#{statusUpdate.GetStatus()}");
                        bookingFound = true;
                    }
                    else
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            
            if (!bookingFound)
            {
                Console.WriteLine($"Booking ID: {bookingId} not found.");
            }
        }
        public void AddSession(Booking booking) {
            StreamWriter writer = new StreamWriter("sessions.txt", true);
            writer.WriteLine($"{booking.GetSessionId()}#{booking.GetSessionDate()}#{booking.GetSessionTime()}#{booking.GetTrainerId()}#{booking.GetTrainerName()}#Open");
            writer.Close();
        }

    }
}