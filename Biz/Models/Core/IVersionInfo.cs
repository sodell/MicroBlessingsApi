using System;

namespace MicroBlessingsApi
{
    /// <summary>
    /// The <c>IVersionInfo</c> interface is used to define the standard versioning scheme
    /// for <see cref="IVersionable"/>.
    /// </summary>
    public interface IVersionInfo
    {
        /// <summary>
        /// Returns the number of times this record has been updated.
        /// </summary>
        int Number { get; }

        /// <summary>
        /// Returns the date and time that this record was last updated.  The UTC offset 
        /// represents the storage layer's local time.
        /// </summary>
        DateTimeOffset DateTime { get; }

        /// <summary>
        /// Returns a string identifier for the account that last updated the record.
        /// </summary>
        string By { get; }
    }
}