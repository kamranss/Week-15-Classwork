// See https://aka.ms/new-console-template for more information



using Domain.Models;
using Service.Service;

Console.WriteLine("Please choose one of the option from Menu bar");
Console.WriteLine(
    "1 - Create Department: " +
    "2 - Update: " +
    "3 - Delete: " +
    "4 - GetbyId: " +
    "5 - GetbyName: " +
    "6 - GetAllbyMaxsize"+
    "7 - GetAllbyName");

string menuoption = Console.ReadLine();
int selectedbutton;
bool result = int.TryParse(menuoption, out selectedbutton);
GroupService service1 = new GroupService();

while (true)
{
    if (selectedbutton >8 && selectedbutton<0)
    {
        switch (selectedbutton)
        {
            case 1:
                Console.WriteLine("Plase write Group Name");
                string name = Console.ReadLine();
                Groupsizeagain:  Console.WriteLine("Please write Group MaxSize");
                string groupmaxsize = Console.ReadLine();
                int selectedsize;
                bool result1 = int.TryParse(groupmaxsize, out selectedsize);
                if (result1)
                {
                    Group group = new Group();
                    group.GroupName = name;
                    group.Maxsize = selectedsize;
                    Group newgroup = service1.Create(group);
                    Console.WriteLine($"{newgroup.Id} {newgroup.GroupName} {newgroup.Maxsize}");
                    break;

                }
                else
                {
                    Console.WriteLine("The Size whihc you have written is wrong. please try again");
                    goto Groupsizeagain;
                }
            case 7:
                
            default:
                break;
        }
    }
}
