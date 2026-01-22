using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowConfigQuotaDto 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("item_info", NullValueHandling = NullValueHandling.Ignore)]
        public ItemInfo ItemInfo { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙成员最大配额 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("max_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxQuota { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙成员配额类型 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("quota_type", NullValueHandling = NullValueHandling.Ignore)]
        public string QuotaType { get; set; }

        /// <summary>
        /// **参数解释**： 已使用配额 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("used_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowConfigQuotaDto {\n");
            sb.Append("  itemInfo: ").Append(ItemInfo).Append("\n");
            sb.Append("  maxQuota: ").Append(MaxQuota).Append("\n");
            sb.Append("  quotaType: ").Append(QuotaType).Append("\n");
            sb.Append("  usedQuota: ").Append(UsedQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowConfigQuotaDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowConfigQuotaDto input)
        {
            if (input == null) return false;
            if (this.ItemInfo != input.ItemInfo || (this.ItemInfo != null && !this.ItemInfo.Equals(input.ItemInfo))) return false;
            if (this.MaxQuota != input.MaxQuota || (this.MaxQuota != null && !this.MaxQuota.Equals(input.MaxQuota))) return false;
            if (this.QuotaType != input.QuotaType || (this.QuotaType != null && !this.QuotaType.Equals(input.QuotaType))) return false;
            if (this.UsedQuota != input.UsedQuota || (this.UsedQuota != null && !this.UsedQuota.Equals(input.UsedQuota))) return false;

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
                if (this.ItemInfo != null) hashCode = hashCode * 59 + this.ItemInfo.GetHashCode();
                if (this.MaxQuota != null) hashCode = hashCode * 59 + this.MaxQuota.GetHashCode();
                if (this.QuotaType != null) hashCode = hashCode * 59 + this.QuotaType.GetHashCode();
                if (this.UsedQuota != null) hashCode = hashCode * 59 + this.UsedQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
