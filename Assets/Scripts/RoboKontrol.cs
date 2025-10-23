using UnityEngine;

public class RoboKontrol : MonoBehaviour
{
    [SerializeField] float hiz = 5f;


    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 pozisyon = new Vector3(yatay, 0, dikey);
        transform.Translate(pozisyon * hiz * Time.deltaTime);


    }
}
