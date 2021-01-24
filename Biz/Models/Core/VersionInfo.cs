using System;
using System.Threading;

namespace MicroBlessingsApi
{
    /// <summary>
    /// Standard implementation of the <see cref="IVersionInfo"/> interface.
    /// </summary>
    public class VersionInfo : IVersionInfo
    {
        /// <summary>
        /// Represents the default version number (1) for a <see cref="ModelId{T}"/>.
        /// </summary>
        public const int DefaultVersion = 1;

        /// <summary>
        /// Represents an un-versioned model reference.  In general all models should support versioning; however,
        /// when one model is referencing another model it often does not need to know the specific version.  In 
        /// those cases the <see cref="ModelId{T}"/> will have a <see cref="Number"/> equal to 0.
        /// </summary>
        public const int NonVersioned = 0;

        /// <summary>
        /// Default constructor.  
        /// Sets <see cref="Number"/> equal to <see cref="NonVersioned"/>.
        /// Sets <see cref="DateTime"/> equal to <see cref="DateTimeOffset.UtcNow"/>.
        /// Sets <see cref="By"/> equal to the current thread's identity.
        /// </summary>
        public VersionInfo()
            : this(NonVersioned, DateTimeOffset.UtcNow, Thread.CurrentPrincipal.Identity.Name)
        {
        }

        /// <summary>
        /// Number and datetime constructor.  Defaults <see cref="By"/> to the current thread's identity.
        /// </summary>
        /// <param name="number">The number of the version information.</param>
        /// <param name="dateTime">The date/time of the version.</param>
        public VersionInfo(int number, DateTimeOffset dateTime)
            : this(number, dateTime, Thread.CurrentPrincipal.Identity.Name)
        {
        }

        /// <summary>
        /// Full constructor.
        /// </summary>
        /// <param name="number">The number of the version information.</param>
        /// <param name="dateTime">The date/time of the version.</param>
        /// <param name="by">Who is responsible for the version.</param>
        public VersionInfo(int number, DateTimeOffset dateTime, string by)
        {
            Number = number;
            DateTime = dateTime;
            By = by;
        }

        public int Number { get; private set; }
        public DateTimeOffset DateTime { get; private set; }
        public string By { get; private set; }

        public override string ToString()
        {
            return string.Format("{0}^{1}^{2}", Number, DateTime, By);
        }
    }
}