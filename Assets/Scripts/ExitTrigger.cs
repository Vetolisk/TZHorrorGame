using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ExitTrigger : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Exit");
        }
    }
}
