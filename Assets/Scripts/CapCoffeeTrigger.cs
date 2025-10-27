using UnityEngine;

public class CapCoffeeTrigger : MonoBehaviour
{
    [SerializeField] private GameObject o_CapCoffee;
    [SerializeField] private ObjectGrabbable _ObjectGrabbable;
    public bool flag=false;
    public bool CapCoffeeFill=false;
    private void OnTriggerEnter(Collider other)
    {

        // Можно расширить после уточнения ТЗ
        if (other.gameObject.name == "Papper Cup 14 OZ"&& !CapCoffeeFill)
        {
            other.gameObject.transform.SetParent(gameObject.transform);
            _ObjectGrabbable.Drop();
            other.gameObject.transform.localPosition = new Vector3(0.0786790848f, -0.161647797f, 0.187580109f);
            other.gameObject.transform.localRotation = Quaternion.Euler(-90,0,0);
            flag=true;
        }
    }
}
    