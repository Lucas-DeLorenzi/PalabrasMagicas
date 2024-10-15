using PalabrasMagicas;

bool exit = false;

while (!exit)
{
    try
    {
        ShowMenu();

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                EnterAndReverseWord();
                break;

            case "2":
                EnterAndCheckPalindrome();
                break;

            case "3":
                EnterAndCountVowels();
                break;

            case "4":
                Console.WriteLine("Gracias por utilizar el programa. ¡Hasta luego!");
                exit = true;
                break;

            default:
                Console.WriteLine("Opción incorrecta. Por favor, elige una opción válida.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
    }
}

static void ShowMenu()
{
    Console.WriteLine("Bienvenido a Palabras Mágicas App:");
    Console.WriteLine("Selecciona una opción:");
    Console.WriteLine("1. Invertir palabra");
    Console.WriteLine("2. Determinar si una palabra es capicúa");
    Console.WriteLine("3. Contar las vocales en la palabra");
    Console.WriteLine("4. Salir");
    Console.Write("Opción: ");
}

static void EnterAndReverseWord()
{
    Console.Write("Ingresa una palabra: ");
    string word = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(word))
    {
        Console.WriteLine("Error: No ingresaste una palabra válida.");
        return;
    }

    string reversedWord = WordProcessor.ReverseWord(word);
    Console.WriteLine($"Palabra invertida: {reversedWord}");
}

static void EnterAndCheckPalindrome()
{
    Console.Write("Ingresa una palabra: ");
    string word = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(word))
    {
        Console.WriteLine("Error: No ingresaste una palabra válida.");
        return;
    }

    if (WordProcessor.IsPalindrome(word))
    {
        Console.WriteLine("La palabra es capicúa.");
    }
    else
    {
        Console.WriteLine("La palabra no es capicúa.");
    }
}

static void EnterAndCountVowels()
{
    Console.Write("Ingresa una palabra: ");
    string word = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(word))
    {
        Console.WriteLine("Error: No ingresaste una palabra válida.");
        return;
    }

    int numberOfVowels = WordProcessor.CountVowels(word);
    Console.WriteLine($"Número de vocales: {numberOfVowels}");
}
