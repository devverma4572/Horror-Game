using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpiderWebBurn : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject spiderWeb;
    [SerializeField] GameObject handCandle;
    [SerializeField] MonoBehaviour metalDoorScript;
    [SerializeField] GameObject theCam;
    [SerializeField] GameObject fireObject;
    [SerializeField] GameObject webtextDesc;
    [SerializeField] AudioSource burnfx;




    public void Interact()
    {
        if (handCandle.activeSelf)
        {
            StartCoroutine(BurnWeb());
        }
    }

    public string GetActionText()
    {
        return "Spider Web";
    }

    public string GetCommandText()
    {
        if (handCandle.activeSelf)
        {
            return "Press [E] to Burn the Web";
        }

        return "Use Candle to burn the web";
    }

    IEnumerator BurnWeb()
    {
        theCam.SetActive(true);
        fireObject.SetActive(true);
        webtextDesc.SetActive(true);
        burnfx.Play();

        yield return new WaitForSeconds(2f);

        webtextDesc.SetActive(false);
        spiderWeb.SetActive(false);
        fireObject.SetActive(false);
        metalDoorScript.enabled = true;
        theCam.SetActive(false);

        gameObject.SetActive(false);
    }
}