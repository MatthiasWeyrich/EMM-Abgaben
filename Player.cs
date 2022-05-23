using UnityEngine;

public class Player : MonoBehaviour
{

    private float _speed = 0.01f;
    private float _angle;
    private int _collected;

    public int get_collected()
    {
        return _collected;
    }
    
    // Update is called once per frame
    void Update()
    {
        bool turnLeft = Input.GetKey(KeyCode.LeftArrow);
        bool turnRight = Input.GetKey(KeyCode.RightArrow);

        if (turnLeft)
        {
            _angle -= 0.01f;
        }
        if (turnRight)
        {
            _angle += 0.01f;
        }
        
        transform.rotation = Quaternion.LookRotation(new Vector3(Mathf.Sin(_angle), 0.0f, Mathf.Cos(_angle)));
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(moveX, 0, moveZ);
        

        transform.Translate(move * _speed);
        
    }

    public void Collect()
    {
        _collected++;
        if(_collected == 30)
        {
            Debug.Log("Level completed!");
        }
        else
        {
            Debug.Log(_collected);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
         GameObject collectables = other.gameObject;
        
        if (collectables.name.Equals("Collectable(Clone)"))
        {
            Destroy(collectables);
            Collect();
        }
    }
}
