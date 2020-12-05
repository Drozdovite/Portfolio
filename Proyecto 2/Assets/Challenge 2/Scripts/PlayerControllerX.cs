using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float time_passed = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && time_passed < Time.time)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            time_passed = Time.time + 1;
        }
    }
}
