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
    public class HttpQueryCfwAttackLogsResponseDTODataRecords 
    {
        /// <summary>
        /// 方向，有内到外和外到内两种
        /// </summary>
        /// <value>方向，有内到外和外到内两种</value>
        [JsonConverter(typeof(EnumClassConverter<DirectionEnum>))]
        public class DirectionEnum
        {
            /// <summary>
            /// Enum OUT2IN for value: out2in
            /// </summary>
            public static readonly DirectionEnum OUT2IN = new DirectionEnum("out2in");

            /// <summary>
            /// Enum IN2OUT for value: in2out
            /// </summary>
            public static readonly DirectionEnum IN2OUT = new DirectionEnum("in2out");

            private static readonly Dictionary<string, DirectionEnum> StaticFields =
            new Dictionary<string, DirectionEnum>()
            {
                { "out2in", OUT2IN },
                { "in2out", IN2OUT },
            };

            private string _value;

            public DirectionEnum()
            {

            }

            public DirectionEnum(string value)
            {
                _value = value;
            }

            public static DirectionEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as DirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DirectionEnum a, DirectionEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(DirectionEnum a, DirectionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 方向，有内到外和外到内两种
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// 动作
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 事件时间
        /// </summary>
        [JsonProperty("event_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EventTime { get; set; }

        /// <summary>
        /// 攻击类型
        /// </summary>
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackType { get; set; }

        /// <summary>
        /// 攻击规则
        /// </summary>
        [JsonProperty("attack_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackRule { get; set; }

        /// <summary>
        /// 威胁等级
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 报文长度
        /// </summary>
        [JsonProperty("packet_length", NullValueHandling = NullValueHandling.Ignore)]
        public long? PacketLength { get; set; }

        /// <summary>
        /// 攻击规则id
        /// </summary>
        [JsonProperty("attack_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttackRuleId { get; set; }

        /// <summary>
        /// 命中时间
        /// </summary>
        [JsonProperty("hit_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? HitTime { get; set; }

        /// <summary>
        /// 日志ID
        /// </summary>
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIp { get; set; }

        /// <summary>
        /// 源端口
        /// </summary>
        [JsonProperty("src_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIp { get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DstPort { get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("packet", NullValueHandling = NullValueHandling.Ignore)]
        public Packet Packet { get; set; }

        /// <summary>
        /// 应用协议
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 攻击报文信息
        /// </summary>
        [JsonProperty("packetMessages", NullValueHandling = NullValueHandling.Ignore)]
        public List<PacketMessage> PacketMessages { get; set; }

        /// <summary>
        /// 目标主机
        /// </summary>
        [JsonProperty("dst_host", NullValueHandling = NullValueHandling.Ignore)]
        public string DstHost { get; set; }

        /// <summary>
        /// 源区域id
        /// </summary>
        [JsonProperty("src_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionId { get; set; }

        /// <summary>
        /// 源区域名称
        /// </summary>
        [JsonProperty("src_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcRegionName { get; set; }

        /// <summary>
        /// 目的区域id
        /// </summary>
        [JsonProperty("dst_region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionId { get; set; }

        /// <summary>
        /// 目的区域名称
        /// </summary>
        [JsonProperty("dst_region_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DstRegionName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpQueryCfwAttackLogsResponseDTODataRecords {\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  eventTime: ").Append(EventTime).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  attackRule: ").Append(AttackRule).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  packetLength: ").Append(PacketLength).Append("\n");
            sb.Append("  attackRuleId: ").Append(AttackRuleId).Append("\n");
            sb.Append("  hitTime: ").Append(HitTime).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  srcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  packet: ").Append(Packet).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  packetMessages: ").Append(PacketMessages).Append("\n");
            sb.Append("  dstHost: ").Append(DstHost).Append("\n");
            sb.Append("  srcRegionId: ").Append(SrcRegionId).Append("\n");
            sb.Append("  srcRegionName: ").Append(SrcRegionName).Append("\n");
            sb.Append("  dstRegionId: ").Append(DstRegionId).Append("\n");
            sb.Append("  dstRegionName: ").Append(DstRegionName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpQueryCfwAttackLogsResponseDTODataRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpQueryCfwAttackLogsResponseDTODataRecords input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.EventTime == input.EventTime ||
                    (this.EventTime != null &&
                    this.EventTime.Equals(input.EventTime))
                ) && 
                (
                    this.AttackType == input.AttackType ||
                    (this.AttackType != null &&
                    this.AttackType.Equals(input.AttackType))
                ) && 
                (
                    this.AttackRule == input.AttackRule ||
                    (this.AttackRule != null &&
                    this.AttackRule.Equals(input.AttackRule))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.PacketLength == input.PacketLength ||
                    (this.PacketLength != null &&
                    this.PacketLength.Equals(input.PacketLength))
                ) && 
                (
                    this.AttackRuleId == input.AttackRuleId ||
                    (this.AttackRuleId != null &&
                    this.AttackRuleId.Equals(input.AttackRuleId))
                ) && 
                (
                    this.HitTime == input.HitTime ||
                    (this.HitTime != null &&
                    this.HitTime.Equals(input.HitTime))
                ) && 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
                (
                    this.SrcIp == input.SrcIp ||
                    (this.SrcIp != null &&
                    this.SrcIp.Equals(input.SrcIp))
                ) && 
                (
                    this.SrcPort == input.SrcPort ||
                    (this.SrcPort != null &&
                    this.SrcPort.Equals(input.SrcPort))
                ) && 
                (
                    this.DstIp == input.DstIp ||
                    (this.DstIp != null &&
                    this.DstIp.Equals(input.DstIp))
                ) && 
                (
                    this.DstPort == input.DstPort ||
                    (this.DstPort != null &&
                    this.DstPort.Equals(input.DstPort))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Packet == input.Packet ||
                    (this.Packet != null &&
                    this.Packet.Equals(input.Packet))
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.PacketMessages == input.PacketMessages ||
                    this.PacketMessages != null &&
                    input.PacketMessages != null &&
                    this.PacketMessages.SequenceEqual(input.PacketMessages)
                ) && 
                (
                    this.DstHost == input.DstHost ||
                    (this.DstHost != null &&
                    this.DstHost.Equals(input.DstHost))
                ) && 
                (
                    this.SrcRegionId == input.SrcRegionId ||
                    (this.SrcRegionId != null &&
                    this.SrcRegionId.Equals(input.SrcRegionId))
                ) && 
                (
                    this.SrcRegionName == input.SrcRegionName ||
                    (this.SrcRegionName != null &&
                    this.SrcRegionName.Equals(input.SrcRegionName))
                ) && 
                (
                    this.DstRegionId == input.DstRegionId ||
                    (this.DstRegionId != null &&
                    this.DstRegionId.Equals(input.DstRegionId))
                ) && 
                (
                    this.DstRegionName == input.DstRegionName ||
                    (this.DstRegionName != null &&
                    this.DstRegionName.Equals(input.DstRegionName))
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
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.EventTime != null)
                    hashCode = hashCode * 59 + this.EventTime.GetHashCode();
                if (this.AttackType != null)
                    hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.AttackRule != null)
                    hashCode = hashCode * 59 + this.AttackRule.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.PacketLength != null)
                    hashCode = hashCode * 59 + this.PacketLength.GetHashCode();
                if (this.AttackRuleId != null)
                    hashCode = hashCode * 59 + this.AttackRuleId.GetHashCode();
                if (this.HitTime != null)
                    hashCode = hashCode * 59 + this.HitTime.GetHashCode();
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.SrcIp != null)
                    hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.SrcPort != null)
                    hashCode = hashCode * 59 + this.SrcPort.GetHashCode();
                if (this.DstIp != null)
                    hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.DstPort != null)
                    hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Packet != null)
                    hashCode = hashCode * 59 + this.Packet.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.PacketMessages != null)
                    hashCode = hashCode * 59 + this.PacketMessages.GetHashCode();
                if (this.DstHost != null)
                    hashCode = hashCode * 59 + this.DstHost.GetHashCode();
                if (this.SrcRegionId != null)
                    hashCode = hashCode * 59 + this.SrcRegionId.GetHashCode();
                if (this.SrcRegionName != null)
                    hashCode = hashCode * 59 + this.SrcRegionName.GetHashCode();
                if (this.DstRegionId != null)
                    hashCode = hashCode * 59 + this.DstRegionId.GetHashCode();
                if (this.DstRegionName != null)
                    hashCode = hashCode * 59 + this.DstRegionName.GetHashCode();
                return hashCode;
            }
        }
    }
}
