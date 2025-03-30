using TMPro;
using UnityEngine;

public class AdministradorDeJogo : MonoBehaviour
{
    public GameObject pontoInicialLevel;
    public GameObject pontoFinalLevel;
    public TextMeshProUGUI colecionavelTexto;
    public TextMeshProUGUI finalTexto;
    public GameObject[] colecionaveis;
    int colecionaveisColetados;
    
    void Start()
    {
        finalTexto.gameObject.SetActive(false);
    }

    void Update()
    {
        colecionavelTexto.text = colecionaveisColetados + "/" + colecionaveis.Length;
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
    }

    public void PerderJogo()
    {
        Debug.LogError("Player morreu!");
    }
}
