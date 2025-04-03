using UnityEngine;

public class MorteComportamento : MonoBehaviour
{
    // Variaveis publicas.
    public AdministradorDeJogo administradorDeJogo;
    
    // Este metódo é chamado pelo componente Collider ao colidir com o player.
    public void OnTriggerEnter(Collider outroObjeto)
    {
        if (outroObjeto.CompareTag("Player"))
        {
            // Perde o jogo.
            administradorDeJogo.PerderJogo();
        }
    }

    // Este metódo é chamado pelo componente Collider ao colidir com o player.
    public void OnCollisionEnter(Collision outroObjeto)
    {
        if (outroObjeto.gameObject.CompareTag("Player"))
        {
            // Perde o jogo.
            administradorDeJogo.PerderJogo();
        }
    }
}
