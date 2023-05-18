using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Car : MonoBehaviour
{

    [SerializeField] private float _speed;
    void Update()
    {
        
        
        var step = _speed * Time.deltaTime;
        var position = gameObject.transform.position;
        if (Input.GetKey(KeyCode.W))
        {
              position.z += step;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            position.z -= step;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            position.z += step;
            position.x -= step/2;
        }
        
        else if(Input.GetKey(KeyCode.D))
        {
            position.z += step;
            position.x += step/2;
        }
      
        transform.position = position;
        
    }
}
