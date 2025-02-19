public class App {
    public static void main(String[] args) throws Exception {
        Animal meuCachorro = new Cachorro();
        Animal meuGato = new Gato();
        meuCachorro.emitirSom();
        meuGato.emitirSom();
    }
}
