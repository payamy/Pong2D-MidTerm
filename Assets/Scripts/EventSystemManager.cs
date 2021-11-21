using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSystemManager : MonoBehaviour
{
    public UnityEvent OnRightGoalEnter;
    public UnityEvent OnLeftGoalEnter;
    public UnityEvent OnPlayerWin;
    public UnityEvent OnPlayerLose;


    private void Awake()
    {
        OnRightGoalEnter = new UnityEvent();
        OnLeftGoalEnter = new UnityEvent();
        OnPlayerWin = new UnityEvent();
        OnPlayerLose = new UnityEvent();
    }
}
