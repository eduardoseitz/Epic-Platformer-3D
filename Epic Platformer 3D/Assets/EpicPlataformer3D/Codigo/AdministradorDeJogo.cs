using TMPro;
using UnityEngine;

// Classe publica administrar jogo.
public class AdministradorDeJogo : MonoBehaviour
{
    // Variaveis publicas.
    public GameObject pontoFinalLevel;
    public TextMeshProUGUI colecionavelTexto;
    public TextMeshProUGUI finalTexto;
    public GameObject[] colecionaveis;
    public GameObject player;
    public GameObject hudUI;
    public GameObject jogoGanhoUI;
    public GameObject jogoPerdidoUI;
    public AudioSource jogoPerdido;
    public AudioSource jogoGanho;
    
    // Variaveis privadas.
    private int colecionaveisColetados;
    private CenaComportamento cenaComportamento; 
    
    // Este metódo é chamado pela Unity no incio do jogo.
    private void Start()
    {
        // Oculta o texto "Pegue a bandeira.".
        finalTexto.gameObject.SetActive(false);
        
        // Pega o componente CenaComportamento nesse mesmo objeto.
        cenaComportamento = GetComponent<CenaComportamento>();
    }

    // Este metódo é chamado pela Unity no incio de cada quadro/frame.
    private void Update()
    {
        // Atualiza o texto dos colecionaveis pegos.
        colecionavelTexto.text = colecionaveisColetados + "/" + colecionaveis.Length;

        // Verifica se o jogador pressionou M.
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Carrega a cena menu.
            cenaComportamento.CarregarCena(0);
        }
        // Verifica se o jogador pressionou R.
        else if (Input.GetKeyDown(KeyCode.R))
        { 
            // Recarrega a cena atual.
            cenaComportamento.RearregarCena();
        }
    }

    // Este metódo é chamado pelo Colecionavel ao colidir com o player.
    public void AdicionarColecionavel()
    {
        Debug.LogWarning("Colecionavel pego!");
        
        // Aumenta o numero de colecionaveis pegos em 1.
        colecionaveisColetados = colecionaveisColetados + 1;
        
        // Se pegou todos os colecionaveis mostra a bandeira.
        if (colecionaveisColetados >= colecionaveis.Length)
        {
            finalTexto.gameObject.SetActive(true);
            pontoFinalLevel.SetActive(true);
        }
    }

    // Este metódo é chamado pelo Ponto Final ao colidir com o player.
    public void GanharJogo()
    {
        Debug.Log("Player ganhou!");
        
        // Toca o som e mostra painel de jogo ganho.
        jogoGanho.Play();
        player.SetActive(false);
        hudUI.SetActive(false);
        jogoGanhoUI.SetActive(true);
    }

    // Este metódo é chamado pelo Ojeto Morte ao colidir com o player.
    public void PerderJogo()
    {
        Debug.LogError("Player morreu!");
        
        // Toca o som e mostra painel de jogo perdido.
        jogoPerdido.Play();
        player.SetActive(false);
        hudUI.SetActive(false);
        jogoPerdidoUI.SetActive(true);
    }
}
