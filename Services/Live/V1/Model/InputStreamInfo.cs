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
    /// 频道入流信息
    /// </summary>
    public class InputStreamInfo 
    {
        /// <summary>
        /// 频道入流协议 - FLV_PULL - RTMP_PUSH - HLS_PULL - SRT_PULL - SRT_PUSH
        /// </summary>
        /// <value>频道入流协议 - FLV_PULL - RTMP_PUSH - HLS_PULL - SRT_PULL - SRT_PUSH</value>
        [JsonConverter(typeof(EnumClassConverter<InputProtocolEnum>))]
        public class InputProtocolEnum
        {
            /// <summary>
            /// Enum FLV_PULL for value: FLV_PULL
            /// </summary>
            public static readonly InputProtocolEnum FLV_PULL = new InputProtocolEnum("FLV_PULL");

            /// <summary>
            /// Enum RTMP_PUSH for value: RTMP_PUSH
            /// </summary>
            public static readonly InputProtocolEnum RTMP_PUSH = new InputProtocolEnum("RTMP_PUSH");

            /// <summary>
            /// Enum HLS_PULL for value: HLS_PULL
            /// </summary>
            public static readonly InputProtocolEnum HLS_PULL = new InputProtocolEnum("HLS_PULL");

            /// <summary>
            /// Enum SRT_PULL for value: SRT_PULL
            /// </summary>
            public static readonly InputProtocolEnum SRT_PULL = new InputProtocolEnum("SRT_PULL");

            /// <summary>
            /// Enum SRT_PUSH for value: SRT_PUSH
            /// </summary>
            public static readonly InputProtocolEnum SRT_PUSH = new InputProtocolEnum("SRT_PUSH");

            private static readonly Dictionary<string, InputProtocolEnum> StaticFields =
            new Dictionary<string, InputProtocolEnum>()
            {
                { "FLV_PULL", FLV_PULL },
                { "RTMP_PUSH", RTMP_PUSH },
                { "HLS_PULL", HLS_PULL },
                { "SRT_PULL", SRT_PULL },
                { "SRT_PUSH", SRT_PUSH },
            };

            private string _value;

            public InputProtocolEnum()
            {

            }

            public InputProtocolEnum(string value)
            {
                _value = value;
            }

            public static InputProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as InputProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InputProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InputProtocolEnum a, InputProtocolEnum b)
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

            public static bool operator !=(InputProtocolEnum a, InputProtocolEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 频道入流协议 - FLV_PULL - RTMP_PUSH - HLS_PULL - SRT_PULL - SRT_PUSH
        /// </summary>
        [JsonProperty("input_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public InputProtocolEnum InputProtocol { get; set; }
        /// <summary>
        /// 频道主源流信息。入流协议为RTMP_PUSH和SRT_PUSH时，非必填项。其他情况下，均为必填项。
        /// </summary>
        [JsonProperty("sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SourcesInfo> Sources { get; set; }

        /// <summary>
        /// 备入流数组，非必填项。如果有备入流，则主备入流必须保证路数、codec和分辨率均一致。入流协议为RTMP_PUSH时，无需填写。
        /// </summary>
        [JsonProperty("secondary_sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<SecondarySourcesInfo> SecondarySources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("failover_conditions", NullValueHandling = NullValueHandling.Ignore)]
        public FailoverConditions FailoverConditions { get; set; }

        /// <summary>
        /// 当入流协议为HLS_PULL时，需要配置的最大带宽。  用户提供的拉流URL中，针对不同码率的音视频，均会携带带宽参数“BANDWIDTH”。 - 如果这里配置最大带宽，媒体直播服务从URL拉流时，会选择小于最大带宽且码率最大的音视频流，推流到源站。 - 如果这里未配置最大带宽，媒体直播服务从URL拉流时，会默认选择“BANDWIDTH”最高的音视频流，推流到源站。
        /// </summary>
        [JsonProperty("max_bandwidth_limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBandwidthLimit { get; set; }

        /// <summary>
        /// 当推流协议为SRT_PUSH时，如果配置了直推源站，编码器不支持输入streamid，需要打开设置为true
        /// </summary>
        [JsonProperty("ip_port_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IpPortMode { get; set; }

        /// <summary>
        /// SRT_PUSH类型时，客户push ip白名单
        /// </summary>
        [JsonProperty("ip_whitelist", NullValueHandling = NullValueHandling.Ignore)]
        public string IpWhitelist { get; set; }

        /// <summary>
        /// 广告的scte35信号源。  仅HLS_PULL类型的频道支持此配置，且目前仅支持SEGMENTS。
        /// </summary>
        [JsonProperty("scte35_source", NullValueHandling = NullValueHandling.Ignore)]
        public string Scte35Source { get; set; }

        /// <summary>
        /// 广告触发器配置。  包含如下取值： - Splice insert：拼接插入 - Provider advertisement：提供商广告 - Distributor advertisement：分销商广告 - Provider placement opportunity：提供商置放机会 - Distributor placement opportunity：分销商置放机会
        /// </summary>
        [JsonProperty("ad_triggers", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AdTriggers { get; set; }

        /// <summary>
        /// 设置音频选择器，最多设置8个音频选择器
        /// </summary>
        [JsonProperty("audio_selectors", NullValueHandling = NullValueHandling.Ignore)]
        public List<InputAudioSelector> AudioSelectors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InputStreamInfo {\n");
            sb.Append("  inputProtocol: ").Append(InputProtocol).Append("\n");
            sb.Append("  sources: ").Append(Sources).Append("\n");
            sb.Append("  secondarySources: ").Append(SecondarySources).Append("\n");
            sb.Append("  failoverConditions: ").Append(FailoverConditions).Append("\n");
            sb.Append("  maxBandwidthLimit: ").Append(MaxBandwidthLimit).Append("\n");
            sb.Append("  ipPortMode: ").Append(IpPortMode).Append("\n");
            sb.Append("  ipWhitelist: ").Append(IpWhitelist).Append("\n");
            sb.Append("  scte35Source: ").Append(Scte35Source).Append("\n");
            sb.Append("  adTriggers: ").Append(AdTriggers).Append("\n");
            sb.Append("  audioSelectors: ").Append(AudioSelectors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InputStreamInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InputStreamInfo input)
        {
            if (input == null) return false;
            if (this.InputProtocol != input.InputProtocol) return false;
            if (this.Sources != input.Sources || (this.Sources != null && input.Sources != null && !this.Sources.SequenceEqual(input.Sources))) return false;
            if (this.SecondarySources != input.SecondarySources || (this.SecondarySources != null && input.SecondarySources != null && !this.SecondarySources.SequenceEqual(input.SecondarySources))) return false;
            if (this.FailoverConditions != input.FailoverConditions || (this.FailoverConditions != null && !this.FailoverConditions.Equals(input.FailoverConditions))) return false;
            if (this.MaxBandwidthLimit != input.MaxBandwidthLimit || (this.MaxBandwidthLimit != null && !this.MaxBandwidthLimit.Equals(input.MaxBandwidthLimit))) return false;
            if (this.IpPortMode != input.IpPortMode || (this.IpPortMode != null && !this.IpPortMode.Equals(input.IpPortMode))) return false;
            if (this.IpWhitelist != input.IpWhitelist || (this.IpWhitelist != null && !this.IpWhitelist.Equals(input.IpWhitelist))) return false;
            if (this.Scte35Source != input.Scte35Source || (this.Scte35Source != null && !this.Scte35Source.Equals(input.Scte35Source))) return false;
            if (this.AdTriggers != input.AdTriggers || (this.AdTriggers != null && input.AdTriggers != null && !this.AdTriggers.SequenceEqual(input.AdTriggers))) return false;
            if (this.AudioSelectors != input.AudioSelectors || (this.AudioSelectors != null && input.AudioSelectors != null && !this.AudioSelectors.SequenceEqual(input.AudioSelectors))) return false;

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
                hashCode = hashCode * 59 + this.InputProtocol.GetHashCode();
                if (this.Sources != null) hashCode = hashCode * 59 + this.Sources.GetHashCode();
                if (this.SecondarySources != null) hashCode = hashCode * 59 + this.SecondarySources.GetHashCode();
                if (this.FailoverConditions != null) hashCode = hashCode * 59 + this.FailoverConditions.GetHashCode();
                if (this.MaxBandwidthLimit != null) hashCode = hashCode * 59 + this.MaxBandwidthLimit.GetHashCode();
                if (this.IpPortMode != null) hashCode = hashCode * 59 + this.IpPortMode.GetHashCode();
                if (this.IpWhitelist != null) hashCode = hashCode * 59 + this.IpWhitelist.GetHashCode();
                if (this.Scte35Source != null) hashCode = hashCode * 59 + this.Scte35Source.GetHashCode();
                if (this.AdTriggers != null) hashCode = hashCode * 59 + this.AdTriggers.GetHashCode();
                if (this.AudioSelectors != null) hashCode = hashCode * 59 + this.AudioSelectors.GetHashCode();
                return hashCode;
            }
        }
    }
}
