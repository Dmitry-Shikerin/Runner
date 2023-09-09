using UnityEngine;

namespace MyProject.Scripts.Players
{
    public class PlayerMover : MonoBehaviour
    {
        [SerializeField] private float _moveSpid;
        [SerializeField] private float _stepSize;
        [SerializeField] private float _maxHeight;
        [SerializeField] private float _minHeight;

        private Vector3 _targetPosition; //почему здесь вектор 3 а не трансформ?

        private void Start()
        {
            _targetPosition = transform.position;
        }

        private void Update()
        {
            if (transform.position != _targetPosition)
                transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _moveSpid * Time.deltaTime);
        }

        public void TryMoveUp()
        {
            if (_targetPosition.y < _maxHeight)
                SetNextPosition(_stepSize);
        }

        public void TryMoveDown()
        {
            if (_targetPosition.y > _minHeight)
                SetNextPosition(-_stepSize);
        }

        private void SetNextPosition(float stepSize)
        {
            _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepSize);
        }
    }
}