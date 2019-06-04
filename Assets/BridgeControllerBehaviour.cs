﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Luke
{
    public class BridgeControllerBehaviour : MonoBehaviour
    {
        [NonSerialized]
        public bool condition;
        public UnityEvent ExecuteIfTrueResponse;
        public UnityEvent ExecuteIfFalseResponse;
        public PlayerInventoryObject inventory;
        public Item key;
        public void CheckInventoryForItem()
        {
            inventory.CheckForItem(key);
            condition = inventory.has_item;
            if (condition)
            {
                ExecuteIfTrueResponse.Invoke();
            }
            else
            {
                ExecuteIfFalseResponse.Invoke();
            }
            
        }
    }
}
