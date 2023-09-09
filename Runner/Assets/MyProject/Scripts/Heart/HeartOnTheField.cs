using MyProject.Scripts.Players;
using UnityEngine;

namespace MyProject.Scripts.Heart
{
    public class HeartOnTheField : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out Player player))
            {
                 player.AddHeart();
            }
        
            Die();
        }

        private void Die()
        {
            gameObject.SetActive(false);
        }
    }
}
