using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timeWait = 1;
    private float timeNextShoot = 0;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > timeNextShoot)
        {
            timeNextShoot = Time.time + timeWait;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
