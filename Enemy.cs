using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    private float _speed = 0.5f;
    public Transform target;
    public Transform myPrefab;
    List<Transform> enemys = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            float x = Random.Range(-4.5f, 4.5f);
            float y = 0.25f;
            float z = Random.Range(-4.5f, 4.5f);
            myPrefab.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            Transform enemy = Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.Euler(0, 0, 0));
            enemys.Add(enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform enemy in enemys)
        {
            enemy.LookAt(target.transform);
            enemy.Translate(Vector3.forward * _speed * Time.deltaTime);
        }
    }
}
