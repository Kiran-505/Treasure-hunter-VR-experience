using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlocked : MonoBehaviour
{
    public GameObject chestLid;
 
    // Start is called before the first frame update
    void Start()
    {
        //chestLid.GetComponent<Grabbable>().allowGrab = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        if (collision.gameObject.tag=="Lock")
        {
            Debug.Log("Destroying the lock");
            collision.gameObject.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject, 3.0f);
            //chestLid.GetComponent<Grabbable>().allowGrab = true;

        }
    }
}
