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
    /// 访问日志基础设置。
    /// </summary>
    public class AccessLoggingBucketBaseline 
    {

        /// <summary>
        /// 桶保留天数。
        /// </summary>
        [JsonProperty("retention_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// 是否允许多AZ存储。
        /// </summary>
        [JsonProperty("enable_multi_az", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMultiAz { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessLoggingBucketBaseline {\n");
            sb.Append("  retentionDays: ").Append(RetentionDays).Append("\n");
            sb.Append("  enableMultiAz: ").Append(EnableMultiAz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessLoggingBucketBaseline);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessLoggingBucketBaseline input)
        {
            if (input == null) return false;
            if (this.RetentionDays != input.RetentionDays || (this.RetentionDays != null && !this.RetentionDays.Equals(input.RetentionDays))) return false;
            if (this.EnableMultiAz != input.EnableMultiAz || (this.EnableMultiAz != null && !this.EnableMultiAz.Equals(input.EnableMultiAz))) return false;

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
                if (this.RetentionDays != null) hashCode = hashCode * 59 + this.RetentionDays.GetHashCode();
                if (this.EnableMultiAz != null) hashCode = hashCode * 59 + this.EnableMultiAz.GetHashCode();
                return hashCode;
            }
        }
    }
}
