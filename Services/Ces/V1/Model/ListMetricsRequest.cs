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
    public class ListMetricsRequest 
    {
        /// <summary>
        /// Defines order
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<OrderEnum>))]
        public class OrderEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderEnum ASC = new OrderEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderEnum DESC = new OrderEnum("desc");

            public static readonly Dictionary<string, OrderEnum> StaticFields =
            new Dictionary<string, OrderEnum>()
            {
                {"asc", ASC},
                {"desc", DESC},
            };

            private string Value;

            public OrderEnum(string Value)
            {
                this.Value = Value;
            }

            public static OrderEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
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

                if (this.Equals(obj as OrderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OrderEnum a, OrderEnum b)
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

            public static bool operator !=(OrderEnum a, OrderEnum b)
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
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

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
        [SDKProperty("order", IsQuery = true)]
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public OrderEnum Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("start", IsQuery = true)]
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public string Start { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListMetricsRequest {\n");
            sb.Append("  dim0: ").Append(Dim0).Append("\n");
            sb.Append("  dim1: ").Append(Dim1).Append("\n");
            sb.Append("  dim2: ").Append(Dim2).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  metricName: ").Append(MetricName).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  start: ").Append(Start).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListMetricsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListMetricsRequest input)
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
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.MetricName != null)
                    hashCode = hashCode * 59 + this.MetricName.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                return hashCode;
            }
        }
    }
}
