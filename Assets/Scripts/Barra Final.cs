using UnityEngine;
using UnityEngine.SceneManagement;

public class BarraFinal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(other.gameObject);

            SceneManager.LoadScene("Level1");
        }
    }
}
