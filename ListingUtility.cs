namespace mis_221_pa_5_gbmorris1
{
    public class ListingUtility
    {
        private string file = "listings.txt";

        public void AddListing(Listing listing) {
            StreamWriter writer = new StreamWriter("listings.txt", true);
            writer.WriteLine($"{listing.GetListingId()}#{listing.GetTrainerName()}#{listing.GetSessionDate()}#{listing.GetSessionTime()}#{listing.GetSessionCost()}#{listing.GetSessionTaken()}");
            writer.Close();
        
        }
        public void EditListing(int listingId, Listing editedListing) {
            string[] lines = File.ReadAllLines("listings.txt");
            bool trainerFound = false;
            
            StreamWriter writer = new StreamWriter("listings.txt");
            
            foreach (string line in lines)
            {
                string[] data = line.Split('#');
                    
                if (int.Parse(data[0]) == listingId)
                {
                    writer.WriteLine($"{editedListing.GetListingId()}#{editedListing.GetTrainerName()}#{editedListing.GetSessionDate()}#{editedListing.GetSessionTime}#{editedListing.GetSessionCost()}#{editedListing.GetSessionTaken()}");
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
                Console.WriteLine($"Listing ID: {listingId} not found.");
            }
        }

        public void DeleteListing(int listingId) {
            {
            string[] lines = File.ReadAllLines("listings.txt");
            bool listingFound = false;
    
            StreamWriter writer = new StreamWriter("listings.txt");
    
            foreach (string line in lines)
            {
                string[] data = line.Split('#');
        
                if (int.Parse(data[0]) != listingId)
                {
                    writer.WriteLine(line);
                }
                else
                {
                    listingFound = true;
                }
            }
    
            writer.Close();
    
            if (!listingFound)
            {
                Console.WriteLine($"Trainer ID: {listingId} not found.");
            }
        }
        }
    }
}