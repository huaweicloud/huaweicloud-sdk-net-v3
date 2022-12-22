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
    public class ListWorkitemsResponse : SdkResponse
    {

        /// <summary>
        /// 工作项
        /// </summary>
        [JsonProperty("work_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Workitems> WorkItems { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkitemsResponse {\n");
            sb.Append("  workItems: ").Append(WorkItems).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkitemsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkitemsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WorkItems == input.WorkItems ||
                    this.WorkItems != null &&
                    input.WorkItems != null &&
                    this.WorkItems.SequenceEqual(input.WorkItems)
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.WorkItems != null)
                    hashCode = hashCode * 59 + this.WorkItems.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
