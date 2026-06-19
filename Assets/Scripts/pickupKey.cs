using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public string keyName = "Metal Key";

    public void Interact()
    {
        PlayerInventory inventory = FindObjectOfType<PlayerInventory>();
        inventory.hasMetalKey = true;

        Debug.Log("Key Collection");
        Destroy(gameObject);
    }
    public string GetActionText()
    {
        return keyName;
    }
    public string GetCommandText()
    {
        return "Press [E] to pick-up Key";
    }
}
