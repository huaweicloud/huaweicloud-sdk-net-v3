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
    /// 扩容磁盘请求
    /// </summary>
    public class ExpandVolumeReq 
    {

        /// <summary>
        /// 订单ID，包周期桌面扩容时使用。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 扩容后的磁盘大小，单位为GB。
        /// </summary>
        [JsonProperty("new_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpandVolumeReq {\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  newSize: ").Append(NewSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExpandVolumeReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExpandVolumeReq input)
        {
            if (input == null) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.NewSize != input.NewSize || (this.NewSize != null && !this.NewSize.Equals(input.NewSize))) return false;

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
                if (this.NewSize != null) hashCode = hashCode * 59 + this.NewSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
