using UnityEngine;
using UnityEngine.InputSystem;


public class Movimento : MonoBehaviour
{
    public Rigidbody2D playerPhysics;
    private float playerSpeed = 5f;
    private float playerPulo = 10f;
    public InputAction playerControle;
    public InputAction playerJump;
    private bool EstaNoChao;
    Vector2 playerDirec;
    

    private void OnEnable(){

        playerControle.Enable();
        playerJump.Enable();
        playerJump.performed += PuloPlayer;

    }
    private void OnDisable(){

        playerControle.Disable();
        playerJump.Disable();
         playerJump.performed -= PuloPlayer;

    }

  
    void Update()
    {
        playerDirec = playerControle.ReadValue<Vector2>();
        playerPhysics.linearVelocity = new Vector2(playerDirec.x * playerSpeed, playerPhysics.linearVelocity.y);
    }

    private void PuloPlayer(InputAction.CallbackContext context)
{
    if (!EstaNoChao)
        return;

    playerPhysics.linearVelocity = new Vector2(
        playerPhysics.linearVelocity.x,
        playerPulo
    );
}
    
    private void OnCollisionStay2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        EstaNoChao = true;
    }
}

private void OnCollisionExit2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        EstaNoChao = false;
    }
}





}
