using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        // Time.deltaTime bilgisayar�n bir frame olu�turmak i�in gereken s�reyi belirtir.

        if (Input.GetKey("d"))
        {
            rb.AddForce((sidewayForce * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
            // ForceMode.VelocityChange, kuvvet t�r�n� h�z de�i�imine ayarlar.
            // B�ylece sa�a veya sola bast���m�zda player daha duyarl� olur. Hemen tepki g�sterir.
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce((-sidewayForce * Time.deltaTime), 0, 0, ForceMode.VelocityChange);
        }

        // Ba�lang��ta Y de�eri 0. E�er Y de�eri eksi olursa oyuncu d���yor demektir.
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
