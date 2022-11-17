using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowIssuesWrokFlowConfigResponse : SdkResponse
    {

        /// <summary>
        /// 流转数据
        /// </summary>
        [JsonProperty("workflows", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScrumStatusFlowVo> Workflows { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIssuesWrokFlowConfigResponse {\n");
            sb.Append("  workflows: ").Append(Workflows).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIssuesWrokFlowConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIssuesWrokFlowConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Workflows == input.Workflows ||
                    this.Workflows != null &&
                    input.Workflows != null &&
                    this.Workflows.SequenceEqual(input.Workflows)
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
                if (this.Workflows != null)
                    hashCode = hashCode * 59 + this.Workflows.GetHashCode();
                return hashCode;
            }
        }
    }
}
