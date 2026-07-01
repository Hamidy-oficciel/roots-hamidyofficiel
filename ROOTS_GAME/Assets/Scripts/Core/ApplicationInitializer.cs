using UnityEngine;

namespace ROOTS.Core
{
    /// <summary>
    /// Handles the boot order for the application core.
    /// </summary>
    public class ApplicationInitializer : MonoBehaviour
    {
        [SerializeField] private GameManager gameManager;

        private void Awake()
        {
            if (gameManager == null)
            {
                gameManager = FindObjectOfType<GameManager>();
            }

            if (gameManager != null)
            {
                // TODO: Extend boot order when additional foundation systems are introduced.
                gameManager.Initialize();
            }
        }
    }
}
