// Querys the Player a qustion aboute what objekt it whas. 
Console.WriteLine("What kind of thing are we talking about?");
// Take the answer of the player is given to veribol a. For later use.
string a = Console.ReadLine();
// Querys the player aboute atrebuts that describe the objekt.
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
/* 
 * Takes the answer from the privuse qustion and givs it to veribol b. For later use.
 * Stores the string "of Doom" in veribol c for later use.
 * Stores the string "3000" in veribol d for later use.
 */
string b = Console.ReadLine();
string c = "of Doom";
string d = "3000";
// Uses all previusly mentiond verbols to construct a sentens.
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");