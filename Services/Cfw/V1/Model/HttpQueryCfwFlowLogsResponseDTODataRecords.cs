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
    public class HttpQueryCfwFlowLogsResponseDTODataRecords 
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
        /// 字节
        /// </summary>
        [JsonProperty("bytes", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bytes { get; set; }

        /// <summary>
        /// 方向，有内到外和外到内两种
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// 包
        /// </summary>
        [JsonProperty("packets", NullValueHandling = NullValueHandling.Ignore)]
        public int? Packets { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? EndTime { get; set; }

        /// <summary>
        /// 文档ID
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
        public string SrcPort { get; set; }

        /// <summary>
        /// 目的IP
        /// </summary>
        [JsonProperty("dst_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DstIp { get; set; }

        /// <summary>
        /// 应用协议
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 目的端口
        /// </summary>
        [JsonProperty("dst_port", NullValueHandling = NullValueHandling.Ignore)]
        public string DstPort { get; set; }

        /// <summary>
        /// 协议类型:TCP为6,UDP为17,ICMP为1,ICMPV6为58,ANY为-1,手动类型不为空，自动类型为空
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HttpQueryCfwFlowLogsResponseDTODataRecords {\n");
            sb.Append("  bytes: ").Append(Bytes).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  packets: ").Append(Packets).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  srcIp: ").Append(SrcIp).Append("\n");
            sb.Append("  srcPort: ").Append(SrcPort).Append("\n");
            sb.Append("  dstIp: ").Append(DstIp).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  dstPort: ").Append(DstPort).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HttpQueryCfwFlowLogsResponseDTODataRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HttpQueryCfwFlowLogsResponseDTODataRecords input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Bytes == input.Bytes ||
                    (this.Bytes != null &&
                    this.Bytes.Equals(input.Bytes))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Packets == input.Packets ||
                    (this.Packets != null &&
                    this.Packets.Equals(input.Packets))
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
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
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
                if (this.Bytes != null)
                    hashCode = hashCode * 59 + this.Bytes.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Packets != null)
                    hashCode = hashCode * 59 + this.Packets.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.SrcIp != null)
                    hashCode = hashCode * 59 + this.SrcIp.GetHashCode();
                if (this.SrcPort != null)
                    hashCode = hashCode * 59 + this.SrcPort.GetHashCode();
                if (this.DstIp != null)
                    hashCode = hashCode * 59 + this.DstIp.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.DstPort != null)
                    hashCode = hashCode * 59 + this.DstPort.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
