using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEngineProductsRequest 
    {
        /// <summary>
        /// **参数解释**： 消息引擎的类型。 **约束限制**： 不涉及。 **取值范围**： kafka **默认取值**： 不涉及。
        /// </summary>
        /// <value>**参数解释**： 消息引擎的类型。 **约束限制**： 不涉及。 **取值范围**： kafka **默认取值**： 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<EngineEnum>))]
        public class EngineEnum
        {
            /// <summary>
            /// Enum KAFKA for value: kafka
            /// </summary>
            public static readonly EngineEnum KAFKA = new EngineEnum("kafka");

            private static readonly Dictionary<string, EngineEnum> StaticFields =
            new Dictionary<string, EngineEnum>()
            {
                { "kafka", KAFKA },
            };

            private string _value;

            public EngineEnum()
            {

            }

            public EngineEnum(string value)
            {
                _value = value;
            }

            public static EngineEnum FromValue(string value)
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

                if (this.Equals(obj as EngineEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EngineEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EngineEnum a, EngineEnum b)
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

            public static bool operator !=(EngineEnum a, EngineEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 消息引擎的类型。 **约束限制**： 不涉及。 **取值范围**： kafka **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("engine", IsPath = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }
        /// <summary>
        /// **参数解释**： 产品ID。 **约束限制**： 不涉及。 **取值范围**： [- s6.2u4g.single.small：对应规格kafka.2u4g.single.small。](tag:ax,dt,hws,hws_eu,hws_hk,srg) [- c6.2u4g.single：对应规格kafka.2u4g.single。](tag:ax,dt,hws,hws_eu,hws_hk,srg) [- s6.2u4g.cluster.small：对应规格kafka.2u4g.cluster.small。](tag:ax,dt,hws,hws_eu,hws_hk,srg) - c6.2u4g.cluster：对应规格kafka.2u4g.cluster。 - c6.4u8g.cluster：对应规格kafka.4u8g.cluster。 - c6.8u16g.cluster：对应规格kafka.8u16g.cluster。 - c6.12u24g.cluster：对应规格kafka.12u24g.cluster。 - c6.16u32g.cluster：对应规格kafka.16u32g.cluster。 **默认取值**： 不涉及。
        /// </summary>
        [SDKProperty("product_id", IsQuery = true)]
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEngineProductsRequest {\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEngineProductsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEngineProductsRequest input)
        {
            if (input == null) return false;
            if (this.Engine != input.Engine) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;

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
                hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                return hashCode;
            }
        }
    }
}
