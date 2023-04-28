namespace mis_221_pa_5_gbmorris1
{
    public class Listing
    {
        private int listingId;
        private string trainerName;
        private DateOnly sessionDate;
        private TimeOnly sessionTime;
        private int sessionCost;
        private string sessionTaken;
    

        public Listing() {
        
        }
        //accessors and mutators
        public int GetListingId() {
            return listingId;
        }
        public void SetListingId(int listingId) {
            this.listingId = listingId;
        }
        public string GetTrainerName() {
            return trainerName;
        }
        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }
        public DateOnly GetSessionDate() {
            return sessionDate;
        }
        public void SetSessionDate(DateOnly sessionDate) {
            this.sessionDate = sessionDate;
        }
        public TimeOnly GetSessionTime() {
            return sessionTime;
        }
        public void SetSessionTime(TimeOnly sessionTime) {
            this.sessionTime =sessionTime;
        }
        public int GetSessionCost() {
            return sessionCost;
        }
        public void SetSessionCost(int sessionCost) {
            this.sessionCost = sessionCost;
        }
        public string GetSessionTaken() {
            return sessionTaken;
        }
        public void SetSessionTaken(string sessionTaken) {
            this.sessionTaken = sessionTaken;
        }


    }
}