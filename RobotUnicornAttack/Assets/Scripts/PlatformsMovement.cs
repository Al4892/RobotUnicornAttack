using System.Runtime.InteropServices;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Events;

public class PlatformsMovement : MonoBehaviour
{
    [SerializeField]
    private float _InitialSpeed=2f;
    [SerializeField]
    private float _speedincrease=0.1f;
    [SerializeField]
    private UnityEvent<int> _onscoredChangued;
    [SerializeField]
    private float _scoreValue=1f;
    private bool _canMove=true;
    public bool CanMove{set => _canMove=value;}
    private Vector3 _StartingPosition;
    private float _speed;
    private float _PastSpeed;
    private Vector3 _moveDistance;
    public void SpeedUp(float SpeedMultiplier)
    {
        _PastSpeed=_speed;
        _speed*=SpeedMultiplier;
    }
    public void SpeedDown()
    {
        _speed=_PastSpeed;
    }
       void Start()
    {
        _StartingPosition= transform.position;
        _speed=_InitialSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(_canMove)
        {
            MovePlatforms();
        }
    }
    private void MovePlatforms()
    {
        Vector3 distanceToMove=Vector3.left*_speed*Time.deltaTime;
        transform.position+=distanceToMove;
        _moveDistance+=distanceToMove;  
        _onscoredChangued?.Invoke(math.abs((int)_scoreValue));

    }
    public void IncreaseSpeed()
    {
        
        _speed+=_speedincrease;
        _PastSpeed+=_speedincrease;
    }
    public void StopMovement()
    {
        _canMove=false; 
    }
    public void StartMovement()
    {
        _canMove=true;
    }
    public void Restart()
    {
        transform.position=_StartingPosition;
        _speed=_InitialSpeed;
        _moveDistance=Vector3.zero;
        StartMovement();
    }
}
