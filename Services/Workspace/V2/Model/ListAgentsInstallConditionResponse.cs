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
    /// Response Object
    /// </summary>
    public class ListAgentsInstallConditionResponse : SdkResponse
    {

        /// <summary>
        /// 桌面agent安装情况
        /// </summary>
        [JsonProperty("agents_condition", NullValueHandling = NullValueHandling.Ignore)]
        public List<AgentsCondition> AgentsCondition { get; set; }

        /// <summary>
        /// 总共条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAgentsInstallConditionResponse {\n");
            sb.Append("  agentsCondition: ").Append(AgentsCondition).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAgentsInstallConditionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgentsInstallConditionResponse input)
        {
            if (input == null) return false;
            if (this.AgentsCondition != input.AgentsCondition || (this.AgentsCondition != null && input.AgentsCondition != null && !this.AgentsCondition.SequenceEqual(input.AgentsCondition))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.AgentsCondition != null) hashCode = hashCode * 59 + this.AgentsCondition.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
