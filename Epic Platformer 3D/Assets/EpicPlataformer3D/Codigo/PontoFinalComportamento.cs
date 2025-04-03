using UnityEngine;

public class PontoFinalComportamento : MonoBehaviour
{
    // Variaveis publicas.
    public AdministradorDeJogo administradorDeJogo;
    
    // Este metódo é chamado pela Unity no incio do jogo.
    public void Start()
    {
        // Desativa essa bandeira.
        gameObject.SetActive(false);
    }
    
    // Este metódo é chamado pelo componente Collider ao colidir com o player.
    public void OnTriggerEnter(Collider outroObjeto)
    {
        if (outroObjeto.CompareTag("Player"))
        {
            // Ganha o jogo.
            administradorDeJogo.GanharJogo();
        }
    }
}
