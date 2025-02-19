import java.util.Scanner;

public class App {
    public static void main(String[] args) throws Exception {
        ContaBancaria conta = new ContaBancaria("Maria");
        conta.depositar(100);
        conta.sacar(30);
        conta.mostrarSaldo();
        

        boolean exibir_menu = true;
        Scanner scanner = new Scanner(System.in);
        double ipca = 0.1006;

        while(exibir_menu){
            System.out.println("Banco Brasil");
            System.out.println();
            System.out.println("Escolha uma opção:");
            System.out.println();
            System.out.println("[1] Depositar");
            System.out.println("[2] Sacar");
            System.out.println("[3] Checar saldo");
            System.out.println("[4] Realizar empréstimo (12 meses/juros ipca)");
            System.out.println("[5] Sair");
            int escolha = scanner.nextInt();
            scanner.nextLine(); //Limpa buffer para os próximos scanner.next~~
            if (escolha == 5){
                System.out.println("Saindo...");
                break;
            }
            switch (escolha) {
                case 1:
                    System.out.println("Digite o valor a depositar:");
                    conta.depositar(scanner.nextDouble());
                    System.out.println("Depósito realizado com sucesso");
                    break;
                case 2:
                    System.out.println("Digite o valor a sacar:");
                    conta.sacar(scanner.nextDouble());
                    System.out.println("Saque realizado com sucesso");
                    break;
                case 3:
                    conta.mostrarSaldo();
                    break;
                case 4:
                    clearScreen();
                    boolean exibir_emprestimo = true;
                    while(exibir_emprestimo){
                        System.out.println("Menu Emprestimo");
                        System.out.println("R$: " + conta.getSaldo());
                        System.out.println("Escolha um opção:");
                        System.out.println();
                        System.out.println("[1] Verificar permissão de empréstimo");
                        System.out.println("[2] Checar valor de parcelas");
                        System.out.println("[3] Sair");
                        int escolha_emprestimo = scanner.nextInt();
                        scanner.nextLine(); //Limpa buffer para os próximos scanner.next~~
                        if (escolha_emprestimo == 3){
                            System.out.println("Aperte ENTER para voltar ao menu...");
                            scanner.nextLine(); 
                            scanner.nextLine(); 
                            break;
                        }
                        switch (escolha_emprestimo) {
                            case 1:
                                System.out.println("Digite de quanto é o empréstimo a ser realizado:");
                                double quantia = scanner.nextDouble();
                                System.out.println();
                                if(conta.emprestimo_1ano_aprovado(quantia, ipca)){
                                    System.out.println("Empréstimo disponível");
                                    System.out.println();
                                    System.out.println("Deseja realizar o empréstimo?");
                                    System.out.println("    [1]Sim      [2]Não");
                                    System.out.println();
                                    int escolha_realizarEmprestimo = scanner.nextInt();
                                    if (escolha_realizarEmprestimo == 1){
                                        conta.emprestimo_aprovar(quantia,ipca);
                                    }else{break;}
                                }else {System.out.println("Empréstimo indisponível");}
                                break;
                            case 2:
                                if(conta.getEmprestimo() > 0.0){
                                    System.out.println("Digite quantas parcelas deseja verificar");
                                    System.out.println();
                                    conta.divida_restante(scanner.nextInt(), ipca);
                                    System.out.println();
                                }else{System.out.println("Não há empréstimos realizados");}
                                break;
                            default:
                                System.out.println("Opção inválida (escolha entre 1 e 3)");
                                break;
                        }
                        System.out.println();
                        System.out.println("Aperte ENTER para continuar...");
                        scanner.nextLine(); 
                        scanner.nextLine();    
                    }
                    break;
                default:
                    System.out.println("Opção inválida (escolha entre 1 e 5)");
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
