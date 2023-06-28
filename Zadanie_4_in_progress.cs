using System;

enum Plec
{
    Mezczyzna,
    Kobieta
}

struct Student
{
    public string Nazwisko;
    public int NrAlbumu;
    public double Ocena;
    public Plec Plec;
}


    class Program
    
    static void WypelnijStudenta(ref Student Student, string Nazwisko, int NrAlbumu, double Ocena, Plec Plec)
{
    student.Nazwisko = Nazwisko;
    student.NrAlbumu = NrAlbumu;

    if (Ocena < 2.0)
    {
        student.Ocena = 2.0;
    }
    else if (Ocena > 5.0)
    {
        student.Ocena = 5.0;
    }
    else
    {
        student.Ocena = Ocena;
    }

    student.Plec = plec;
}

        static void Wyswietl(Student Student)
    {
            Console.WriteLine("Nazwisko: " + student.Nazwisko);
            Console.WriteLine("Nr albumu: " + student.NrAlbumu);
            Console.WriteLine("Ocena: " + student.Ocena);
            Console.WriteLine("Płeć: " + student.Plec);
        }

double ObliczSrednia(Student[] grupa)
{
    int iloscStudentow = grupa.Length;
    double sumaOcen = 0;

    foreach (var student in grupa)
    {
        sumaOcen += student.Ocena;
    }

    double srednia = sumaOcen / iloscStudentow;
    return srednia;
}

            Console.WriteLine("Średnia ocen: " + srednia);

