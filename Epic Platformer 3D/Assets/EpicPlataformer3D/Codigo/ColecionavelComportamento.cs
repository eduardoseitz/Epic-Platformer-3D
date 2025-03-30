using UnityEngine;

public class ColecionavelComportamento : MonoBehaviour
{
    public AdministradorDeJogo administradorDeJogo;

    public void OnTriggerEnter(Collider other)
    {
        administradorDeJogo.AdicionarColecionavel();
        Destroy(gameObject);
    }
}
