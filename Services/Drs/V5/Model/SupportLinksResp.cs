using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 查询可用链路信息响应体
    /// </summary>
    public class SupportLinksResp 
    {

        /// <summary>
        /// **参数解释**：  列表中的项目总数，与分页无关。表示满足查询条件的记录总数量，用于分页计算。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// **参数解释**：  DRS支持的数据复制链路列表，每条链路包含引擎类型、网络类型、迁移模式等组合信息。  **约束限制**：  不涉及。  **取值范围**：  不涉及。  **默认取值**：  不涉及
        /// </summary>
        [JsonProperty("support_links", NullValueHandling = NullValueHandling.Ignore)]
        public List<SupportLinkInfo> SupportLinks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SupportLinksResp {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  supportLinks: ").Append(SupportLinks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SupportLinksResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SupportLinksResp input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.SupportLinks != input.SupportLinks || (this.SupportLinks != null && input.SupportLinks != null && !this.SupportLinks.SequenceEqual(input.SupportLinks))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.SupportLinks != null) hashCode = hashCode * 59 + this.SupportLinks.GetHashCode();
                return hashCode;
            }
        }
    }
}
