using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class GetFeatureStatusV5Request 
    {
        /// <summary>
        /// 功能特征的唯一名称。
        /// </summary>
        /// <value>功能特征的唯一名称。</value>
        [JsonConverter(typeof(EnumClassConverter<FeatureNameEnum>))]
        public class FeatureNameEnum
        {
            /// <summary>
            /// Enum V5_CONSOLE for value: v5_console
            /// </summary>
            public static readonly FeatureNameEnum V5_CONSOLE = new FeatureNameEnum("v5_console");

            /// <summary>
            /// Enum ACCESS_ANALYZER for value: access_analyzer
            /// </summary>
            public static readonly FeatureNameEnum ACCESS_ANALYZER = new FeatureNameEnum("access_analyzer");

            private static readonly Dictionary<string, FeatureNameEnum> StaticFields =
            new Dictionary<string, FeatureNameEnum>()
            {
                { "v5_console", V5_CONSOLE },
                { "access_analyzer", ACCESS_ANALYZER },
            };

            private string _value;

            public FeatureNameEnum()
            {

            }

            public FeatureNameEnum(string value)
            {
                _value = value;
            }

            public static FeatureNameEnum FromValue(string value)
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

                if (this.Equals(obj as FeatureNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FeatureNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FeatureNameEnum a, FeatureNameEnum b)
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

            public static bool operator !=(FeatureNameEnum a, FeatureNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能特征的唯一名称。
        /// </summary>
        [SDKProperty("feature_name", IsPath = true)]
        [JsonProperty("feature_name", NullValueHandling = NullValueHandling.Ignore)]
        public FeatureNameEnum FeatureName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFeatureStatusV5Request {\n");
            sb.Append("  featureName: ").Append(FeatureName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetFeatureStatusV5Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetFeatureStatusV5Request input)
        {
            if (input == null) return false;
            if (this.FeatureName != input.FeatureName) return false;

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
                hashCode = hashCode * 59 + this.FeatureName.GetHashCode();
                return hashCode;
            }
        }
    }
}
