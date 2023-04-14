//zdefinuj string do zaszyfrowania
string clearText = "Ala ma kota, a kot ma Ale, a sierotka ma rysia";
//zamieniamy na wielkie litery
clearText = clearText.ToUpper();
//iteruj przez caly tekst litera po literze
foreach (char c in clearText)
{
    //wyciagamy kod ascii danej litery
    // w jezyku c# rzutowanie jawne z char na int powoduje pobranie wartosci ascii
    int asciiCode = (int)c;
    //dodajemy wartosc klucza
    asciiCode += 3;
    char encryptedChar = (char)asciiCode;
    Console.Write(encryptedChar);
}