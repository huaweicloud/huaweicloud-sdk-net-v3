using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Tms.v1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListPredefineTagsRequest 
    {
        /// <summary>
        /// Defines orderMethod
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<OrderMethodEnum>))]
        public class OrderMethodEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly OrderMethodEnum ASC = new OrderMethodEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly OrderMethodEnum DESC = new OrderMethodEnum("desc");

            public static readonly Dictionary<string, OrderMethodEnum> StaticFields =
            new Dictionary<string, OrderMethodEnum>()
            {
                {"asc", ASC},
                {"desc", DESC},
            };

            private string Value;

            public OrderMethodEnum(string Value)
            {
                this.Value = Value;
            }

            public static OrderMethodEnum FromValue(string Value)
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

                if (this.Equals(obj as OrderMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OrderMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OrderMethodEnum a, OrderMethodEnum b)
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

            public static bool operator !=(OrderMethodEnum a, OrderMethodEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("key", IsQuery = true)]
        public string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("value", IsQuery = true)]
        public string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        public string Marker { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("order_field", IsQuery = true)]
        public string OrderField { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("order_method", IsQuery = true)]
        public OrderMethodEnum OrderMethod { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPredefineTagsRequest {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  orderField: ").Append(OrderField).Append("\n");
            sb.Append("  orderMethod: ").Append(OrderMethod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPredefineTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPredefineTagsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.OrderField == input.OrderField ||
                    (this.OrderField != null &&
                    this.OrderField.Equals(input.OrderField))
                ) && 
                (
                    this.OrderMethod == input.OrderMethod ||
                    (this.OrderMethod != null &&
                    this.OrderMethod.Equals(input.OrderMethod))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.OrderField != null)
                    hashCode = hashCode * 59 + this.OrderField.GetHashCode();
                if (this.OrderMethod != null)
                    hashCode = hashCode * 59 + this.OrderMethod.GetHashCode();
                return hashCode;
            }
        }
    }
}
