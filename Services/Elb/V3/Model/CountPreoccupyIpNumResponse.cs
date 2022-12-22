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
    public class CountPreoccupyIpNumResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("preoccupy_ip", NullValueHandling = NullValueHandling.Ignore)]
        public PreoccupyIp PreoccupyIp { get; set; }

        /// <summary>
        /// 请求ID。  注：自动生成 。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountPreoccupyIpNumResponse {\n");
            sb.Append("  preoccupyIp: ").Append(PreoccupyIp).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CountPreoccupyIpNumResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CountPreoccupyIpNumResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PreoccupyIp == input.PreoccupyIp ||
                    (this.PreoccupyIp != null &&
                    this.PreoccupyIp.Equals(input.PreoccupyIp))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PreoccupyIp != null)
                    hashCode = hashCode * 59 + this.PreoccupyIp.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
