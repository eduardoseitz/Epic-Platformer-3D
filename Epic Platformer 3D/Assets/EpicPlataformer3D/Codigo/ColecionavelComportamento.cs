using UnityEngine;

public class ColecionavelComportamento : MonoBehaviour
{ 
    // Variaveis publicas.
    public AdministradorDeJogo administradorDeJogo;
    public AudioSource colecionavelSom;

    // Este metódo é chamado pelo componente Collider ao colidir com o player.
    public void OnTriggerEnter(Collider outroObjeto)
    {
        if (outroObjeto.CompareTag("Player"))
        {
            // Toca o som.
            colecionavelSom.Play();
            
            // Adiciona o colecionavel.
            administradorDeJogo.AdicionarColecionavel();
            
            // Remove esse objeto da cena.
            Destroy(gameObject);
        }
    }
}
