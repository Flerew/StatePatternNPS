using UnityEngine;

public class WorkerConfig : MonoBehaviour
{
    [SerializeField] private Transform _workplacePosition;
    [SerializeField] private Transform _restPlacePosition;
    [SerializeField] private float _workTime;
    [SerializeField] private float _restTime;

    public Transform WorkplacePosition => _workplacePosition;
    public Transform RestPlacePosition => _restPlacePosition;
    public float WorkTime => _workTime;
    public float RestTime => _restTime;
}
