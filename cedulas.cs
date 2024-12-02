using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());
        
        Console.WriteLine(N);
        
        int[] cedulas = { 100, 50, 20, 10, 5, 2, 1 };
        
        foreach (int cedula in cedulas)
        {
            int quantidade = N / cedula;
            
            N = N % cedula;
            
            Console.WriteLine($"{quantidade} nota(s) de R$ {cedula},00");
        }

    }

}