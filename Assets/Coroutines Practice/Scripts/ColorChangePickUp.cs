using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangePickUp : MonoBehaviour
{
    [Header("Materials")]
    public Material defaultMaterial;
    public Material newMaterial;

    [Header("Duration")]
    public float duration;

    //Components

    private MeshRenderer myMr;
    private MeshRenderer playerMr;
    private Collider myCollider;


    // Start is called before the first frame update
    void Start()
    {
        myMr = GetComponent<MeshRenderer>();
        myCollider = GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            //get the players mesh render
            playerMr = other.gameObject.GetComponent<MeshRenderer>();

            //turn off my collider
            myCollider.enabled = false;

            //change colour
            playerMr.material = newMaterial;

            //start the coroutine
            StartCoroutine(ColourReset());
        }
    }
    IEnumerator ColourReset()
    {
        yield return new WaitForSeconds(duration);
        playerMr.material = default;
        myCollider.enabled = true;
    }
}
