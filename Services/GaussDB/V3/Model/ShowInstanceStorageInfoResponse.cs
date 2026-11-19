using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowInstanceStorageInfoResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**：  存储类型。  **取值范围**：  - POOL：DL6存储类型。 - STANDARDPOOL：DL5存储类型。
        /// </summary>
        /// <value>**参数解释**：  存储类型。  **取值范围**：  - POOL：DL6存储类型。 - STANDARDPOOL：DL5存储类型。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum POOL for value: POOL
            /// </summary>
            public static readonly TypeEnum POOL = new TypeEnum("POOL");

            /// <summary>
            /// Enum STANDARDPOOL for value: STANDARDPOOL
            /// </summary>
            public static readonly TypeEnum STANDARDPOOL = new TypeEnum("STANDARDPOOL");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "POOL", POOL },
                { "STANDARDPOOL", STANDARDPOOL },
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
        /// **参数解释**：  已使用存储空间大小，单位是GB。  **取值范围**：  大于等于0。
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public double? Used { get; set; }

        /// <summary>
        /// **参数解释**：  包年/包月购买的存储空间大小，单位是GB。  **取值范围**：  大于0。
        /// </summary>
        [JsonProperty("prepaid_size", NullValueHandling = NullValueHandling.Ignore)]
        public double? PrepaidSize { get; set; }

        /// <summary>
        /// **参数解释**：  实例可使用的存储空间上限，单位是GB。  **取值范围**：  大于0。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public double? Limit { get; set; }

        /// <summary>
        /// **参数解释**：  存储类型。  **取值范围**：  - POOL：DL6存储类型。 - STANDARDPOOL：DL5存储类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowInstanceStorageInfoResponse {\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  prepaidSize: ").Append(PrepaidSize).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowInstanceStorageInfoResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowInstanceStorageInfoResponse input)
        {
            if (input == null) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.PrepaidSize != input.PrepaidSize || (this.PrepaidSize != null && !this.PrepaidSize.Equals(input.PrepaidSize))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.PrepaidSize != null) hashCode = hashCode * 59 + this.PrepaidSize.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
