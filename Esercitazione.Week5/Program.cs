// See https://aka.ms/new-console-template for more information
//teoria:
//1) c
//2) reference type, Heap
//3) a-b
using Esercitazione.Week5;


Console.WriteLine("Benvenuto all'università");



Console.WriteLine("Inserisci nome");
string nome = Console.ReadLine();
Console.WriteLine("Inserisci cognome");
string cognome= Console.ReadLine();
DateTime dataDiNascita;

do
{
    Console.WriteLine("Inserisci data di nascita");
}while(DateTime.TryParse(Console.ReadLine(),out dataDiNascita));
bool richiesta;

do {
    Console.WriteLine("Hai già fatto richiesta di laurea?");
} while (bool.TryParse(Console.ReadLine(), out richiesta));

Studente s = new Studente(nome, cognome, dataDiNascita,richiesta );
//bool verificaAutentificazione = IsAutenticato(s); non mi va 
//if(verificaAutentificazione)
//{



int scelta;
        do
        {
            Console.WriteLine("Fai la tua scelta");
        } while (int.TryParse(Console.ReadLine(), out scelta));



        switch (scelta)
        {
            case 1:
                Console.WriteLine("Prenotati a un esame");
                Console.WriteLine("Quale esame vuoi sostenere?");
                


                break;
        }

    
//}else{
//return}








