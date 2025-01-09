using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListHistoryOnlineInfoResponse : SdkResponse
    {

        /// <summary>
        /// 返回前端历史登录信息。查询的时间和计数之间用冒号分隔。查询的时间，按Day查询或时间段在同一天时，按小时计数，其他场景为按天计数。
        /// </summary>
        [JsonProperty("time_counts", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TimeCounts { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHistoryOnlineInfoResponse {\n");
            sb.Append("  timeCounts: ").Append(TimeCounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHistoryOnlineInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHistoryOnlineInfoResponse input)
        {
            if (input == null) return false;
            if (this.TimeCounts != input.TimeCounts || (this.TimeCounts != null && input.TimeCounts != null && !this.TimeCounts.SequenceEqual(input.TimeCounts))) return false;

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
                if (this.TimeCounts != null) hashCode = hashCode * 59 + this.TimeCounts.GetHashCode();
                return hashCode;
            }
        }
    }
}
