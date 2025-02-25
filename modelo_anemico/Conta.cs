public sealed class Conta {
    public int Id { get; private set; }
    public decimal? Saldo { get; private set; }

    public Conta(int Id) {
        if (Id < 0) {
            throw new ArgumentException("O Id não deve ser menor que 0");
        }

        this.Id = Id;
        this.Saldo = 0;
    }

    public void Sacar(decimal? Saque) {
        if (Saque < 0) {
            throw new ArgumentException("O saque não deve ser negativo.");
        }

        if (this.Saldo < Saque) {
            throw new ArgumentException("Não há saldo disponível para realizar o saque.");
        }

        this.Saldo -= Saque;
    }
    
    public void Depositar(decimal? Deposito) {
        if (Deposito < 0) {
            throw new ArgumentException("O deposito não deve ser negativo.");
        }

        this.Saldo += Deposito;
    }
}
