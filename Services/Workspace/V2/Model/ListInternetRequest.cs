using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInternetRequest 
    {

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// NAT网关名称。
        /// </summary>
        [SDKProperty("nat_name", IsQuery = true)]
        [JsonProperty("nat_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NatName { get; set; }

        /// <summary>
        /// EIP地址。
        /// </summary>
        [SDKProperty("eip", IsQuery = true)]
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public string Eip { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInternetRequest {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  natName: ").Append(NatName).Append("\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInternetRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInternetRequest input)
        {
            if (input == null) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.NatName != input.NatName || (this.NatName != null && !this.NatName.Equals(input.NatName))) return false;
            if (this.Eip != input.Eip || (this.Eip != null && !this.Eip.Equals(input.Eip))) return false;

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
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.NatName != null) hashCode = hashCode * 59 + this.NatName.GetHashCode();
                if (this.Eip != null) hashCode = hashCode * 59 + this.Eip.GetHashCode();
                return hashCode;
            }
        }
    }
}
