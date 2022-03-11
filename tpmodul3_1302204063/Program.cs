// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        KodePos table_Kodepos = new KodePos();
        Console.WriteLine("Keluarahan       Kode Pos");
        table_Kodepos.getKodePos();

        Console.WriteLine("====== KunciPintu ======");
        DoorMachine pintu = new DoorMachine();
        pintu.kunci();
    }

}
class KodePos
{

    Dictionary<string, string> dic = new Dictionary<string, string>() {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "        40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "        40274"},
            {"Samoja", "        40273"}
        };

    public void getKodePos()
    {
        foreach (KeyValuePair<string, string> ele1 in dic)
        {
            Console.WriteLine("{0} \t {1}", ele1.Key, ele1.Value);
        }
    }
}
class DoorMachine
{
    enum State { Terkunci, Terbuka };
    public void kunci()
    {
        State state = State.Terkunci;

        String[] screenName = { "Pintu Terkunci", "Pintu tidak Terkunci" };
        do
        {
            Console.WriteLine("" + screenName[(int)state]);
            Console.Write("Masukan Command : ");
            String command = Console.ReadLine();
            switch (state)
            {
                case State.Terbuka:
                    if (command != "BukaPintu")
                    {
                        state = State.Terkunci;
                    }
                    break;
                case State.Terkunci:
                    if (command != "KunciPintu")
                    {
                        state = State.Terbuka;
                    }
                    break;
            }
        } while (state != State.Terkunci);
    }
}
