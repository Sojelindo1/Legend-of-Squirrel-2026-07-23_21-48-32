using UnityEngine;
using UnityEngine.InputSystem;


public class Movimento : MonoBehaviour
{
    public Rigidbody2D playerPhysics;
    private float playerSpeed = 5f;
    private float playerPulo = 10f;
    public InputAction playerControle;
    public InputAction playerJump;
    Vector2 playerDirec;
    

    private void OnEnable(){

        playerControle.Enable();
        playerJump.Enable();
        playerJump.performed += PuloPlayer;

    }
    private void OnDisable(){

        playerControle.Disable();
        playerJump.Disable();


    }

  
    void Update()
    {
        playerDirec = playerControle.ReadValue<Vector2>();
        playerPhysics.linearVelocity = new Vector2(playerDirec.x * playerSpeed, playerPhysics.linearVelocity.y);
    }

    private void PuloPlayer(InputAction.CallbackContext context){

        playerPhysics.linearVelocity = new Vector2(playerPhysics.linearVelocity.x, playerPulo);




    }





}
