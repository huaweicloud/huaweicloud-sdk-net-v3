using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 委托转储信息。若配置委托转储，则需要输入该参数
    /// </summary>
    public class CreateTransferRequestBodyLogTransferInfoLogAgencyTransfer 
    {

        /// <summary>
        /// 委托方账号ID
        /// </summary>
        [JsonProperty("agency_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyDomainId { get; set; }

        /// <summary>
        /// 委托方账号名称
        /// </summary>
        [JsonProperty("agency_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyDomainName { get; set; }

        /// <summary>
        /// 委托方配置的委托名称
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// 委托方项目ID
        /// </summary>
        [JsonProperty("agency_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyProjectId { get; set; }

        /// <summary>
        /// 被委托方账号ID，实际配置转储的账号ID
        /// </summary>
        [JsonProperty("be_agency_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BeAgencyDomainId { get; set; }

        /// <summary>
        /// 被委托方项目ID，实际配置转储的账号的项目ID
        /// </summary>
        [JsonProperty("be_agency_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BeAgencyProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTransferRequestBodyLogTransferInfoLogAgencyTransfer {\n");
            sb.Append("  agencyDomainId: ").Append(AgencyDomainId).Append("\n");
            sb.Append("  agencyDomainName: ").Append(AgencyDomainName).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  agencyProjectId: ").Append(AgencyProjectId).Append("\n");
            sb.Append("  beAgencyDomainId: ").Append(BeAgencyDomainId).Append("\n");
            sb.Append("  beAgencyProjectId: ").Append(BeAgencyProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTransferRequestBodyLogTransferInfoLogAgencyTransfer);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTransferRequestBodyLogTransferInfoLogAgencyTransfer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgencyDomainId == input.AgencyDomainId ||
                    (this.AgencyDomainId != null &&
                    this.AgencyDomainId.Equals(input.AgencyDomainId))
                ) && 
                (
                    this.AgencyDomainName == input.AgencyDomainName ||
                    (this.AgencyDomainName != null &&
                    this.AgencyDomainName.Equals(input.AgencyDomainName))
                ) && 
                (
                    this.AgencyName == input.AgencyName ||
                    (this.AgencyName != null &&
                    this.AgencyName.Equals(input.AgencyName))
                ) && 
                (
                    this.AgencyProjectId == input.AgencyProjectId ||
                    (this.AgencyProjectId != null &&
                    this.AgencyProjectId.Equals(input.AgencyProjectId))
                ) && 
                (
                    this.BeAgencyDomainId == input.BeAgencyDomainId ||
                    (this.BeAgencyDomainId != null &&
                    this.BeAgencyDomainId.Equals(input.BeAgencyDomainId))
                ) && 
                (
                    this.BeAgencyProjectId == input.BeAgencyProjectId ||
                    (this.BeAgencyProjectId != null &&
                    this.BeAgencyProjectId.Equals(input.BeAgencyProjectId))
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
                if (this.AgencyDomainId != null)
                    hashCode = hashCode * 59 + this.AgencyDomainId.GetHashCode();
                if (this.AgencyDomainName != null)
                    hashCode = hashCode * 59 + this.AgencyDomainName.GetHashCode();
                if (this.AgencyName != null)
                    hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.AgencyProjectId != null)
                    hashCode = hashCode * 59 + this.AgencyProjectId.GetHashCode();
                if (this.BeAgencyDomainId != null)
                    hashCode = hashCode * 59 + this.BeAgencyDomainId.GetHashCode();
                if (this.BeAgencyProjectId != null)
                    hashCode = hashCode * 59 + this.BeAgencyProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
