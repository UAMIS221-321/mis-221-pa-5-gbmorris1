namespace mis_221_pa_5_gbmorris1
{
    public class Booking
    {
        private int sessionId;
        private string customerName;
        private string customerEmail;
        private DateOnly sessionDate;
        private TimeOnly sessionTime;
        private int trainerId;
        private string trainerName;
        private string status;

        public Booking() {

        }

        public int GetSessionId() {
            return sessionId;
        }
        public void SetSessionId(int sessionId) {
            this.sessionId = sessionId;
        }
        public string GetCustomerName() {
            return customerName;
        }
        public void SetCustomerName(string customerName) {
            this.customerName = customerName;
        }
        public string GetCustomerEmail() {
            return customerEmail;
        }
        public void SetCustomerEmail(string customerEmail) {
            this.customerEmail = customerEmail;
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
            this.sessionTime = sessionTime;
        }
        public int GetTrainerId() {
            return trainerId;
        }
        public void SetTrainerId(int trainerId) {
            this.trainerId = trainerId;
        }
        public string GetTrainerName() {
            return trainerName;
        }
        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }
        public string GetStatus() {
            return status;
        }
        public void SetStatus(string status) {
            this.status = status;
        }
    }

    
    }
