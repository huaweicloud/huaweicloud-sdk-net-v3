using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CbcOrderResult 
    {

        /// <summary>
        /// 云服务ID
        /// </summary>
        [JsonProperty("cloudServiceId", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudServiceId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("orderId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 订购结果，1：成功；0：失败
        /// </summary>
        [JsonProperty("subscribeResult", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscribeResult { get; set; }

        /// <summary>
        /// 包周期资源预生成资源id。
        /// </summary>
        [JsonProperty("resourceId", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CbcOrderResult {\n");
            sb.Append("  cloudServiceId: ").Append(CloudServiceId).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  subscribeResult: ").Append(SubscribeResult).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CbcOrderResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CbcOrderResult input)
        {
            if (input == null) return false;
            if (this.CloudServiceId != input.CloudServiceId || (this.CloudServiceId != null && !this.CloudServiceId.Equals(input.CloudServiceId))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.SubscribeResult != input.SubscribeResult || (this.SubscribeResult != null && !this.SubscribeResult.Equals(input.SubscribeResult))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;

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
                if (this.CloudServiceId != null) hashCode = hashCode * 59 + this.CloudServiceId.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.SubscribeResult != null) hashCode = hashCode * 59 + this.SubscribeResult.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
