using UnityEngine;

public class PontoFinalComportamento : MonoBehaviour
{
    public AdministradorDeJogo administradorDeJogo;
    
    public void Start()
    {
        gameObject.SetActive(false);
    }
    
    public void OnTriggerEnter(Collider other)
    {
        administradorDeJogo.GanharJogo();
    }
}
