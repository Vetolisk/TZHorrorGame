using UnityEngine;

public class TriggerCoffeeNPC : MonoBehaviour
{
    [SerializeField] private NPCMovement NPC;
    public Animator AnimEnemy;
    [SerializeField] private AudioSource _AudioSource;
    [SerializeField] private AudioClip _AudioClip;
    [SerializeField] private AudioSource _AudioSourcePlayer;
    [SerializeField] private AudioClip _AudioClipPlayer;
    private void Start()
    {
        AnimEnemy.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Papper Cup 14 OZ")
        {
            Destroy(other.gameObject);
            AnimEnemy.gameObject.SetActive(true);
            NPC.flagGetCoffee=true;
            AnimEnemy.SetBool("Scare", NPC.flagGetCoffee);
            //_AudioSource.PlayOneShot(_AudioClip);
            _AudioSourcePlayer.PlayOneShot(_AudioClipPlayer);
        }
    }
}
