using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// **参数解释**： 私网网段信息列表 **取值范围**： 不涉及
    /// </summary>
    public class ListPrivateNetworkSegmentsVO 
    {

        /// <summary>
        /// **参数解释**： 私网网段列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("private_network_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PrivateNetworkSegmentVO> PrivateNetworkList { get; set; }

        /// <summary>
        /// **参数解释**： 总条数 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**： 私网网段配额 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quota { get; set; }

        /// <summary>
        /// **参数解释**： 支持的可用区列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("support_az_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportAzList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPrivateNetworkSegmentsVO {\n");
            sb.Append("  privateNetworkList: ").Append(PrivateNetworkList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  quota: ").Append(Quota).Append("\n");
            sb.Append("  supportAzList: ").Append(SupportAzList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPrivateNetworkSegmentsVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPrivateNetworkSegmentsVO input)
        {
            if (input == null) return false;
            if (this.PrivateNetworkList != input.PrivateNetworkList || (this.PrivateNetworkList != null && input.PrivateNetworkList != null && !this.PrivateNetworkList.SequenceEqual(input.PrivateNetworkList))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Quota != input.Quota || (this.Quota != null && !this.Quota.Equals(input.Quota))) return false;
            if (this.SupportAzList != input.SupportAzList || (this.SupportAzList != null && input.SupportAzList != null && !this.SupportAzList.SequenceEqual(input.SupportAzList))) return false;

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
                if (this.PrivateNetworkList != null) hashCode = hashCode * 59 + this.PrivateNetworkList.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Quota != null) hashCode = hashCode * 59 + this.Quota.GetHashCode();
                if (this.SupportAzList != null) hashCode = hashCode * 59 + this.SupportAzList.GetHashCode();
                return hashCode;
            }
        }
    }
}
