using System;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    [SerializeField] private Waffle _waffle;
    [SerializeField] private Transform _transform;
    [SerializeField] private Toaster _toaster;
    private void Start()
    {
        _toaster.TimerIsUp += WaffleOn;
    }

    private void WaffleOn()
    {
        Instantiate(_waffle, _transform);
    }
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 
}