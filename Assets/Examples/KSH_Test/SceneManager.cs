using System;
using System.Collections;
using System.Collections.Generic;
using Puerts;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public JsEnv JSEnv;

    public UIManager UIManager;

    public Func<string, Action<MonoBehaviour>> GETJsUI;

    private void Start()
    {
        JSEnv = new JsEnv();
        JSEnv.UsingAction<Action<MonoBehaviour>>();
        JSEnv.UsingFunc<Func<string, Action<MonoBehaviour>>>();
        GETJsUI = JSEnv.Eval<Func<string, Action<MonoBehaviour>>>("require('./ksh_init')");
    }

    public void OnClickOpenHUD()
    {
        UIManager.Open("UIPanelHUD");
    }
}