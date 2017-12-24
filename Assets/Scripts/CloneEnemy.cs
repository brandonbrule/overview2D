using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneEnemy : MonoBehaviour {
    public GameObject EnemyReference;
    private GameObject Copy;
    public int spawn_count = -1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnCopy()
    {
        if(spawn_count > 0)
        {
            Copy = Instantiate(EnemyReference, EnemyReference.transform.position, Quaternion.identity);
            Copy.SetActive(true);
            spawn_count = spawn_count - 1;
        }

        if(spawn_count == -1)
        {
            Copy = Instantiate(EnemyReference, EnemyReference.transform.position, Quaternion.identity);
            Copy.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (!Copy)
            {
                SpawnCopy();
            }
            
        }

    }
}
