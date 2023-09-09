using MyProject.Scripts.Players;
using UnityEngine;

namespace MyProject.Scripts.Enemy
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int _damage;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Player player))
            {
                player.ApplyDamage(_damage);
            }
        
            Die();
        }

        private void Die()
        {
            gameObject.SetActive(false);
        }
    }
}