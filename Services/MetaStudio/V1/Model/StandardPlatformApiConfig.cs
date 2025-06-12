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
    /// 自定义直播平台回调配置
    /// </summary>
    public class StandardPlatformApiConfig 
    {
        /// <summary>
        /// API类型。 * PRODUCT_QUERY: 查询商品 * LIVE_EVENT_CALLBACK: 直播事件回调
        /// </summary>
        /// <value>API类型。 * PRODUCT_QUERY: 查询商品 * LIVE_EVENT_CALLBACK: 直播事件回调</value>
        [JsonConverter(typeof(EnumClassConverter<ApiTypeEnum>))]
        public class ApiTypeEnum
        {
            /// <summary>
            /// Enum PRODUCT_QUERY for value: PRODUCT_QUERY
            /// </summary>
            public static readonly ApiTypeEnum PRODUCT_QUERY = new ApiTypeEnum("PRODUCT_QUERY");

            /// <summary>
            /// Enum LIVE_EVENT_CALLBACK for value: LIVE_EVENT_CALLBACK
            /// </summary>
            public static readonly ApiTypeEnum LIVE_EVENT_CALLBACK = new ApiTypeEnum("LIVE_EVENT_CALLBACK");

            private static readonly Dictionary<string, ApiTypeEnum> StaticFields =
            new Dictionary<string, ApiTypeEnum>()
            {
                { "PRODUCT_QUERY", PRODUCT_QUERY },
                { "LIVE_EVENT_CALLBACK", LIVE_EVENT_CALLBACK },
            };

            private string _value;

            public ApiTypeEnum()
            {

            }

            public ApiTypeEnum(string value)
            {
                _value = value;
            }

            public static ApiTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ApiTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ApiTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ApiTypeEnum a, ApiTypeEnum b)
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

            public static bool operator !=(ApiTypeEnum a, ApiTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// API类型。 * PRODUCT_QUERY: 查询商品 * LIVE_EVENT_CALLBACK: 直播事件回调
        /// </summary>
        [JsonProperty("api_type", NullValueHandling = NullValueHandling.Ignore)]
        public ApiTypeEnum ApiType { get; set; }
        /// <summary>
        /// URL。仅支持HTTPS形式URL
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StandardPlatformApiConfig {\n");
            sb.Append("  apiType: ").Append(ApiType).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StandardPlatformApiConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StandardPlatformApiConfig input)
        {
            if (input == null) return false;
            if (this.ApiType != input.ApiType) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;

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
                hashCode = hashCode * 59 + this.ApiType.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }
}
