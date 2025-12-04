using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserPolicyResponeEntity 
    {

        /// <summary>
        /// **参数解释**： 资源类型。 **取值范围**： - TOPIC：表示资源类型为Topic。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// **参数解释**： 资源名称。 **取值范围**： - 已有的Topic名称。 - 符合Topic名称规则的前缀。 - “*”表示匹配所有的Topic。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// **参数解释**： 匹配方式。 **取值范围**： - LITERAL：完全匹配。 - PREFIXED：前缀匹配。
        /// </summary>
        [JsonProperty("pattern_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PatternType { get; set; }

        /// <summary>
        /// **参数解释**： 权限类型。 **取值范围**： - all：拥有发布、订阅权限。 - pub：拥有发布权限。 - sub：拥有订阅权限。
        /// </summary>
        [JsonProperty("access_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessPolicy { get; set; }

        /// <summary>
        /// **参数解释**： Acl权限类型。 **取值范围**： - ALLOW：允许用户进行某种操作。
        /// </summary>
        [JsonProperty("acl_permission_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AclPermissionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserPolicyResponeEntity {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  patternType: ").Append(PatternType).Append("\n");
            sb.Append("  accessPolicy: ").Append(AccessPolicy).Append("\n");
            sb.Append("  aclPermissionType: ").Append(AclPermissionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserPolicyResponeEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserPolicyResponeEntity input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.PatternType != input.PatternType || (this.PatternType != null && !this.PatternType.Equals(input.PatternType))) return false;
            if (this.AccessPolicy != input.AccessPolicy || (this.AccessPolicy != null && !this.AccessPolicy.Equals(input.AccessPolicy))) return false;
            if (this.AclPermissionType != input.AclPermissionType || (this.AclPermissionType != null && !this.AclPermissionType.Equals(input.AclPermissionType))) return false;

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
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.PatternType != null) hashCode = hashCode * 59 + this.PatternType.GetHashCode();
                if (this.AccessPolicy != null) hashCode = hashCode * 59 + this.AccessPolicy.GetHashCode();
                if (this.AclPermissionType != null) hashCode = hashCode * 59 + this.AclPermissionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
