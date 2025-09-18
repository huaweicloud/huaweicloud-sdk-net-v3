using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ModifyFlowOutputResponse : SdkResponse
    {
        /// <summary>
        /// 输出状态，ENABLED：启用，DISABLED：禁用
        /// </summary>
        /// <value>输出状态，ENABLED：启用，DISABLED：禁用</value>
        [JsonConverter(typeof(EnumClassConverter<OutputStatusEnum>))]
        public class OutputStatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly OutputStatusEnum ENABLED = new OutputStatusEnum("ENABLED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly OutputStatusEnum DISABLED = new OutputStatusEnum("DISABLED");

            private static readonly Dictionary<string, OutputStatusEnum> StaticFields =
            new Dictionary<string, OutputStatusEnum>()
            {
                { "ENABLED", ENABLED },
                { "DISABLED", DISABLED },
            };

            private string _value;

            public OutputStatusEnum()
            {

            }

            public OutputStatusEnum(string value)
            {
                _value = value;
            }

            public static OutputStatusEnum FromValue(string value)
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

                if (this.Equals(obj as OutputStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OutputStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OutputStatusEnum a, OutputStatusEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OutputStatusEnum a, OutputStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 协议，srt-caller，srt-listener
        /// </summary>
        /// <value>协议，srt-caller，srt-listener</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum SRT_LISTENER for value: srt-listener
            /// </summary>
            public static readonly ProtocolEnum SRT_LISTENER = new ProtocolEnum("srt-listener");

            /// <summary>
            /// Enum SRT_CALLER for value: srt-caller
            /// </summary>
            public static readonly ProtocolEnum SRT_CALLER = new ProtocolEnum("srt-caller");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "srt-listener", SRT_LISTENER },
                { "srt-caller", SRT_CALLER },
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
                if (ReferenceEquals(a, b))
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
        /// 转推流状态，CONNECTED：转推中，DISCONNECTED：转推中断
        /// </summary>
        /// <value>转推流状态，CONNECTED：转推中，DISCONNECTED：转推中断</value>
        [JsonConverter(typeof(EnumClassConverter<HealthStatusEnum>))]
        public class HealthStatusEnum
        {
            /// <summary>
            /// Enum DISCONNECTED for value: DISCONNECTED
            /// </summary>
            public static readonly HealthStatusEnum DISCONNECTED = new HealthStatusEnum("DISCONNECTED");

            /// <summary>
            /// Enum CONNECTED for value: CONNECTED
            /// </summary>
            public static readonly HealthStatusEnum CONNECTED = new HealthStatusEnum("CONNECTED");

            private static readonly Dictionary<string, HealthStatusEnum> StaticFields =
            new Dictionary<string, HealthStatusEnum>()
            {
                { "DISCONNECTED", DISCONNECTED },
                { "CONNECTED", CONNECTED },
            };

            private string _value;

            public HealthStatusEnum()
            {

            }

            public HealthStatusEnum(string value)
            {
                _value = value;
            }

            public static HealthStatusEnum FromValue(string value)
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

                if (this.Equals(obj as HealthStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HealthStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HealthStatusEnum a, HealthStatusEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(HealthStatusEnum a, HealthStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// ip白名单，最大20条ip白名单
        /// </summary>
        [JsonProperty("cidr_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CidrWhitelist { get; set; }

        /// <summary>
        /// 推流地址，支持ip和域名，最大值64
        /// </summary>
        [JsonProperty("destination", NullValueHandling = NullValueHandling.Ignore)]
        public string Destination { get; set; }

        /// <summary>
        /// output名称，有效字符：大小写字母，数字，中划线，下划线;且只能以字母开头
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encryption", NullValueHandling = NullValueHandling.Ignore)]
        public FlowSourceDecryption Encryption { get; set; }

        /// <summary>
        /// 输出状态，ENABLED：启用，DISABLED：禁用
        /// </summary>
        [JsonProperty("output_status", NullValueHandling = NullValueHandling.Ignore)]
        public OutputStatusEnum OutputStatus { get; set; }
        /// <summary>
        /// srt-listener模式，监听地址，不支持修改
        /// </summary>
        [JsonProperty("listener_address", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerAddress { get; set; }

        /// <summary>
        /// 端口，如果ssrt-listener为监听端口，那么srt-caller为对端端口
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 协议，srt-caller，srt-listener
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// srt-caller模式支持设置streamid
        /// </summary>
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }

        /// <summary>
        /// 输出描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 最小时延，单位毫秒，默认值2000，最小值10，最大值15000
        /// </summary>
        [JsonProperty("min_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinLatency { get; set; }

        /// <summary>
        /// 转推流状态，CONNECTED：转推中，DISCONNECTED：转推中断
        /// </summary>
        [JsonProperty("health_status", NullValueHandling = NullValueHandling.Ignore)]
        public HealthStatusEnum HealthStatus { get; set; }
        /// <summary>
        /// 输出类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyFlowOutputResponse {\n");
            sb.Append("  cidrWhitelist: ").Append(CidrWhitelist).Append("\n");
            sb.Append("  destination: ").Append(Destination).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  encryption: ").Append(Encryption).Append("\n");
            sb.Append("  outputStatus: ").Append(OutputStatus).Append("\n");
            sb.Append("  listenerAddress: ").Append(ListenerAddress).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  minLatency: ").Append(MinLatency).Append("\n");
            sb.Append("  healthStatus: ").Append(HealthStatus).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyFlowOutputResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyFlowOutputResponse input)
        {
            if (input == null) return false;
            if (this.CidrWhitelist != input.CidrWhitelist || (this.CidrWhitelist != null && input.CidrWhitelist != null && !this.CidrWhitelist.SequenceEqual(input.CidrWhitelist))) return false;
            if (this.Destination != input.Destination || (this.Destination != null && !this.Destination.Equals(input.Destination))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Encryption != input.Encryption || (this.Encryption != null && !this.Encryption.Equals(input.Encryption))) return false;
            if (this.OutputStatus != input.OutputStatus) return false;
            if (this.ListenerAddress != input.ListenerAddress || (this.ListenerAddress != null && !this.ListenerAddress.Equals(input.ListenerAddress))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Protocol != input.Protocol) return false;
            if (this.StreamId != input.StreamId || (this.StreamId != null && !this.StreamId.Equals(input.StreamId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.MinLatency != input.MinLatency || (this.MinLatency != null && !this.MinLatency.Equals(input.MinLatency))) return false;
            if (this.HealthStatus != input.HealthStatus) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;

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
                if (this.CidrWhitelist != null) hashCode = hashCode * 59 + this.CidrWhitelist.GetHashCode();
                if (this.Destination != null) hashCode = hashCode * 59 + this.Destination.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Encryption != null) hashCode = hashCode * 59 + this.Encryption.GetHashCode();
                hashCode = hashCode * 59 + this.OutputStatus.GetHashCode();
                if (this.ListenerAddress != null) hashCode = hashCode * 59 + this.ListenerAddress.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.StreamId != null) hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MinLatency != null) hashCode = hashCode * 59 + this.MinLatency.GetHashCode();
                hashCode = hashCode * 59 + this.HealthStatus.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
