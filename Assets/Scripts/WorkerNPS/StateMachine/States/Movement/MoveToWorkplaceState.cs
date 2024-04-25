using UnityEngine;

public class MoveToWorkplaceState : MovementState
{
    public MoveToWorkplaceState(IStateSwitcher switcher, Worker worker, Transform targetPosition) : base(switcher, worker, targetPosition)
    {
    }

    public override void Enter()
    {
        TargetPosition = WorkerConfig.WorkplacePosition;

        base.Enter();
    }

    public override void Update()
    {
        if (Vector3.Distance(Worker.Transform.position, TargetPosition.position) <= MinDistanceToTarget)
            StateSwitcher.SwitchState<WorkState>();
    }
}
