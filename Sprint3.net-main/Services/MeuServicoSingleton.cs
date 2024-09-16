using Sprint3.Models;

public class MeuServicoSingleton
{
    // Instância estática da classe
    private static MeuServicoSingleton _instance;

    // Objeto de sincronização para garantir a thread-safety
    private static readonly object _lock = new object();

    // Construtor privado para evitar instância externa
    private MeuServicoSingleton()
    {
        // Inicialize aqui, se necessário
    }

    // Propriedade pública para acessar a instância única
    public static MeuServicoSingleton Instance
    {
        get
        {
            // Verifica se a instância já foi criada
            if (_instance == null)
            {
                // Bloqueia o acesso para threads múltiplas
                lock (_lock)
                {
                    // Verifica novamente se a instância foi criada após o bloqueio
                    if (_instance == null)
                    {
                        _instance = new MeuServicoSingleton();
                    }
                }
            }
            return _instance;
        }
    }

    // Métodos e propriedades da classe
    public void MetodoExemplo()
    {
        // Implementação do método
    }
}
