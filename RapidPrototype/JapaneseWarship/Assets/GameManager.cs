using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ship ship;
    private float cooldown;
    private float spawnCooldown = 2.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        cooldown = Time.time + spawnCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown < Time.time)
        {
            var spawn = Instantiate(ship, transform.position, Quaternion.identity);
            spawn.GetComponent<Rigidbody>().velocity = Vector3.forward;
            cooldown = Time.time + Random.Range(0.0f, 2.0f);
        }
    }
}
