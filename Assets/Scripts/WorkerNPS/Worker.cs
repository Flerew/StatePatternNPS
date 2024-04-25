using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Worker : MonoBehaviour
{
    [SerializeField] private WorkerConfig _config;

    private WorkerStateMachine _stateMachine;

    public Transform Transform => transform;
    public WorkerConfig Config => _config;
    public NavMeshAgent Agent { get; private set; }

    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();

        _stateMachine = new WorkerStateMachine(this);
    }

    private void Update()
    {
        _stateMachine.Update();
    }
}
