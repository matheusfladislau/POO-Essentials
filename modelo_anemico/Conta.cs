public sealed class Conta {
    public int Id { get; private set; }
    public decimal? Saldo { get; private set; }

    public Conta(int Id) {
        this.Id = Id;
        this.Saldo = 0;
    }

    public void Sacar(decimal? Saque) {
        if (Saque < 0) {
            throw new InvalidOperationException("O saque não deve ser negativo.");
        }

        if (this.Saldo < Saque) {
            throw new InvalidOperationException("Não há saldo disponível para realizar o saque.");
        }

        this.Saldo -= Saque;
    }
    
    public void Depositar(decimal? Deposito) {
        if (Deposito < 0) {
            throw new InvalidOperationException("O deposito não deve ser negativo.");
        }

        this.Saldo += Deposito;
    }
}
