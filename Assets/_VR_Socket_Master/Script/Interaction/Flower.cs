using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{

    public GameObject finalpanel;
    public AudioSource victory;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Static")
        {
            Debug.Log("Completed!");
            finalpanel.SetActive(true);

            victory.Play();

           GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
       }
    }
}
