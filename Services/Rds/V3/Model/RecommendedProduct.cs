using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 推荐商品信息
    /// </summary>
    public class RecommendedProduct 
    {
        /// <summary>
        /// 推荐级别
        /// </summary>
        /// <value>推荐级别</value>
        [JsonConverter(typeof(EnumClassConverter<RecommendedLevelEnum>))]
        public class RecommendedLevelEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly RecommendedLevelEnum _0 = new RecommendedLevelEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly RecommendedLevelEnum _1 = new RecommendedLevelEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly RecommendedLevelEnum _2 = new RecommendedLevelEnum("2");

            private static readonly Dictionary<string, RecommendedLevelEnum> StaticFields =
            new Dictionary<string, RecommendedLevelEnum>()
            {
                { "0", _0 },
                { "1", _1 },
                { "2", _2 },
            };

            private string _value;

            public RecommendedLevelEnum()
            {

            }

            public RecommendedLevelEnum(string value)
            {
                _value = value;
            }

            public static RecommendedLevelEnum FromValue(string value)
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

                if (this.Equals(obj as RecommendedLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecommendedLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecommendedLevelEnum a, RecommendedLevelEnum b)
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

            public static bool operator !=(RecommendedLevelEnum a, RecommendedLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 应用场景
        /// </summary>
        /// <value>应用场景</value>
        [JsonConverter(typeof(EnumClassConverter<ApplicationScenariosEnum>))]
        public class ApplicationScenariosEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly ApplicationScenariosEnum _0 = new ApplicationScenariosEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly ApplicationScenariosEnum _1 = new ApplicationScenariosEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly ApplicationScenariosEnum _2 = new ApplicationScenariosEnum("2");

            private static readonly Dictionary<string, ApplicationScenariosEnum> StaticFields =
            new Dictionary<string, ApplicationScenariosEnum>()
            {
                { "0", _0 },
                { "1", _1 },
                { "2", _2 },
            };

            private string _value;

            public ApplicationScenariosEnum()
            {

            }

            public ApplicationScenariosEnum(string value)
            {
                _value = value;
            }

            public static ApplicationScenariosEnum FromValue(string value)
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

                if (this.Equals(obj as ApplicationScenariosEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ApplicationScenariosEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ApplicationScenariosEnum a, ApplicationScenariosEnum b)
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

            public static bool operator !=(ApplicationScenariosEnum a, ApplicationScenariosEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 推荐级别
        /// </summary>
        [JsonProperty("recommended_level", NullValueHandling = NullValueHandling.Ignore)]
        public RecommendedLevelEnum RecommendedLevel { get; set; }
        /// <summary>
        /// 应用场景
        /// </summary>
        [JsonProperty("application_scenarios", NullValueHandling = NullValueHandling.Ignore)]
        public ApplicationScenariosEnum ApplicationScenarios { get; set; }
        /// <summary>
        /// 规格信息
        /// </summary>
        [JsonProperty("flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<RecommendFlavor> Flavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecommendedProduct {\n");
            sb.Append("  recommendedLevel: ").Append(RecommendedLevel).Append("\n");
            sb.Append("  applicationScenarios: ").Append(ApplicationScenarios).Append("\n");
            sb.Append("  flavors: ").Append(Flavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecommendedProduct);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecommendedProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecommendedLevel == input.RecommendedLevel ||
                    (this.RecommendedLevel != null &&
                    this.RecommendedLevel.Equals(input.RecommendedLevel))
                ) && 
                (
                    this.ApplicationScenarios == input.ApplicationScenarios ||
                    (this.ApplicationScenarios != null &&
                    this.ApplicationScenarios.Equals(input.ApplicationScenarios))
                ) && 
                (
                    this.Flavors == input.Flavors ||
                    this.Flavors != null &&
                    input.Flavors != null &&
                    this.Flavors.SequenceEqual(input.Flavors)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RecommendedLevel != null)
                    hashCode = hashCode * 59 + this.RecommendedLevel.GetHashCode();
                if (this.ApplicationScenarios != null)
                    hashCode = hashCode * 59 + this.ApplicationScenarios.GetHashCode();
                if (this.Flavors != null)
                    hashCode = hashCode * 59 + this.Flavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
