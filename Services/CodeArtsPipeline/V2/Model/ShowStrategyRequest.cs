using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowStrategyRequest 
    {

        /// <summary>
        /// 策略ID
        /// </summary>
        [SDKProperty("rule_set_id", IsPath = true)]
        [JsonProperty("rule_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleSetId { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [SDKProperty("domain_id", IsPath = true)]
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [SDKProperty("cloud_project_id", IsQuery = true)]
        [JsonProperty("cloud_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowStrategyRequest {\n");
            sb.Append("  ruleSetId: ").Append(RuleSetId).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  cloudProjectId: ").Append(CloudProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowStrategyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowStrategyRequest input)
        {
            if (input == null) return false;
            if (this.RuleSetId != input.RuleSetId || (this.RuleSetId != null && !this.RuleSetId.Equals(input.RuleSetId))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.CloudProjectId != input.CloudProjectId || (this.CloudProjectId != null && !this.CloudProjectId.Equals(input.CloudProjectId))) return false;

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
                if (this.RuleSetId != null) hashCode = hashCode * 59 + this.RuleSetId.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CloudProjectId != null) hashCode = hashCode * 59 + this.CloudProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
