using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AttachBatchPublicIpResponse : SdkResponse
    {

        /// <summary>
        /// 弹性公网IP对象
        /// </summary>
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchPublicipResp> Publicips { get; set; }

        /// <summary>
        /// 本次请求编号
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachBatchPublicIpResponse {\n");
            sb.Append("  publicips: ").Append(Publicips).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachBatchPublicIpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachBatchPublicIpResponse input)
        {
            if (input == null) return false;
            if (this.Publicips != input.Publicips || (this.Publicips != null && input.Publicips != null && !this.Publicips.SequenceEqual(input.Publicips))) return false;
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
                if (this.Publicips != null) hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
