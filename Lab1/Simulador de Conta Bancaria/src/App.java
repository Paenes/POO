public class App {
    public static void main(String[] args) throws Exception {
        ContaBancaria conta = new ContaBancaria("Maria");
        conta.depositar(100);
        conta.sacar(30);
        conta.mostrarSaldo();
    }
}
