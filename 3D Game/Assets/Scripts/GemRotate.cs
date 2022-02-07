using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemRotate : MonoBehaviour
{
    // Start is called before the first frame update

    public int RotateSpeed;
    public AudioSource collectSound;
    public GameObject gemPiece;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, RotateSpeed, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        gemPiece.SetActive(false);
    }
}
