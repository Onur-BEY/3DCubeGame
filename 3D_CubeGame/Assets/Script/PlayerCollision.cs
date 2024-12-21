using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("We hit an Obstacle!");
            movement.enabled = false;  //veya GetComponent<PlayerMovement>().enabled=false;
            FindObjectOfType<GameManager>().EndGame(); // GameManager t�r�nde obje arar.
            // B�ylece GameManager'�n direkt referans�n� olu�turmam�� oluruz.
        }
    }
}
