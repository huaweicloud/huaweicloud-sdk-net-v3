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
    public class ListRepoDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 镜像仓库列表.
        /// </summary>
        [JsonProperty("repos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ShowReposRespV3> Repos { get; set; }

        /// <summary>
        /// 分页查询时,查询下一页数据的起始位置。
        /// </summary>
        [JsonProperty("nextMarker", NullValueHandling = NullValueHandling.Ignore)]
        public int? NextMarker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRepoDetailsResponse {\n");
            sb.Append("  repos: ").Append(Repos).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRepoDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRepoDetailsResponse input)
        {
            if (input == null) return false;
            if (this.Repos != input.Repos || (this.Repos != null && input.Repos != null && !this.Repos.SequenceEqual(input.Repos))) return false;
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
                if (this.Repos != null) hashCode = hashCode * 59 + this.Repos.GetHashCode();
                if (this.NextMarker != null) hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                return hashCode;
            }
        }
    }
}
