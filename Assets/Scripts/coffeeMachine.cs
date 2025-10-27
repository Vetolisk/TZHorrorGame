using UnityEngine;

public class coffeeMachine : MonoBehaviour
{
    [SerializeField]private float Timer;
    [SerializeField]private GameObject CapObject;
    private AudioSource _AudioSource;
    [SerializeField]private AudioClip _AudioClip;
    [SerializeField] private CapCoffeeTrigger CT;
    private void Awake()
    {
        _AudioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
       //_AudioSource.PlayOneShot(_AudioClip);
    }
    private void Update()
    {
        if (CT.flag) 
        {
            _AudioSource.PlayOneShot(_AudioClip);
            CT.flag=false;
            CT.CapCoffeeFill = true;
        }
    }
}
