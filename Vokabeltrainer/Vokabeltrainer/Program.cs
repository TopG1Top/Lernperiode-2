using System;
using System.Collections.Generic;

class VocabTrainer
{
    static Dictionary<string, string> vocab = new Dictionary<string, string>();

    static void Main()
    {
        
        AddVocabulary("Hello", "Hallo");
        AddVocabulary("Goodbye", "Auf Wiedersehen");

        bool continueTraining = true;

        while (continueTraining)
        {
            Console.WriteLine("Vokabeltrainer");
            Console.WriteLine("1. Vokabel üben");
            Console.WriteLine("2. Vokabel hinzufügen");
            Console.WriteLine("3. Beenden");
            Console.Write("Wählen Sie eine Option: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StartTraining();
                    break;
                case 2:
                    AddVocabularyManually();
                    break;
                case 3:
                    continueTraining = false;
                    break;
                default:
                    Console.WriteLine("Ungültige Option. Bitte wählen Sie erneut.");
                    break;
            }
        }
    }

    static void AddVocabulary(string word, string translation)
    {
        vocab[word] = translation;
    }

    static void AddVocabularyManually()
    {
        Console.Write("Vokabel eingeben: ");
        string word = Console.ReadLine();
        Console.Write("Übersetzung eingeben: ");
        string translation = Console.ReadLine();
        AddVocabulary(word, translation);
        Console.WriteLine("Vokabel wurde hinzugefügt.");
    }

    static void StartTraining()
    {
        foreach (var pair in vocab)
        {
            Console.Write("Übersetzen Sie: " + pair.Key + " -> ");
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == pair.Value.ToLower())
            {
                Console.WriteLine("Richtig!");
            }
            else
            {
                Console.WriteLine("Falsch. Die richtige Antwort ist: " + pair.Value);
            }
        }
    }
}
