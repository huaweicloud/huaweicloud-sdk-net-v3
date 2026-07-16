using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListWorkflowStepExecutionResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：总数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释**：返回个数。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释**：StepExecution数组。
        /// </summary>
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<StepExecutionResp> Items { get; set; }

        /// <summary>
        /// **参数解释**：默认排序。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("default_order", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compare_columns", NullValueHandling = NullValueHandling.Ignore)]
        public CompareColumns CompareColumns { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkflowStepExecutionResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  items: ").Append(Items).Append("\n");
            sb.Append("  defaultOrder: ").Append(DefaultOrder).Append("\n");
            sb.Append("  compareColumns: ").Append(CompareColumns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkflowStepExecutionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkflowStepExecutionResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Items != input.Items || (this.Items != null && input.Items != null && !this.Items.SequenceEqual(input.Items))) return false;
            if (this.DefaultOrder != input.DefaultOrder || (this.DefaultOrder != null && !this.DefaultOrder.Equals(input.DefaultOrder))) return false;
            if (this.CompareColumns != input.CompareColumns || (this.CompareColumns != null && !this.CompareColumns.Equals(input.CompareColumns))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Items != null) hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.DefaultOrder != null) hashCode = hashCode * 59 + this.DefaultOrder.GetHashCode();
                if (this.CompareColumns != null) hashCode = hashCode * 59 + this.CompareColumns.GetHashCode();
                return hashCode;
            }
        }
    }
}
