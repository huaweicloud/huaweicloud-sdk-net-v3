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
    /// Response Object
    /// </summary>
    public class ChangeOrderResponse : SdkResponse
    {

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("orderId", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 变更状态码
        /// </summary>
        [JsonProperty("retCode", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? RetCode { get; set; }

        /// <summary>
        /// 变更信息
        /// </summary>
        [JsonProperty("retMsg", NullValueHandling = NullValueHandling.Ignore)]
        public string RetMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeOrderResponse {\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  retCode: ").Append(RetCode).Append("\n");
            sb.Append("  retMsg: ").Append(RetMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChangeOrderResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChangeOrderResponse input)
        {
            if (input == null) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.RetCode != input.RetCode || (this.RetCode != null && !this.RetCode.Equals(input.RetCode))) return false;
            if (this.RetMsg != input.RetMsg || (this.RetMsg != null && !this.RetMsg.Equals(input.RetMsg))) return false;

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
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.RetCode != null) hashCode = hashCode * 59 + this.RetCode.GetHashCode();
                if (this.RetMsg != null) hashCode = hashCode * 59 + this.RetMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
