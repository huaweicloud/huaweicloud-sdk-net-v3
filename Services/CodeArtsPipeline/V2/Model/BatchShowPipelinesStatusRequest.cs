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
    public class BatchShowPipelinesStatusRequest 
    {

        /// <summary>
        /// 要获取状态的流水线ID，用逗号隔开
        /// </summary>
        [SDKProperty("pipeline_ids", IsQuery = true)]
        [JsonProperty("pipeline_ids", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchShowPipelinesStatusRequest {\n");
            sb.Append("  pipelineIds: ").Append(PipelineIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchShowPipelinesStatusRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchShowPipelinesStatusRequest input)
        {
            if (input == null) return false;
            if (this.PipelineIds != input.PipelineIds || (this.PipelineIds != null && !this.PipelineIds.Equals(input.PipelineIds))) return false;

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
                if (this.PipelineIds != null) hashCode = hashCode * 59 + this.PipelineIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
