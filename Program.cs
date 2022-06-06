// int[] numArray = new int[9];

// Three Basic Arrays
int[] numArray = {0,1,2,3,4,5,6,7,8};

string[] strArray = {"Tim", "Martin", "Nikki", "Sara"};

bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};


// List of Flavors

List<string> flavors = new List<string>();
flavors.Add("Chocolate");
flavors.Add("Mint Chocolate Chip");
flavors.Add("Cookie Dough");
flavors.Add("Moose Tracks");
flavors.Add("Cookies & Cream");

// Output length of list
Console.WriteLine(flavors.Count);
// Output 3rd item in list
Console.WriteLine(flavors[2]);
// Remove 3rd item from list
flavors.RemoveAt(2);
// Ouput new length of list
Console.WriteLine(flavors.Count);


// User Info Dictionary
// Create random number
Random rand = new Random();

Dictionary<string, string> user = new Dictionary<string, string>();
user.Add("Tim", flavors[rand.Next(4)]);
user.Add("Martin", flavors[rand.Next(4)]);
user.Add("Nikki", flavors[rand.Next(4)]);
user.Add("Sara", flavors[rand.Next(4)]);

foreach (var entry in user) {
    Console.WriteLine(entry.Key + " - " + entry.Value);
}
