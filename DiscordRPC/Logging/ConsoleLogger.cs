using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiscordRPC.Logging
{
	/// <summary>
	/// Logs the outputs to the console using <see cref="Console.WriteLine()"/>
	/// </summary>
	public class ConsoleLogger : ILogger
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
		/// Should the output be coloured?
		/// </summary>
		public bool Coloured { get; set; }

		/// <summary>
		/// Creates a new instance of a Console Logger.
		/// </summary>
		/// <param name="level">The log level</param>
		/// <param name="coloured">Should the logs be in colour?</param>
		/// <param name="verbose">Should the logs be more detailed?</param>
		public ConsoleLogger(LogLevel level = LogLevel.Info, bool coloured = false, bool verbose = false)
		{
			Level = level;
			Coloured = coloured;
			Verbose = verbose;
        }

        /// <summary>
		/// Informative log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		public void Trace(string message, params object[] args)
		{
			if (Level > LogLevel.Trace) return;

			if (Coloured) Console.ForegroundColor = ConsoleColor.Gray;

			string prefixedMessage = "TRACE: " + message;

			if (args.Length > 0)
			{
				Console.WriteLine(prefixedMessage, args);
			}
			else
			{
				Console.WriteLine(prefixedMessage);
			}
		}

        /// <summary>
        /// Informative log messages
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public void Info(string message, params object[] args)
		{
			if (Level > LogLevel.Info) return;

			if (Coloured) Console.ForegroundColor = ConsoleColor.White;

			string prefixedMessage = "INFO: " + message;

			if (args.Length > 0)
			{
				Console.WriteLine(prefixedMessage, args);
			}
			else
			{
				Console.WriteLine(prefixedMessage);
			}
		}

		/// <summary>
		/// Warning log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		public void Warning(string message, params object[] args) => Warning(message, false, args);
		
		/// <summary>
		/// Warning log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		/// <param name="verbose"></param>
		public void Warning(string message, bool verbose, params object[] args)
		{
			if (Level > LogLevel.Warning) return;
			if (verbose && !Verbose) return;

			if (Coloured) Console.ForegroundColor = ConsoleColor.Yellow;

			string prefixedMessage = "WARN: " + message;

			if (args.Length > 0)
			{
				Console.WriteLine(prefixedMessage, args);
			}
			else
			{
				Console.WriteLine(prefixedMessage);
			}
		}

		/// <summary>
		/// Error log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		public void Error(string message, params object[] args) => Error(message, false, args);

		/// <summary>
		/// Error log messages
		/// </summary>
		/// <param name="message"></param>
		/// <param name="args"></param>
		/// <param name="verbose"></param>
		public void Error(string message, bool verbose, params object[] args)
		{
			if (Level > LogLevel.Error) return;
			if (verbose && !Verbose) return;

			if (Coloured) Console.ForegroundColor = ConsoleColor.Red;

			string prefixedMessage = "ERR : " + message;

			if (args.Length > 0)
			{
				Console.WriteLine(prefixedMessage, args);
			}
			else
			{
				Console.WriteLine(prefixedMessage);
			}
		}
    }
}
