using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// Landing Zone日志配置。
    /// </summary>
    public class LoggingConfiguration 
    {

        /// <summary>
        /// 日志桶名称。
        /// </summary>
        [JsonProperty("logging_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LoggingBucketName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("access_logging_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public AccessLoggingBucketBaseline AccessLoggingBucket { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logging_bucket", NullValueHandling = NullValueHandling.Ignore)]
        public LoggingBucketBaseline LoggingBucket { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoggingConfiguration {\n");
            sb.Append("  loggingBucketName: ").Append(LoggingBucketName).Append("\n");
            sb.Append("  accessLoggingBucket: ").Append(AccessLoggingBucket).Append("\n");
            sb.Append("  loggingBucket: ").Append(LoggingBucket).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoggingConfiguration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoggingConfiguration input)
        {
            if (input == null) return false;
            if (this.LoggingBucketName != input.LoggingBucketName || (this.LoggingBucketName != null && !this.LoggingBucketName.Equals(input.LoggingBucketName))) return false;
            if (this.AccessLoggingBucket != input.AccessLoggingBucket || (this.AccessLoggingBucket != null && !this.AccessLoggingBucket.Equals(input.AccessLoggingBucket))) return false;
            if (this.LoggingBucket != input.LoggingBucket || (this.LoggingBucket != null && !this.LoggingBucket.Equals(input.LoggingBucket))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.LoggingBucketName != null) hashCode = hashCode * 59 + this.LoggingBucketName.GetHashCode();
                if (this.AccessLoggingBucket != null) hashCode = hashCode * 59 + this.AccessLoggingBucket.GetHashCode();
                if (this.LoggingBucket != null) hashCode = hashCode * 59 + this.LoggingBucket.GetHashCode();
                return hashCode;
            }
        }
    }
}
