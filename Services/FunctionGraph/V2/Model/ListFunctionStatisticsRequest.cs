using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListFunctionStatisticsRequest 
    {
        /// <summary>
        /// 获取最近多少分钟内函数执行的指标。
        /// </summary>
        /// <value>获取最近多少分钟内函数执行的指标。</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodEnum>))]
        public class PeriodEnum
        {
            /// <summary>
            /// Enum _5 for value: 5
            /// </summary>
            public static readonly PeriodEnum _5 = new PeriodEnum("5");

            /// <summary>
            /// Enum _15 for value: 15
            /// </summary>
            public static readonly PeriodEnum _15 = new PeriodEnum("15");

            /// <summary>
            /// Enum _60 for value: 60
            /// </summary>
            public static readonly PeriodEnum _60 = new PeriodEnum("60");

            private static readonly Dictionary<string, PeriodEnum> StaticFields =
            new Dictionary<string, PeriodEnum>()
            {
                { "5", _5 },
                { "15", _15 },
                { "60", _60 },
            };

            private string Value;

            public PeriodEnum(string value)
            {
                Value = value;
            }

            public static PeriodEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as PeriodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PeriodEnum a, PeriodEnum b)
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

            public static bool operator !=(PeriodEnum a, PeriodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 函数的URN（Uniform Resource Name），唯一标识函数。
        /// </summary>
        [SDKProperty("func_urn", IsPath = true)]
        [JsonProperty("func_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string FuncUrn { get; set; }

        /// <summary>
        /// 获取最近多少分钟内函数执行的指标。
        /// </summary>
        [SDKProperty("period", IsPath = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodEnum Period { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFunctionStatisticsRequest {\n");
            sb.Append("  funcUrn: ").Append(FuncUrn).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFunctionStatisticsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFunctionStatisticsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FuncUrn == input.FuncUrn ||
                    (this.FuncUrn != null &&
                    this.FuncUrn.Equals(input.FuncUrn))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
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
                if (this.FuncUrn != null)
                    hashCode = hashCode * 59 + this.FuncUrn.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                return hashCode;
            }
        }
    }
}
