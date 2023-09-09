using UnityEngine;
using UnityEngine.Events;

namespace MyProject.Scripts.Players
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private int _health;

        public event UnityAction<int> HealthChanged;
        public event UnityAction Died;

        private void Start()
        {
            HealthChanged?.Invoke(_health);
        }

        public void AddHeart()
        {
            _health++;
            HealthChanged?.Invoke(_health);
        }

        public void ApplyDamage(int damage)
        {
            _health -= damage;
            HealthChanged?.Invoke(_health);

            if (_health <= 0)
                Die();
        }

        private void Die()
        {
            Died?.Invoke();
        }
    }
}