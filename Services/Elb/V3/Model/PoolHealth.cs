using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PoolHealth 
    {

        /// <summary>
        /// **参数解释**：当健康检查在线的member个数小于该个数，判定pool的state为不健康。  **取值范围**： - 0：默认值，不生效。 - 1：全下线转发生效。  [不支持该字段，请勿使用。](tag:hws_eu,hws_eu_wb,hws_test,fcs,dt,hcso_dt,ctc,cmcc,tm,sbc,hk_sbc,hk_tm,hk_vdf,srg,g42,hk_g42)
        /// </summary>
        [JsonProperty("minimum_healthy_member_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinimumHealthyMemberCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolHealth {\n");
            sb.Append("  minimumHealthyMemberCount: ").Append(MinimumHealthyMemberCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolHealth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolHealth input)
        {
            if (input == null) return false;
            if (this.MinimumHealthyMemberCount != input.MinimumHealthyMemberCount || (this.MinimumHealthyMemberCount != null && !this.MinimumHealthyMemberCount.Equals(input.MinimumHealthyMemberCount))) return false;

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
                if (this.MinimumHealthyMemberCount != null) hashCode = hashCode * 59 + this.MinimumHealthyMemberCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
