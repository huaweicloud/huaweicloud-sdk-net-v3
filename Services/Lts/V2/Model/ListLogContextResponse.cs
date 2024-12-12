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
    /// Response Object
    /// </summary>
    public class ListLogContextResponse : SdkResponse
    {

        /// <summary>
        /// 上下文日志信息。
        /// </summary>
        [JsonProperty("logs", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogContents> Logs { get; set; }

        /// <summary>
        /// 返回的总日志条数，包含请求参数中所指定的起始日志。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 向前查询到的日志条数。
        /// </summary>
        [JsonProperty("backwards_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BackwardsCount { get; set; }

        /// <summary>
        /// 向后查询到的日志条数。
        /// </summary>
        [JsonProperty("forwards_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ForwardsCount { get; set; }

        /// <summary>
        /// 是否查询完成。
        /// </summary>
        [JsonProperty("isQueryComplete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsQueryComplete { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListLogContextResponse {\n");
            sb.Append("  logs: ").Append(Logs).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  backwardsCount: ").Append(BackwardsCount).Append("\n");
            sb.Append("  forwardsCount: ").Append(ForwardsCount).Append("\n");
            sb.Append("  isQueryComplete: ").Append(IsQueryComplete).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListLogContextResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListLogContextResponse input)
        {
            if (input == null) return false;
            if (this.Logs != input.Logs || (this.Logs != null && input.Logs != null && !this.Logs.SequenceEqual(input.Logs))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.BackwardsCount != input.BackwardsCount || (this.BackwardsCount != null && !this.BackwardsCount.Equals(input.BackwardsCount))) return false;
            if (this.ForwardsCount != input.ForwardsCount || (this.ForwardsCount != null && !this.ForwardsCount.Equals(input.ForwardsCount))) return false;
            if (this.IsQueryComplete != input.IsQueryComplete || (this.IsQueryComplete != null && !this.IsQueryComplete.Equals(input.IsQueryComplete))) return false;

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
                if (this.Logs != null) hashCode = hashCode * 59 + this.Logs.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.BackwardsCount != null) hashCode = hashCode * 59 + this.BackwardsCount.GetHashCode();
                if (this.ForwardsCount != null) hashCode = hashCode * 59 + this.ForwardsCount.GetHashCode();
                if (this.IsQueryComplete != null) hashCode = hashCode * 59 + this.IsQueryComplete.GetHashCode();
                return hashCode;
            }
        }
    }
}
