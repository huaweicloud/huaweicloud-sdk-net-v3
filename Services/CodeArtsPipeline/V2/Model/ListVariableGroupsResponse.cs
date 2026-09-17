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
    /// Response Object
    /// </summary>
    public class ListVariableGroupsResponse : SdkResponse
    {

        /// <summary>
        /// 详情列表
        /// </summary>
        [JsonProperty("pipeline_variable_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListVariableGroupsRespPipelineVariableGroups> PipelineVariableGroups { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 单页条数·
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释**： 总条目数量。 **取值范围**： 大于等于0。 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVariableGroupsResponse {\n");
            sb.Append("  pipelineVariableGroups: ").Append(PipelineVariableGroups).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVariableGroupsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVariableGroupsResponse input)
        {
            if (input == null) return false;
            if (this.PipelineVariableGroups != input.PipelineVariableGroups || (this.PipelineVariableGroups != null && input.PipelineVariableGroups != null && !this.PipelineVariableGroups.SequenceEqual(input.PipelineVariableGroups))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.PipelineVariableGroups != null) hashCode = hashCode * 59 + this.PipelineVariableGroups.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
