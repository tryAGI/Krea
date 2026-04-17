
#nullable enable

namespace Krea
{
    /// <summary>
    /// Lifecycle status of a generation job.
    /// </summary>
    public enum JobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Backlogged,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        IntermediateComplete,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Sampling,
        /// <summary>
        /// 
        /// </summary>
        Scheduled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JobStatus value)
        {
            return value switch
            {
                JobStatus.Backlogged => "backlogged",
                JobStatus.Cancelled => "cancelled",
                JobStatus.Completed => "completed",
                JobStatus.Failed => "failed",
                JobStatus.IntermediateComplete => "intermediate-complete",
                JobStatus.Processing => "processing",
                JobStatus.Queued => "queued",
                JobStatus.Sampling => "sampling",
                JobStatus.Scheduled => "scheduled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JobStatus? ToEnum(string value)
        {
            return value switch
            {
                "backlogged" => JobStatus.Backlogged,
                "cancelled" => JobStatus.Cancelled,
                "completed" => JobStatus.Completed,
                "failed" => JobStatus.Failed,
                "intermediate-complete" => JobStatus.IntermediateComplete,
                "processing" => JobStatus.Processing,
                "queued" => JobStatus.Queued,
                "sampling" => JobStatus.Sampling,
                "scheduled" => JobStatus.Scheduled,
                _ => null,
            };
        }
    }
}