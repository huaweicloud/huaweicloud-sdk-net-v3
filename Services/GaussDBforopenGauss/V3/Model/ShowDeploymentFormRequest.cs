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
    public class ShowDeploymentFormRequest 
    {
        /// <summary>
        /// 解决方案模板名称。
        /// </summary>
        /// <value>解决方案模板名称。</value>
        [JsonConverter(typeof(EnumClassConverter<SolutionEnum>))]
        public class SolutionEnum
        {
            /// <summary>
            /// Enum TRISET for value: triset
            /// </summary>
            public static readonly SolutionEnum TRISET = new SolutionEnum("triset");

            /// <summary>
            /// Enum SINGLE for value: single
            /// </summary>
            public static readonly SolutionEnum SINGLE = new SolutionEnum("single");

            private static readonly Dictionary<string, SolutionEnum> StaticFields =
            new Dictionary<string, SolutionEnum>()
            {
                { "triset", TRISET },
                { "single", SINGLE },
            };

            private string _value;

            public SolutionEnum()
            {

            }

            public SolutionEnum(string value)
            {
                _value = value;
            }

            public static SolutionEnum FromValue(string value)
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

                if (this.Equals(obj as SolutionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SolutionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SolutionEnum a, SolutionEnum b)
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

            public static bool operator !=(SolutionEnum a, SolutionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语言。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 解决方案模板名称。
        /// </summary>
        [SDKProperty("solution", IsQuery = true)]
        [JsonProperty("solution", NullValueHandling = NullValueHandling.Ignore)]
        public SolutionEnum Solution { get; set; }
        /// <summary>
        /// 实例ID。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDeploymentFormRequest {\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  solution: ").Append(Solution).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDeploymentFormRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDeploymentFormRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XLanguage == input.XLanguage ||
                    (this.XLanguage != null &&
                    this.XLanguage.Equals(input.XLanguage))
                ) && 
                (
                    this.Solution == input.Solution ||
                    (this.Solution != null &&
                    this.Solution.Equals(input.Solution))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
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
                if (this.XLanguage != null)
                    hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                if (this.Solution != null)
                    hashCode = hashCode * 59 + this.Solution.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
