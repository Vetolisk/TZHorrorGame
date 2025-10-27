using UnityEngine;

public class ScareScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            Debug.Log("BLOP");
        }
    }
}
