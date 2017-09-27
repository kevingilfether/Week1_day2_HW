using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day2_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            // #1
            int mikeRestaurant = 13;
            int totalBill = mikeRestaurant * 4;

            // #2
            int recipeIn = 2;
            int recipeTarget = 7;
            int recipeStillNeeded = 2 + 5;

            // #3
            int totalCash = 40;
            int diaperCost = 8;
            int diaperPacks = totalCash / diaperCost;

            //#4
            int trevonStart = 29;
            int trevonFinish = 41;
            int trevonDiff = trevonFinish - trevonStart;

            // #5
            int juliaRan = 41;
            int runDiff = 30;
            int pranavRan = juliaRan - runDiff;

            // #6
            int envelopeCash = 12;
            int envelopeBox = 3;
            int numEnvelopeBox = envelopeCash / envelopeBox;

            // #7
            float saladCost = 5.12f;
            float norachaiAfterMoney = 27.10f;
            float norachaiBeforeMoney = norachaiAfterMoney + saladCost;

            // #8
            int fieldTripTotal = 331;
            int fieldTripBusses = 6;
            int fieldTripCarStudents = 7;
            int fieldTripStudentsPerBus = (fieldTripTotal - fieldTripCarStudents) / fieldTripBusses;

            // #9
            int aliyahInit = 24;
            int aliyahFinal = 10;
            int pencilNum = 7;
            int pencilCost = (aliyahInit - aliyahFinal) / 7;

            // #10 
            int number = 72 / 3;

            // #11
            int modNumber11 = 48 % 3;
            int divNumber11 = 48 / 3;
            // Console.WriteLine(divNumber11 + "r" + modNumber11);

            // #12
            int mariaBoxesFinal = 22;
            int mariaBoxesBought = 7;
            int mariaBoxesStart = ((22 * 2) + 7);
            Console.WriteLine(mariaBoxesStart);




        }
    }
}
