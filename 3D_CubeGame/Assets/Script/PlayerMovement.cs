using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        // Time.deltaTime bilgisayarýn bir frame oluþturmak için gereken süreyi belirtir.

        if (Input.GetKey("d"))
        {
            rb.AddForce((sidewayForce * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
            // ForceMode.VelocityChange, kuvvet türünü hýz deðiþimine ayarlar.
            // Böylece saða veya sola bastýðýmýzda player daha duyarlý olur. Hemen tepki gösterir.
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce((-sidewayForce * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
        }

        // Baþlangýçta Y deðeri 0. Eðer Y deðeri eksi olursa oyuncu düþüyor demektir.
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
