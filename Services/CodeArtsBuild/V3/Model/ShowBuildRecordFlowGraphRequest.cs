using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowBuildRecordFlowGraphRequest 
    {

        /// <summary>
        /// 父任务构建记录ID
        /// </summary>
        [SDKProperty("build_flow_record_id", IsPath = true)]
        [JsonProperty("build_flow_record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildFlowRecordId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBuildRecordFlowGraphRequest {\n");
            sb.Append("  buildFlowRecordId: ").Append(BuildFlowRecordId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBuildRecordFlowGraphRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBuildRecordFlowGraphRequest input)
        {
            if (input == null) return false;
            if (this.BuildFlowRecordId != input.BuildFlowRecordId || (this.BuildFlowRecordId != null && !this.BuildFlowRecordId.Equals(input.BuildFlowRecordId))) return false;

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
                if (this.BuildFlowRecordId != null) hashCode = hashCode * 59 + this.BuildFlowRecordId.GetHashCode();
                return hashCode;
            }
        }
    }
}
