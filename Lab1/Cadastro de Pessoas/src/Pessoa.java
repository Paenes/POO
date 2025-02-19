public class Pessoa {
    private String nome;
    private int idade;

    public Pessoa(){
        this.nome = "";
        this.idade = 0;
    }

    public Pessoa(String c1_nome) {
        this.nome = c1_nome;
        this.idade = 0;
    }

    public Pessoa(int c1_idade) {
        this.nome = "";
        this.idade = c1_idade;
    }

    public Pessoa(String c2_nome, int c2_idade) {
        this.nome = c2_nome;
        this.idade = c2_idade;
    }
    

    public void exibirInfo(){
        System.out.println("Nome: " + this.getNome() + ", " + this.getIdade() + " ano(s)");
    }

    public String getNome() { return nome; }
    public void setNome(String Nome) { this.nome = Nome; }

    public int getIdade() { return idade; }
    public void setIdade(int Idade) { this.idade = Idade; }
}
