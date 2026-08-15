using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float suavidade = 5f;

    void LateUpdate()
    {
        if (player == null)
            return;

        Vector3 posicao = player.position;
        posicao.z = transform.position.z;

        transform.position = Vector3.Lerp(
            transform.position,
            posicao,
            suavidade * Time.deltaTime
        );
    }
}