using System;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;

public class Collectables : MonoBehaviour {

    public Transform myPrefab;
    private List<Transform> collectables = new List<Transform>();
    private float _rotatespeed = 50;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 30; i++)
        {
            float x = Random.Range(-4.5f, 4.5f);
            float y = 0.5f;
            float z = Random.Range(-4.5f, 4.5f);
            Transform collectable = Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.Euler(0,0, 0));
            collectables.Add(collectable);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform collectable in collectables) 
        {
            if(collectable != null) 
                collectable.transform.Rotate( new Vector3(0,_rotatespeed, 0) * Time.deltaTime);
        }
    }
    
}
