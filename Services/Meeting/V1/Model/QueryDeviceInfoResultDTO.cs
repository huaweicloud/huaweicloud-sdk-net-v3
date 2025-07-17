using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 终端设备型号信息。
    /// </summary>
    public class QueryDeviceInfoResultDTO 
    {

        /// <summary>
        /// 终端型号。
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// 设备终端产品尺寸。
        /// </summary>
        [JsonProperty("deviceSize", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceSize { get; set; }

        /// <summary>
        /// 终端设备购买渠道。
        /// </summary>
        [JsonProperty("purchaseChannel", NullValueHandling = NullValueHandling.Ignore)]
        public string PurchaseChannel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryDeviceInfoResultDTO {\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("  deviceSize: ").Append(DeviceSize).Append("\n");
            sb.Append("  purchaseChannel: ").Append(PurchaseChannel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryDeviceInfoResultDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryDeviceInfoResultDTO input)
        {
            if (input == null) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;
            if (this.DeviceSize != input.DeviceSize || (this.DeviceSize != null && !this.DeviceSize.Equals(input.DeviceSize))) return false;
            if (this.PurchaseChannel != input.PurchaseChannel || (this.PurchaseChannel != null && !this.PurchaseChannel.Equals(input.PurchaseChannel))) return false;

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
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.DeviceSize != null) hashCode = hashCode * 59 + this.DeviceSize.GetHashCode();
                if (this.PurchaseChannel != null) hashCode = hashCode * 59 + this.PurchaseChannel.GetHashCode();
                return hashCode;
            }
        }
    }
}
