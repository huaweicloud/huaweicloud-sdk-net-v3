using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 合规规则最新修正记录查询条件。
    /// </summary>
    public class RemediationExecutionStatusesSummaryRequestBody 
    {

        /// <summary>
        /// 合规规则最新修正记录查询条件列表。
        /// </summary>
        [JsonProperty("resource_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<RemediationResourceKey> ResourceKeys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RemediationExecutionStatusesSummaryRequestBody {\n");
            sb.Append("  resourceKeys: ").Append(ResourceKeys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RemediationExecutionStatusesSummaryRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RemediationExecutionStatusesSummaryRequestBody input)
        {
            if (input == null) return false;
            if (this.ResourceKeys != input.ResourceKeys || (this.ResourceKeys != null && input.ResourceKeys != null && !this.ResourceKeys.SequenceEqual(input.ResourceKeys))) return false;

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
                if (this.ResourceKeys != null) hashCode = hashCode * 59 + this.ResourceKeys.GetHashCode();
                return hashCode;
            }
        }
    }
}
