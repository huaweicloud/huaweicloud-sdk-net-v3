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
    public class FirewallReport 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("attack_info", NullValueHandling = NullValueHandling.Ignore)]
        public AttackReport AttackInfo { get; set; }

        /// <summary>
        /// **参数解释**： 报告类型 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("internet_firewall", NullValueHandling = NullValueHandling.Ignore)]
        public InternetReport InternetFirewall { get; set; }

        /// <summary>
        /// **参数解释**： 发送时间 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("send_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? SendTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("statistic_period", NullValueHandling = NullValueHandling.Ignore)]
        public StatisticPeriod StatisticPeriod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vpc_firewall", NullValueHandling = NullValueHandling.Ignore)]
        public VpcReport VpcFirewall { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FirewallReport {\n");
            sb.Append("  attackInfo: ").Append(AttackInfo).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  internetFirewall: ").Append(InternetFirewall).Append("\n");
            sb.Append("  sendTime: ").Append(SendTime).Append("\n");
            sb.Append("  statisticPeriod: ").Append(StatisticPeriod).Append("\n");
            sb.Append("  vpcFirewall: ").Append(VpcFirewall).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FirewallReport);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FirewallReport input)
        {
            if (input == null) return false;
            if (this.AttackInfo != input.AttackInfo || (this.AttackInfo != null && !this.AttackInfo.Equals(input.AttackInfo))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.InternetFirewall != input.InternetFirewall || (this.InternetFirewall != null && !this.InternetFirewall.Equals(input.InternetFirewall))) return false;
            if (this.SendTime != input.SendTime || (this.SendTime != null && !this.SendTime.Equals(input.SendTime))) return false;
            if (this.StatisticPeriod != input.StatisticPeriod || (this.StatisticPeriod != null && !this.StatisticPeriod.Equals(input.StatisticPeriod))) return false;
            if (this.VpcFirewall != input.VpcFirewall || (this.VpcFirewall != null && !this.VpcFirewall.Equals(input.VpcFirewall))) return false;

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
                if (this.AttackInfo != null) hashCode = hashCode * 59 + this.AttackInfo.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.InternetFirewall != null) hashCode = hashCode * 59 + this.InternetFirewall.GetHashCode();
                if (this.SendTime != null) hashCode = hashCode * 59 + this.SendTime.GetHashCode();
                if (this.StatisticPeriod != null) hashCode = hashCode * 59 + this.StatisticPeriod.GetHashCode();
                if (this.VpcFirewall != null) hashCode = hashCode * 59 + this.VpcFirewall.GetHashCode();
                return hashCode;
            }
        }
    }
}
