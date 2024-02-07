using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowUserDisclaimerRequest 
    {
        /// <summary>
        /// Defines fields
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<FieldsEnum>))]
        public class FieldsEnum
        {
            /// <summary>
            /// Enum DOMAIN_ID for value: domain_id
            /// </summary>
            public static readonly FieldsEnum DOMAIN_ID = new FieldsEnum("domain_id");

            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly FieldsEnum CREATED_AT = new FieldsEnum("created_at");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly FieldsEnum UPDATED_AT = new FieldsEnum("updated_at");

            private static readonly Dictionary<string, FieldsEnum> StaticFields =
            new Dictionary<string, FieldsEnum>()
            {
                { "domain_id", DOMAIN_ID },
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
            };

            private string _value;

            public FieldsEnum()
            {

            }

            public FieldsEnum(string value)
            {
                _value = value;
            }

            public static FieldsEnum FromValue(string value)
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

                if (this.Equals(obj as FieldsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FieldsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FieldsEnum a, FieldsEnum b)
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

            public static bool operator !=(FieldsEnum a, FieldsEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 只显示指定的字段
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldsEnum> Fields { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowUserDisclaimerRequest {\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowUserDisclaimerRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowUserDisclaimerRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                return hashCode;
            }
        }
    }
}
