using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UP_DeactivationEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent onDeactivate = null;

    void OnDisable()
    {
        onDeactivate?.Invoke();
    }
}
