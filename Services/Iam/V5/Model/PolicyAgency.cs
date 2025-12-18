using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PolicyAgency 
    {

        /// <summary>
        /// 委托或信任委托ID，长度为1到64个字符，只包含字母、数字和\&quot;-\&quot;的字符串。
        /// </summary>
        [JsonProperty("agency_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyId { get; set; }

        /// <summary>
        /// 身份策略的附加时间。
        /// </summary>
        [JsonProperty("attached_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? AttachedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyAgency {\n");
            sb.Append("  agencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  attachedAt: ").Append(AttachedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PolicyAgency);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PolicyAgency input)
        {
            if (input == null) return false;
            if (this.AgencyId != input.AgencyId || (this.AgencyId != null && !this.AgencyId.Equals(input.AgencyId))) return false;
            if (this.AttachedAt != input.AttachedAt || (this.AttachedAt != null && !this.AttachedAt.Equals(input.AttachedAt))) return false;

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
                if (this.AgencyId != null) hashCode = hashCode * 59 + this.AgencyId.GetHashCode();
                if (this.AttachedAt != null) hashCode = hashCode * 59 + this.AttachedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
