using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAgencyOption 
    {

        /// <summary>
        /// 被委托方账号ID。如果trust_domain_id和trust_domain_name都填写，则优先校验trust_domain_name。四个参数至少填写一个。
        /// </summary>
        [JsonProperty("trust_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustDomainId { get; set; }

        /// <summary>
        /// 被委托方账号名。如果trust_domain_id和trust_domain_name都填写，则优先校验trust_domain_name。四个参数至少填写一个。
        /// </summary>
        [JsonProperty("trust_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TrustDomainName { get; set; }

        /// <summary>
        /// 委托描述信息，长度不大于255位。四个参数至少填写一个。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 委托的期限，单位为“天”。默认为FOREVER。取值为“FOREVER\&quot;表示委托的期限为永久，取值为\&quot;ONEDAY\&quot;表示委托的期限为一天,取值为自定义天数表示委托的期限为有限天数，如20。四个参数至少填写一个。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAgencyOption {\n");
            sb.Append("  trustDomainId: ").Append(TrustDomainId).Append("\n");
            sb.Append("  trustDomainName: ").Append(TrustDomainName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAgencyOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAgencyOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrustDomainId == input.TrustDomainId ||
                    (this.TrustDomainId != null &&
                    this.TrustDomainId.Equals(input.TrustDomainId))
                ) && 
                (
                    this.TrustDomainName == input.TrustDomainName ||
                    (this.TrustDomainName != null &&
                    this.TrustDomainName.Equals(input.TrustDomainName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.TrustDomainId != null)
                    hashCode = hashCode * 59 + this.TrustDomainId.GetHashCode();
                if (this.TrustDomainName != null)
                    hashCode = hashCode * 59 + this.TrustDomainName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
