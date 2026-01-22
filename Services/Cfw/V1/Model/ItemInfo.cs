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
    public class ItemInfo 
    {

        /// <summary>
        /// **参数解释**： 最大配额 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("max_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxQuota { get; set; }

        /// <summary>
        /// **参数解释**： 已使用配额 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("used_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsedQuota { get; set; }

        /// <summary>
        /// **参数解释**： 额外参数，ACL和网络域名使用 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("extras_info", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExtrasInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemInfo {\n");
            sb.Append("  maxQuota: ").Append(MaxQuota).Append("\n");
            sb.Append("  usedQuota: ").Append(UsedQuota).Append("\n");
            sb.Append("  extrasInfo: ").Append(ExtrasInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItemInfo input)
        {
            if (input == null) return false;
            if (this.MaxQuota != input.MaxQuota || (this.MaxQuota != null && !this.MaxQuota.Equals(input.MaxQuota))) return false;
            if (this.UsedQuota != input.UsedQuota || (this.UsedQuota != null && !this.UsedQuota.Equals(input.UsedQuota))) return false;
            if (this.ExtrasInfo != input.ExtrasInfo || (this.ExtrasInfo != null && input.ExtrasInfo != null && !this.ExtrasInfo.SequenceEqual(input.ExtrasInfo))) return false;

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
                if (this.MaxQuota != null) hashCode = hashCode * 59 + this.MaxQuota.GetHashCode();
                if (this.UsedQuota != null) hashCode = hashCode * 59 + this.UsedQuota.GetHashCode();
                if (this.ExtrasInfo != null) hashCode = hashCode * 59 + this.ExtrasInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
