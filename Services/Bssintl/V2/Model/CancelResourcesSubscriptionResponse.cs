using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CancelResourcesSubscriptionResponse : SdkResponse
    {

        /// <summary>
        /// 客户退订订单ID的列表信息。
        /// </summary>
        [JsonProperty("order_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> OrderIds { get; set; }

        /// <summary>
        /// |参数名称：失败的资源信息列表| |参数的约束及描述：套餐包使用量信息|
        /// </summary>
        [JsonProperty("fail_resource_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<FailResourceInfo> FailResourceInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelResourcesSubscriptionResponse {\n");
            sb.Append("  orderIds: ").Append(OrderIds).Append("\n");
            sb.Append("  failResourceInfos: ").Append(FailResourceInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CancelResourcesSubscriptionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CancelResourcesSubscriptionResponse input)
        {
            if (input == null) return false;
            if (this.OrderIds != input.OrderIds || (this.OrderIds != null && input.OrderIds != null && !this.OrderIds.SequenceEqual(input.OrderIds))) return false;
            if (this.FailResourceInfos != input.FailResourceInfos || (this.FailResourceInfos != null && input.FailResourceInfos != null && !this.FailResourceInfos.SequenceEqual(input.FailResourceInfos))) return false;

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
                if (this.OrderIds != null) hashCode = hashCode * 59 + this.OrderIds.GetHashCode();
                if (this.FailResourceInfos != null) hashCode = hashCode * 59 + this.FailResourceInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
