using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListInstanceAllArtifactsResponse : SdkResponse
    {

        /// <summary>
        /// 制品列表
        /// </summary>
        [JsonProperty("artifacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Artifact> Artifacts { get; set; }

        /// <summary>
        /// 下一次分页查询的起始ID。如果未返回该值，则表示数据已查询完毕
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextMarker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceAllArtifactsResponse {\n");
            sb.Append("  artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceAllArtifactsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceAllArtifactsResponse input)
        {
            if (input == null) return false;
            if (this.Artifacts != input.Artifacts || (this.Artifacts != null && input.Artifacts != null && !this.Artifacts.SequenceEqual(input.Artifacts))) return false;
            if (this.NextMarker != input.NextMarker || (this.NextMarker != null && !this.NextMarker.Equals(input.NextMarker))) return false;

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
                if (this.Artifacts != null) hashCode = hashCode * 59 + this.Artifacts.GetHashCode();
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                return hashCode;
            }
        }
    }
}
