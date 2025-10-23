using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Camera maincam;
    public float interactDistance = 10f;


    // public GameObject interactionUI;
    //public TextMeshProUGUI interactionText;

    private void Update()
    {
        InteractionRay();
    }
    void InteractionRay()
    {
        Ray ray = maincam.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;
        bool hitSomething = false;
        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                hitSomething = true;
                //interactionText.text = interactable.GetDescription();

                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    interactable.Interact();
                }
                if (Input.GetKeyUp(KeyCode.Mouse0))
                {
                    interactable.InteractStop();
                }

            }
        }
        // interactionUI.SetActive(hitSomething);
    }
}
