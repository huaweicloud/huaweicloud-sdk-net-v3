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
    public class ShowInstanceArtifactAdditionResponse : SdkResponse
    {

        /// <summary>
        /// 构建历史列表
        /// </summary>
        [JsonProperty("build_histories", NullValueHandling = NullValueHandling.Ignore)]
        public List<BuildHistory> BuildHistories { get; set; }

        /// <summary>
        /// 构建历史条数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceArtifactAdditionResponse {\n");
            sb.Append("  buildHistories: ").Append(BuildHistories).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceArtifactAdditionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceArtifactAdditionResponse input)
        {
            if (input == null) return false;
            if (this.BuildHistories != input.BuildHistories || (this.BuildHistories != null && input.BuildHistories != null && !this.BuildHistories.SequenceEqual(input.BuildHistories))) return false;
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
                if (this.BuildHistories != null) hashCode = hashCode * 59 + this.BuildHistories.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
