// See https://aka.ms/new-console-template for more information

bool isMale = true;
bool isTall = true;

if (isMale && isTall){
    Console.WriteLine("You are a tall man");
} else if (isMale && !isTall) {
        Console.WriteLine("You are a small man");
} else if (!isMale && isTall){
        Console.WriteLine("You are a tall woman");
} else {
        Console.WriteLine("You are a small woman");
}