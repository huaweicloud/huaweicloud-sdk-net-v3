using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class AssumeAgencyForPodIdentityResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("assumedAgency", NullValueHandling = NullValueHandling.Ignore)]
        public AssumedAgency AssumedAgency { get; set; }

        /// <summary>
        /// **参数解释：** 凭据签发时传入的audience属性，通过pod-identity关联获取委托凭据的场景下，该值固定为 service.cce.pods。 该属性只在pod-identity关联绑定信任委托时返回 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("audience", NullValueHandling = NullValueHandling.Ignore)]
        public string Audience { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("credentials", NullValueHandling = NullValueHandling.Ignore)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// **参数解释：** 委托凭据所属的pod-identity关联id。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("podIdentityAssociationId", NullValueHandling = NullValueHandling.Ignore)]
        public string PodIdentityAssociationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subject", NullValueHandling = NullValueHandling.Ignore)]
        public PodIdentitySubject Subject { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssumeAgencyForPodIdentityResponse {\n");
            sb.Append("  assumedAgency: ").Append(AssumedAgency).Append("\n");
            sb.Append("  audience: ").Append(Audience).Append("\n");
            sb.Append("  credentials: ").Append(Credentials).Append("\n");
            sb.Append("  podIdentityAssociationId: ").Append(PodIdentityAssociationId).Append("\n");
            sb.Append("  subject: ").Append(Subject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssumeAgencyForPodIdentityResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssumeAgencyForPodIdentityResponse input)
        {
            if (input == null) return false;
            if (this.AssumedAgency != input.AssumedAgency || (this.AssumedAgency != null && !this.AssumedAgency.Equals(input.AssumedAgency))) return false;
            if (this.Audience != input.Audience || (this.Audience != null && !this.Audience.Equals(input.Audience))) return false;
            if (this.Credentials != input.Credentials || (this.Credentials != null && !this.Credentials.Equals(input.Credentials))) return false;
            if (this.PodIdentityAssociationId != input.PodIdentityAssociationId || (this.PodIdentityAssociationId != null && !this.PodIdentityAssociationId.Equals(input.PodIdentityAssociationId))) return false;
            if (this.Subject != input.Subject || (this.Subject != null && !this.Subject.Equals(input.Subject))) return false;

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
                if (this.AssumedAgency != null) hashCode = hashCode * 59 + this.AssumedAgency.GetHashCode();
                if (this.Audience != null) hashCode = hashCode * 59 + this.Audience.GetHashCode();
                if (this.Credentials != null) hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.PodIdentityAssociationId != null) hashCode = hashCode * 59 + this.PodIdentityAssociationId.GetHashCode();
                if (this.Subject != null) hashCode = hashCode * 59 + this.Subject.GetHashCode();
                return hashCode;
            }
        }
    }
}
