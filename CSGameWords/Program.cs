// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

void ToConsole(string d) {
    int ind = 0, line = 0, n =0;
    Console.Write(" ");
    while (ind<d.Length) {
        int maxN = 4;
        if (line % 2 == 0) {
            maxN = 3;
        }
        
        Console.Write(d[ind]);
        Console.Write(" ");
        ind++;
        n++;
        if (n == maxN) {
            Console.WriteLine();
            line++;
            if (line % 2 == 0) {
                Console.Write(" ");
            }

            n = 0;
        }
    }
}


Console.OutputEncoding = System.Text.Encoding.UTF8;
string data = "КОСДРАЛУАЄЕПІАІЕИЕДХОИМВЩІЛАВОИАГОІОТПЖМЇЕЯАИРСГЄВРЩИЙУНПДАЕНОІ";
ToConsole(data);