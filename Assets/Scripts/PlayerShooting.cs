using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject PlayerBulletPrefab;
    public float shootDelay = 0.25f;
    float reloadTime = 0;
    // Update is called once per frame
    void Update()
    {
        reloadTime -= Time.deltaTime;

        if(Input.GetButton("Fire1") && reloadTime <= 0)
        { 
            reloadTime = shootDelay;

            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);

            Instantiate(PlayerBulletPrefab, transform.position + offset, transform.rotation);
        }
    }
}
