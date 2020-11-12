using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        Console.WriteLine(extractInitials2("Bob Destroyer Hoskins "));
    }

    public static string extractInitials(string name) {
        string initials = ""+name[0];
        int spacePosition = name.IndexOf(" ");
        while (spacePosition >= 0) {
            if (spacePosition + 1 < name.Length) {
                initials += name[spacePosition + 1];
            }
            spacePosition = name.IndexOf(" ", spacePosition + 1);
        }
        return initials;
    }

    public static string extractInitials2(string name) {
        string initials = "";
        int p = 0;
        while (p >= 0 && p < name.Length) {
            initials += name[p];
            p = name.IndexOf(" ", p+1);
            if (p>0) {p+=1;}
        }
        return initials;
    }
}