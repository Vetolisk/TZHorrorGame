using UnityEngine;

public class TriggerCoffeeNPC : MonoBehaviour
{
    [SerializeField] private NPCMovement NPC;
    public Animator AnimEnemy;
    [SerializeField] private AudioSource _AudioSource;
    [SerializeField] private AudioClip _AudioClip;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Papper Cup 14 OZ")
        {
            Destroy(other.gameObject);
            NPC.flagGetCoffee=true;
            AnimEnemy.SetBool("Scare", NPC.flagGetCoffee);
            //_AudioSource.PlayOneShot(_AudioClip);
        }
    }
}
