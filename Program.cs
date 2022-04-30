namespace name 
{
    class Program 
    {
        public static void Main()
        {

            //reso = resorses 
          Data reso1 = new Data("FreeCodeCamp", "https://www.freecodecamp.org/learn/","html&css","This is used to learn basics in many languages", "Noob-intermidiate", "Quincy Larson"); 



        Console.Write("The resorse name is: ");
        Console.WriteLine(reso1.name);

        Console.Write("The resorse link is: ");
        Console.WriteLine(reso1.link);

        Console.Write("It is for this lang: ");
        Console.WriteLine(reso1.lang);

        Console.Write("The discription: ");
        Console.WriteLine(reso1.dis);

        Console.Write("Skill required: ");
        Console.WriteLine(reso1.skill);

        Console.Write("The author-maker: ");
        Console.WriteLine(reso1.maker);




            
        }
    }
}
