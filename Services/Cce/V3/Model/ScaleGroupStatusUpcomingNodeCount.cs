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
    /// 伸缩组将要创建的节点统计信息
    /// </summary>
    public class ScaleGroupStatusUpcomingNodeCount 
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
            sb.Append("class ScaleGroupStatusUpcomingNodeCount {\n");
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
            return this.Equals(input as ScaleGroupStatusUpcomingNodeCount);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleGroupStatusUpcomingNodeCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostPaid == input.PostPaid ||
                    (this.PostPaid != null &&
                    this.PostPaid.Equals(input.PostPaid))
                ) && 
                (
                    this.PrePaid == input.PrePaid ||
                    (this.PrePaid != null &&
                    this.PrePaid.Equals(input.PrePaid))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.PostPaid != null)
                    hashCode = hashCode * 59 + this.PostPaid.GetHashCode();
                if (this.PrePaid != null)
                    hashCode = hashCode * 59 + this.PrePaid.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
