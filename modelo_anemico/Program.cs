class Program {
    public static void Main(string[] args) {
        var conta = new Conta(1);

        conta.Depositar(100);
        conta.Sacar(10);

        Console.WriteLine(conta.Saldo);
    }
}
