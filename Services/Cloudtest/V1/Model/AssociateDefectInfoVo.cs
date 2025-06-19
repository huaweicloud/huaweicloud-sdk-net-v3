using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 关联缺陷信息
    /// </summary>
    public class AssociateDefectInfoVo 
    {

        /// <summary>
        /// 是否已关联
        /// </summary>
        [JsonProperty("associate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Associate { get; set; }

        /// <summary>
        /// 关联缺陷数
        /// </summary>
        [JsonProperty("associate_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? AssociateCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociateDefectInfoVo {\n");
            sb.Append("  associate: ").Append(Associate).Append("\n");
            sb.Append("  associateCount: ").Append(AssociateCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociateDefectInfoVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociateDefectInfoVo input)
        {
            if (input == null) return false;
            if (this.Associate != input.Associate || (this.Associate != null && !this.Associate.Equals(input.Associate))) return false;
            if (this.AssociateCount != input.AssociateCount || (this.AssociateCount != null && !this.AssociateCount.Equals(input.AssociateCount))) return false;

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
                if (this.Associate != null) hashCode = hashCode * 59 + this.Associate.GetHashCode();
                if (this.AssociateCount != null) hashCode = hashCode * 59 + this.AssociateCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
