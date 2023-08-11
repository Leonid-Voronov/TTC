using UnityEngine;

namespace TTC
{
    public class Wire : MonoBehaviour
    {
        [SerializeField] private GameStater _gameStater;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.GetComponent<PlayerTrigger>() && _gameStater.IsInGameplay())
            {
                _gameStater.FinishGame();
            }
        }
    }
}

