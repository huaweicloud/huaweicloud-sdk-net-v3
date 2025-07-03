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
    public class SearchApplicationResponse : SdkResponse
    {

        /// <summary>
        /// 组件列表。
        /// </summary>
        [JsonProperty("app_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AppInfo> AppInfoList { get; set; }

        /// <summary>
        /// 组件总数目。
        /// </summary>
        [JsonProperty("app_total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AppTotalCount { get; set; }

        /// <summary>
        /// 组件名称和组件详情map表。
        /// </summary>
        [JsonProperty("app_info_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, AppInfo> AppInfoMap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchApplicationResponse {\n");
            sb.Append("  appInfoList: ").Append(AppInfoList).Append("\n");
            sb.Append("  appTotalCount: ").Append(AppTotalCount).Append("\n");
            sb.Append("  appInfoMap: ").Append(AppInfoMap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchApplicationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchApplicationResponse input)
        {
            if (input == null) return false;
            if (this.AppInfoList != input.AppInfoList || (this.AppInfoList != null && input.AppInfoList != null && !this.AppInfoList.SequenceEqual(input.AppInfoList))) return false;
            if (this.AppTotalCount != input.AppTotalCount || (this.AppTotalCount != null && !this.AppTotalCount.Equals(input.AppTotalCount))) return false;
            if (this.AppInfoMap != input.AppInfoMap || (this.AppInfoMap != null && input.AppInfoMap != null && !this.AppInfoMap.SequenceEqual(input.AppInfoMap))) return false;

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
                if (this.AppInfoList != null) hashCode = hashCode * 59 + this.AppInfoList.GetHashCode();
                if (this.AppTotalCount != null) hashCode = hashCode * 59 + this.AppTotalCount.GetHashCode();
                if (this.AppInfoMap != null) hashCode = hashCode * 59 + this.AppInfoMap.GetHashCode();
                return hashCode;
            }
        }
    }
}
