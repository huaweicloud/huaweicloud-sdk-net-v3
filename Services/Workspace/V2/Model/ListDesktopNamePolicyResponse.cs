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
    public class ListDesktopNamePolicyResponse : SdkResponse
    {

        /// <summary>
        /// 桌面名称策略信息。
        /// </summary>
        [JsonProperty("desktop_name_policy_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopNamePolicyInfo> DesktopNamePolicyInfos { get; set; }

        /// <summary>
        /// 查询返回总条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopNamePolicyResponse {\n");
            sb.Append("  desktopNamePolicyInfos: ").Append(DesktopNamePolicyInfos).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopNamePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopNamePolicyResponse input)
        {
            if (input == null) return false;
            if (this.DesktopNamePolicyInfos != input.DesktopNamePolicyInfos || (this.DesktopNamePolicyInfos != null && input.DesktopNamePolicyInfos != null && !this.DesktopNamePolicyInfos.SequenceEqual(input.DesktopNamePolicyInfos))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.DesktopNamePolicyInfos != null) hashCode = hashCode * 59 + this.DesktopNamePolicyInfos.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
