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
    /// 获取分布式/主备版实例时返回。
    /// </summary>
    public class ListHa 
    {
        /// <summary>
        /// 数据库一致性类型，分布式模式实例仅有。取值为“strong”、“eventual”，分别表示强一致性、最终一致性。
        /// </summary>
        /// <value>数据库一致性类型，分布式模式实例仅有。取值为“strong”、“eventual”，分别表示强一致性、最终一致性。</value>
        [JsonConverter(typeof(EnumClassConverter<ConsistencyEnum>))]
        public class ConsistencyEnum
        {
            /// <summary>
            /// Enum STRONG for value: strong
            /// </summary>
            public static readonly ConsistencyEnum STRONG = new ConsistencyEnum("strong");

            /// <summary>
            /// Enum EVENTUAL for value: eventual
            /// </summary>
            public static readonly ConsistencyEnum EVENTUAL = new ConsistencyEnum("eventual");

            private static readonly Dictionary<string, ConsistencyEnum> StaticFields =
            new Dictionary<string, ConsistencyEnum>()
            {
                { "strong", STRONG },
                { "eventual", EVENTUAL },
            };

            private string _value;

            public ConsistencyEnum()
            {

            }

            public ConsistencyEnum(string value)
            {
                _value = value;
            }

            public static ConsistencyEnum FromValue(string value)
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

                if (this.Equals(obj as ConsistencyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConsistencyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConsistencyEnum a, ConsistencyEnum b)
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

            public static bool operator !=(ConsistencyEnum a, ConsistencyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 数据库一致性类型，分布式模式实例仅有。取值为“strong”、“eventual”，分别表示强一致性、最终一致性。
        /// </summary>
        [JsonProperty("consistency", NullValueHandling = NullValueHandling.Ignore)]
        public ConsistencyEnum Consistency { get; set; }
        /// <summary>
        /// 备机同步参数。  取值：非空。  GaussDB为 “sync” 说明： “sync”为同步模式。
        /// </summary>
        [JsonProperty("replication_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ReplicationMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHa {\n");
            sb.Append("  consistency: ").Append(Consistency).Append("\n");
            sb.Append("  replicationMode: ").Append(ReplicationMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHa);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHa input)
        {
            if (input == null) return false;
            if (this.Consistency != input.Consistency) return false;
            if (this.ReplicationMode != input.ReplicationMode || (this.ReplicationMode != null && !this.ReplicationMode.Equals(input.ReplicationMode))) return false;

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
                hashCode = hashCode * 59 + this.Consistency.GetHashCode();
                if (this.ReplicationMode != null) hashCode = hashCode * 59 + this.ReplicationMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
