using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProtocolResVo 
    {

        /// <summary>
        /// 期望响应的状态码
        /// </summary>
        [JsonProperty("response_code", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> ResponseCode { get; set; }

        /// <summary>
        /// 期望响应时间
        /// </summary>
        [JsonProperty("response_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ResponseTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtocolResVo {\n");
            sb.Append("  responseCode: ").Append(ResponseCode).Append("\n");
            sb.Append("  responseTime: ").Append(ResponseTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtocolResVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtocolResVo input)
        {
            if (input == null) return false;
            if (this.ResponseCode != input.ResponseCode || (this.ResponseCode != null && input.ResponseCode != null && !this.ResponseCode.SequenceEqual(input.ResponseCode))) return false;
            if (this.ResponseTime != input.ResponseTime || (this.ResponseTime != null && !this.ResponseTime.Equals(input.ResponseTime))) return false;

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
                if (this.ResponseCode != null) hashCode = hashCode * 59 + this.ResponseCode.GetHashCode();
                if (this.ResponseTime != null) hashCode = hashCode * 59 + this.ResponseTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
