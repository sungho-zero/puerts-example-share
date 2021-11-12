using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPanelJSBind : MonoBehaviour
{
    public Action onAwake;

    public Action onDestroy;

    public Action onStart;
    
    public void Awake()
    {
        onAwake?.Invoke();
    }

    public void Start()
    {
        onStart?.Invoke();
    }

    private void OnDestroy()
    {
        onDestroy?.Invoke();
    }
}
