using TMPro;
using UnityEngine;

public class AdministradorDeJogo : MonoBehaviour
{
    public GameObject pontoFinalLevel;
    public TextMeshProUGUI colecionavelTexto;
    public TextMeshProUGUI finalTexto;
    public GameObject[] colecionaveis;
    public GameObject player;
    public GameObject hudUI;
    public GameObject jogoGanhoUI;
    public GameObject jogoPerdidoUI;
    CenaComportamento cenaComportamento; 
    int colecionaveisColetados;
    
    void Start()
    {
        finalTexto.gameObject.SetActive(false);
        cenaComportamento = GetComponent<CenaComportamento>();
    }

    void Update()
    {
        colecionavelTexto.text = colecionaveisColetados + "/" + colecionaveis.Length;
        
        if (Input.GetKeyDown(KeyCode.Backspace))
            cenaComportamento.CarregarCena(0);
        else if (Input.GetKeyDown(KeyCode.R))
            cenaComportamento.RearregarCena();
    }

    public void AdicionarColecionavel()
    {
        Debug.LogWarning("Colecionavel pego!");
        colecionaveisColetados = colecionaveisColetados + 1;
        if (colecionaveisColetados >= colecionaveis.Length)
        {
            finalTexto.gameObject.SetActive(true);
            pontoFinalLevel.SetActive(true);
        }
    }

    public void GanharJogo()
    {
        Debug.LogWarning("Player ganhou!");
        player.SetActive(false);
        hudUI.SetActive(false);
        jogoGanhoUI.SetActive(true);
    }

    public void PerderJogo()
    {
        Debug.LogError("Player morreu!");
        player.SetActive(false);
        hudUI.SetActive(false);
        jogoPerdidoUI.SetActive(true);
    }
}
