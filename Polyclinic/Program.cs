using System;

namespace Polyclinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityPatientQueue;
            int timeReceptionPatient = 10;
            int quantityMinutesInHour = 60;
            int hoursWait;
            int minutesWait;
            int timeWait;

            Console.Write("Введите кол-во старушек в очереди: ");
            quantityPatientQueue = Convert.ToInt32(Console.ReadLine());

            timeWait = quantityPatientQueue * timeReceptionPatient;
            hoursWait = timeWait / quantityMinutesInHour;
            minutesWait = timeWait % quantityMinutesInHour;

            Console.WriteLine($"Время ожидания: {hoursWait} ч, {minutesWait} мин.");
        }
    }
}