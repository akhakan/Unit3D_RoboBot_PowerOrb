using UnityEngine;

public class KureToplayici : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("MaviKure"))
        {
            Debug.Log("Mavi K�re yok oldu");
            
        }
        else if (other.gameObject.CompareTag("KirmiziKure"))
        {
            Debug.Log("K�rm�z� K�re yok oldu");
           
        }
        else if (other.gameObject.CompareTag("YesilKure"))
        {
            Debug.Log("Ye�il K�re yok oldu");

        }

        Destroy(other.gameObject);
    }

}
