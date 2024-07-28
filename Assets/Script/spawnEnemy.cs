using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemy : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public GameObject player;
    private int count = 0;

    [SerializeField] private float moveSpeed = 3f;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    private void Update()
    {
        count++;
        if (count > 3000)
        {
            GameObject spawn = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            Vector3 dir = (player.transform.position - spawn.transform.position).normalized;
            spawn.GetComponent<Rigidbody2D>().velocity = dir * moveSpeed;
            count = 0;
        }
    }
}
