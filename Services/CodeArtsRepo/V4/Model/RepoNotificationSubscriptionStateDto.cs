using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepoNotificationSubscriptionStateDto 
    {
        /// <summary>
        /// **参数解释：** 配资源。
        /// </summary>
        /// <value>**参数解释：** 配资源。</value>
        [JsonConverter(typeof(EnumClassConverter<ConfigSourceEnum>))]
        public class ConfigSourceEnum
        {
            /// <summary>
            /// Enum REPO for value: repo
            /// </summary>
            public static readonly ConfigSourceEnum REPO = new ConfigSourceEnum("repo");

            /// <summary>
            /// Enum PRODUCT for value: product
            /// </summary>
            public static readonly ConfigSourceEnum PRODUCT = new ConfigSourceEnum("product");

            private static readonly Dictionary<string, ConfigSourceEnum> StaticFields =
            new Dictionary<string, ConfigSourceEnum>()
            {
                { "repo", REPO },
                { "product", PRODUCT },
            };

            private string _value;

            public ConfigSourceEnum()
            {

            }

            public ConfigSourceEnum(string value)
            {
                _value = value;
            }

            public static ConfigSourceEnum FromValue(string value)
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

                if (this.Equals(obj as ConfigSourceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfigSourceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfigSourceEnum a, ConfigSourceEnum b)
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

            public static bool operator !=(ConfigSourceEnum a, ConfigSourceEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 配资源。
        /// </summary>
        [JsonProperty("config_source", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigSourceEnum ConfigSource { get; set; }
        /// <summary>
        /// **参数解释：** 开启通知。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepoNotificationSubscriptionStateDto {\n");
            sb.Append("  configSource: ").Append(ConfigSource).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepoNotificationSubscriptionStateDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepoNotificationSubscriptionStateDto input)
        {
            if (input == null) return false;
            if (this.ConfigSource != input.ConfigSource) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;

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
                hashCode = hashCode * 59 + this.ConfigSource.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
