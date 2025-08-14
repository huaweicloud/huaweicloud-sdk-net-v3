using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// 联邦Schema配置Subject属性详细信息
    /// </summary>
    public class ResponseSchemaSubjectDetailsDto 
    {
        /// <summary>
        /// 是否包含NameID
        /// </summary>
        /// <value>是否包含NameID</value>
        [JsonConverter(typeof(EnumClassConverter<IncludeEnum>))]
        public class IncludeEnum
        {
            /// <summary>
            /// Enum REQUIRED for value: REQUIRED
            /// </summary>
            public static readonly IncludeEnum REQUIRED = new IncludeEnum("REQUIRED");

            private static readonly Dictionary<string, IncludeEnum> StaticFields =
            new Dictionary<string, IncludeEnum>()
            {
                { "REQUIRED", REQUIRED },
            };

            private string _value;

            public IncludeEnum()
            {

            }

            public IncludeEnum(string value)
            {
                _value = value;
            }

            public static IncludeEnum FromValue(string value)
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

                if (this.Equals(obj as IncludeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IncludeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IncludeEnum a, IncludeEnum b)
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

            public static bool operator !=(IncludeEnum a, IncludeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// NameID的格式
        /// </summary>
        [JsonProperty("name_id_format", NullValueHandling = NullValueHandling.Ignore)]
        public string NameIdFormat { get; set; }

        /// <summary>
        /// 是否包含NameID
        /// </summary>
        [JsonProperty("include", NullValueHandling = NullValueHandling.Ignore)]
        public IncludeEnum Include { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResponseSchemaSubjectDetailsDto {\n");
            sb.Append("  nameIdFormat: ").Append(NameIdFormat).Append("\n");
            sb.Append("  include: ").Append(Include).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResponseSchemaSubjectDetailsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResponseSchemaSubjectDetailsDto input)
        {
            if (input == null) return false;
            if (this.NameIdFormat != input.NameIdFormat || (this.NameIdFormat != null && !this.NameIdFormat.Equals(input.NameIdFormat))) return false;
            if (this.Include != input.Include) return false;

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
                if (this.NameIdFormat != null) hashCode = hashCode * 59 + this.NameIdFormat.GetHashCode();
                hashCode = hashCode * 59 + this.Include.GetHashCode();
                return hashCode;
            }
        }
    }
}
