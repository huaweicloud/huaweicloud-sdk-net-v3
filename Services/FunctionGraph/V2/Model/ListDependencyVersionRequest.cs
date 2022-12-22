using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListDependencyVersionRequest 
    {

        /// <summary>
        /// 依赖包的ID。
        /// </summary>
        [SDKProperty("depend_id", IsPath = true)]
        [JsonProperty("depend_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DependId { get; set; }

        /// <summary>
        /// 上一次查询依赖包的最后记录位置，默认为\&quot;0\&quot;。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 单次查询最大条数
        /// </summary>
        [SDKProperty("maxitems", IsQuery = true)]
        [JsonProperty("maxitems", NullValueHandling = NullValueHandling.Ignore)]
        public string Maxitems { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDependencyVersionRequest {\n");
            sb.Append("  dependId: ").Append(DependId).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  maxitems: ").Append(Maxitems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDependencyVersionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDependencyVersionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DependId == input.DependId ||
                    (this.DependId != null &&
                    this.DependId.Equals(input.DependId))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.Maxitems == input.Maxitems ||
                    (this.Maxitems != null &&
                    this.Maxitems.Equals(input.Maxitems))
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
                if (this.DependId != null)
                    hashCode = hashCode * 59 + this.DependId.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Maxitems != null)
                    hashCode = hashCode * 59 + this.Maxitems.GetHashCode();
                return hashCode;
            }
        }
    }
}
