using UnityEngine;

public class Personagem : MonoBehaviour
{
   public string Name;
   [SerializeField]protected int Vida = 100;

   public void ReceberDano(int damage){

    Vida = Vida - damage;
    Debug.Log("Vida Atual: " + Vida);



   }









}
