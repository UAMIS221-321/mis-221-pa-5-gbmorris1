namespace mis_221_pa_5_gbmorris1
{
    public class Trainer
    {
        private int trainerId;
        private string trainerName;
        private string mailingAddress;
        private string trainerEmail;

        public Trainer() {

        }
        //accessor methods

        public int GetTrainerId() {
            return trainerId;
        }
        public string GetTrainerName() {
            return trainerName;
        }
        public string GetMailingAddress() {
            return mailingAddress;
        }
        public string GetTrainerEmail() {
            return trainerEmail;
        }

        public void SetTrainerId(int trainerId) {
            this.trainerId = trainerId;
        }
        public void SetTrainerName(string trainerName){
            this.trainerName = trainerName;
        }

        public void SetMailingAddress(string mailingAddress) {
            this.mailingAddress = mailingAddress;
        }
        public void SetTrainerEmail(string trainerEmail){
            this.trainerEmail= trainerEmail;
        }
    }
}