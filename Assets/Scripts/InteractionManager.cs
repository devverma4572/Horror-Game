using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public float interactDistance = 3f;

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(
            new Vector3(0.5f, 0.5f, 0));

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            IInteractable interactable =
                hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                UIController.actionText =
                    interactable.GetActionText();

                UIController.commandText =
                    interactable.GetCommandText();

                UIController.uiActive = true;

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }

                return;
            }
        }
        UIController.uiActive = false;
    }
}