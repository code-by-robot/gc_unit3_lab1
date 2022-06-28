string[] names = { "Justin Jones", "Connor Wood", "Kris Pranger", "Josh Carolin", "Krista Anderson", "Travis Amador", "Asia Drew", "Ali Al-Hashemi", "Vinh Dang", "Tolulope Olubunmi", "Robot Haupt", "Matt Fox", "Daniel Schuler", "Anthony Ventura", "Mara Johnson", "Brandon Harman", "Olukayode Olubunmi" };
string[] food = { "Baja Blast", "Chicken Sandwich", "Sushi", "Naleśniki", "Sushi", "General Tso's", "Jerk chicken", "Steak", "Sushi", "Rice and Dodo", "Bread", "Steak", "BBQ", "Thai", "tacos", "Pasta", "Pounded Yam" };
string[] hometown = { "Wyoming, MI", "Grosse Pointe, MI", "Grosse Pointe, MI", "Westland, MI", "Grosse Ile, MI", "Brown City, MI", "Detroit, MI", "Dearborn Heights, MI", "Shelby, MI", "Asese, Nigeria", "Green Bay, WI", "Sterling Heights, MI", "Potterville, MI", "Canton, MI", "Rochester, MI", "Dallas, TX", "Ibadan, Nigeria" };
bool runProgram = true;

while (runProgram == true)
{
    //find index from user
    Console.WriteLine("Welcome! Which student would you like to learn more about? Enter a number 1-17, a full student name, or 'names' to see all student names: ");
    string userinput = Console.ReadLine();
    var IsNumeric = int.TryParse(userinput, out int userindex);
    int index = userindex - 1;
    bool containsName = false;

    //check if numeric
    if (IsNumeric == false && userinput.ToLower().Trim() == "names")
    {
        //give option to print all names
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }   
    else
    {
        if (IsNumeric == false)
        {
            //loops over all names to see if name entered is in class
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].ToLower().Trim() == userinput.ToLower().Trim())
                {
                    index = i;
                    containsName = true;
                    Console.WriteLine($"You have searched for {names[i]}.");
                }
            }
            if (containsName == false)
            {
                Console.WriteLine($"{userinput.Trim()} is not in this class. Please try again.");
                continue;
            }
        }
        //validate input in range
        else if (index < 0 || index >= names.Length)
        {
            Console.WriteLine("That number is not in range, please try again. ");
            continue;
        }
        else
        {
            //print student name
            Console.WriteLine($"Student {userindex} is {names[index]}.");
        }

        //ask for input on what info to display
        while (true)
        {
            Console.WriteLine("What would you like to know? Enter 'hometown' or 'favorite food'.");
            string userinput2 = Console.ReadLine();
            //displays hometown
            if (userinput2.ToLower().Trim() == "hometown")
            {
                Console.WriteLine($"{names[index]} is from {hometown[index]}.");
                break;
            }
            //displays food
            else if (userinput2.ToLower().Trim() == "favorite food" || userinput2.ToLower().Trim() == "food")
            {
                Console.WriteLine($"{names[index]}'s favorite food is {food[index]}.");
                break;
            }
            //tells that option isn't available
            else
            {
                Console.WriteLine("That category does not exist. Please try again.");
            }
        }
    }
    
    // Ask to end loop
    Console.WriteLine("Would you like to learn about another student? y/n");
    string userchoice = Console.ReadLine();
    runProgram = userchoice.ToLower().Trim() != "y" ? false : true;
}