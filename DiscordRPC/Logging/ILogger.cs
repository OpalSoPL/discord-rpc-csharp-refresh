using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscordRPC.Logging
{
	/// <summary>
	/// Logging interface to log the internal states of the pipe. Logs are sent in a NON thread safe way. They can come from multiple threads and it is upto the ILogger to account for it.
	/// </summary>
	public interface ILogger
	{
		/// <summary>
		/// The level of logging to apply to this logger.
		/// </summary>
		LogLevel Level { get; set; }

		/// <summary>
		/// Toggles verbose mode. When disabled, only important Errors and Warnings are shown
		/// </summary>
		bool Verbose { get; set; }

		/// <summary>
		/// Debug trace messeages used for debugging internal elements.
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		void Trace(string message, params object[] args);

		/// <summary>
		/// Informative log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		void Info(string message, params object[] args);

		/// <summary>
		/// Warning log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		void Warning(string message, params object[] args);

		/// <summary>
		/// Warning log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		/// <param name="verbose"></param>
		void Warning(string message, bool verbose, params object[] args);

		/// <summary>
		/// Error log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		void Error(string message, params object[] args);

		/// <summary>
		/// Error log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		/// <param name="verbose"></param>
		void Error(string message, bool verbose, params object[] args);
	}
}
