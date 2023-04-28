namespace mis_221_pa_5_gbmorris1
{
    public class WorkoutUser
    {
        public string name;
        public int age;
        public double weight;
        public double height;
        public DateOnly date;

        public WorkoutUser(string name, int age, double weight, double height, DateOnly date) {
            this.name= name;
            this.age=age;
            this.weight= weight;
            this.height= height;
            this.date = date;
        }
        
    }
}