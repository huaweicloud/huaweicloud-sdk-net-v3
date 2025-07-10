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
    /// 
    /// </summary>
    public class OrderV5 
    {

        /// <summary>
        /// 订单id。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态:0:初始化; 1:待审核; 2:待退款; 3:处理中; 4:已取消; 5:已完成; 6:待支付; 7:补偿中; 8:待审批; 9:待确认; 10:待发货; 11:待收货; 12:待上门取货; 13:换新中; 14:待商家收货。
        /// </summary>
        [JsonProperty("order_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderStatus { get; set; }

        /// <summary>
        /// 结果，SUCCESS:成功； FAIL：失败。
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// result&#x3D;FAIL时，必填，表示该订单失败原因。
        /// </summary>
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 失败信息，和result_code结对出现。
        /// </summary>
        [JsonProperty("result_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderV5 {\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  orderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  resultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  resultMsg: ").Append(ResultMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrderV5 input)
        {
            if (input == null) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.OrderStatus != input.OrderStatus || (this.OrderStatus != null && !this.OrderStatus.Equals(input.OrderStatus))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.ResultCode != input.ResultCode || (this.ResultCode != null && !this.ResultCode.Equals(input.ResultCode))) return false;
            if (this.ResultMsg != input.ResultMsg || (this.ResultMsg != null && !this.ResultMsg.Equals(input.ResultMsg))) return false;

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
                if (this.OrderStatus != null) hashCode = hashCode * 59 + this.OrderStatus.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.ResultCode != null) hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.ResultMsg != null) hashCode = hashCode * 59 + this.ResultMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
