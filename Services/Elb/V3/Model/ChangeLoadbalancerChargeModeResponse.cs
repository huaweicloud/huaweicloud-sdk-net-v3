using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ChangeLoadbalancerChargeModeResponse : SdkResponse
    {

        /// <summary>
        /// 转包周期下单成功的EIP ID列表
        /// </summary>
        [JsonProperty("eip_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EipIdList { get; set; }

        /// <summary>
        /// 转包周期下单成功的LB ID列表
        /// </summary>
        [JsonProperty("loadbalancer_id_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> LoadbalancerIdList { get; set; }

        /// <summary>
        /// 转包周期订单号
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 请求的UUIID
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeLoadbalancerChargeModeResponse {\n");
            sb.Append("  eipIdList: ").Append(EipIdList).Append("\n");
            sb.Append("  loadbalancerIdList: ").Append(LoadbalancerIdList).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeLoadbalancerChargeModeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeLoadbalancerChargeModeResponse input)
        {
            if (input == null) return false;
            if (this.EipIdList != input.EipIdList || (this.EipIdList != null && input.EipIdList != null && !this.EipIdList.SequenceEqual(input.EipIdList))) return false;
            if (this.LoadbalancerIdList != input.LoadbalancerIdList || (this.LoadbalancerIdList != null && input.LoadbalancerIdList != null && !this.LoadbalancerIdList.SequenceEqual(input.LoadbalancerIdList))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;

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
                if (this.EipIdList != null) hashCode = hashCode * 59 + this.EipIdList.GetHashCode();
                if (this.LoadbalancerIdList != null) hashCode = hashCode * 59 + this.LoadbalancerIdList.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
