using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AffectedResource 
    {

        /// <summary>
        /// 被防护对象账户ID
        /// </summary>
        [JsonProperty("affected_attached_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedAttachedDomainId { get; set; }

        /// <summary>
        /// 被防护对象项目ID
        /// </summary>
        [JsonProperty("affected_attached_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedAttachedProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("affected_head", NullValueHandling = NullValueHandling.Ignore)]
        public DataResourceHead AffectedHead { get; set; }

        /// <summary>
        /// 资源扩展信息
        /// </summary>
        [JsonProperty("affected_properties", NullValueHandling = NullValueHandling.Ignore)]
        public Object AffectedProperties { get; set; }

        /// <summary>
        /// 被防护(受影响）对象在防线系统内唯一ID
        /// </summary>
        [JsonProperty("affected_protected_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedProtectedId { get; set; }

        /// <summary>
        /// 被防护(受影响）对象子类型: 固定为：DB
        /// </summary>
        [JsonProperty("affected_subtype", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedSubtype { get; set; }

        /// <summary>
        /// 被防护(受影响）对象类型，数据库资产，固定为：Data
        /// </summary>
        [JsonProperty("affected_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedType { get; set; }

        /// <summary>
        /// 被防护对象urn
        /// </summary>
        [JsonProperty("affected_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedUrn { get; set; }

        /// <summary>
        /// 被防护对象URN扩展
        /// </summary>
        [JsonProperty("affected_urnext", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedUrnext { get; set; }

        /// <summary>
        /// 被防护(受影响）对象值，云下数据库同affectedProtectedId，云上不传
        /// </summary>
        [JsonProperty("affected_value", NullValueHandling = NullValueHandling.Ignore)]
        public string AffectedValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AffectedResource {\n");
            sb.Append("  affectedAttachedDomainId: ").Append(AffectedAttachedDomainId).Append("\n");
            sb.Append("  affectedAttachedProjectId: ").Append(AffectedAttachedProjectId).Append("\n");
            sb.Append("  affectedHead: ").Append(AffectedHead).Append("\n");
            sb.Append("  affectedProperties: ").Append(AffectedProperties).Append("\n");
            sb.Append("  affectedProtectedId: ").Append(AffectedProtectedId).Append("\n");
            sb.Append("  affectedSubtype: ").Append(AffectedSubtype).Append("\n");
            sb.Append("  affectedType: ").Append(AffectedType).Append("\n");
            sb.Append("  affectedUrn: ").Append(AffectedUrn).Append("\n");
            sb.Append("  affectedUrnext: ").Append(AffectedUrnext).Append("\n");
            sb.Append("  affectedValue: ").Append(AffectedValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AffectedResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AffectedResource input)
        {
            if (input == null) return false;
            if (this.AffectedAttachedDomainId != input.AffectedAttachedDomainId || (this.AffectedAttachedDomainId != null && !this.AffectedAttachedDomainId.Equals(input.AffectedAttachedDomainId))) return false;
            if (this.AffectedAttachedProjectId != input.AffectedAttachedProjectId || (this.AffectedAttachedProjectId != null && !this.AffectedAttachedProjectId.Equals(input.AffectedAttachedProjectId))) return false;
            if (this.AffectedHead != input.AffectedHead || (this.AffectedHead != null && !this.AffectedHead.Equals(input.AffectedHead))) return false;
            if (this.AffectedProperties != input.AffectedProperties || (this.AffectedProperties != null && !this.AffectedProperties.Equals(input.AffectedProperties))) return false;
            if (this.AffectedProtectedId != input.AffectedProtectedId || (this.AffectedProtectedId != null && !this.AffectedProtectedId.Equals(input.AffectedProtectedId))) return false;
            if (this.AffectedSubtype != input.AffectedSubtype || (this.AffectedSubtype != null && !this.AffectedSubtype.Equals(input.AffectedSubtype))) return false;
            if (this.AffectedType != input.AffectedType || (this.AffectedType != null && !this.AffectedType.Equals(input.AffectedType))) return false;
            if (this.AffectedUrn != input.AffectedUrn || (this.AffectedUrn != null && !this.AffectedUrn.Equals(input.AffectedUrn))) return false;
            if (this.AffectedUrnext != input.AffectedUrnext || (this.AffectedUrnext != null && !this.AffectedUrnext.Equals(input.AffectedUrnext))) return false;
            if (this.AffectedValue != input.AffectedValue || (this.AffectedValue != null && !this.AffectedValue.Equals(input.AffectedValue))) return false;

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
                if (this.AffectedAttachedDomainId != null) hashCode = hashCode * 59 + this.AffectedAttachedDomainId.GetHashCode();
                if (this.AffectedAttachedProjectId != null) hashCode = hashCode * 59 + this.AffectedAttachedProjectId.GetHashCode();
                if (this.AffectedHead != null) hashCode = hashCode * 59 + this.AffectedHead.GetHashCode();
                if (this.AffectedProperties != null) hashCode = hashCode * 59 + this.AffectedProperties.GetHashCode();
                if (this.AffectedProtectedId != null) hashCode = hashCode * 59 + this.AffectedProtectedId.GetHashCode();
                if (this.AffectedSubtype != null) hashCode = hashCode * 59 + this.AffectedSubtype.GetHashCode();
                if (this.AffectedType != null) hashCode = hashCode * 59 + this.AffectedType.GetHashCode();
                if (this.AffectedUrn != null) hashCode = hashCode * 59 + this.AffectedUrn.GetHashCode();
                if (this.AffectedUrnext != null) hashCode = hashCode * 59 + this.AffectedUrnext.GetHashCode();
                if (this.AffectedValue != null) hashCode = hashCode * 59 + this.AffectedValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
