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
    public class ListFtArtifactsResponse : SdkResponse
    {

        /// <summary>
        /// 本次查询到的数据条目数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 产物信息。
        /// </summary>
        [JsonProperty("artifact_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<ArtifactInfo> ArtifactInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFtArtifactsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  artifactInfo: ").Append(ArtifactInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFtArtifactsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFtArtifactsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.ArtifactInfo != input.ArtifactInfo || (this.ArtifactInfo != null && input.ArtifactInfo != null && !this.ArtifactInfo.SequenceEqual(input.ArtifactInfo))) return false;

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
                if (this.ArtifactInfo != null) hashCode = hashCode * 59 + this.ArtifactInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
