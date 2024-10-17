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
    public class ListProjectIterationsV4Response : SdkResponse
    {

        /// <summary>
        /// 迭代总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 迭代信息
        /// </summary>
        [JsonProperty("iterations", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListProjectVersionsV4ResponseBodyIterations> Iterations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProjectIterationsV4Response {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  iterations: ").Append(Iterations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProjectIterationsV4Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProjectIterationsV4Response input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.Iterations != input.Iterations || (this.Iterations != null && input.Iterations != null && !this.Iterations.SequenceEqual(input.Iterations))) return false;

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
                if (this.Iterations != null) hashCode = hashCode * 59 + this.Iterations.GetHashCode();
                return hashCode;
            }
        }
    }
}
