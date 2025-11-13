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
    /// OTT频道创建消息体
    /// </summary>
    public class CreateOttChannelInfoReq 
    {
        /// <summary>
        /// 频道状态 - ON：频道下发成功后，自动启动拉流、转码、录制等功能 - OFF：仅保存频道信息，不启动频道
        /// </summary>
        /// <value>频道状态 - ON：频道下发成功后，自动启动拉流、转码、录制等功能 - OFF：仅保存频道信息，不启动频道</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum ON for value: ON
            /// </summary>
            public static readonly StateEnum ON = new StateEnum("ON");

            /// <summary>
            /// Enum OFF for value: OFF
            /// </summary>
            public static readonly StateEnum OFF = new StateEnum("OFF");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "ON", ON },
                { "OFF", OFF },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 频道模式 ADD_CDN：一站式服务，源站和CDN绑在一起（默认） ONLY_OS：独立源站服务，CDN和源站解耦
        /// </summary>
        /// <value>频道模式 ADD_CDN：一站式服务，源站和CDN绑在一起（默认） ONLY_OS：独立源站服务，CDN和源站解耦</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum ADD_CDN for value: ADD_CDN
            /// </summary>
            public static readonly ModeEnum ADD_CDN = new ModeEnum("ADD_CDN");

            /// <summary>
            /// Enum ONLY_OS for value: ONLY_OS
            /// </summary>
            public static readonly ModeEnum ONLY_OS = new ModeEnum("ONLY_OS");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "ADD_CDN", ADD_CDN },
                { "ONLY_OS", ONLY_OS },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 频道推流域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 组名或应用名
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 频道ID。频道唯一标识，为必填项。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 频道名。可选配置
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 频道状态 - ON：频道下发成功后，自动启动拉流、转码、录制等功能 - OFF：仅保存频道信息，不启动频道
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// 频道模式 ADD_CDN：一站式服务，源站和CDN绑在一起（默认） ONLY_OS：独立源站服务，CDN和源站解耦
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 当mode是ONLY_OS时，该字段生效，表示频道所在Region
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public InputStreamInfo Input { get; set; }

        /// <summary>
        /// 转码模板配置
        /// </summary>
        [JsonProperty("encoder_settings", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModifyOttChannelEncoderSettingsEncoderSettings> EncoderSettings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("record_settings", NullValueHandling = NullValueHandling.Ignore)]
        public CreateOttChannelInfoReqRecordSettings RecordSettings { get; set; }

        /// <summary>
        /// 频道出流信息
        /// </summary>
        [JsonProperty("endpoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<EndpointItem> Endpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("encoder_settings_expand", NullValueHandling = NullValueHandling.Ignore)]
        public EncoderSettingsExpand EncoderSettingsExpand { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOttChannelInfoReq {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  encoderSettings: ").Append(EncoderSettings).Append("\n");
            sb.Append("  recordSettings: ").Append(RecordSettings).Append("\n");
            sb.Append("  endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  encoderSettingsExpand: ").Append(EncoderSettingsExpand).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateOttChannelInfoReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateOttChannelInfoReq input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.State != input.State) return false;
            if (this.Mode != input.Mode) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Input != input.Input || (this.Input != null && !this.Input.Equals(input.Input))) return false;
            if (this.EncoderSettings != input.EncoderSettings || (this.EncoderSettings != null && input.EncoderSettings != null && !this.EncoderSettings.SequenceEqual(input.EncoderSettings))) return false;
            if (this.RecordSettings != input.RecordSettings || (this.RecordSettings != null && !this.RecordSettings.Equals(input.RecordSettings))) return false;
            if (this.Endpoints != input.Endpoints || (this.Endpoints != null && input.Endpoints != null && !this.Endpoints.SequenceEqual(input.Endpoints))) return false;
            if (this.EncoderSettingsExpand != input.EncoderSettingsExpand || (this.EncoderSettingsExpand != null && !this.EncoderSettingsExpand.Equals(input.EncoderSettingsExpand))) return false;

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
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.EncoderSettings != null) hashCode = hashCode * 59 + this.EncoderSettings.GetHashCode();
                if (this.RecordSettings != null) hashCode = hashCode * 59 + this.RecordSettings.GetHashCode();
                if (this.Endpoints != null) hashCode = hashCode * 59 + this.Endpoints.GetHashCode();
                if (this.EncoderSettingsExpand != null) hashCode = hashCode * 59 + this.EncoderSettingsExpand.GetHashCode();
                return hashCode;
            }
        }
    }
}
