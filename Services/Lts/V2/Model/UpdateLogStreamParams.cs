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
    public class UpdateLogStreamParams 
    {

        /// <summary>
        /// 日志存储时间（天）。
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TtlInDays { get; set; }

        /// <summary>
        /// 标签字段信息
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsBody> Tags { get; set; }

        /// <summary>
        /// 日志是否存储
        /// </summary>
        [JsonProperty("whether_log_storage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhetherLogStorage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLogStreamParams {\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  whetherLogStorage: ").Append(WhetherLogStorage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLogStreamParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLogStreamParams input)
        {
            if (input == null) return false;
            if (this.TtlInDays != input.TtlInDays || (this.TtlInDays != null && !this.TtlInDays.Equals(input.TtlInDays))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.WhetherLogStorage != input.WhetherLogStorage || (this.WhetherLogStorage != null && !this.WhetherLogStorage.Equals(input.WhetherLogStorage))) return false;

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
                if (this.TtlInDays != null) hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.WhetherLogStorage != null) hashCode = hashCode * 59 + this.WhetherLogStorage.GetHashCode();
                return hashCode;
            }
        }
    }
}
