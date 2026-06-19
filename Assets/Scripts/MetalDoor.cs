using UnityEngine;
using System.Collections;
using StarterAssets;

public class MetalDoor : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject theCam;
    [SerializeField] GameObject DoorInstText;
    [SerializeField] GameObject theDoor;

    [SerializeField] FirstPersonController playerMovement;

    [SerializeField] AudioSource lockedoorfx;
    [SerializeField] AudioSource creakDoorfx;
    private PlayerInventory inventory;


    void Start()
    {
        Debug.Log(thePlayer);
        Debug.Log(theCam);
        Debug.Log(DoorInstText);
        inventory = FindObjectOfType<PlayerInventory>();
    }

    // INTERACTION MANAGER CALLS THIS
    public void Interact()
    {
        if (!inventory.hasMetalKey)
        {
            lockedoorfx.Play();
            Debug.Log("Need Key");
            return;
        }
        
        StartCoroutine(OpeningDoor());
    }

    // UI TEXT
    public string GetActionText()
    {
        if (!inventory.hasMetalKey)
        {
            return "Locked Door";
        }
        return "Open Door";
    }

    public string GetCommandText()
    {
        if (!inventory.hasMetalKey)
        {
            return "Need Key To Open";
        }
        
        return "Press [E] to Open";
    }

    IEnumerator OpeningDoor()
    {
       

        creakDoorfx.Play();
        theCam.SetActive(true);
        theDoor.GetComponent<Animator>().Play("DoorOpen1");
        yield return new WaitForSeconds(2f);
        theCam.SetActive(false);


    }
}