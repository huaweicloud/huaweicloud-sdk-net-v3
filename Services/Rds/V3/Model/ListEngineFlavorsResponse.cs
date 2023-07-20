using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEngineFlavorsResponse : SdkResponse
    {

        /// <summary>
        /// 可用的规格列表信息
        /// </summary>
        [JsonProperty("optional_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<EngineFlavorData> OptionalFlavors { get; set; }

        /// <summary>
        /// 可用的规格总数
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEngineFlavorsResponse {\n");
            sb.Append("  optionalFlavors: ").Append(OptionalFlavors).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEngineFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEngineFlavorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OptionalFlavors == input.OptionalFlavors ||
                    this.OptionalFlavors != null &&
                    input.OptionalFlavors != null &&
                    this.OptionalFlavors.SequenceEqual(input.OptionalFlavors)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.OptionalFlavors != null)
                    hashCode = hashCode * 59 + this.OptionalFlavors.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
