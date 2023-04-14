//deklarujemy funkcje zwracajaca stringa i przyjmujaca stringa jako argument
string toAsciiCaesar(string clearText)
{

    //zamieniamy na wielkie litery
    clearText = clearText.ToUpper();
    //iteruj przez cały tekst litera po literze
    //deklarujemy string wynikowy
    string encryptedText = "";
    foreach (char c in clearText)
    {
        //pomiń wszystkie znaki poza literami z alfabetu łacińskiego
        if (c >= 65 && c <= 90)
        {
            //wyciągamy kod ascii danej liery
            //w języku c# rzutowanie jawne z char na int powoduje pobranie wartości ascii
            int asciiCode = (int)c;
            //dodajemy wartośc klucza
            asciiCode += 3;
            //sprawdzamy czy nie przekroczxyliśmy ostatniego znaku (z, 90)
            if (asciiCode > 90)
                //jeśli przekroczyło to cofnij o długość alfabetu
                asciiCode -= 26;
            //zamianiamy kod z powrotem na znak
            char encryptedChar = (char)asciiCode;
            //dopisujemy do szyfru
            encryptedText += encryptedChar;
        }
    }
    //zwroc zakodowany string
    return encryptedText;
}

string fromAsciiCaesar(string encryptedText)
{
    string clearText = "";
    //todo: napisz funkcje 

    //zwroc wartosc
    return clearText;
}

String fromAsciiCaesar(string encrypatedText)
{
    string clearText = "";
    foreach (char c in encrypatedText)
    {
        //pomin wszystkie znaki poza literami z alfabetu lacinskiego 
        if (c >= 65 && c <= 90)
        {
            int asciiCode = (int)c; 
            asciiCode -= 3;
            if (asciiCode > 90)
                asciiCode -= 26;
            char encrypatedChar = (char)asciiCode;
            encrypatedText += encrypatedChar;
        }
        string uncryptedText = "";
    }
    return encrypatedText;
}


//zdefiniuj string do zaszyfrowania 
string clearText = "Ala ma kota, kot ma Ale, a sierotka ma rysia";
Console.WriteLine("zaszyfrowany tekst: " + toAsciiCaesar(clearText));
