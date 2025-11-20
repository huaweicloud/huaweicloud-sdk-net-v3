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
    /// 
    /// </summary>
    public class AccessPolicy 
    {

        /// <summary>
        /// **参数解释：** API类型。 **约束限制：** 该值不可修改 **取值范围：** 不涉及 **默认取值：** AccessPolicy
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// **参数解释：** API版本。 **约束限制：** 该值不可修改 **取值范围：** 不涉及 **默认取值：** v3
        /// </summary>
        [JsonProperty("apiVersion", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// **参数解释：** 访问策略名称。 **约束限制：** 以小写字母开头，由小写字母、数字、中划线(-)、点(.)组成，长度范围1-56位，且不能以中划线(-)结尾。 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 集群ID的列表，允许使用通配符（“\\*”），表示所有集群。获取方式请参见[如何获取接口URI中参数](cce_02_0271.xml)。 **约束限制：** 当前最多支持同时授权200个集群。 **取值范围：** \\[\&quot;\\*\&quot;\\]或者集群ID列表。 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("clusters", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Clusters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("accessScope", NullValueHandling = NullValueHandling.Ignore)]
        public AccessScope AccessScope { get; set; }

        /// <summary>
        /// **参数解释：** 权限类型。 **约束限制：** 不涉及 **取值范围：** - CCEClusterAdminPolicy：管理员权限 - CCEAdminPolicy：运维权限 - CCEEditPolicy：开发权限 - CCEViewPolicy：只读权限  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("policyType", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("principal", NullValueHandling = NullValueHandling.Ignore)]
        public Principal Principal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessPolicy {\n");
            sb.Append("  kind: ").Append(Kind).Append("\n");
            sb.Append("  apiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  clusters: ").Append(Clusters).Append("\n");
            sb.Append("  accessScope: ").Append(AccessScope).Append("\n");
            sb.Append("  policyType: ").Append(PolicyType).Append("\n");
            sb.Append("  principal: ").Append(Principal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessPolicy input)
        {
            if (input == null) return false;
            if (this.Kind != input.Kind || (this.Kind != null && !this.Kind.Equals(input.Kind))) return false;
            if (this.ApiVersion != input.ApiVersion || (this.ApiVersion != null && !this.ApiVersion.Equals(input.ApiVersion))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Clusters != input.Clusters || (this.Clusters != null && input.Clusters != null && !this.Clusters.SequenceEqual(input.Clusters))) return false;
            if (this.AccessScope != input.AccessScope || (this.AccessScope != null && !this.AccessScope.Equals(input.AccessScope))) return false;
            if (this.PolicyType != input.PolicyType || (this.PolicyType != null && !this.PolicyType.Equals(input.PolicyType))) return false;
            if (this.Principal != input.Principal || (this.Principal != null && !this.Principal.Equals(input.Principal))) return false;

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
                if (this.Kind != null) hashCode = hashCode * 59 + this.Kind.GetHashCode();
                if (this.ApiVersion != null) hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Clusters != null) hashCode = hashCode * 59 + this.Clusters.GetHashCode();
                if (this.AccessScope != null) hashCode = hashCode * 59 + this.AccessScope.GetHashCode();
                if (this.PolicyType != null) hashCode = hashCode * 59 + this.PolicyType.GetHashCode();
                if (this.Principal != null) hashCode = hashCode * 59 + this.Principal.GetHashCode();
                return hashCode;
            }
        }
    }
}
