using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Player objesinin Transform yani konum, pozisyon, rotasyon �zelli�ini al�r.
    public Transform player;
    // 3 boyutlu (x,y,z) bir vekt�r tan�mlar.
    public Vector3 offset; 

    // Update is called once per frame
    void Update()
    {
        // K���k harflerle yaz�lan transform mevcut nesnenin transformunu ifade eder.
        transform.position = player.position+offset; 
        // Kameran�n player'dan biraz geride ve yukar�da durmas� i�in offset'i �st�ne ekleriz.
        // E�er eklemezsek kamera player'�n merkezine yerle�ir. Dolas�yla 1. �ah�s modunda olur.
        // Ama �imdi karakterimiz 3. �ah�s modundad�r.
    }
}
