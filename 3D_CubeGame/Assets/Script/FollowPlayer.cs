using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Player objesinin Transform yani konum, pozisyon, rotasyon özelliðini alýr.
    public Transform player;
    // 3 boyutlu (x,y,z) bir vektör tanýmlar.
    public Vector3 offset; 

    // Update is called once per frame
    void Update()
    {
        // Küçük harflerle yazýlan transform mevcut nesnenin transformunu ifade eder.
        transform.position = player.position+offset; 
        // Kameranýn player'dan biraz geride ve yukarýda durmasý için offset'i üstüne ekleriz.
        // Eðer eklemezsek kamera player'ýn merkezine yerleþir. Dolasýyla 1. þahýs modunda olur.
        // Ama þimdi karakterimiz 3. þahýs modundadýr.
    }
}
