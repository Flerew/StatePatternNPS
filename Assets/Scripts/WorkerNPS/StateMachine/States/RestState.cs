using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    private readonly Worker _worker;
    private float _restTime;

    public RestState(IStateSwitcher switcher, Worker worker)
    {
        StateSwitcher = switcher;
        _worker = worker;
    }

    public void Enter()
    {
        Debug.Log(GetType());
        _restTime = _worker.Config.WorkTime;
    }

    public void Exit()
    {
        Debug.Log($"Exit {GetType()} state");
    }

    public void Update()
    {
        _restTime -= Time.deltaTime;
        if (_restTime < 0)
            StateSwitcher.SwitchState<MoveToWorkplaceState>();
    }
}
