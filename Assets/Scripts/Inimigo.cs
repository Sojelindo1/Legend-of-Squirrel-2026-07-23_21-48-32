using UnityEngine;

public class Inimigo : Personagem
{
    [SerializeField] private int EnemyDamage = 20;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Personagem player = collision.gameObject.GetComponent<Personagem>();
        if(player != null)
        {
            player.ReceberDano(EnemyDamage);


        }

        }


    }


}
