using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int valor = 10;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager score = FindFirstObjectByType<ScoreManager>();

            if (score != null)
            {
                score.AdicionarPontos(valor);
            }

            Destroy(gameObject);
        }
    }
}