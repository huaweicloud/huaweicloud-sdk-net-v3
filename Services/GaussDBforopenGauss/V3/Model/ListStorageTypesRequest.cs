using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListStorageTypesRequest 
    {
        /// <summary>
        /// 实例类型： enterprise(企业版)， centralization_standard(主备版)，不区分大小写。
        /// </summary>
        /// <value>实例类型： enterprise(企业版)， centralization_standard(主备版)，不区分大小写。</value>
        [JsonConverter(typeof(EnumClassConverter<HaModeEnum>))]
        public class HaModeEnum
        {
            /// <summary>
            /// Enum ENTERPRISE for value: enterprise
            /// </summary>
            public static readonly HaModeEnum ENTERPRISE = new HaModeEnum("enterprise");

            /// <summary>
            /// Enum CENTRALIZATION_STANDARD for value: centralization_standard
            /// </summary>
            public static readonly HaModeEnum CENTRALIZATION_STANDARD = new HaModeEnum("centralization_standard");

            private static readonly Dictionary<string, HaModeEnum> StaticFields =
            new Dictionary<string, HaModeEnum>()
            {
                { "enterprise", ENTERPRISE },
                { "centralization_standard", CENTRALIZATION_STANDARD },
            };

            private string _value;

            public HaModeEnum()
            {

            }

            public HaModeEnum(string value)
            {
                _value = value;
            }

            public static HaModeEnum FromValue(string value)
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

                if (this.Equals(obj as HaModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HaModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HaModeEnum a, HaModeEnum b)
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

            public static bool operator !=(HaModeEnum a, HaModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 数据库版本号。
        /// </summary>
        [SDKProperty("version", IsQuery = true)]
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 实例类型： enterprise(企业版)， centralization_standard(主备版)，不区分大小写。
        /// </summary>
        [SDKProperty("ha_mode", IsQuery = true)]
        [JsonProperty("ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public HaModeEnum HaMode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListStorageTypesRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  haMode: ").Append(HaMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListStorageTypesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListStorageTypesRequest input)
        {
            if (input == null) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.HaMode != input.HaMode) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                hashCode = hashCode * 59 + this.HaMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
