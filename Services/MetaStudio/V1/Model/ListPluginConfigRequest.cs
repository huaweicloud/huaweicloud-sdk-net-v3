using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPluginConfigRequest 
    {
        /// <summary>
        /// 插件供应商  * BOCHA:博查  * AMAP_WEATHER：高德天气
        /// </summary>
        /// <value>插件供应商  * BOCHA:博查  * AMAP_WEATHER：高德天气</value>
        [JsonConverter(typeof(EnumClassConverter<PluginProviderEnum>))]
        public class PluginProviderEnum
        {
            /// <summary>
            /// Enum BOCHA for value: BOCHA
            /// </summary>
            public static readonly PluginProviderEnum BOCHA = new PluginProviderEnum("BOCHA");

            /// <summary>
            /// Enum AMAP_WEATHER for value: AMAP_WEATHER
            /// </summary>
            public static readonly PluginProviderEnum AMAP_WEATHER = new PluginProviderEnum("AMAP_WEATHER");

            private static readonly Dictionary<string, PluginProviderEnum> StaticFields =
            new Dictionary<string, PluginProviderEnum>()
            {
                { "BOCHA", BOCHA },
                { "AMAP_WEATHER", AMAP_WEATHER },
            };

            private string _value;

            public PluginProviderEnum()
            {

            }

            public PluginProviderEnum(string value)
            {
                _value = value;
            }

            public static PluginProviderEnum FromValue(string value)
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

                if (this.Equals(obj as PluginProviderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PluginProviderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PluginProviderEnum a, PluginProviderEnum b)
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

            public static bool operator !=(PluginProviderEnum a, PluginProviderEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 插件类型  * WEATHER_QUERY：天气查询  * WEB_SEARCH：网络搜索
        /// </summary>
        /// <value>插件类型  * WEATHER_QUERY：天气查询  * WEB_SEARCH：网络搜索</value>
        [JsonConverter(typeof(EnumClassConverter<PluginTypeEnum>))]
        public class PluginTypeEnum
        {
            /// <summary>
            /// Enum WEATHER_QUERY for value: WEATHER_QUERY
            /// </summary>
            public static readonly PluginTypeEnum WEATHER_QUERY = new PluginTypeEnum("WEATHER_QUERY");

            /// <summary>
            /// Enum WEB_SEARCH for value: WEB_SEARCH
            /// </summary>
            public static readonly PluginTypeEnum WEB_SEARCH = new PluginTypeEnum("WEB_SEARCH");

            private static readonly Dictionary<string, PluginTypeEnum> StaticFields =
            new Dictionary<string, PluginTypeEnum>()
            {
                { "WEATHER_QUERY", WEATHER_QUERY },
                { "WEB_SEARCH", WEB_SEARCH },
            };

            private string _value;

            public PluginTypeEnum()
            {

            }

            public PluginTypeEnum(string value)
            {
                _value = value;
            }

            public static PluginTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PluginTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PluginTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PluginTypeEnum a, PluginTypeEnum b)
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

            public static bool operator !=(PluginTypeEnum a, PluginTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 使用AK/SK方式认证时必选，携带的鉴权信息。
        /// </summary>
        [SDKProperty("Authorization", IsHeader = true)]
        [JsonProperty("Authorization", NullValueHandling = NullValueHandling.Ignore)]
        public string Authorization { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，请求的发生时间。
        /// </summary>
        [SDKProperty("X-Sdk-Date", IsHeader = true)]
        [JsonProperty("X-Sdk-Date", NullValueHandling = NullValueHandling.Ignore)]
        public string XSdkDate { get; set; }

        /// <summary>
        /// 使用AK/SK方式认证时必选，携带项目ID信息。
        /// </summary>
        [SDKProperty("X-Project-Id", IsHeader = true)]
        [JsonProperty("X-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XProjectId { get; set; }

        /// <summary>
        /// 第三方用户ID。不允许输入中文。
        /// </summary>
        [SDKProperty("X-App-UserId", IsHeader = true)]
        [JsonProperty("X-App-UserId", NullValueHandling = NullValueHandling.Ignore)]
        public string XAppUserId { get; set; }

        /// <summary>
        /// 偏移量，表示从此偏移量开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页显示的条目数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 插件供应商  * BOCHA:博查  * AMAP_WEATHER：高德天气
        /// </summary>
        [SDKProperty("plugin_provider", IsQuery = true)]
        [JsonProperty("plugin_provider", NullValueHandling = NullValueHandling.Ignore)]
        public PluginProviderEnum PluginProvider { get; set; }
        /// <summary>
        /// 插件类型  * WEATHER_QUERY：天气查询  * WEB_SEARCH：网络搜索
        /// </summary>
        [SDKProperty("plugin_type", IsQuery = true)]
        [JsonProperty("plugin_type", NullValueHandling = NullValueHandling.Ignore)]
        public PluginTypeEnum PluginType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPluginConfigRequest {\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  xSdkDate: ").Append(XSdkDate).Append("\n");
            sb.Append("  xProjectId: ").Append(XProjectId).Append("\n");
            sb.Append("  xAppUserId: ").Append(XAppUserId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  pluginProvider: ").Append(PluginProvider).Append("\n");
            sb.Append("  pluginType: ").Append(PluginType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPluginConfigRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPluginConfigRequest input)
        {
            if (input == null) return false;
            if (this.Authorization != input.Authorization || (this.Authorization != null && !this.Authorization.Equals(input.Authorization))) return false;
            if (this.XSdkDate != input.XSdkDate || (this.XSdkDate != null && !this.XSdkDate.Equals(input.XSdkDate))) return false;
            if (this.XProjectId != input.XProjectId || (this.XProjectId != null && !this.XProjectId.Equals(input.XProjectId))) return false;
            if (this.XAppUserId != input.XAppUserId || (this.XAppUserId != null && !this.XAppUserId.Equals(input.XAppUserId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.PluginProvider != input.PluginProvider) return false;
            if (this.PluginType != input.PluginType) return false;

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
                if (this.Authorization != null) hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.XSdkDate != null) hashCode = hashCode * 59 + this.XSdkDate.GetHashCode();
                if (this.XProjectId != null) hashCode = hashCode * 59 + this.XProjectId.GetHashCode();
                if (this.XAppUserId != null) hashCode = hashCode * 59 + this.XAppUserId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.PluginProvider.GetHashCode();
                hashCode = hashCode * 59 + this.PluginType.GetHashCode();
                return hashCode;
            }
        }
    }
}
