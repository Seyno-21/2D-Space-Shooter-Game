using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
   public GameObject EnemyBulletPrefab;
    public float shootDelay = 1f;
    float reloadTime = 0;
    // Update is called once per frame
    void Update()
    {
        reloadTime -= Time.deltaTime;

        if(reloadTime <= 0)
        { 
            reloadTime = shootDelay;

            Vector3 offset = transform.rotation * new Vector3(0, 0.5f, 0);

            Instantiate(EnemyBulletPrefab, transform.position + offset, transform.rotation);
        }
    }
}
