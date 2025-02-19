import java.util.Scanner;

public class App {
    public static void main(String[] args) {
        Pessoa p = new Pessoa("João", 25);
        System.out.println("Nome: " + p.getNome());
        System.out.println("Idade: " + p.getIdade());

        Pessoa[] p_array10 = new Pessoa[10];
        Scanner scanner = new Scanner(System.in);
        boolean exibir_menu = true;
        int qtd = 0;

        while (exibir_menu) {
            clearScreen();
            System.out.println("Cadastro de Pessoa Física (Limite de 10)");
            System.out.println();
            System.out.println("Selecione uma opção:");
            System.out.println();
            System.out.println("1. Registrar pessoa");
            System.out.println("2. Consultar registros");
            System.out.println("3. Sair...");
            System.out.println();
            System.out.print("Digita sua escolha: ");
            int escolha = scanner.nextInt();
            scanner.nextLine(); // Limpar buffer 
            if (escolha == 3) 
            {
                System.out.println("\nSaindo...");
                break;
            }
            switch (escolha) {
                case 1:
                    System.out.println("Digite o nome completo:"); 
                    p_array10[qtd] = new Pessoa(scanner.nextLine()); // Buffer precisa estar limpo
                    System.out.println("Digite a idade:");
                    p_array10[qtd].setIdade(scanner.nextInt());
                    qtd +=1;
                    System.out.println("Registrado com sucesso");
                    
                    break;
                case 2:
                    System.out.println("Lista de pessoas registradas:");
                    System.out.println();                    
                    for (int p_i = 0; p_i < qtd; p_i++){
                        System.out.printf("[%d] ", (p_i+1));
                        p_array10[p_i].exibirInfo();
                    }
                    break;
                case 3:
                    System.out.println("\nSaindo...");
                    break;
                default:
                    System.out.println("Escolha entre o número 1 e 3");
                    break;
            }
            System.out.println();
            System.out.println("Aperte ENTER para continuar...");
            scanner.nextLine(); 
            scanner.nextLine();
        }
        scanner.close();
    }
    public static void clearScreen() {  
        try {  
            new ProcessBuilder("cmd", "/c", "cls").inheritIO().start().waitFor();  
            System.out.flush();
        } catch (Exception e) {  
            e.printStackTrace();  
        } 
    }
}
