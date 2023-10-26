using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteserviceDiscoveryRulesRequest 
    {

        /// <summary>
        /// 发现规则ID,传多个时以逗号分隔。
        /// </summary>
        [SDKProperty("appRulesIds", IsQuery = true)]
        [JsonProperty("appRulesIds", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AppRulesIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteserviceDiscoveryRulesRequest {\n");
            sb.Append("  appRulesIds: ").Append(AppRulesIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteserviceDiscoveryRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteserviceDiscoveryRulesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AppRulesIds == input.AppRulesIds ||
                    this.AppRulesIds != null &&
                    input.AppRulesIds != null &&
                    this.AppRulesIds.SequenceEqual(input.AppRulesIds)
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
                if (this.AppRulesIds != null)
                    hashCode = hashCode * 59 + this.AppRulesIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
