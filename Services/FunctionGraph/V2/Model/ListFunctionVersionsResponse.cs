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
    /// Response Object
    /// </summary>
    public class ListFunctionVersionsResponse : SdkResponse
    {

        /// <summary>
        /// 版本列表
        /// </summary>
        [JsonProperty("versions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListFunctionVersionResult> Versions { get; set; }

        /// <summary>
        /// 下一次记录位置
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextMarker { get; set; }

        /// <summary>
        /// 版本总数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public long? Count { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionVersionsResponse {\n");
            sb.Append("  versions: ").Append(Versions).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionVersionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionVersionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Versions == input.Versions ||
                    this.Versions != null &&
                    input.Versions != null &&
                    this.Versions.SequenceEqual(input.Versions)
                ) && 
                (
                    this.NextMarker == input.NextMarker ||
                    (this.NextMarker != null &&
                    this.NextMarker.Equals(input.NextMarker))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Versions != null)
                    hashCode = hashCode * 59 + this.Versions.GetHashCode();
                if (this.NextMarker != null)
                    hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
