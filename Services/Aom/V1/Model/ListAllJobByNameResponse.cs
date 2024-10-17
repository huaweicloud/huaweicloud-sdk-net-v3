using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAllJobByNameResponse : SdkResponse
    {

        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_elements", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalElements { get; set; }

        /// <summary>
        /// 查询作业信息集合。
        /// </summary>
        [JsonProperty("elements", NullValueHandling = NullValueHandling.Ignore)]
        public List<Job> Elements { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAllJobByNameResponse {\n");
            sb.Append("  totalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  elements: ").Append(Elements).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAllJobByNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAllJobByNameResponse input)
        {
            if (input == null) return false;
            if (this.TotalElements != input.TotalElements || (this.TotalElements != null && !this.TotalElements.Equals(input.TotalElements))) return false;
            if (this.Elements != input.Elements || (this.Elements != null && input.Elements != null && !this.Elements.SequenceEqual(input.Elements))) return false;

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
                if (this.TotalElements != null) hashCode = hashCode * 59 + this.TotalElements.GetHashCode();
                if (this.Elements != null) hashCode = hashCode * 59 + this.Elements.GetHashCode();
                return hashCode;
            }
        }
    }
}
