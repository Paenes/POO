public class ContaBancaria {
    private String titular;
    private double saldo;
    public ContaBancaria(String titular) {
        this.titular = titular;
        this.saldo = 0.0;
    }
    public void depositar(double valor) {
        saldo += valor;
    }
    public void sacar(double valor) {
        if (saldo >= valor) saldo -= valor;
        else System.out.println("Saldo insuficiente!");
    }
    public void mostrarSaldo() {
    System.out.println("Saldo de " + titular + ": R$" + saldo);
    }
}
