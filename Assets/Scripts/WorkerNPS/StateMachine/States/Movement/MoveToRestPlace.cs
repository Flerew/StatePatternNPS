using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToRestPlace : MovementState
{
    public MoveToRestPlace(IStateSwitcher switcher, Worker worker, Transform targetPosition) : base(switcher, worker, targetPosition)
    {
    }

    public override void Enter()
    {
        TargetPosition = WorkerConfig.RestPlacePosition;

        base.Enter();
    }

    public override void Update()
    {
        if (Vector3.Distance(Worker.Transform.position, TargetPosition.position) <= MinDistanceToTarget)
            StateSwitcher.SwitchState<RestState>();
    }
}
