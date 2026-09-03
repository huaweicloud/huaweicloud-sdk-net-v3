using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练指标响应体
    /// </summary>
    public class FtMetricData 
    {

        /// <summary>
        /// 固定值 \&quot;1.0\&quot;，标识数据格式版本
        /// </summary>
        [JsonProperty("format_version", NullValueHandling = NullValueHandling.Ignore)]
        public string FormatVersion { get; set; }

        /// <summary>
        /// 文件生成时间，ISO 8601 格式（如 2026-07-18T10:30:00Z）
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<FtMetric> Metrics { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FtMetricData {\n");
            sb.Append("  formatVersion: ").Append(FormatVersion).Append("\n");
            sb.Append("  timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  metrics: ").Append(Metrics).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FtMetricData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FtMetricData input)
        {
            if (input == null) return false;
            if (this.FormatVersion != input.FormatVersion || (this.FormatVersion != null && !this.FormatVersion.Equals(input.FormatVersion))) return false;
            if (this.Timestamp != input.Timestamp || (this.Timestamp != null && !this.Timestamp.Equals(input.Timestamp))) return false;
            if (this.Metrics != input.Metrics || (this.Metrics != null && input.Metrics != null && !this.Metrics.SequenceEqual(input.Metrics))) return false;

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
                if (this.FormatVersion != null) hashCode = hashCode * 59 + this.FormatVersion.GetHashCode();
                if (this.Timestamp != null) hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Metrics != null) hashCode = hashCode * 59 + this.Metrics.GetHashCode();
                return hashCode;
            }
        }
    }
}
