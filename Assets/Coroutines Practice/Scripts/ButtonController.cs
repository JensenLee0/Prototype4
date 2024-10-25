using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public bool isPushed = false;
    public GameObject laserPrefab;
    public Material notreadytofire;
    public Material readytofire;
    public MeshRenderer buttonMr;
    public GameObject missileSpawn;

    private void Start()
    {
        buttonMr = GetComponent<MeshRenderer>();
        buttonMr.material = readytofire;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( ! isPushed)
        {
            Debug.Log("THE BUTTON HAS BEEN PRESSED");
            isPushed = true;
            Instantiate(laserPrefab, missileSpawn.transform.position, laserPrefab.transform.rotation);
            buttonMr.material = notreadytofire;
            StartCoroutine(ButtonReset());
        }
    }
    IEnumerator ButtonReset()
    {
        yield return new WaitForSeconds(5);
        isPushed = false;
        buttonMr.material = readytofire;
    }
    
}
