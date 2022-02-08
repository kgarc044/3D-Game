using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeSwing : MonoBehaviour
{

    public GameObject theAxe;
    public bool isSwinging = false;
    public AudioSource swingSound;

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && isSwinging == false)
        {
            isSwinging = true;
            StartCoroutine(SwingTheAxe());
        }

    }

    IEnumerator SwingTheAxe()
    {
        swingSound.Play();
        theAxe.GetComponent<Animation>().Play("SwingAxe");
        yield return new WaitForSeconds(0.55f);
        isSwinging = false;
    }
}