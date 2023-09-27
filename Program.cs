using HW_2._2_oop;


Console.WriteLine("Enter Team Name:");
string teamName = Console.ReadLine();
Team team = new Team(teamName);

while (true)
{
    Console.WriteLine("Choose option: (1) Add Devops, (2) Add Manager, (3) Show team, (4) Show information about members in team, (5) Exit");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter developer`s name, position, workday:");
            string devName = Console.ReadLine();
            string devPos = Console.ReadLine();
            string devWD = Console.ReadLine();
            Developer dev = new Developer(devName, devPos, devWD);
            team.AddWorker(dev);
            break;

        case "2":
            Console.WriteLine("Enter meneger`s name, position, workday:");
            string mgrName = Console.ReadLine();
            string mgrPos = Console.ReadLine();
            string mgrDW = Console.ReadLine();
            Manager mgr = new Manager(mgrName, mgrPos, mgrDW);
            team.AddWorker(mgr);
            break;

        case "3":
            team.WatchInf();
            break;

        case "4":
            team.GetDetailInf();
            break;

        case "5":
            return;

        default:
            Console.WriteLine("Uncorrect answer, try again.");
            break;
    }
}

