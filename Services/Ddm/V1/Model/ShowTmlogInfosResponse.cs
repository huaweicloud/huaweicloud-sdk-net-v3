using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowTmlogInfosResponse : SdkResponse
    {

        /// <summary>
        /// TMLOG信息列表。
        /// </summary>
        [JsonProperty("tmlogs", NullValueHandling = NullValueHandling.Ignore)]
        public List<TmlogInfo> Tmlogs { get; set; }

        /// <summary>
        /// 查询到TMLOG的节点总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTmlogInfosResponse {\n");
            sb.Append("  tmlogs: ").Append(Tmlogs).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTmlogInfosResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTmlogInfosResponse input)
        {
            if (input == null) return false;
            if (this.Tmlogs != input.Tmlogs || (this.Tmlogs != null && input.Tmlogs != null && !this.Tmlogs.SequenceEqual(input.Tmlogs))) return false;
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
                if (this.Tmlogs != null) hashCode = hashCode * 59 + this.Tmlogs.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
