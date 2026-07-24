using UnityEngine;

public class Personagem : MonoBehaviour
{
   public string Name;
   public float Speed = 10f;
   [SerializeField]protected int Vida = 100;

   void ReceberDano(int damage){

    Vida = Vida - damage;
    Debug.Log("Vida Atual: " + Vida);



   }









}
