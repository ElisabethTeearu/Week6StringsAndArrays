
string userName = "Elisabeth";

Console.WriteLine(userName.Length);
Console.WriteLine($"The last letter in your name is {userName[userName.Length - 1]}.");

string updatedUsername = userName.Replace('a', '4').Replace('e', '3');

Console.WriteLine(updatedUsername);

//int counter = 0;

//for (int i = 0; i < userName.Length; i++)
//{
//    if (userName[i] == 'a')
//    {
//        counter++;
//    }
//}

//Console.WriteLine($"Your first name has {counter} a-letters.");