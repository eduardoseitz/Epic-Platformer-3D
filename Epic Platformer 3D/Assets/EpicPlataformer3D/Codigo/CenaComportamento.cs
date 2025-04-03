using UnityEngine;
using UnityEngine.SceneManagement;

public class CenaComportamento : MonoBehaviour
{
    // Carrega a cena especifica pelo numero.
    public void CarregarCena(int indexDaCena)
    {
        SceneManager.LoadScene(indexDaCena);
    }
    
    // Recarrega a cena atual.
    public void RearregarCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
