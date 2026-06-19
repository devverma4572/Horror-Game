using UnityEngine;

public class CandlePickup : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;
    [SerializeField] AudioSource equipfx;

    public void Interact()
    {
        equipfx.Play();
        tableCandle.SetActive(false);
        handCandle.SetActive(true);

        gameObject.SetActive(false);
    }

    public string GetActionText()
    {
        return "Candle";
    }

    public string GetCommandText()
    {
        return "Press [E] to Pickup";
    }
}