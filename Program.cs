cat();
Menu();



void cat(){
    Console.WriteLine("I don't know what you meant by display a cat, so here is this:");
    Console.WriteLine("Cat");
}

int addStuff(int num1, int num2){
    int num3 = num1 + num2;
    return num3;
}

int subtractStuff(int num1, int num2){
    int num3 = num1 + num2;
    return num3;
}

int multiplyStuff(int num1, int num2){
    int num3 = num1 + num2;
    return num3;
}

int divideStuff(int num1, int num2){
    int num3 = num1 + num2;
    return num3;
}

void Menu(){
/*Frankly I have no Idea what you mean by Driver Program, and becuase of my stupid lack of ablility 
to remember to go to lab class I missed the class and never had the chance to learn what it was 
So im hopeing that works, and is if doesn't than oh well, it's my fault. */
int decide = 0;
int num1 = 0;
int num2 = 0;
int awnser = 0;
while(true){
    try{
Console.WriteLine("What math equation do you want to do?");
Console.WriteLine("1:Add");
Console.WriteLine("2:Subtract");
Console.WriteLine("3:Multiply");
Console.WriteLine("4:Divide");
decide = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Okay now give me number 1");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Okay now give me number 2");
num2 = Convert.ToInt32(Console.ReadLine());
    }catch{
Console.WriteLine("Please input a number");
    }
    switch (decide){
        case 1:
            awnser = addStuff(num1,num2);
            break;
        case 2:
            awnser = subtractStuff(num1,num2);
            break;
        case 3:
            awnser = multiplyStuff(num1,num2);
            break;
        case 4:
            awnser = divideStuff(num1,num2);
            break;
    }
    Console.WriteLine($"The Awnser is {awnser}");
    break;
}
}