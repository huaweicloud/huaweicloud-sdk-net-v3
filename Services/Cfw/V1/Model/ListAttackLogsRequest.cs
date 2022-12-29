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
    /// Request Object
    /// </summary>
    public class ListAttackLogsRequest 
    {
        /// <summary>
        /// 协议类型:TCP为6, UDP为17,ICMP为1,ICMPV6为58,ANY为-1,手动类型不为空，自动类型为空
        /// </summary>
        /// <value>协议类型:TCP为6, UDP为17,ICMP为1,ICMPV6为58,ANY为-1,手动类型不为空，自动类型为空</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum _6 for value: 6
            /// </summary>
            public static readonly ProtocolEnum _6 = new ProtocolEnum("6");

            /// <summary>
            /// Enum _17 for value: 17
            /// </summary>
            public static readonly ProtocolEnum _17 = new ProtocolEnum("17");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly ProtocolEnum _1 = new ProtocolEnum("1");

            /// <summary>
            /// Enum _58 for value: 58
            /// </summary>
            public static readonly ProtocolEnum _58 = new ProtocolEnum("58");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "6", _6 },
                { "17", _17 },
                { "1", _1 },
                { "58", _58 },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 动作0：permit,1：deny
        /// </summary>
        /// <value>动作0：permit,1：deny</value>
        [JsonConverter(typeof(EnumClassConverter<ActionEnum>))]
        public class ActionEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly ActionEnum _0 = new ActionEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly ActionEnum _1 = new ActionEnum("1");

            private static readonly Dictionary<string, ActionEnum> StaticFields =
            new Dictionary<string, ActionEnum>()
            {
                { "0", _0 },
                { "1", _1 },
            };

            private string _value;

            public ActionEnum()
            {

            }

            public ActionEnum(string value)
            {
                _value = value;
            }

            public static ActionEnum FromValue(string value)
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

                if (this.Equals(obj as ActionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActionEnum a, ActionEnum b)
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

            public static bool operator !=(ActionEnum a, ActionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 方向0：外到内1：内到外
        /// </summary>
        /// <value>方向0：外到内1：内到外</value>
        [JsonConverter(typeof(EnumClassConverter<DirectionEnum>))]
        public class DirectionEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly DirectionEnum _0 = new DirectionEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly DirectionEnum _1 = new DirectionEnum("1");

            private static readonly Dictionary<string, DirectionEnum> StaticFields =
            new Dictionary<string, DirectionEnum>()
            {
                { "0", _0 },
                { "1", _1 },
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
        /// 开始时间
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 源IP
        /// </summary>
        [SDKProperty("src_ip", IsQuery = true)]
        [JsonProperty("src_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string SrcIp { get; set; }

        /// <summary>
        /// 源端口号
        /// </summary>
        [SDKProperty("src_port", IsQuery = true)]
        [JsonProperty("src_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [SDKProperty("dst_ip", IsQuery = true)]
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIp { get; set; }

        /// <summary>
        /// 目的端口号
        /// </summary>
        [SDKProperty("dst_port", IsQuery = true)]
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? DstPort { get; set; }

        /// <summary>
        /// 协议类型:TCP为6, UDP为17,ICMP为1,ICMPV6为58,ANY为-1,手动类型不为空，自动类型为空
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 应用协议
        /// </summary>
        [SDKProperty("app", IsQuery = true)]
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 日志ID，当是第一页时为空，不是第一页时不为空
        /// </summary>
        [SDKProperty("log_id", IsQuery = true)]
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// 下个日期，当是第一页时为空，不是第一页时不为空
        /// </summary>
        [SDKProperty("next_date", IsQuery = true)]
        [JsonProperty("next_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? NextDate { get; set; }

        /// <summary>
        /// 偏移量：指定返回记录的开始位置，必须为数字，取值范围为大于或等于0，默认0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示个数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 防火墙实例id，创建云防火墙后用于标志防火墙由系统自动生成的标志id，可通过调用查询防火墙实例接口获得。具体可参考APIExlorer和帮助中心FAQ。
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 动作0：permit,1：deny
        /// </summary>
        [SDKProperty("action", IsQuery = true)]
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// 方向0：外到内1：内到外
        /// </summary>
        [SDKProperty("direction", IsQuery = true)]
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// 入侵事件类型
        /// </summary>
        [SDKProperty("attack_type", IsQuery = true)]
        [JsonProperty("attack_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackType { get; set; }

        /// <summary>
        /// 入侵事件规则
        /// </summary>
        [SDKProperty("attack_rule", IsQuery = true)]
        [JsonProperty("attack_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string AttackRule { get; set; }

        /// <summary>
        /// 威胁等级
        /// </summary>
        [SDKProperty("level", IsQuery = true)]
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public string Level { get; set; }

        /// <summary>
        /// 判断来源
        /// </summary>
        [SDKProperty("source", IsQuery = true)]
        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public string Source { get; set; }

        /// <summary>
        /// 企业项目id，用户支持企业项目后，由企业项目生成的id。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAttackLogsRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  srcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  nextDate: ").Append(NextDate).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  attackType: ").Append(AttackType).Append("\n");
            sb.Append("  attackRule: ").Append(AttackRule).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  source: ").Append(Source).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAttackLogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAttackLogsRequest input)
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
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
                (
                    this.NextDate == input.NextDate ||
                    (this.NextDate != null &&
                    this.NextDate.Equals(input.NextDate))
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
                    this.FwInstanceId == input.FwInstanceId ||
                    (this.FwInstanceId != null &&
                    this.FwInstanceId.Equals(input.FwInstanceId))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
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
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.NextDate != null)
                    hashCode = hashCode * 59 + this.NextDate.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.FwInstanceId != null)
                    hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.AttackType != null)
                    hashCode = hashCode * 59 + this.AttackType.GetHashCode();
                if (this.AttackRule != null)
                    hashCode = hashCode * 59 + this.AttackRule.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
