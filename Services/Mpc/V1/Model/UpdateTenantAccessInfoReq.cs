using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateTenantAccessInfoReq 
    {

        /// <summary>
        /// 是否已开通服务 - false：未开通 - true：已开通 
        /// </summary>
        [JsonProperty("is_open", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// 服务协议版本 
        /// </summary>
        [JsonProperty("agreement_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? AgreementVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTenantAccessInfoReq {\n");
            sb.Append("  isOpen: ").Append(IsOpen).Append("\n");
            sb.Append("  agreementVersion: ").Append(AgreementVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTenantAccessInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTenantAccessInfoReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsOpen == input.IsOpen ||
                    (this.IsOpen != null &&
                    this.IsOpen.Equals(input.IsOpen))
                ) && 
                (
                    this.AgreementVersion == input.AgreementVersion ||
                    (this.AgreementVersion != null &&
                    this.AgreementVersion.Equals(input.AgreementVersion))
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
                if (this.IsOpen != null)
                    hashCode = hashCode * 59 + this.IsOpen.GetHashCode();
                if (this.AgreementVersion != null)
                    hashCode = hashCode * 59 + this.AgreementVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
