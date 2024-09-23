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
    /// 包含有关组织的详细信息。组织是账号集合，由组织单元构成的层次结构，并通过策略控制。
    /// </summary>
    public class OrganizationDto 
    {

        /// <summary>
        /// 组织的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 组织的统一资源名称。
        /// </summary>
        [JsonProperty("urn", NullValueHandling = NullValueHandling.Ignore)]
        public string Urn { get; set; }

        /// <summary>
        /// 组织管理账号的唯一标识符（ID）。
        /// </summary>
        [JsonProperty("management_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementAccountId { get; set; }

        /// <summary>
        /// 组织的管理账号的名称。
        /// </summary>
        [JsonProperty("management_account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagementAccountName { get; set; }

        /// <summary>
        /// 组织的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  urn: ").Append(Urn).Append("\n");
            sb.Append("  managementAccountId: ").Append(ManagementAccountId).Append("\n");
            sb.Append("  managementAccountName: ").Append(ManagementAccountName).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrganizationDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrganizationDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Urn == input.Urn ||
                    (this.Urn != null &&
                    this.Urn.Equals(input.Urn))
                ) && 
                (
                    this.ManagementAccountId == input.ManagementAccountId ||
                    (this.ManagementAccountId != null &&
                    this.ManagementAccountId.Equals(input.ManagementAccountId))
                ) && 
                (
                    this.ManagementAccountName == input.ManagementAccountName ||
                    (this.ManagementAccountName != null &&
                    this.ManagementAccountName.Equals(input.ManagementAccountName))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Urn != null)
                    hashCode = hashCode * 59 + this.Urn.GetHashCode();
                if (this.ManagementAccountId != null)
                    hashCode = hashCode * 59 + this.ManagementAccountId.GetHashCode();
                if (this.ManagementAccountName != null)
                    hashCode = hashCode * 59 + this.ManagementAccountName.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
