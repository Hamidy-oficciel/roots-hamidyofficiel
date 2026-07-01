namespace ROOTS.Core
{
    /// <summary>
    /// Defines the core lifecycle states for the application.
    /// </summary>
    public enum GameState
    {
        /// <summary>
        /// No state has been assigned.
        /// </summary>
        None,

        /// <summary>
        /// The application is starting up.
        /// </summary>
        Booting,

        /// <summary>
        /// The application core is initializing.
        /// </summary>
        Initializing,

        /// <summary>
        /// The application core is ready.
        /// </summary>
        Ready,

        /// <summary>
        /// The application core is paused.
        /// </summary>
        Paused,

        /// <summary>
        /// The application is shutting down.
        /// </summary>
        ShuttingDown
    }
}
