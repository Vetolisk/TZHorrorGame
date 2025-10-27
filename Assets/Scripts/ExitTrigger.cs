using UnityEngine;

public class ExitTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            Application.Quit();
        }
    }
}
