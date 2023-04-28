using mis_221_pa_5_gbmorris1;
{
    //start main
    int userChoice = GetUserChoice();
    while(userChoice!=6) {//condition check
        RouteEm(userChoice);
        userChoice = GetUserChoice();
    }
    //End Main
    static int GetUserChoice() {
        DisplayMenu();
        string userChoice=Console.ReadLine();
        if(IsValidChoice(userChoice)) {
            return int.Parse(userChoice);
        }
        else return 0;
    }

    static void DisplayMenu() {
        Console.Clear();
        System.Console.WriteLine("Hello! Welcome to The Crimson Trainer!\nEnter 1 to Manage Trainer Data\nEnter 2 to Manage Listing Data\nEnter 3 to Manage Booking Data\nEnter 4 Access Reports\nEnter 5 for E-Trainer\nEnter 6 to Exit");
    }

    static bool IsValidChoice(string userInput) {
        if(userInput=="1" || userInput=="2" || userInput=="3" || userInput=="4" || userInput == "5" || userInput == "6") {
            return true;
        }
        return false;
    }

    static void RouteEm(int menuChoice) {
        if(menuChoice==1) {
            TrainerData();
        }
        else if(menuChoice==2) {
            ListingData();
        }
        else if(menuChoice ==3) {
            BookingData();
        }
        else if(menuChoice==4){
            RunReports();
        }
        else if(menuChoice==5){
            OnlineTrainer();
        }
        else if(menuChoice!=6){
            SayInvalid();
        }

        }
        static void SayInvalid() {
        System.Console.WriteLine("Invalid!");
        PauseAction();
        }
    static void PauseAction() {
        System.Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void TrainerData() {
        //start trainer main
        int userChoice = GetUserChoice1();
    while(userChoice!=4) {//condition check
        RouteOne(userChoice);
        userChoice = GetUserChoice1();
        //end trainer main
    }
    }
    //start trainer menu
    static void RouteOne(int menuChoice) {
        if(menuChoice==1) {
            AddTrainer();
        }
        else if(menuChoice==2) {
            EditTrainer();
        }
        else if(menuChoice ==3) {
            DeleteTrainer();
        }
        else if(menuChoice!=4){
            SayInvalid();
        }
    }
    static int GetUserChoice1() {
        DisplayMenu1();
        string userChoice=Console.ReadLine();
        if(IsValidChoice1(userChoice)) {
            return int.Parse(userChoice);
        }
        else return 0;
    }
    static bool IsValidChoice1(string userInput) {
        if(userInput=="1" || userInput=="2" || userInput=="3" || userInput=="4") {
            return true;
        }
        return false;
    }
    static void DisplayMenu1() {
        Console.Clear();
        System.Console.WriteLine("Enter 1 to Add Trainer Data\nEnter 2 to Edit Trainer Data\nEnter 3 Delete Trainer Data\nEnter 4 To Exit");
    }
    //end trainer menu
    static void AddTrainer() {
        TrainerUtility utility = new TrainerUtility();
        System.Console.WriteLine("Enter trainer ID:");
        int id = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter trainer name:");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter trainer mailing address:");
        string address = Console.ReadLine();
        System.Console.WriteLine("Enter trainer email address:");
        string email = Console.ReadLine();
        Trainer trainer = new Trainer();
        trainer.SetTrainerId(id);
        trainer.SetTrainerName(name);
        trainer.SetMailingAddress(address);
        trainer.SetTrainerEmail(email);
        utility.AddTrainer(trainer);
        System.Console.WriteLine("Trainer Successfully Added!");
        PauseAction();
    }
    static void EditTrainer() {
        TrainerUtility utility = new TrainerUtility();
        System.Console.WriteLine("Enter ID of Trainer you would like to Edit:");
        int editId = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter New Trainer Details\nTrainer ID:");
        int newId = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Trainer Name:");
        string newName = Console.ReadLine();
        System.Console.WriteLine("Enter Trainer Mailing Address:");
        string newAddress = Console.ReadLine();
        System.Console.WriteLine("Enter Email Address:");
        string newEmail = Console.ReadLine();
        Trainer editedTrainer = new Trainer();
        editedTrainer.SetTrainerId(newId);
        editedTrainer.SetTrainerName(newName);
        editedTrainer.SetMailingAddress(newAddress);
        editedTrainer.SetTrainerEmail(newEmail);
        utility.EditTrainer(editId, editedTrainer);
        System.Console.WriteLine("Trainer Successfully Edited");
        PauseAction();
    }
    static void DeleteTrainer() {
        TrainerUtility utility = new TrainerUtility();
        Trainer trainer = new Trainer();
        System.Console.WriteLine("Enter ID of Trainer to Delete:");
        int deleteId = int.Parse(Console.ReadLine());
        utility.DeleteTrainer(deleteId);
        System.Console.WriteLine("Trainer Successfully Deleted\nPress any Key to Continue");
        Console.ReadLine();
    }

    static void ListingData() {
        //start listing main
        int userChoice = GetUserChoice2();
        while(userChoice!=4) {//condition check
        RouteTwo(userChoice);
        userChoice = GetUserChoice2();
        }
    //end listing main
    }   
    //start listing menu
    static void RouteTwo(int menuChoice) {
        if(menuChoice==1) {
            AddListing();
        }
        else if(menuChoice==2) {
            EditListing();
        }
        else if(menuChoice ==3) {
            DeleteListing();
        }
        else if(menuChoice!=4){
            SayInvalid();
        }
    }
    static int GetUserChoice2() {
        DisplayMenu2();
        string userChoice=Console.ReadLine();
        if(IsValidChoice2(userChoice)) {
            return int.Parse(userChoice);
        }
        else return 0;
    }
    static bool IsValidChoice2(string userInput) {
        if(userInput=="1" || userInput=="2" || userInput=="3" || userInput=="4") {
            return true;
        }
        return false;
    }
    static void DisplayMenu2() {
        Console.Clear();
        System.Console.WriteLine("Enter 1 to Add Listing Data\nEnter 2 to Edit Listing Data\nEnter 3 Delete Listing Data\nEnter 4 To Exit");
    }
    //end listing menu

    static void AddListing() {
    ListingUtility utility = new ListingUtility();
    System.Console.WriteLine("Enter Listing ID:");
    int id = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter trainer name:");
    string name = Console.ReadLine();
    System.Console.WriteLine("Enter the Session Date:(must be in format mm/dd/year)");
    DateOnly date= DateOnly.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter the Session Time:(Enter in Milatary Time)");
    TimeOnly time = TimeOnly.Parse(Console.ReadLine());
    System.Console.WriteLine("Enter the session cost:");
    int cost = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Has the listing been taken?");
    string sessionTaken = Console.ReadLine();
    Listing listing = new Listing();
    listing.SetListingId(id);
    listing.SetTrainerName(name);
    listing.SetSessionDate(date);
    listing.SetSessionTime(time);
    listing.SetSessionCost(cost);
    listing.SetSessionTaken(sessionTaken);
    utility.AddListing(listing);
    System.Console.WriteLine("Listing Successfully Added!");
    PauseAction();
    }

    static void EditListing() {
        ListingUtility utility = new ListingUtility();
        System.Console.WriteLine("Enter ID of Listing you would like to edit:");
        int editId = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter new listing detailed\nEnter new Listing ID:");
        int newId = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter trainer name:");
        string newName = Console.ReadLine();
        System.Console.WriteLine("Enter the Session Date:(must be in format mm/dd/year)");
        DateOnly newDate= DateOnly.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the Session Time:(Enter in Military Time)");
        TimeOnly newTime = TimeOnly.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the session cost:");
        int newCost = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Has the listing been taken?");
        string newSessionTaken = Console.ReadLine();
        Listing editedListing = new Listing();
        editedListing.SetListingId(newId);
        editedListing.SetTrainerName(newName);
        editedListing.SetSessionDate(newDate);
        editedListing.SetSessionTime(newTime);
        editedListing.SetSessionCost(newCost);
        editedListing.SetSessionTaken(newSessionTaken);
        utility.EditListing(editId, editedListing);
        System.Console.WriteLine("Listing Successfully Edited");
        PauseAction();
    }

    static void DeleteListing() {
        ListingUtility utility = new ListingUtility();
        Listing listing = new Listing();
        System.Console.WriteLine("Enter ID of Listing to Delete:");
        int deleteId = int.Parse(Console.ReadLine());
        utility.DeleteListing(deleteId);
        System.Console.WriteLine("Listing Successfully Deleted\nPress any Key to Continue");
        PauseAction();

    }
    static void BookingData() {
        //start booking main
        int userChoice = GetUserChoice3();
    while(userChoice!=4) {//condition check
        RouteThree(userChoice);
        userChoice = GetUserChoice3();
        //end booking main
    }
    }
    //start booking menu
    static void RouteThree(int menuChoice) {
        if(menuChoice==1) {
            ViewBooking();
        }
        else if(menuChoice==2) {
            MakeBooking();
        }
        else if(menuChoice ==3) {
            AddBooking();
        }
        else if(menuChoice !=4){
            SayInvalid();
        }
    }
    static int GetUserChoice3() {
        DisplayMenu3();
        string userChoice=Console.ReadLine();
        if(IsValidChoice3(userChoice)) {
            return int.Parse(userChoice);
        }
        else return 0;
    }
    static bool IsValidChoice3(string userInput) {
        if(userInput=="1" || userInput=="2" || userInput=="3" || userInput=="4" ) {
            return true;
        }
        return false;
    }
    static void DisplayMenu3() {
        Console.Clear();
        System.Console.WriteLine("Enter 1 to View Available Sessions\nEnter 2 to Book A Session or Update a Booking\nEnter 3 to Add a Session(Trainers ONLY)\nEnter 4 To Exit");
    }
    //end booking menu

    static void ViewBooking() {
        BookingUtility utility = new BookingUtility();
        utility.ViewAvailableSessions();
        PauseAction();
    }

    static void MakeBooking() {
        System.Console.WriteLine("Press 1 To Book a Session\nPress 2 To Update A Booking");
        int userChoice = int.Parse(Console.ReadLine());
        if(userChoice==1) {
            BookingUtility utility = new BookingUtility();
            Booking booking = new Booking();
            System.Console.WriteLine("Enter Session ID of Session You Want to Book:");
            int id = int.Parse(Console.ReadLine());
            utility.DeleteBooking(id);
            System.Console.WriteLine("Enter Your Name:");
            string custName = Console.ReadLine();
            System.Console.WriteLine("Enter Your Email:");
            string email = Console.ReadLine();
            System.Console.WriteLine("Enter the session date:(must be in format mm/dd/year)");
            DateOnly date = DateOnly.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the session time:(Must be in Military Time hh:mm)");
            TimeOnly time = TimeOnly.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Trainer ID:");
            int trainerId = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer name:");
            string trainerName = Console.ReadLine();
            booking.SetStatus("Booked");
            booking.SetSessionId(id);
            booking.SetCustomerName(custName);
            booking.SetCustomerEmail(email);
            booking.SetSessionDate(date);
            booking.SetSessionTime(time);
            booking.SetTrainerId(trainerId);
            booking.SetTrainerName(trainerName);
            utility.BookSession(booking);
            System.Console.WriteLine("Booking Complete!");
            PauseAction();
        }
        else if(userChoice==2) {
            BookingUtility utility = new BookingUtility();
            System.Console.WriteLine("Enter the Session ID of the Session You Want to Update The Status of:");
            int bookingId = int.Parse(Console.ReadLine());
            Console.Write("Enter new status (cancelled/completed): ");
            string status = Console.ReadLine();
            Booking statusUpdate = new Booking();
            statusUpdate.SetStatus(status);
            utility.UpdateBooking(bookingId, statusUpdate);
            System.Console.WriteLine("Status Successfully Updated!");
            PauseAction();
        }
    }
    static void AddBooking() {
            BookingUtility utility = new BookingUtility();
            Booking booking = new Booking();
            System.Console.WriteLine("Enter Session ID:");
            int id = int.Parse(Console.ReadLine());
            utility.DeleteBooking(id);
            System.Console.WriteLine("Enter the session date:(must be in format mm/dd/year");
            DateOnly date = DateOnly.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the session time:(Must be in Military Time)");
            TimeOnly time = TimeOnly.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the Trainer ID:");
            int trainerId = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter the trainer name:");
            string trainerName = Console.ReadLine();
            booking.SetSessionId(id);
            booking.SetSessionDate(date);
            booking.SetSessionTime(time);
            booking.SetTrainerId(trainerId);
            booking.SetTrainerName(trainerName);
            utility.AddSession(booking);
            System.Console.WriteLine("Session Successfully Added!");
            PauseAction();
    }
    static void RunReports() {
         //start booking main
        int userChoice = GetUserChoice4();
        while(userChoice!=4) {//condition check
        RouteFour(userChoice);
        userChoice = GetUserChoice4();
        //end booking main
        }
    }
        //start booking menu
    static void RouteFour(int menuChoice) {
        if(menuChoice==1) {
            IndividualReports();
        }
        else if(menuChoice==2) {
            HistoricalReports();
        }
        else if(menuChoice ==3) {
            RevenueReports();
        }
        else if(menuChoice !=4){
            SayInvalid();
        }
    }
    static int GetUserChoice4() {
        DisplayMenu4();
        string userChoice=Console.ReadLine();
        if(IsValidChoice4(userChoice)) {
            return int.Parse(userChoice);
        }
        else return 0;
    }
    static bool IsValidChoice4(string userInput) {
        if(userInput=="1" || userInput=="2" || userInput=="3" || userInput=="4" ) {
            return true;
        }
        return false;
    }
    static void DisplayMenu4() {
        Console.Clear();
        System.Console.WriteLine("Enter 1 to Access Individual Customer Session Reports\nEnter 2 to Access Historical Customer Session Reports\nEnter 3 to Access Historical Revenue Reports\nEnter 4 To Exit");
    }
    //end booking menu
    static void IndividualReports() {
        System.Console.WriteLine("Please enter the customer email to generate report:");
        string email = Console.ReadLine();
        IndCustomerRep report = new IndCustomerRep(email);
        report.GenerateReport();
        PauseAction();
        System.Console.WriteLine("Would you like to save the report to a file?\nEnter 1 For Yes\nEnter 2 For No");
        int userChoice = int.Parse(Console.ReadLine());
        if(userChoice==1) {
            System.Console.WriteLine("Enter file name to save report to");
            string fileName = Console.ReadLine();
            report.SaveReport(fileName);
            System.Console.WriteLine("File Saved!");
        }
        PauseAction();

    }
    static void HistoricalReports() {
        HistCustReport report = new HistCustReport();
        report.GenerateReport();
        PauseAction();
        System.Console.WriteLine("Would you like to save the report to a file?\nEnter 1 For Yes\nEnter 2 For No");
        int userChoice = int.Parse(Console.ReadLine());
        if(userChoice==1) {
            System.Console.WriteLine("Enter file name to save report to");
            string fileName = Console.ReadLine();
            report.SaveReport(fileName);
            System.Console.WriteLine("File Saved!");
        }
        PauseAction();
    }
    static void RevenueReports() {
        RevenueReport report = new RevenueReport();
        report.GenerateReports();
        System.Console.WriteLine("Would you like to save the report to a file?\nEnter 1 For Yes\nEnter 2 For No");
        int userChoice = int.Parse(Console.ReadLine());
        if(userChoice==1) {
            System.Console.WriteLine("Enter file name to save report to");
            string fileName = Console.ReadLine();
            report.SaveReports(fileName);
            System.Console.WriteLine("File Saved!");
        }
        PauseAction();
    }
    static void OnlineTrainer() {
        Console.WriteLine("Welcome to the EFitness Program!");
            Console.WriteLine();

            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Please enter your weight in pounds: ");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Please enter your height in inches: ");
            double height = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Please enter today's date: mm/dd/year");
            DateOnly date = DateOnly.Parse(Console.ReadLine());
            WorkoutUser user = new WorkoutUser(name, age, weight, height, date);
            System.Console.WriteLine("Please select your Workout\nEnter 1 For Upper Body\nEnter 2 for Lower Body\nEnter 3 For Core");
            int userInput = int.Parse(Console.ReadLine());
            WorkoutPlan workout = new WorkoutPlan();
            if(userInput==1){
                workout.UpperBodyWorkout(user); 
            }
            else if(userInput==2) {
                workout.LowerBodyWorkout(user);
            }
            else if(userInput==3) {
                workout.CoreWorkout(user);
            }
            System.Console.WriteLine("Have a nice day!");
            PauseAction();
    }
}
