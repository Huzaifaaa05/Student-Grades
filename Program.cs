Console.Clear();
#nullable disable

// Student grade assignment

Console.WriteLine("\nWelcome to Student Grades!");

Random rnd = new Random();
int[] gradesArray = new int[35];
for (int i = 0; i < 35; i++) {
   gradesArray[i] = rnd.Next(100);
}

bool loop = true;
while (loop) {
   Console.WriteLine("\n1 Display All Grades");
   Console.WriteLine("2 Display Honours");
   Console.WriteLine("3 Stats");
   Console.WriteLine("4 Randomize Grades");
   Console.WriteLine("5 Exit\n");
   string userChoice = Console.ReadLine();
   if (userChoice == "1") {
      Console.WriteLine("\nALL GRADES\n");
      for (int n = 0; n < 35; n++) {
         Console.WriteLine(gradesArray[n] + "%");
      }
   } else if (userChoice == "2") {
      int honorsCount = 0;
      Console.WriteLine("\nHONOURS\n");
      for (int n = 0; n < 35; n++) {
         if (gradesArray[n] > 80) {
            Console.WriteLine(gradesArray[n] + "%");
            honorsCount++;
         }
      }
      Console.WriteLine($"\nThe number of honours grades: {honorsCount}");
   } else if (userChoice == "3") {
      Console.WriteLine("\nSTATS\n");
      Console.WriteLine($"Highest Grade: {gradesArray.Max()}%");
      Console.WriteLine($"Lowest Grade: {gradesArray.Min()}%");
      int sum = gradesArray.Sum();
      int length = gradesArray.Length;
      Console.WriteLine($"Average Grade: {sum / length}%");
   } else if (userChoice == "4") {
      Random r = new Random();
      for (int n = 0; n < 35; n++) {
         gradesArray[n] = r.Next(100);
      }
      Console.WriteLine("\nGRADES HAVE BEEN RANDOMIZED");
   } else if (userChoice == "5") {
      loop = false;
   } else {
      Console.WriteLine("\nINVALID CHOICE");
   }
}