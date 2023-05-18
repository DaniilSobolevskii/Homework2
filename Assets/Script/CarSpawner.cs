using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;

    [SerializeField]
    private Transform _parent;
    private void Awake()
    {
        Instantiate(_prefab, _parent, worldPositionStays:true);
    }
    
}
