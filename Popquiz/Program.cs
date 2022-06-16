using System;

namespace Examn
{
    class Program
    {
        static void Main(string[] args)
        {
            /** 
             * Opdrachten
             * Opdracht 1. Verzin 3 nieuwe vragen en stop die in de Array of Lijst
             * Opdracht 2. Voeg 4 nieuw studenten toe in de Popquiz array
             * Opdracht 3. Zorg ervoor dat in de Class Popquiz de antwoorden in de GetAnswers method kloppen met de
             *             vragen die je toegevoegd hebt
             * Opdracht 4. Toon alle vragen in de Console en vraag de gebruiker om de vraag te beantwoorden.
             *             Toon ook de naam van de student die de vraag moet beantwoorden.
             * 
             * Opdracht 5. Toon alle vragen in de Console, vraag de gebruiker om de vraag te beantwoorden en 
             *              toon of het antwoord goed is. 
             * Opdracht 6. Voeg in bovenstaande for-loop een teller toe die als het antwoord goed is een punt
             *              optelt. Na de for-loop toon je het aantal goede punten van de gebruiker.
             * Opdracht 7. a) Voeg de antwoorden op alle vragen toe aan de answer-array4
             * Opdracht    b) Herhaal opdracht 4, maar controleer tegen de waarde in de answer-array
             *                LEES DE TEKST BIJ DE OPDRACHT BENEDEN GOED DOOR
             * Opdracht    c) Tel het aantal goede, en foute antwoorden en toon dit na de for-loop aan de gebruiker.
             *              
             * Opdracht 8. Er zijn (met opdracht 2 mee) 8 studenten. Schrijf een nieuwe methode, noem die methode CalculateAverage
             *             Deze methode berekent het gemiddelde van alle studenten en toont dit op het scherm. 
             *             
             * Opdracht 9. Als je goed kijkt zijn alle antwoorden gelijk. Dit is dubbele code, dat willen we niet. Zorg ervoor dat 
             *             de vragen net zoals de antwoorden in de Popquiz-class staan.
             */        

            Console.WriteLine("Welkom bij de Advanced popquiz");

            //Declareren en Initialiseren van de questions array
            string[] questions = { "Wat is de hoofdstad van Nederland?", "Wat is de C# benaming voor als-dan?", "Wat is de HTML code voor een kleine Heading?", "Kan je een html pagina maken met notepad?", "Met welke command kan je de look veranderen van de website?", "Is Jan  transgender?" };

            //Bouwen van een Array met toetsen
            Popquiz[] advancedPopquiz =
            {
                new Popquiz(4.5, "Jantje", 2, "T1K", questions),
                new Popquiz(8.4, "Pietje", 3, "T1J", questions ),
                new Popquiz(7.1, "Mohamed", 3, "T1L", questions ),
                new Popquiz(9.4, "Louise", 4, "T1M", questions ),
                new Popquiz(2.3, "Bertje", 1, "T1M", questions ),
                new Popquiz(5.4, "Karel", 1, "T1M", questions ),
                new Popquiz(6.9, "Nabil", 4, "T1K", questions ),
                new Popquiz(1.3, "Diah-Rita", 3, "T1L", questions ),
                new Popquiz(4.4, "Pooh C", 1, "T1J", questions )
            };

            //Tonen van alle vragen
            for (int i = 0; i < advancedPopquiz.Length; i++)
            {
                //We maken een variabele advancePQ, dit is een instance van de class Popquiz (Popquiz.cs) 
                Popquiz advancePQ = advancedPopquiz[i];


                //We kunnen de properties en methodes van de gegeven instance van Popquiz gebruiken
                Console.WriteLine(advancePQ.GetStudentName());
                



            }
        }
    }
}
