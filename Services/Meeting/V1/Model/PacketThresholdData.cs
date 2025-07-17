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
    /// 丢包率阈值查询结果结构体
    /// </summary>
    public class PacketThresholdData 
    {

        /// <summary>
        /// 自定义接收方向阈值，单位为百分比(%)
        /// </summary>
        [JsonProperty("receiving", NullValueHandling = NullValueHandling.Ignore)]
        public int? Receiving { get; set; }

        /// <summary>
        /// 默认接收方向阈值，单位为百分比(%)
        /// </summary>
        [JsonProperty("receivingDefault", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReceivingDefault { get; set; }

        /// <summary>
        /// 自定义发送方向阈值，单位为百分比(%)
        /// </summary>
        [JsonProperty("sending", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sending { get; set; }

        /// <summary>
        /// 默认发送方向阈值，单位为百分比(%)
        /// </summary>
        [JsonProperty("sendingDefault", NullValueHandling = NullValueHandling.Ignore)]
        public int? SendingDefault { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PacketThresholdData {\n");
            sb.Append("  receiving: ").Append(Receiving).Append("\n");
            sb.Append("  receivingDefault: ").Append(ReceivingDefault).Append("\n");
            sb.Append("  sending: ").Append(Sending).Append("\n");
            sb.Append("  sendingDefault: ").Append(SendingDefault).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PacketThresholdData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PacketThresholdData input)
        {
            if (input == null) return false;
            if (this.Receiving != input.Receiving || (this.Receiving != null && !this.Receiving.Equals(input.Receiving))) return false;
            if (this.ReceivingDefault != input.ReceivingDefault || (this.ReceivingDefault != null && !this.ReceivingDefault.Equals(input.ReceivingDefault))) return false;
            if (this.Sending != input.Sending || (this.Sending != null && !this.Sending.Equals(input.Sending))) return false;
            if (this.SendingDefault != input.SendingDefault || (this.SendingDefault != null && !this.SendingDefault.Equals(input.SendingDefault))) return false;

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
                if (this.Receiving != null) hashCode = hashCode * 59 + this.Receiving.GetHashCode();
                if (this.ReceivingDefault != null) hashCode = hashCode * 59 + this.ReceivingDefault.GetHashCode();
                if (this.Sending != null) hashCode = hashCode * 59 + this.Sending.GetHashCode();
                if (this.SendingDefault != null) hashCode = hashCode * 59 + this.SendingDefault.GetHashCode();
                return hashCode;
            }
        }
    }
}
