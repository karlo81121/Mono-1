using mono;

static void WorkWithDog()
{
    Console.WriteLine("Give your dog a name:");
    string name = Console.ReadLine();
    Console.WriteLine();

    Random dogAge = new Random();
    int age = dogAge.Next(1, 15);

    Random dogWeight = new Random();
    double weight = Math.Round(dogWeight.NextDouble() * 5, 2);

    string type = "Mammal";

    Console.WriteLine("Please enter dog species: ");
    string species = Console.ReadLine();
    Console.WriteLine();

    bool hasLegs = true;

    Dog dog = new Dog(age, weight, type, species, hasLegs, name);
    List<Dog> dogs = new List<Dog>();
    dogs.Add(dog);

    Console.WriteLine("You created a dog with these attributes: ");
    Console.WriteLine("Name: " + dog.Name);
    Console.WriteLine("Age: " + dog.Age);
    Console.WriteLine("Weight: " + dog.Weight + " kg");
    Console.WriteLine("Type: " + dog.Type);
    Console.WriteLine("Species: " + dog.Species);
    Console.WriteLine("Legs: " + dog.Legs);

    Console.WriteLine();

    Console.WriteLine("You can do something with your dog.");
    Console.WriteLine("1 - Make it run.");
    Console.WriteLine("2 - Make it sleep.");
    Console.WriteLine("3 - Give it food.");
    Console.WriteLine("4 - Count how old is it in people age.");

    Console.WriteLine();

    string choosenDogOption = Console.ReadLine();

    switch (choosenDogOption)
    {
        case "1":
            Console.WriteLine();
            dog.Run();
            break;
        case "2":
            Console.WriteLine();
            dog.Sleep();
            break;
        case "3":
            Console.WriteLine();
            dog.EatFood();
            break;
        case "4":
            Console.WriteLine();
            Console.WriteLine("If your dog was a human it would be " + dog.CountDogAgeInPeopleAge() + " years old.");
            break;
    }
}

static void WorkWithBird()
{
    Random birdAge = new Random();
    int age = birdAge.Next(1, 10);

    Random birdWeight = new Random();
    double weight = Math.Round(birdWeight.NextDouble(), 2);

    string type = "Bird";

    Console.WriteLine("Please enter bird species: ");
    string species = Console.ReadLine();

    Console.WriteLine();

    bool hasLegs = true;

    Random birdWingspan = new Random();
    double wingspan = Math.Round(birdWingspan.NextDouble(), 2);

    Bird bird = new Bird(age, weight, type, species, hasLegs, wingspan);
    List<Bird> birds = new List<Bird>();
    birds.Add(bird);

    Console.WriteLine("You created a bird with these attributes: ");
    Console.WriteLine("Age: " + bird.Age);
    Console.WriteLine("Weight: " + bird.Weight + " kg");
    Console.WriteLine("Type: " + bird.Type);
    Console.WriteLine("Species: " + bird.Species);
    Console.WriteLine("Legs: " + bird.Legs);

    Console.WriteLine();

    Console.WriteLine("You can do something with your bird.");
    Console.WriteLine("1 - Make it run.");
    Console.WriteLine("2 - Make it sleep.");
    Console.WriteLine("3 - Give it food.");
    Console.WriteLine("4 - Measure its wingspan.");

    Console.WriteLine();

    string choosenBirdOption = Console.ReadLine();

    switch (choosenBirdOption)
    {
        case "1":
            Console.WriteLine();
            bird.Run();
            break;
        case "2":
            Console.WriteLine();
            bird.Sleep();
            break;
        case "3":
            Console.WriteLine();
            bird.EatFood();
            break;
        case "4":
            Console.WriteLine();
            Console.WriteLine("Wingspan of your bird is: " + bird.Wingspan + " meters.");
            Console.Write("That is a ");
            bird.MeasureWingspan();
            break;
    }
}

static void WorkWithSnake()
{
    Random snakeAge = new Random();
    int age = snakeAge.Next(1, 10);

    Random snakeWeight = new Random();
    double weight = Math.Round(snakeWeight.NextDouble() * 2, 2);

    string type = "Reptile";

    Console.WriteLine("Please enter snake species: ");
    string species = Console.ReadLine();

    Console.WriteLine();

    bool hasLegs = false;

    Random snakeLength = new Random();
    double length = Math.Round(snakeLength.NextDouble() * 10, 2);

    Snake snake = new Snake(age, weight, type, species, hasLegs, length);
    List<Snake> snakes = new List<Snake>();
    snakes.Add(snake);

    Console.WriteLine("You created a snake with these attributes: ");
    Console.WriteLine("Age: " + snake.Age);
    Console.WriteLine("Weight: " + snake.Weight + " kg");
    Console.WriteLine("Type: " + snake.Type);
    Console.WriteLine("Species: " + snake.Species);
    Console.WriteLine("Legs: " + snake.Legs);
    Console.WriteLine("Snake Length: " + snake.Length);

    Console.WriteLine();

    Console.WriteLine("You can do something with your snake.");
    Console.WriteLine("1 - Make it run.");
    Console.WriteLine("2 - Make it sleep.");
    Console.WriteLine("3 - Give it food.");
    Console.WriteLine("4 - Measure its length.");

    Console.WriteLine();

    string choosenSnakeOption = Console.ReadLine();

    switch (choosenSnakeOption)
    {
        case "1":
            Console.WriteLine();
            snake.Run();
            break;
        case "2":
            Console.WriteLine();
            snake.Sleep();
            break;
        case "3":
            Console.WriteLine();
            snake.EatFood();
            break;
        case "4":
            Console.WriteLine();
            Console.WriteLine("Lenght of a snake is " + snake.Length + " meters.");
            break;
    }
}

static void Main()
{
    Console.WriteLine("Choose an option: ");
    Console.WriteLine("1 - Create random dog.");
    Console.WriteLine("2 - Create random bird.");
    Console.WriteLine("3 - Create random snake.");
    Console.WriteLine();

    string choosenOption = Console.ReadLine();

    Console.WriteLine();

    switch (choosenOption)
    {
        case "1":
            WorkWithDog();
            break;

        case "2":
            WorkWithBird();
            break;

        case "3":
            WorkWithSnake();
            break;
    }
}

Main();