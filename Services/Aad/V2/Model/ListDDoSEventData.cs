using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListDDoSEventData 
    {

        /// <summary>
        /// 防护IP
        /// </summary>
        [JsonProperty("zone_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneIp { get; set; }

        /// <summary>
        /// 开始时间（毫秒时间戳）
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间（毫秒时间戳）
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 攻击流量峰值，单位“kbps”
        /// </summary>
        [JsonProperty("max_drop_kbps", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxDropKbps { get; set; }

        /// <summary>
        /// 攻击报文数峰值，单位“pps”
        /// </summary>
        [JsonProperty("max_drop_pps", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxDropPps { get; set; }

        /// <summary>
        /// 入流量峰值，单位“kbps”
        /// </summary>
        [JsonProperty("max_in_kbps", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxInKbps { get; set; }

        /// <summary>
        /// 入报文数峰值，单位“pps”
        /// </summary>
        [JsonProperty("max_in_pps", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxInPps { get; set; }

        /// <summary>
        /// 攻击类型
        /// </summary>
        [JsonProperty("attack_types", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackTypes { get; set; }

        /// <summary>
        /// 攻击源IP
        /// </summary>
        [JsonProperty("attack_ips", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackIps { get; set; }

        /// <summary>
        /// 攻击IP描述
        /// </summary>
        [JsonProperty("attack_ips_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackIpsDesc { get; set; }

        /// <summary>
        /// 攻击状态
        /// </summary>
        [JsonProperty("attack_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDDoSEventData {\n");
            sb.Append("  zoneIp: ").Append(ZoneIp).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  maxDropKbps: ").Append(MaxDropKbps).Append("\n");
            sb.Append("  maxDropPps: ").Append(MaxDropPps).Append("\n");
            sb.Append("  maxInKbps: ").Append(MaxInKbps).Append("\n");
            sb.Append("  maxInPps: ").Append(MaxInPps).Append("\n");
            sb.Append("  attackTypes: ").Append(AttackTypes).Append("\n");
            sb.Append("  attackIps: ").Append(AttackIps).Append("\n");
            sb.Append("  attackIpsDesc: ").Append(AttackIpsDesc).Append("\n");
            sb.Append("  attackStatus: ").Append(AttackStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDDoSEventData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDDoSEventData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ZoneIp == input.ZoneIp ||
                    (this.ZoneIp != null &&
                    this.ZoneIp.Equals(input.ZoneIp))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.MaxDropKbps == input.MaxDropKbps ||
                    (this.MaxDropKbps != null &&
                    this.MaxDropKbps.Equals(input.MaxDropKbps))
                ) && 
                (
                    this.MaxDropPps == input.MaxDropPps ||
                    (this.MaxDropPps != null &&
                    this.MaxDropPps.Equals(input.MaxDropPps))
                ) && 
                (
                    this.MaxInKbps == input.MaxInKbps ||
                    (this.MaxInKbps != null &&
                    this.MaxInKbps.Equals(input.MaxInKbps))
                ) && 
                (
                    this.MaxInPps == input.MaxInPps ||
                    (this.MaxInPps != null &&
                    this.MaxInPps.Equals(input.MaxInPps))
                ) && 
                (
                    this.AttackTypes == input.AttackTypes ||
                    (this.AttackTypes != null &&
                    this.AttackTypes.Equals(input.AttackTypes))
                ) && 
                (
                    this.AttackIps == input.AttackIps ||
                    (this.AttackIps != null &&
                    this.AttackIps.Equals(input.AttackIps))
                ) && 
                (
                    this.AttackIpsDesc == input.AttackIpsDesc ||
                    (this.AttackIpsDesc != null &&
                    this.AttackIpsDesc.Equals(input.AttackIpsDesc))
                ) && 
                (
                    this.AttackStatus == input.AttackStatus ||
                    (this.AttackStatus != null &&
                    this.AttackStatus.Equals(input.AttackStatus))
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
                if (this.ZoneIp != null)
                    hashCode = hashCode * 59 + this.ZoneIp.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.MaxDropKbps != null)
                    hashCode = hashCode * 59 + this.MaxDropKbps.GetHashCode();
                if (this.MaxDropPps != null)
                    hashCode = hashCode * 59 + this.MaxDropPps.GetHashCode();
                if (this.MaxInKbps != null)
                    hashCode = hashCode * 59 + this.MaxInKbps.GetHashCode();
                if (this.MaxInPps != null)
                    hashCode = hashCode * 59 + this.MaxInPps.GetHashCode();
                if (this.AttackTypes != null)
                    hashCode = hashCode * 59 + this.AttackTypes.GetHashCode();
                if (this.AttackIps != null)
                    hashCode = hashCode * 59 + this.AttackIps.GetHashCode();
                if (this.AttackIpsDesc != null)
                    hashCode = hashCode * 59 + this.AttackIpsDesc.GetHashCode();
                if (this.AttackStatus != null)
                    hashCode = hashCode * 59 + this.AttackStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
