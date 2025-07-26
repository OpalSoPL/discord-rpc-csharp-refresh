using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscordRPC.Logging
{
	/// <summary>
	/// Ignores all log events
	/// </summary>
	public class NullLogger : ILogger
	{
		/// <summary>
		/// The level of logging to apply to this logger.
		/// </summary>
		public LogLevel Level { get; set; }

		/// <summary>
		/// Toggles verbose mode. When disabled, only important Errors and Warnings are shown
		/// </summary>
        public bool Verbose { get; set; }

        /// <summary>
        /// Informative log messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public void Trace(string message, params object[] args)
        {
            //Null Logger, so no messages are actually sent
        }

        /// <summary>
        /// Informative log messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public void Info(string message, params object[] args)
		{
			//Null Logger, so no messages are actually sent
		}

		/// <summary>
		/// Warning log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		public void Warning(string message, params object[] args)
		{
			//Null Logger, so no messages are actually sent
		}


		/// <summary>
		/// Warning log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		/// <param name="verbose"></param>
		public void Warning(string message, bool verbose, params object[] args)
		{
			//Null Logger, so no messages are actually sent
		}

		/// <summary>
		/// Error log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		public void Error(string message, params object[] args)
		{
			//Null Logger, so no messages are actually sent
		}

		/// <summary>
		/// Error log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		/// <param name="verbose"></param>
		public void Error(string message, bool verbose, params object[] args)
		{
			//Null Logger, so no messages are actually sent
		}
    }
}
