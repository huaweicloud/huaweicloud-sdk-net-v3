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
    /// 入流信息
    /// </summary>
    public class FlowSource 
    {
        /// <summary>
        /// 协议，srt-caller，srt-listener
        /// </summary>
        /// <value>协议，srt-caller，srt-listener</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum SRT_CALLER for value: srt-caller
            /// </summary>
            public static readonly ProtocolEnum SRT_CALLER = new ProtocolEnum("srt-caller");

            /// <summary>
            /// Enum SRT_LISTENER for value: srt-listener
            /// </summary>
            public static readonly ProtocolEnum SRT_LISTENER = new ProtocolEnum("srt-listener");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "srt-caller", SRT_CALLER },
                { "srt-listener", SRT_LISTENER },
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
        /// 拉流地址
        /// </summary>
        [JsonProperty("source_listener_address", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceListenerAddress { get; set; }

        /// <summary>
        /// 拉流端口，2077/2088不可选
        /// </summary>
        [JsonProperty("source_listener_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceListenerPort { get; set; }

        /// <summary>
        /// srt拉流streamid
        /// </summary>
        [JsonProperty("stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamId { get; set; }

        /// <summary>
        /// 最小时延，单位ms
        /// </summary>
        [JsonProperty("min_latency", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinLatency { get; set; }

        /// <summary>
        /// 推流CIDR IP白名单列表
        /// </summary>
        [JsonProperty("cidr_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CidrWhitelist { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 协议，srt-caller，srt-listener
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 入流资源名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("decryption", NullValueHandling = NullValueHandling.Ignore)]
        public FlowSourceDecryption Decryption { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlowSource {\n");
            sb.Append("  sourceListenerAddress: ").Append(SourceListenerAddress).Append("\n");
            sb.Append("  sourceListenerPort: ").Append(SourceListenerPort).Append("\n");
            sb.Append("  streamId: ").Append(StreamId).Append("\n");
            sb.Append("  minLatency: ").Append(MinLatency).Append("\n");
            sb.Append("  cidrWhitelist: ").Append(CidrWhitelist).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  decryption: ").Append(Decryption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlowSource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlowSource input)
        {
            if (input == null) return false;
            if (this.SourceListenerAddress != input.SourceListenerAddress || (this.SourceListenerAddress != null && !this.SourceListenerAddress.Equals(input.SourceListenerAddress))) return false;
            if (this.SourceListenerPort != input.SourceListenerPort || (this.SourceListenerPort != null && !this.SourceListenerPort.Equals(input.SourceListenerPort))) return false;
            if (this.StreamId != input.StreamId || (this.StreamId != null && !this.StreamId.Equals(input.StreamId))) return false;
            if (this.MinLatency != input.MinLatency || (this.MinLatency != null && !this.MinLatency.Equals(input.MinLatency))) return false;
            if (this.CidrWhitelist != input.CidrWhitelist || (this.CidrWhitelist != null && input.CidrWhitelist != null && !this.CidrWhitelist.SequenceEqual(input.CidrWhitelist))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Protocol != input.Protocol) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Decryption != input.Decryption || (this.Decryption != null && !this.Decryption.Equals(input.Decryption))) return false;

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
                if (this.SourceListenerAddress != null) hashCode = hashCode * 59 + this.SourceListenerAddress.GetHashCode();
                if (this.SourceListenerPort != null) hashCode = hashCode * 59 + this.SourceListenerPort.GetHashCode();
                if (this.StreamId != null) hashCode = hashCode * 59 + this.StreamId.GetHashCode();
                if (this.MinLatency != null) hashCode = hashCode * 59 + this.MinLatency.GetHashCode();
                if (this.CidrWhitelist != null) hashCode = hashCode * 59 + this.CidrWhitelist.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Decryption != null) hashCode = hashCode * 59 + this.Decryption.GetHashCode();
                return hashCode;
            }
        }
    }
}
