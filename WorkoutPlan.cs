namespace mis_221_pa_5_gbmorris1
{
   public class WorkoutPlan
    {
   
        public void UpperBodyWorkout(WorkoutUser user) {
            System.Console.WriteLine($"Welcome to EGym Upper Body Day {user.name}!");
            System.Console.WriteLine($"The First Exercise is Bench Press\nYou Will Do 3 Sets of 12 Repetitions of " + user.weight * 0.75 + " pounds");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("The Next Exercise is Dumbbell Curls\nYou will do 3 Sets with 12 Repititions of " + user.weight * .15 + " pounds");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("The Next Exercise is Pull-Ups\nYou will do 3 sets for 12 repetitions");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("Workout Complete!\nWould you like to save your workout?\nEnter 1 for Yes\nEnter 2 for No");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput==1) {
                System.Console.WriteLine("What would you like to call the saved file?");
                string fileName = Console.ReadLine();
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine($"UPPER BODY WORKOUT FOR {user.name}\tAGE:{user.age} DATE: {user.date}\nBench Press: " + user.weight * 0.75 + " pounds for 3 Sets and 12 Repititions\nBicep Curls: "+ user.weight*.2 +" pounds for 3 sets and 12 repetitions\nPull Ups: 3 Sets for 12 Repetitions");
                writer.Close();
            }
   }
        public void LowerBodyWorkout(WorkoutUser user) {
            System.Console.WriteLine($"Welcome to EGym Lower Body Day {user.name}!");
            System.Console.WriteLine($"The First Exercise is Barbell Squat\nYou Will Do 3 Sets of 12 Repetitions of " + user.weight + " pounds");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("The Next Exercise is Quad Extensions\nYou will do 3 Sets with 12 Repititions of " + user.weight * .5 + " pounds");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("The Next Exercise is Hamstring Curls\nYou will do 3 sets for 12 repetitions of " + user.weight * .4 + " pounds");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("Workout Complete!\nWould you like to save your workout?\nEnter 1 for Yes\nEnter 2 for No");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput==1) {
                System.Console.WriteLine("What would you like to call the saved file?");
                string fileName = Console.ReadLine();
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine($"LOWER BODY WORKOUT FOR {user.name}\tAGE:{user.age} DATE: {user.date}\nSquat: " + user.weight  + " pounds for 3 Sets and 12 Repititions\nQuad Extensions: "+ user.weight*.5 +" pounds for 3 sets and 12 repetitions\nHamstring Curls: " + user.weight*.4 +" pounds for 3 Sets for 12 Repetitions");
                writer.Close();
            }
        }
        public void CoreWorkout(WorkoutUser user) {
            System.Console.WriteLine($"Welcome to EGym Core Day {user.name}!");
            System.Console.WriteLine($"The First Exercise is Sit-Ups\nYou Will Do 3 Sets of 12 Repetitions of Sit-Ups");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("The Next Exercise is Russian Twists\nYou will do 3 Sets with 12 Repititions of " + user.weight * .1 + " pounds");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("The Next Exercise is Planks\nYou will do 3 sets for 1 minute each");
            System.Console.WriteLine("Press Enter After Each Set");
            Console.ReadKey();
            System.Console.WriteLine("Set 1 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Set 2 Complete!");
            Console.ReadKey();
            System.Console.WriteLine("Exercise Complete! Great Job\nPress Any Key to Continue");
            Console.ReadKey(); Console.Clear();
            System.Console.WriteLine("Workout Complete!\nWould you like to save your workout?\nEnter 1 for Yes\nEnter 2 for No");
            int userInput = int.Parse(Console.ReadLine());
            if(userInput==1) {
                System.Console.WriteLine("What would you like to call the saved file?");
                string fileName = Console.ReadLine();
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine($"CORE BODY WORKOUT FOR {user.name}\tAGE:{user.age} DATE: {user.date}\nSit-Ups: For 3 Sets and 12 Repititions\nRussian Twists: "+ user.weight*.1 +" pounds for 3 sets and 12 repetitions\nPlanks: 3 Sets for 1 Minute Each");

                writer.Close();
            }
        }
    }
}