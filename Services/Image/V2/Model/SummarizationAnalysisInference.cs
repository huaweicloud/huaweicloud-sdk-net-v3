using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Image.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SummarizationAnalysisInference 
    {
        /// <summary>
        /// 输出类型，不填摘要片段和集锦都输出。填summary只输出集锦；填fragment只输出片段。
        /// </summary>
        /// <value>输出类型，不填摘要片段和集锦都输出。填summary只输出集锦；填fragment只输出片段。</value>
        [JsonConverter(typeof(EnumClassConverter<OutcomeTypeEnum>))]
        public class OutcomeTypeEnum
        {
            /// <summary>
            /// Enum FRAGMENT for value: fragment
            /// </summary>
            public static readonly OutcomeTypeEnum FRAGMENT = new OutcomeTypeEnum("fragment");

            /// <summary>
            /// Enum SUMMARY for value: summary
            /// </summary>
            public static readonly OutcomeTypeEnum SUMMARY = new OutcomeTypeEnum("summary");

            private static readonly Dictionary<string, OutcomeTypeEnum> StaticFields =
            new Dictionary<string, OutcomeTypeEnum>()
            {
                { "fragment", FRAGMENT },
                { "summary", SUMMARY },
            };

            private string _value;

            public OutcomeTypeEnum()
            {

            }

            public OutcomeTypeEnum(string value)
            {
                _value = value;
            }

            public static OutcomeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OutcomeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OutcomeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OutcomeTypeEnum a, OutcomeTypeEnum b)
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

            public static bool operator !=(OutcomeTypeEnum a, OutcomeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 摘要片段输出总时长
        /// </summary>
        [JsonProperty("output_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? OutputDuration { get; set; }

        /// <summary>
        /// 输出类型，不填摘要片段和集锦都输出。填summary只输出集锦；填fragment只输出片段。
        /// </summary>
        [JsonProperty("outcome_type", NullValueHandling = NullValueHandling.Ignore)]
        public OutcomeTypeEnum OutcomeType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SummarizationAnalysisInference {\n");
            sb.Append("  outputDuration: ").Append(OutputDuration).Append("\n");
            sb.Append("  outcomeType: ").Append(OutcomeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SummarizationAnalysisInference);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SummarizationAnalysisInference input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OutputDuration == input.OutputDuration ||
                    (this.OutputDuration != null &&
                    this.OutputDuration.Equals(input.OutputDuration))
                ) && 
                (
                    this.OutcomeType == input.OutcomeType ||
                    (this.OutcomeType != null &&
                    this.OutcomeType.Equals(input.OutcomeType))
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
                if (this.OutputDuration != null)
                    hashCode = hashCode * 59 + this.OutputDuration.GetHashCode();
                if (this.OutcomeType != null)
                    hashCode = hashCode * 59 + this.OutcomeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
