using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    
    private void Start()
    {
        Shelf[] shelfs = FindObjectsOfType<Shelf>();
        foreach (var shelf in shelfs)
        {
            shelf.ItemSpawned += UpdateShelf;
        }

        void UpdateShelf()
        {
            foreach (var shelf in shelfs)
            {
                if (shelf.ItemsCount>3)
                {
                   shelf.Fall();
                }
            }
        }
    }

    
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
}