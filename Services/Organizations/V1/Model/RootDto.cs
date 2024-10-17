using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Organizations.V1.Model
{
    /// <summary>
    /// 包含根的详细信息。根是组织层次结构中的顶级父节点，可以包含组织单元和账号。
    /// </summary>
    public class RootDto 
    {

        /// <summary>
        /// 根的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 根的统一资源名称。
        /// </summary>
        [JsonProperty("urn", NullValueHandling = NullValueHandling.Ignore)]
        public string Urn { get; set; }

        /// <summary>
        /// 根的名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 策略类型在当前根已启用，则该类型策略可以绑定到根或其组织单元或账号。
        /// </summary>
        [JsonProperty("policy_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyTypeSummaryDto> PolicyTypes { get; set; }

        /// <summary>
        /// 根的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RootDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  urn: ").Append(Urn).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  policyTypes: ").Append(PolicyTypes).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RootDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RootDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Urn != input.Urn || (this.Urn != null && !this.Urn.Equals(input.Urn))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PolicyTypes != input.PolicyTypes || (this.PolicyTypes != null && input.PolicyTypes != null && !this.PolicyTypes.SequenceEqual(input.PolicyTypes))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Urn != null) hashCode = hashCode * 59 + this.Urn.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PolicyTypes != null) hashCode = hashCode * 59 + this.PolicyTypes.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
