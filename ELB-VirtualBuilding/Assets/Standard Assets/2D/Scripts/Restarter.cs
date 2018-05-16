using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnitySampleAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}