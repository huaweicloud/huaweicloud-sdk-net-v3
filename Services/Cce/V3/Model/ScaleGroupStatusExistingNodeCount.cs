using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 伸缩组存量节点统计信息
    /// </summary>
    public class ScaleGroupStatusExistingNodeCount 
    {

        /// <summary>
        /// 按需计费节点个数
        /// </summary>
        [JsonProperty("postPaid", NullValueHandling = NullValueHandling.Ignore)]
        public int? PostPaid { get; set; }

        /// <summary>
        /// 包年包月节点个数
        /// </summary>
        [JsonProperty("prePaid", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrePaid { get; set; }

        /// <summary>
        /// 按需计费和包年包月节点总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleGroupStatusExistingNodeCount {\n");
            sb.Append("  postPaid: ").Append(PostPaid).Append("\n");
            sb.Append("  prePaid: ").Append(PrePaid).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleGroupStatusExistingNodeCount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleGroupStatusExistingNodeCount input)
        {
            if (input == null) return false;
            if (this.PostPaid != input.PostPaid || (this.PostPaid != null && !this.PostPaid.Equals(input.PostPaid))) return false;
            if (this.PrePaid != input.PrePaid || (this.PrePaid != null && !this.PrePaid.Equals(input.PrePaid))) return false;
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
                if (this.PostPaid != null) hashCode = hashCode * 59 + this.PostPaid.GetHashCode();
                if (this.PrePaid != null) hashCode = hashCode * 59 + this.PrePaid.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
