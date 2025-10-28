using System.Collections;
using UnityEngine;

public class SceneTwo : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(CoroutineExit());
    }
    IEnumerator CoroutineExit()
    {
        yield return new WaitForSeconds(0.5f);
        Application.Quit();
    }
}
