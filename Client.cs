using System;

namespace AbstractFactory
{
    class Client
    {
        static void Main(string[] args)
        {
            ITuwaiqMember studentFactory = new Student();
            ITuwaiqMember instructorFactory = new Instructor();

            var trainee1 = studentFactory.GetAdvancedMember();
            var trainee2 = studentFactory.GetBasicMember();

            var trainer1 = instructorFactory.GetAdvancedMember();
            var trainer2 = instructorFactory.GetBasicMember();

            Console.WriteLine("\nTrainee 1: " + trainee1.GetMemberDetails());
            Console.WriteLine("Trainee 2: " + trainee2.GetMemberDetails());
            Console.WriteLine("\nTrainer 1: " + trainer1.GetMemberDetails());
            Console.WriteLine("Trainer 2: " + trainer2.GetMemberDetails());
        }
    }
}
