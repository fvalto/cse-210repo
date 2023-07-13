using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("############## EVENT 1 ##############");
        LectureEvent lectureEvent = new LectureEvent("The Speaker Sessions vol. 3", "Hi! Welcome to our third edition of The Speaker Sessions!, please join to one the greatest Lecture events in the region", "Lecture Event", "Markus Lumis", 50);
        lectureEvent.SetDate(2023, 10, 5, 19, 0, 0);
        lectureEvent.SetAdresss("3711 Oliver Street", "New Braunfels", "Texas");
        lectureEvent.DisplayStandardDetails();
        lectureEvent.DisplayFullDetails();
        lectureEvent.DisplayShortDescription();
        Console.WriteLine();

        Console.WriteLine("############## EVENT 2 ##############");
        ReceptionEvent receptionEvent = new ReceptionEvent("Joe & Samantha Wedding", "With hearts full of joy, we invite you to our wedding, please don't forget to confirm your attendance", "Reception Event", "Tatiana Melinda");
        receptionEvent.SetDate(2024, 4, 25, 17, 30, 0);
        receptionEvent.SetAdresss("4838 Kembery Drive", "Northbrook", "Illinois");
        receptionEvent.DisplayStandardDetails();
        receptionEvent.DisplayFullDetails();
        receptionEvent.DisplayShortDescription();
        Console.WriteLine();

        Console.WriteLine("############## EVENT 3 ##############");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Flip Flop Fiesta", "Live music, food, pools and much more. Come, meet people, have fun and don't forget to bring your very own and unic flip flops", "Outdoor Event", "Sunny");
        outdoorEvent.SetDate(2023, 7, 20, 14, 0, 0);
        outdoorEvent.SetAdresss("2450 Corpening Drive", "Royal Oak", "Michigan");
        outdoorEvent.DisplayStandardDetails();
        outdoorEvent.DisplayFullDetails();
        outdoorEvent.DisplayShortDescription();
        Console.WriteLine();
    }
}