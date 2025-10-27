using UnityEngine;

public class CapTrigger : MonoBehaviour
{
    [SerializeField] private GameObject o_Cap;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name== "Cap 2")
        {
            Destroy(other.gameObject);
            o_Cap.SetActive(true);
            o_Cap.layer = 1;
        }
    }
}
