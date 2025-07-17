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
    /// 阈值阈值设置请求体。
    /// </summary>
    public class SetThresholdData 
    {

        /// <summary>
        /// 接收方向阈值设定值，单位为毫秒(ms)。 取值范围：0 - 10000。
        /// </summary>
        [JsonProperty("receiving", NullValueHandling = NullValueHandling.Ignore)]
        public int? Receiving { get; set; }

        /// <summary>
        /// 发送方向阈值设定值，单位为毫秒(ms)。 取值范围：0 - 10000。
        /// </summary>
        [JsonProperty("sending", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sending { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetThresholdData {\n");
            sb.Append("  receiving: ").Append(Receiving).Append("\n");
            sb.Append("  sending: ").Append(Sending).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetThresholdData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetThresholdData input)
        {
            if (input == null) return false;
            if (this.Receiving != input.Receiving || (this.Receiving != null && !this.Receiving.Equals(input.Receiving))) return false;
            if (this.Sending != input.Sending || (this.Sending != null && !this.Sending.Equals(input.Sending))) return false;

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
                if (this.Sending != null) hashCode = hashCode * 59 + this.Sending.GetHashCode();
                return hashCode;
            }
        }
    }
}
