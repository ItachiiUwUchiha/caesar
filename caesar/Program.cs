//zdefinuj string do zaszyfrowania
string clearText = "Ala ma kota, a kot ma Ale, a sierotka ma rysia";
//zamieniamy na wielkie litery
clearText = clearText.ToUpper();
//iteruj przez caly tekst litera po literze
//deklarujemy string wynikowy
string encryptedText = "";
foreach (char c in clearText)
{
    if (c != ' ' && c != ',')
    {
        //wyciagamy kod ascii danej litery
        // w jezyku c# rzutowanie jawne z char na int powoduje pobranie wartosci ascii
        int asciiCode = (int)c;
        //dodajemy wartosc klucza
        asciiCode += 3;
        //sprawdzamy czy nie przekroczylismy ostatniego znaku (z, 90)
        if (asciiCode > 90)
            asciiCode -= 26;
        //zamieniamy kod z powrotem na znak
        char encryptedChar = (char)asciiCode;
        //dopisujemy do szyfru
        encryptedText += encryptedChar;
    }
}

Console.WriteLine("zaszyfrowany tekst: " + encryptedText);