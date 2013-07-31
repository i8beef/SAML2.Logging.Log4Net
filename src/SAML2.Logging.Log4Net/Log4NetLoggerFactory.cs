using log4net;

namespace SAML2.Logging.Log4Net
{
    /// <summary>
    /// SAML2 logger factory based on Log4Net.
    /// </summary>
    public class Log4NetLoggerFactory : ILoggerFactory
    {
        /// <summary>
        /// Gets a logger for the specified name.
        /// </summary>
        /// <param name="keyName">Name of the key.</param>
        /// <returns>An <see cref="IInternalLogger"/> implementation.</returns>
        public IInternalLogger LoggerFor(string keyName)
        {
            return new Log4NetInternalLogger(LogManager.GetLogger(keyName));
        }

        /// <summary>
        /// Gets a logger for specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>An <see cref="IInternalLogger"/> implementation.</returns>
        public IInternalLogger LoggerFor(System.Type type)
        {
            return new Log4NetInternalLogger(LogManager.GetLogger(type));
        }
    }
}
