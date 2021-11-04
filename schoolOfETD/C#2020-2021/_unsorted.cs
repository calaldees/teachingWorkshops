		string expected_name = "Amy";
		string expected_password = "moose";
		
		Console.WriteLine("What is your name");
		string name = Console.ReadLine();
		Console.WriteLine("What is your password");
		string password = Console.ReadLine();
		
		if (name == expected_name && password == expected_password) {
			Console.WriteLine("You are " + expected_name + "! Hello!! and welcome!");
		} else {
			Console.WriteLine("You are not " + expected_name + "! Go away!");
		}




		// Task 1:  -5, -4 , -3 , .... 3, 4, 5
		// Task 2:  5, 4, 3 ... -4, -5
		// Task 3: 2, 4 ,6 , 8 ,10
		for (int counter=0 ; counter < 5 ;  counter = counter + 1) 
		{
			Console.WriteLine(counter);
		}


		string[] names = {"Bob", "Sally", "Tom", "James", "Allan", "Obi", "Moontas"};
		
		Random random = new Random();
		int randNo = random.Next(0, names.Length);
		Console.WriteLine("Dont tell the user, but the name is " + names[randNo]);
				
		string name = "";
		while (name != names[randNo]) {
			Console.WriteLine("Give me a name: " + String.Join(",",names));
			name = Console.ReadLine();
		}
		Console.WriteLine("We are out of the loop");
