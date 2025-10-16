using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowStatusAppResponse : SdkResponse
    {

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 应用列表
        /// </summary>
        [JsonProperty("app_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowStatusAppItem> AppList { get; set; }

        /// <summary>
        /// 总访问次数
        /// </summary>
        [JsonProperty("total_access_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalAccessCount { get; set; }

        /// <summary>
        /// 成功访问次数
        /// </summary>
        [JsonProperty("success_access_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? SuccessAccessCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStatusAppResponse {\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  appList: ").Append(AppList).Append("\n");
            sb.Append("  totalAccessCount: ").Append(TotalAccessCount).Append("\n");
            sb.Append("  successAccessCount: ").Append(SuccessAccessCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStatusAppResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStatusAppResponse input)
        {
            if (input == null) return false;
            if (this.MetricName != input.MetricName || (this.MetricName != null && !this.MetricName.Equals(input.MetricName))) return false;
            if (this.AppList != input.AppList || (this.AppList != null && input.AppList != null && !this.AppList.SequenceEqual(input.AppList))) return false;
            if (this.TotalAccessCount != input.TotalAccessCount || (this.TotalAccessCount != null && !this.TotalAccessCount.Equals(input.TotalAccessCount))) return false;
            if (this.SuccessAccessCount != input.SuccessAccessCount || (this.SuccessAccessCount != null && !this.SuccessAccessCount.Equals(input.SuccessAccessCount))) return false;

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
                if (this.MetricName != null) hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.AppList != null) hashCode = hashCode * 59 + this.AppList.GetHashCode();
                if (this.TotalAccessCount != null) hashCode = hashCode * 59 + this.TotalAccessCount.GetHashCode();
                if (this.SuccessAccessCount != null) hashCode = hashCode * 59 + this.SuccessAccessCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
