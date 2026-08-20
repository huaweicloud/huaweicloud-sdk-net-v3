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
    /// 请求结果。
    /// </summary>
    public class ShowIpdProcessInstancesResponseResult 
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 评审单列表。
        /// </summary>
        [JsonProperty("process_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowIpdProcessInstancesResponseResultProcessInstances> ProcessInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowIpdProcessInstancesResponseResult {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  processInstances: ").Append(ProcessInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowIpdProcessInstancesResponseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowIpdProcessInstancesResponseResult input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.ProcessInstances != input.ProcessInstances || (this.ProcessInstances != null && input.ProcessInstances != null && !this.ProcessInstances.SequenceEqual(input.ProcessInstances))) return false;

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
                if (this.ProcessInstances != null) hashCode = hashCode * 59 + this.ProcessInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
