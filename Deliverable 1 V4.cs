// See https://aka.ms/new-console-template for more information
// Ask the user, “How many people are we making PB&J sandwiches for?”  
string repeatinput = "";
do
{
    Console.WriteLine("How many people are we making PB&J sandwiches for?");
    // Expect the user to enter a number. You’ll need to parse the input and store it in a number variable
    int userinput = int.Parse(Console.ReadLine());
    // List of units for project
    double slices_per_loaf = 28;
    double total_slices_needed = userinput * 2;
    double total_loaves_needed = total_slices_needed / slices_per_loaf;
    int total_loaves_needed_rounded_up = (int)Math.Ceiling(total_loaves_needed);
    double tablespoons_per_jar_of_peanut_butter = 32;
    double total_tablespoons_of_peanut_butter_needed = userinput * 2;
    double total_jars_of_peanut_butter_needed = total_tablespoons_of_peanut_butter_needed / tablespoons_per_jar_of_peanut_butter;
    int total_jars_of_peanut_butter_needed_rounded_up = (int)Math.Ceiling(total_jars_of_peanut_butter_needed);
    double teaspoons_of_jelly_per_jar = 48;
    double total_teaspoons_of_jelly_needed = 4 * userinput;
    double total_jars_of_jelly_needed = total_teaspoons_of_jelly_needed / teaspoons_of_jelly_per_jar;
    int total_jars_of_jelly_needed_rounded_up = (int)Math.Ceiling(total_jars_of_jelly_needed);
    Console.WriteLine("");
    Console.WriteLine("You Need:");
    Console.WriteLine("");
    {
        Console.WriteLine(total_slices_needed + " slices of bread");
    }
    {
        Console.WriteLine(total_tablespoons_of_peanut_butter_needed + " tablespoons of peanut butter");
    }
    {
        Console.WriteLine(total_teaspoons_of_jelly_needed + " teaspoons of jelly");
    }
    Console.WriteLine("");
    Console.WriteLine("Which is:");
    Console.WriteLine("");
    {
        if (userinput <= 14) Console.WriteLine(total_loaves_needed_rounded_up + " loaf of bread");
        else Console.WriteLine(total_loaves_needed_rounded_up + " loaves of bread");
    }
    {
        if (userinput <= 16) Console.WriteLine(total_jars_of_peanut_butter_needed_rounded_up + " jar of peanut butter.");
        else Console.WriteLine(total_jars_of_peanut_butter_needed_rounded_up + " jars of peanut butter.");
    }
    {
        if (userinput <= 12) Console.WriteLine(total_jars_of_jelly_needed_rounded_up + " jar of jelly.");
        else Console.WriteLine(total_jars_of_jelly_needed_rounded_up + " jars of jelly.");
    }
    Console.WriteLine("");
    Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
    repeatinput = Console.ReadLine();
}
while ((repeatinput == "yes") || (repeatinput == "y"));
    {
}
Console.WriteLine("Goodbye!");















