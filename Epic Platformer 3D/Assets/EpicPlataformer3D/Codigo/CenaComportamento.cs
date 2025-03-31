using UnityEngine;
using UnityEngine.SceneManagement;

public class CenaComportamento : MonoBehaviour
{
    public void CarregarCena(int indexDaCena)
    {
        SceneManager.LoadScene(indexDaCena);
    }
    
    public void RearregarCena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
