public class ContaBancaria {
    private String titular;
    private double saldo, emprestimo;

    public ContaBancaria() {
        this.titular = "";
        this.saldo = 0.0;
        this.emprestimo = 0.0;
    }
    public ContaBancaria(String Titular) {
        this.titular = Titular;
        this.saldo = 0.0;
    }
    public void depositar(double Valor) {
        saldo += Valor;
    }
    public void sacar(double valor) {
        if (saldo >= valor) saldo -= valor;
        else System.out.println("Saldo insuficiente!");
    }
    public void mostrarSaldo() {
        System.out.println("Saldo de " + this.titular + ": R$" + saldo);
    }

    public boolean emprestimo_1ano_aprovado(double divida, double ipca_emprestimo){
        if (divida * (1.0 + ipca_emprestimo) < saldo * 12){
            return true;
        }else { return false;}
    }

    public void emprestimo_aprovar(double quantia_emprestar, double ipca_emprestar) {
        this.emprestimo += quantia_emprestar*(1+ipca_emprestar);
    }

    public void divida_restante(int Meses, double ipca_mostrar_juros){
        System.out.println(this.titular + " deve " + (1.0/12.0 * this.emprestimo * Meses) + " reais");
    }

    public String getTitular() {return this.titular;}
    public void setTitular(String _Titular ) {this.titular = _Titular;}
    
    public double getSaldo() {return this.saldo;}
    public void setSaldo(double _Saldo ) {this.saldo = _Saldo;}
    
    public double getEmprestimo() {return this.emprestimo;}
    public void setTitular(double _Emprestimo ) {this.emprestimo = _Emprestimo;}
    
    
}
