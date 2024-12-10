using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 授权传入参数
    /// </summary>
    public class GrantSecretReqBody 
    {

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源类型（SECRET、GROUP）
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 被授权类型，（0：USER；2：GROUP）个人，群组
        /// </summary>
        [JsonProperty("grantee_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GranteeType { get; set; }

        /// <summary>
        /// 被授权id
        /// </summary>
        [JsonProperty("grantee_target_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GranteeTargetId { get; set; }

        /// <summary>
        /// 有效期截止时间
        /// </summary>
        [JsonProperty("validity_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ValidityTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GrantSecretReqBody {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  granteeType: ").Append(GranteeType).Append("\n");
            sb.Append("  granteeTargetId: ").Append(GranteeTargetId).Append("\n");
            sb.Append("  validityTime: ").Append(ValidityTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GrantSecretReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GrantSecretReqBody input)
        {
            if (input == null) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.GranteeType != input.GranteeType || (this.GranteeType != null && !this.GranteeType.Equals(input.GranteeType))) return false;
            if (this.GranteeTargetId != input.GranteeTargetId || (this.GranteeTargetId != null && !this.GranteeTargetId.Equals(input.GranteeTargetId))) return false;
            if (this.ValidityTime != input.ValidityTime || (this.ValidityTime != null && !this.ValidityTime.Equals(input.ValidityTime))) return false;

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
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.GranteeType != null) hashCode = hashCode * 59 + this.GranteeType.GetHashCode();
                if (this.GranteeTargetId != null) hashCode = hashCode * 59 + this.GranteeTargetId.GetHashCode();
                if (this.ValidityTime != null) hashCode = hashCode * 59 + this.ValidityTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
