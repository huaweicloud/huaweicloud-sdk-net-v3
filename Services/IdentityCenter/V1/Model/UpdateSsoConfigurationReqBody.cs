using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// description: the request body of UpdateSsoConfiguration
    /// </summary>
    public class UpdateSsoConfigurationReqBody 
    {
        /// <summary>
        /// 配置类型
        /// </summary>
        /// <value>配置类型</value>
        [JsonConverter(typeof(EnumClassConverter<ConfigurationTypeEnum>))]
        public class ConfigurationTypeEnum
        {
            /// <summary>
            /// Enum APP_AUTHENTICATION_CONFIGURATION for value: APP_AUTHENTICATION_CONFIGURATION
            /// </summary>
            public static readonly ConfigurationTypeEnum APP_AUTHENTICATION_CONFIGURATION = new ConfigurationTypeEnum("APP_AUTHENTICATION_CONFIGURATION");

            /// <summary>
            /// Enum SESSION for value: SESSION
            /// </summary>
            public static readonly ConfigurationTypeEnum SESSION = new ConfigurationTypeEnum("SESSION");

            private static readonly Dictionary<string, ConfigurationTypeEnum> StaticFields =
            new Dictionary<string, ConfigurationTypeEnum>()
            {
                { "APP_AUTHENTICATION_CONFIGURATION", APP_AUTHENTICATION_CONFIGURATION },
                { "SESSION", SESSION },
            };

            private string _value;

            public ConfigurationTypeEnum()
            {

            }

            public ConfigurationTypeEnum(string value)
            {
                _value = value;
            }

            public static ConfigurationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ConfigurationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConfigurationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConfigurationTypeEnum a, ConfigurationTypeEnum b)
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

            public static bool operator !=(ConfigurationTypeEnum a, ConfigurationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sso_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public SSOConfigurationDto SsoConfiguration { get; set; }

        /// <summary>
        /// 配置类型
        /// </summary>
        [JsonProperty("configuration_type", NullValueHandling = NullValueHandling.Ignore)]
        public ConfigurationTypeEnum ConfigurationType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSsoConfigurationReqBody {\n");
            sb.Append("  ssoConfiguration: ").Append(SsoConfiguration).Append("\n");
            sb.Append("  configurationType: ").Append(ConfigurationType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSsoConfigurationReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSsoConfigurationReqBody input)
        {
            if (input == null) return false;
            if (this.SsoConfiguration != input.SsoConfiguration || (this.SsoConfiguration != null && !this.SsoConfiguration.Equals(input.SsoConfiguration))) return false;
            if (this.ConfigurationType != input.ConfigurationType) return false;

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
                if (this.SsoConfiguration != null) hashCode = hashCode * 59 + this.SsoConfiguration.GetHashCode();
                hashCode = hashCode * 59 + this.ConfigurationType.GetHashCode();
                return hashCode;
            }
        }
    }
}
