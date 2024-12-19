using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdatePublicIpRequestBody 
    {

        /// <summary>
        /// 公网访问绑定的ELB的EIP的ID，当Redis版本为3.0时，该参数为必填参数。
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 是否开启SSL，仅在开启SSL时有值，当Redis版本为3.0时，该参数为必填参数。
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// 公网访问绑定的ELB ID，当Redis版本为4.0，5.0，6.0和企业版时，该参数为必填参数。
        /// </summary>
        [JsonProperty("elb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePublicIpRequestBody {\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  elbId: ").Append(ElbId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePublicIpRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePublicIpRequestBody input)
        {
            if (input == null) return false;
            if (this.PublicipId != input.PublicipId || (this.PublicipId != null && !this.PublicipId.Equals(input.PublicipId))) return false;
            if (this.EnableSsl != input.EnableSsl || (this.EnableSsl != null && !this.EnableSsl.Equals(input.EnableSsl))) return false;
            if (this.ElbId != input.ElbId || (this.ElbId != null && !this.ElbId.Equals(input.ElbId))) return false;

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
                if (this.PublicipId != null) hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.EnableSsl != null) hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.ElbId != null) hashCode = hashCode * 59 + this.ElbId.GetHashCode();
                return hashCode;
            }
        }
    }
}
