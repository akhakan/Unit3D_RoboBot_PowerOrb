using UnityEngine;

public class KureToplayici : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("MaviKure"))
        {
            Debug.Log("Mavi Küre yok oldu");
            
        }
        else if (other.gameObject.CompareTag("KirmiziKure"))
        {
            Debug.Log("Kýrmýzý Küre yok oldu");
           
        }
        else if (other.gameObject.CompareTag("YesilKure"))
        {
            Debug.Log("Yeþil Küre yok oldu");

        }

        Destroy(other.gameObject);
    }

}
