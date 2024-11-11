using System;

namespace TryCatchExceptions.TryCatch
{
    internal class ThrowExample
    {
        // Konstruktor erwartet nun die Benutzereingabe als Parameter
        public ThrowExample(string input)
        {
            try
            {
                int age = ThrowExampleMethod(input); // Die Eingabe wird an ThrowExampleMethod weitergegeben
                Console.WriteLine($"Age entered: {age}");
            }
            //  If an exception is thrown during the execution of ThrowExampleMethod (e.g., invalid age or invalid input),
            //  the exception is handled in the catch block.
            catch (Exception ex)
            {
                // Fehlerbehandlung: Ausgabe der Fehlermeldung
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Die Methode verarbeitet die Eingabe und wirft eine Ausnahme bei ungültigen Daten
        public int ThrowExampleMethod(string input)  // Rückgabetyp ist 'int'
        {
            int age;

            if (!int.TryParse(input, out age))
            {
                throw new Exception("You didn't enter a valid age.");
            }
            if (age < 0 || age > 120)
            {
                throw new Exception("Your age must be between 0 and 120.");
            }
            return age;
        }
    }
}

// Purpose:
// The throw keyword is used to signal the occurrence of an exception.
// It is used within a method to indicate that an error has occurred and needs to be handled. 

// How it Works:
// When an exception is thrown, the normal flow of the program is interrupted,
// and control is transferred to the nearest enclosing try/catch block.
