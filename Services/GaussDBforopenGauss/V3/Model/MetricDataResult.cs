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
    /// 
    /// </summary>
    public class MetricDataResult 
    {
        /// <summary>
        /// **参数解释** 指标类型 **取值范围** - INSTANCE：实例类型。 - NODE：节点类型。 - COMPONENT：组件类型。 
        /// </summary>
        /// <value>**参数解释** 指标类型 **取值范围** - INSTANCE：实例类型。 - NODE：节点类型。 - COMPONENT：组件类型。 </value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum INSTANCE for value: INSTANCE
            /// </summary>
            public static readonly TypeEnum INSTANCE = new TypeEnum("INSTANCE");

            /// <summary>
            /// Enum NODE for value: NODE
            /// </summary>
            public static readonly TypeEnum NODE = new TypeEnum("NODE");

            /// <summary>
            /// Enum COMPONENT for value: COMPONENT
            /// </summary>
            public static readonly TypeEnum COMPONENT = new TypeEnum("COMPONENT");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "INSTANCE", INSTANCE },
                { "NODE", NODE },
                { "COMPONENT", COMPONENT },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 指标ID。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public string Metric { get; set; }

        /// <summary>
        /// **参数解释** 指标类型 **取值范围** - INSTANCE：实例类型。 - NODE：节点类型。 - COMPONENT：组件类型。 
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释**: 指标单位。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// **参数解释**: 指标维度及指标值。
        /// </summary>
        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<DatapointResult> Datapoints { get; set; }

        /// <summary>
        /// **参数解释**: 时间戳，例如1699495140000。
        /// </summary>
        [JsonProperty("timestamps", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Timestamps { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetricDataResult {\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("  timestamps: ").Append(Timestamps).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetricDataResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetricDataResult input)
        {
            if (input == null) return false;
            if (this.Metric != input.Metric || (this.Metric != null && !this.Metric.Equals(input.Metric))) return false;
            if (this.Type != input.Type) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Datapoints != input.Datapoints || (this.Datapoints != null && input.Datapoints != null && !this.Datapoints.SequenceEqual(input.Datapoints))) return false;
            if (this.Timestamps != input.Timestamps || (this.Timestamps != null && input.Timestamps != null && !this.Timestamps.SequenceEqual(input.Timestamps))) return false;

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
                if (this.Metric != null) hashCode = hashCode * 59 + this.Metric.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Datapoints != null) hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                if (this.Timestamps != null) hashCode = hashCode * 59 + this.Timestamps.GetHashCode();
                return hashCode;
            }
        }
    }
}
