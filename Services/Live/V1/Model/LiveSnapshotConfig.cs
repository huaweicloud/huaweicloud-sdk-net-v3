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
    /// 
    /// </summary>
    public class LiveSnapshotConfig 
    {
        /// <summary>
        /// 是否启用回调通知 - on：启用。 - off：不启用。
        /// </summary>
        /// <value>是否启用回调通知 - on：启用。 - off：不启用。</value>
        [JsonConverter(typeof(EnumClassConverter<CallBackEnableEnum>))]
        public class CallBackEnableEnum
        {
            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly CallBackEnableEnum ON = new CallBackEnableEnum("on");

            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly CallBackEnableEnum OFF = new CallBackEnableEnum("off");

            private static readonly Dictionary<string, CallBackEnableEnum> StaticFields =
            new Dictionary<string, CallBackEnableEnum>()
            {
                { "on", ON },
                { "off", OFF },
            };

            private string _value;

            public CallBackEnableEnum()
            {

            }

            public CallBackEnableEnum(string value)
            {
                _value = value;
            }

            public static CallBackEnableEnum FromValue(string value)
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

                if (this.Equals(obj as CallBackEnableEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CallBackEnableEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CallBackEnableEnum a, CallBackEnableEnum b)
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

            public static bool operator !=(CallBackEnableEnum a, CallBackEnableEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 截图存储文件访问协议， 仅支持http、https格式
        /// </summary>
        /// <value>截图存储文件访问协议， 仅支持http、https格式</value>
        [JsonConverter(typeof(EnumClassConverter<ImageAccessProtocolEnum>))]
        public class ImageAccessProtocolEnum
        {
            /// <summary>
            /// Enum HTTP for value: http
            /// </summary>
            public static readonly ImageAccessProtocolEnum HTTP = new ImageAccessProtocolEnum("http");

            /// <summary>
            /// Enum HTTPS for value: https
            /// </summary>
            public static readonly ImageAccessProtocolEnum HTTPS = new ImageAccessProtocolEnum("https");

            private static readonly Dictionary<string, ImageAccessProtocolEnum> StaticFields =
            new Dictionary<string, ImageAccessProtocolEnum>()
            {
                { "http", HTTP },
                { "https", HTTPS },
            };

            private string _value;

            public ImageAccessProtocolEnum()
            {

            }

            public ImageAccessProtocolEnum(string value)
            {
                _value = value;
            }

            public static ImageAccessProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ImageAccessProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ImageAccessProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ImageAccessProtocolEnum a, ImageAccessProtocolEnum b)
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

            public static bool operator !=(ImageAccessProtocolEnum a, ImageAccessProtocolEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 直播推流域名
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 回调鉴权密钥值  长度范围：[32-128]  若需要使用回调鉴权功能，请配置鉴权密钥，否则，留空即可。
        /// </summary>
        [JsonProperty("auth_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthKey { get; set; }

        /// <summary>
        /// 截图频率  取值范围：[5-3600]  单位：秒
        /// </summary>
        [JsonProperty("time_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeInterval { get; set; }

        /// <summary>
        /// 在OBS桶存储截图的方式：  - 0：实时截图，以时间戳命名截图文件，保存所有截图文件到OBS桶。例：snapshot/{domain}/{app_name}/{stream_name}/{UnixTimestamp}.jpg  - 1：覆盖截图，只保存最新的截图文件，新的截图会覆盖原来的截图文件。例：snapshot/{domain}/{app_name}/{stream_name}.jpg
        /// </summary>
        [JsonProperty("object_write_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ObjectWriteMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("obs_location", NullValueHandling = NullValueHandling.Ignore)]
        public ObsFileAddr ObsLocation { get; set; }

        /// <summary>
        /// 是否启用回调通知 - on：启用。 - off：不启用。
        /// </summary>
        [JsonProperty("call_back_enable", NullValueHandling = NullValueHandling.Ignore)]
        public CallBackEnableEnum CallBackEnable { get; set; }
        /// <summary>
        /// 通知服务器地址，必须是合法的URL且携带协议，协议支持http和https。截图完成后直播服务会向此地址推送截图状态信息。
        /// </summary>
        [JsonProperty("call_back_url", NullValueHandling = NullValueHandling.Ignore)]
        public string CallBackUrl { get; set; }

        /// <summary>
        /// 截图存储文件命名规则， 仅支持jpg格式 包含 - &#39;{obs_object}&#39; OBS存储路径，即obs_location.object的值  - &#39;{domain}&#39; 域名 - &#39;{app}&#39; 应用名 - &#39;{stream}&#39;  流名  其中实时截图模式下  - &#39;{unix_time}&#39;  时间戳，秒 - &#39;{unix_time_milli}&#39;  时间戳，毫秒 - &#39;{fmt_time_utc}&#39;   格式化UTC时间, 格式：YYYYMMDDhhmmss, 如20060102070405 - &#39;{fmt_time_local}&#39;  格式化本地时间, 格式：YYYYMMDDhhmmss，如20060102150405 必选一个时间类型模板
        /// </summary>
        [JsonProperty("image_object_format", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageObjectFormat { get; set; }

        /// <summary>
        /// 截图存储文件访问协议， 仅支持http、https格式
        /// </summary>
        [JsonProperty("image_access_protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ImageAccessProtocolEnum ImageAccessProtocol { get; set; }
        /// <summary>
        /// 截图存储文件访问域名
        /// </summary>
        [JsonProperty("image_access_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageAccessDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LiveSnapshotConfig {\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  authKey: ").Append(AuthKey).Append("\n");
            sb.Append("  timeInterval: ").Append(TimeInterval).Append("\n");
            sb.Append("  objectWriteMode: ").Append(ObjectWriteMode).Append("\n");
            sb.Append("  obsLocation: ").Append(ObsLocation).Append("\n");
            sb.Append("  callBackEnable: ").Append(CallBackEnable).Append("\n");
            sb.Append("  callBackUrl: ").Append(CallBackUrl).Append("\n");
            sb.Append("  imageObjectFormat: ").Append(ImageObjectFormat).Append("\n");
            sb.Append("  imageAccessProtocol: ").Append(ImageAccessProtocol).Append("\n");
            sb.Append("  imageAccessDomain: ").Append(ImageAccessDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LiveSnapshotConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LiveSnapshotConfig input)
        {
            if (input == null) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AuthKey != input.AuthKey || (this.AuthKey != null && !this.AuthKey.Equals(input.AuthKey))) return false;
            if (this.TimeInterval != input.TimeInterval || (this.TimeInterval != null && !this.TimeInterval.Equals(input.TimeInterval))) return false;
            if (this.ObjectWriteMode != input.ObjectWriteMode || (this.ObjectWriteMode != null && !this.ObjectWriteMode.Equals(input.ObjectWriteMode))) return false;
            if (this.ObsLocation != input.ObsLocation || (this.ObsLocation != null && !this.ObsLocation.Equals(input.ObsLocation))) return false;
            if (this.CallBackEnable != input.CallBackEnable) return false;
            if (this.CallBackUrl != input.CallBackUrl || (this.CallBackUrl != null && !this.CallBackUrl.Equals(input.CallBackUrl))) return false;
            if (this.ImageObjectFormat != input.ImageObjectFormat || (this.ImageObjectFormat != null && !this.ImageObjectFormat.Equals(input.ImageObjectFormat))) return false;
            if (this.ImageAccessProtocol != input.ImageAccessProtocol) return false;
            if (this.ImageAccessDomain != input.ImageAccessDomain || (this.ImageAccessDomain != null && !this.ImageAccessDomain.Equals(input.ImageAccessDomain))) return false;

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
                if (this.AuthKey != null) hashCode = hashCode * 59 + this.AuthKey.GetHashCode();
                if (this.TimeInterval != null) hashCode = hashCode * 59 + this.TimeInterval.GetHashCode();
                if (this.ObjectWriteMode != null) hashCode = hashCode * 59 + this.ObjectWriteMode.GetHashCode();
                if (this.ObsLocation != null) hashCode = hashCode * 59 + this.ObsLocation.GetHashCode();
                hashCode = hashCode * 59 + this.CallBackEnable.GetHashCode();
                if (this.CallBackUrl != null) hashCode = hashCode * 59 + this.CallBackUrl.GetHashCode();
                if (this.ImageObjectFormat != null) hashCode = hashCode * 59 + this.ImageObjectFormat.GetHashCode();
                hashCode = hashCode * 59 + this.ImageAccessProtocol.GetHashCode();
                if (this.ImageAccessDomain != null) hashCode = hashCode * 59 + this.ImageAccessDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
