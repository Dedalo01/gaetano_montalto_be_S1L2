namespace eser_S1L2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Esempio di Oggetto Persona:");
            Console.WriteLine();
            Persona persona = new Persona();
            persona.GetDettagli();

            Console.Write("Inserisci nome: ");
            string actualName = Console.ReadLine();
            Console.Write("Inserisci cognome: ");
            string actualSurname = Console.ReadLine();
            Console.Write("Inserisci età: ");
            int actualEta = int.Parse(Console.ReadLine());

            Persona actualPerson = new Persona(actualName, actualSurname, actualEta);
            actualPerson.GetDettagli();
            Console.WriteLine(actualPerson.getCognome(true));

            Console.ReadKey();
        }
    }

    public class Persona
    {
        private string _nome;
        private string _cognome;
        private int _eta;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public int Eta
        {
            get { return _eta; }
            set
            {
                if (value < 0)
                {
                    _eta = 0;
                }
                else
                {
                    _eta = value;
                }

            }
        }

        public Persona()
        {
            Nome = "Pippo";
            Cognome = "Pluto";
            Eta = 12;

        }

        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }


        public string getNome()
        {
            return $"Il nome di questa persona è: {Nome}";
        }

        public string getCognome()
        {
            return $"Il cognome di questa persona è: {Cognome}";
        }

        public string getCognome(bool isBoss)
        {
            if (isBoss)
                return $"Il cognome di questa persona è: {Cognome.ToUpper()}, un rinomato boss locale.\nMeglio starci alla larga ragazzi...";

            return getCognome();
        }

        public string getEta()
        {
            return $"L'età di questa persona è: {Eta}";
        }


        public void GetDettagli()
        {
            Console.WriteLine("DETTAGLI");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cognome: {Cognome}");
            Console.WriteLine($"Età: {Eta}");
            Console.WriteLine();
        }
    }

}
