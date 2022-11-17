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
    public class ListFlowLogsRequest 
    {
        /// <summary>
        /// 日志类型
        /// </summary>
        /// <value>日志类型</value>
        [JsonConverter(typeof(EnumClassConverter<LogTypeEnum>))]
        public class LogTypeEnum
        {
            /// <summary>
            /// Enum INTERNET for value: internet
            /// </summary>
            public static readonly LogTypeEnum INTERNET = new LogTypeEnum("internet");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly LogTypeEnum VPC = new LogTypeEnum("vpc");

            /// <summary>
            /// Enum NAT for value: nat
            /// </summary>
            public static readonly LogTypeEnum NAT = new LogTypeEnum("nat");

            private static readonly Dictionary<string, LogTypeEnum> StaticFields =
            new Dictionary<string, LogTypeEnum>()
            {
                { "internet", INTERNET },
                { "vpc", VPC },
                { "nat", NAT },
            };

            private string Value;

            public LogTypeEnum(string value)
            {
                Value = value;
            }

            public static LogTypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as LogTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(LogTypeEnum a, LogTypeEnum b)
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

            public static bool operator !=(LogTypeEnum a, LogTypeEnum b)
            {
                return !(a == b);
            }
        }

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

            private string Value;

            public ProtocolEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 防火墙实例ID
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 方向
        /// </summary>
        [SDKProperty("direction", IsQuery = true)]
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// 日志类型
        /// </summary>
        [SDKProperty("log_type", IsQuery = true)]
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public LogTypeEnum LogType { get; set; }
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
        /// 源端口
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
        /// 目的端口
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
        /// 文档ID，首页时为null，非首页时不为null
        /// </summary>
        [SDKProperty("log_id", IsQuery = true)]
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// 日期，首页时为null，非首页时不为null
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFlowLogsRequest {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFlowLogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFlowLogsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FwInstanceId == input.FwInstanceId ||
                    (this.FwInstanceId != null &&
                    this.FwInstanceId.Equals(input.FwInstanceId))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.LogType == input.LogType ||
                    (this.LogType != null &&
                    this.LogType.Equals(input.LogType))
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
                if (this.FwInstanceId != null)
                    hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.LogType != null)
                    hashCode = hashCode * 59 + this.LogType.GetHashCode();
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
                return hashCode;
            }
        }
    }
}
