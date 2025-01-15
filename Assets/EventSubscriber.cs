using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSubscriber : MonoBehaviour
{
    private void Start()
    {
        EventManager.Instance.OnKeyPressed += EventManager_OnKeyPressed;
        EventManager.Instance.OnActionEvent += EventManager_OnActionEvent;
        EventManager.Instance.OnDelegateEvent += EventManager_OnDelegateEvent;
    }

    private void EventManager_OnDelegateEvent(int i)
    {
        Debug.Log("Number: " + i);
        //EventManager.Instance.OnDelegateEvent -= EventManager_OnDelegateEvent;
    }

    private void EventManager_OnActionEvent(int f)
    {
        Debug.Log("Number: " + f);
        //EventManager.Instance.OnActionEvent -= EventManager_OnActionEvent;
    }

    private void EventManager_OnKeyPressed(object sender, EventArgs e)
    {
        Debug.Log("Space Key Pressed!");
        //EventManager.Instance.OnKeyPressed -= EventManager_OnKeyPressed;
    }

    public void EventManager_OnUnityEvent()
    {
        Debug.Log("Unity Event Works Fine!");
    }
}
