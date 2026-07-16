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
    public class ShowPodIdentityAssociationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** pod-identity关联的uid。 **约束限制：** 该值不可修改 **取值范围：** 不涉及 **默认取值：** 无
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// **参数解释：** pod-identity关联所属的集群id。 **约束限制：** 该值不可修改 **取值范围：** 不涉及 **默认取值：** 无
        /// </summary>
        [JsonProperty("clusterId", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// **参数解释：** pod-identity关联所要绑定的serviceaccount所属的命名空间。 **约束限制：** 该值不可修改 **取值范围：** 不涉及 **默认取值：** 无
        /// </summary>
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// **参数解释：** pod-identity关联所要绑定的serviceaccount名称。 **约束限制：** 该值不可修改 **取值范围：** 不涉及 **默认取值：** 无
        /// </summary>
        [JsonProperty("serviceAccount", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceAccount { get; set; }

        /// <summary>
        /// **参数解释：** pod-identity关联所要绑定的委托名称。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 无
        /// </summary>
        [JsonProperty("agencyName", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// **参数解释：** pod-identity关联的资源标签列表。 **约束限制：** 不涉及 
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTag> Tags { get; set; }

        /// <summary>
        /// **参数解释：** pod-identity关联创建时间。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 无
        /// </summary>
        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** pod-identity关联最近一次更新时间。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 无
        /// </summary>
        [JsonProperty("modifiedAt", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPodIdentityAssociationResponse {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  serviceAccount: ").Append(ServiceAccount).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  modifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPodIdentityAssociationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPodIdentityAssociationResponse input)
        {
            if (input == null) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.Namespace != input.Namespace || (this.Namespace != null && !this.Namespace.Equals(input.Namespace))) return false;
            if (this.ServiceAccount != input.ServiceAccount || (this.ServiceAccount != null && !this.ServiceAccount.Equals(input.ServiceAccount))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.ModifiedAt != input.ModifiedAt || (this.ModifiedAt != null && !this.ModifiedAt.Equals(input.ModifiedAt))) return false;

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
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.Namespace != null) hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.ServiceAccount != null) hashCode = hashCode * 59 + this.ServiceAccount.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.ModifiedAt != null) hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
