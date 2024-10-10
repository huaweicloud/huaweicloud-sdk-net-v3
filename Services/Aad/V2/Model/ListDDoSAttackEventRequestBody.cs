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
    public class ListDDoSAttackEventRequestBody 
    {

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
        /// 偏移量
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 限制条数，范围1-100
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 高防ip
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// 攻击流量最小值
        /// </summary>
        [JsonProperty("attack_flow_low", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackFlowLow { get; set; }

        /// <summary>
        /// 攻击流量最大值
        /// </summary>
        [JsonProperty("attack_flow_up", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackFlowUp { get; set; }

        /// <summary>
        /// 攻击状态：attack-攻击; normal-结束攻击
        /// </summary>
        [JsonProperty("attack_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDDoSAttackEventRequestBody {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  attackFlowLow: ").Append(AttackFlowLow).Append("\n");
            sb.Append("  attackFlowUp: ").Append(AttackFlowUp).Append("\n");
            sb.Append("  attackStatus: ").Append(AttackStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDDoSAttackEventRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDDoSAttackEventRequestBody input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.AttackFlowLow == input.AttackFlowLow ||
                    (this.AttackFlowLow != null &&
                    this.AttackFlowLow.Equals(input.AttackFlowLow))
                ) && 
                (
                    this.AttackFlowUp == input.AttackFlowUp ||
                    (this.AttackFlowUp != null &&
                    this.AttackFlowUp.Equals(input.AttackFlowUp))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.AttackFlowLow != null)
                    hashCode = hashCode * 59 + this.AttackFlowLow.GetHashCode();
                if (this.AttackFlowUp != null)
                    hashCode = hashCode * 59 + this.AttackFlowUp.GetHashCode();
                if (this.AttackStatus != null)
                    hashCode = hashCode * 59 + this.AttackStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
