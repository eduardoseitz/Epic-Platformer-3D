using UnityEngine;

public class MorteComportamento : MonoBehaviour
{
    public AdministradorDeJogo administradorDeJogo;
    
    public void OnTriggerEnter(Collider outroObjeto)
    {
        administradorDeJogo.PerderJogo();
    }

    public void OnCollisionEnter(Collision outroObjeto)
    {
        administradorDeJogo.PerderJogo();
    }
}
