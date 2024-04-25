using UnityEngine;

public class WorkState : IState
{
    protected readonly IStateSwitcher StateSwitcher;
    private readonly Worker _worker;
    private float _workTime;

    public WorkState(IStateSwitcher switcher, Worker worker)
    {
        StateSwitcher = switcher;
        _worker = worker;
    }

    public void Enter()
    {
        Debug.Log(GetType());
        _workTime = _worker.Config.WorkTime;
    }

    public void Exit()
    {
        Debug.Log($"Exit {GetType()} state");
    }

    public void Update()
    {
        _workTime -= Time.deltaTime;
        if (_workTime < 0)
            StateSwitcher.SwitchState<MoveToRestPlace>();
    }
}
