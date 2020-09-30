using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowMetricDataRequest 
    {
        /// <summary>
        /// Defines filter
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<FilterEnum>))]
        public class FilterEnum
        {
            /// <summary>
            /// Enum MAX for value: max
            /// </summary>
            public static readonly FilterEnum MAX = new FilterEnum("max");

            /// <summary>
            /// Enum MIN for value: min
            /// </summary>
            public static readonly FilterEnum MIN = new FilterEnum("min");

            /// <summary>
            /// Enum AVERAGE for value: average
            /// </summary>
            public static readonly FilterEnum AVERAGE = new FilterEnum("average");

            /// <summary>
            /// Enum SUM for value: sum
            /// </summary>
            public static readonly FilterEnum SUM = new FilterEnum("sum");

            /// <summary>
            /// Enum VARIANCE for value: variance
            /// </summary>
            public static readonly FilterEnum VARIANCE = new FilterEnum("variance");

            private static readonly Dictionary<string, FilterEnum> StaticFields =
            new Dictionary<string, FilterEnum>()
            {
                { "max", MAX },
                { "min", MIN },
                { "average", AVERAGE },
                { "sum", SUM },
                { "variance", VARIANCE },
            };

            private string Value;

            private FilterEnum(string value)
            {
                this.Value = value;
            }

            public static FilterEnum FromValue(string value)
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
                return this.Value;
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

                if (this.Equals(obj as FilterEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FilterEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(FilterEnum a, FilterEnum b)
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

            public static bool operator !=(FilterEnum a, FilterEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("dim.0", IsQuery = true)]
        [JsonProperty("dim.0", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim0 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("dim.1", IsQuery = true)]
        [JsonProperty("dim.1", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim1 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("dim.2", IsQuery = true)]
        [JsonProperty("dim.2", NullValueHandling = NullValueHandling.Ignore)]
        public string Dim2 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("filter", IsQuery = true)]
        [JsonProperty("filter", NullValueHandling = NullValueHandling.Ignore)]
        public FilterEnum Filter { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("from", IsQuery = true)]
        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public long? From { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("metric_name", IsQuery = true)]
        [JsonProperty("metric_name", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("namespace", IsQuery = true)]
        [JsonProperty("namespace", NullValueHandling = NullValueHandling.Ignore)]
        public string Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("period", IsQuery = true)]
        [JsonProperty("period", NullValueHandling = NullValueHandling.Ignore)]
        public int? Period { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("to", IsQuery = true)]
        [JsonProperty("to", NullValueHandling = NullValueHandling.Ignore)]
        public long? To { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMetricDataRequest {\n");
            sb.Append("  dim0: ").Append(Dim0).Append("\n");
            sb.Append("  dim1: ").Append(Dim1).Append("\n");
            sb.Append("  dim2: ").Append(Dim2).Append("\n");
            sb.Append("  filter: ").Append(Filter).Append("\n");
            sb.Append("  from: ").Append(From).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  period: ").Append(Period).Append("\n");
            sb.Append("  to: ").Append(To).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMetricDataRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMetricDataRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dim0 == input.Dim0 ||
                    (this.Dim0 != null &&
                    this.Dim0.Equals(input.Dim0))
                ) && 
                (
                    this.Dim1 == input.Dim1 ||
                    (this.Dim1 != null &&
                    this.Dim1.Equals(input.Dim1))
                ) && 
                (
                    this.Dim2 == input.Dim2 ||
                    (this.Dim2 != null &&
                    this.Dim2.Equals(input.Dim2))
                ) && 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.MetricName == input.MetricName ||
                    (this.MetricName != null &&
                    this.MetricName.Equals(input.MetricName))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.Dim0 != null)
                    hashCode = hashCode * 59 + this.Dim0.GetHashCode();
                if (this.Dim1 != null)
                    hashCode = hashCode * 59 + this.Dim1.GetHashCode();
                if (this.Dim2 != null)
                    hashCode = hashCode * 59 + this.Dim2.GetHashCode();
                if (this.Filter != null)
                    hashCode = hashCode * 59 + this.Filter.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                return hashCode;
            }
        }
    }
}
