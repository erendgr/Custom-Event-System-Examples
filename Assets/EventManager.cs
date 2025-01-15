using System;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public event EventHandler OnKeyPressed;

    public event Action<int> OnActionEvent;

    public event DelegateEvent OnDelegateEvent;
    public delegate void DelegateEvent(int key);

    public UnityEvent OnUnityEvent;

    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnKeyPressed?.Invoke(this, EventArgs.Empty);
            OnActionEvent?.Invoke(5);
            OnDelegateEvent?.Invoke(10);
            OnUnityEvent?.Invoke();
        }
    }
}

