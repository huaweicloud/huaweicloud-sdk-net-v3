using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class LogMappingStreamInfo 
    {

        /// <summary>
        /// 源日志流ID
        /// </summary>
        [JsonProperty("source_log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceLogStreamId { get; set; }

        /// <summary>
        /// 目标日志流ID
        /// </summary>
        [JsonProperty("target_log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogStreamId { get; set; }

        /// <summary>
        /// 目标日志流名称
        /// </summary>
        [JsonProperty("target_log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogStreamName { get; set; }

        /// <summary>
        /// 目标日志流EPS ID
        /// </summary>
        [JsonProperty("target_log_stream_eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetLogStreamEpsId { get; set; }

        /// <summary>
        /// 目标日志流ttl
        /// </summary>
        [JsonProperty("target_log_stream_ttl", NullValueHandling = NullValueHandling.Ignore)]
        public int? TargetLogStreamTtl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogMappingStreamInfo {\n");
            sb.Append("  sourceLogStreamId: ").Append(SourceLogStreamId).Append("\n");
            sb.Append("  targetLogStreamId: ").Append(TargetLogStreamId).Append("\n");
            sb.Append("  targetLogStreamName: ").Append(TargetLogStreamName).Append("\n");
            sb.Append("  targetLogStreamEpsId: ").Append(TargetLogStreamEpsId).Append("\n");
            sb.Append("  targetLogStreamTtl: ").Append(TargetLogStreamTtl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogMappingStreamInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogMappingStreamInfo input)
        {
            if (input == null) return false;
            if (this.SourceLogStreamId != input.SourceLogStreamId || (this.SourceLogStreamId != null && !this.SourceLogStreamId.Equals(input.SourceLogStreamId))) return false;
            if (this.TargetLogStreamId != input.TargetLogStreamId || (this.TargetLogStreamId != null && !this.TargetLogStreamId.Equals(input.TargetLogStreamId))) return false;
            if (this.TargetLogStreamName != input.TargetLogStreamName || (this.TargetLogStreamName != null && !this.TargetLogStreamName.Equals(input.TargetLogStreamName))) return false;
            if (this.TargetLogStreamEpsId != input.TargetLogStreamEpsId || (this.TargetLogStreamEpsId != null && !this.TargetLogStreamEpsId.Equals(input.TargetLogStreamEpsId))) return false;
            if (this.TargetLogStreamTtl != input.TargetLogStreamTtl || (this.TargetLogStreamTtl != null && !this.TargetLogStreamTtl.Equals(input.TargetLogStreamTtl))) return false;

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
                if (this.SourceLogStreamId != null) hashCode = hashCode * 59 + this.SourceLogStreamId.GetHashCode();
                if (this.TargetLogStreamId != null) hashCode = hashCode * 59 + this.TargetLogStreamId.GetHashCode();
                if (this.TargetLogStreamName != null) hashCode = hashCode * 59 + this.TargetLogStreamName.GetHashCode();
                if (this.TargetLogStreamEpsId != null) hashCode = hashCode * 59 + this.TargetLogStreamEpsId.GetHashCode();
                if (this.TargetLogStreamTtl != null) hashCode = hashCode * 59 + this.TargetLogStreamTtl.GetHashCode();
                return hashCode;
            }
        }
    }
}
