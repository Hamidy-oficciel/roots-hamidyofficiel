using System;
using UnityEngine;

namespace ROOTS.Core
{
    /// <summary>
    /// Coordinates the application's initialization flow.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private ApplicationInitializer initializer;

        private GameState currentState = GameState.None;

        /// <summary>
        /// Occurs when the application core has completed initialization.
        /// </summary>
        public event Action Initialized;

        /// <summary>
        /// Gets the current lifecycle state of the application core.
        /// </summary>
        public GameState CurrentState => currentState;

        private void Awake()
        {
            currentState = GameState.Booting;

            if (initializer == null)
            {
                Debug.LogWarning("Application initializer reference is missing.");
            }
        }

        /// <summary>
        /// Begins the initialization sequence for the application core.
        /// </summary>
        public void Initialize()
        {
            if (currentState == GameState.Initializing || currentState == GameState.Ready)
            {
                return;
            }

            currentState = GameState.Initializing;

            // TODO: Register core services.
            // TODO: Initialize foundational systems.
            // TODO: Connect future application modules.

            currentState = GameState.Ready;
            Initialized?.Invoke();
        }

        /// <summary>
        /// Pauses the application core.
        /// </summary>
        public void Pause()
        {
            if (currentState == GameState.Ready)
            {
                currentState = GameState.Paused;
            }
        }

        /// <summary>
        /// Resumes the application core.
        /// </summary>
        public void Resume()
        {
            if (currentState == GameState.Paused)
            {
                currentState = GameState.Ready;
            }
        }

        /// <summary>
        /// Begins the shutdown sequence for the application core.
        /// </summary>
        public void Shutdown()
        {
            currentState = GameState.ShuttingDown;

            // TODO: Release core resources.
            // TODO: Finalize future systems.
        }
    }
}
