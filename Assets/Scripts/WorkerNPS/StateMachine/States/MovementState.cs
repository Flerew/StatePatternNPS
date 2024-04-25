using UnityEngine;
using UnityEngine.AI;

public class MovementState : IState
{
    protected const float MinDistanceToTarget = 1f;
    protected Transform TargetPosition;
    protected readonly IStateSwitcher StateSwitcher;
    protected readonly WorkerConfig WorkerConfig;
    protected readonly Worker Worker;

    private readonly NavMeshAgent _agent;

    public MovementState(IStateSwitcher switcher, Worker worker, Transform targetPosition)
    {
        StateSwitcher = switcher;
        TargetPosition = targetPosition;
        Worker = worker;
        WorkerConfig = worker.Config;
        _agent = Worker.Agent;
    }

    public virtual void Enter()
    {
        Debug.Log(GetType());
        _agent.destination = TargetPosition.position;
    }

    public virtual void Exit()
    { 
        Debug.Log($"Exit {GetType()} state");
    }

    public virtual void Update() { }
}
