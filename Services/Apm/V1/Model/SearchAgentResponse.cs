using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SearchAgentResponse : SdkResponse
    {

        /// <summary>
        /// 总页数。
        /// </summary>
        [JsonProperty("total_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalPage { get; set; }

        /// <summary>
        /// 总个数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 正常个数。
        /// </summary>
        [JsonProperty("online_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlineCount { get; set; }

        /// <summary>
        /// 心跳异常个数。
        /// </summary>
        [JsonProperty("offline_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OfflineCount { get; set; }

        /// <summary>
        /// 被关闭的个数。
        /// </summary>
        [JsonProperty("disable_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisableCount { get; set; }

        /// <summary>
        /// agent地址列表。
        /// </summary>
        [JsonProperty("agent_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<InstanceInfo> AgentInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchAgentResponse {\n");
            sb.Append("  totalPage: ").Append(TotalPage).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  onlineCount: ").Append(OnlineCount).Append("\n");
            sb.Append("  offlineCount: ").Append(OfflineCount).Append("\n");
            sb.Append("  disableCount: ").Append(DisableCount).Append("\n");
            sb.Append("  agentInfoList: ").Append(AgentInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchAgentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchAgentResponse input)
        {
            if (input == null) return false;
            if (this.TotalPage != input.TotalPage || (this.TotalPage != null && !this.TotalPage.Equals(input.TotalPage))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.OnlineCount != input.OnlineCount || (this.OnlineCount != null && !this.OnlineCount.Equals(input.OnlineCount))) return false;
            if (this.OfflineCount != input.OfflineCount || (this.OfflineCount != null && !this.OfflineCount.Equals(input.OfflineCount))) return false;
            if (this.DisableCount != input.DisableCount || (this.DisableCount != null && !this.DisableCount.Equals(input.DisableCount))) return false;
            if (this.AgentInfoList != input.AgentInfoList || (this.AgentInfoList != null && input.AgentInfoList != null && !this.AgentInfoList.SequenceEqual(input.AgentInfoList))) return false;

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
                if (this.TotalPage != null) hashCode = hashCode * 59 + this.TotalPage.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.OnlineCount != null) hashCode = hashCode * 59 + this.OnlineCount.GetHashCode();
                if (this.OfflineCount != null) hashCode = hashCode * 59 + this.OfflineCount.GetHashCode();
                if (this.DisableCount != null) hashCode = hashCode * 59 + this.DisableCount.GetHashCode();
                if (this.AgentInfoList != null) hashCode = hashCode * 59 + this.AgentInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
