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
    public class ListProductsRequest 
    {
        /// <summary>
        /// 消息引擎的类型。当前只支持kafka类型。
        /// </summary>
        /// <value>消息引擎的类型。当前只支持kafka类型。</value>
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

            public static bool operator !=(EngineEnum a, EngineEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 消息引擎的类型。当前只支持kafka类型。
        /// </summary>
        [SDKProperty("engine", IsQuery = true)]
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public EngineEnum Engine { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProductsRequest {\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProductsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProductsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
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
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                return hashCode;
            }
        }
    }
}
