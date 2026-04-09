using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModifyDBPayTypeRequestBody 
    {

        /// <summary>
        /// **参数解释**: 需要转成包周期计费模式的实例ID列表。 **约束限制**: 不涉及。
        /// </summary>
        [JsonProperty("entity_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EntityIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("charge_info", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodChargeInfoOption ChargeInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyDBPayTypeRequestBody {\n");
            sb.Append("  entityIds: ").Append(EntityIds).Append("\n");
            sb.Append("  chargeInfo: ").Append(ChargeInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyDBPayTypeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyDBPayTypeRequestBody input)
        {
            if (input == null) return false;
            if (this.EntityIds != input.EntityIds || (this.EntityIds != null && input.EntityIds != null && !this.EntityIds.SequenceEqual(input.EntityIds))) return false;
            if (this.ChargeInfo != input.ChargeInfo || (this.ChargeInfo != null && !this.ChargeInfo.Equals(input.ChargeInfo))) return false;

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
                if (this.EntityIds != null) hashCode = hashCode * 59 + this.EntityIds.GetHashCode();
                if (this.ChargeInfo != null) hashCode = hashCode * 59 + this.ChargeInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
