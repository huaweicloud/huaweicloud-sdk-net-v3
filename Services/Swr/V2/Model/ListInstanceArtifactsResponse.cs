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
    public class ListInstanceArtifactsResponse : SdkResponse
    {

        /// <summary>
        /// 制品列表
        /// </summary>
        [JsonProperty("artifacts", NullValueHandling = NullValueHandling.Ignore)]
        public List<Artifact> Artifacts { get; set; }

        /// <summary>
        /// 制品总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceArtifactsResponse {\n");
            sb.Append("  artifacts: ").Append(Artifacts).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceArtifactsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceArtifactsResponse input)
        {
            if (input == null) return false;
            if (this.Artifacts != input.Artifacts || (this.Artifacts != null && input.Artifacts != null && !this.Artifacts.SequenceEqual(input.Artifacts))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
