using UnityEngine;

public class ColecionavelComportamento : MonoBehaviour
{
    public AdministradorDeJogo administradorDeJogo;

    public void Start()
    {
        gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        administradorDeJogo.AdicionarColecionavel();
        Destroy(gameObject);
    }
}
