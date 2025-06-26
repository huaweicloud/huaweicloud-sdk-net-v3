using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NamespaceMetadata 
    {
        /// <summary>
        /// 是否公开，可选true、false
        /// </summary>
        /// <value>是否公开，可选true、false</value>
        [JsonConverter(typeof(EnumClassConverter<PublicEnum>))]
        public class PublicEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly PublicEnum TRUE = new PublicEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly PublicEnum FALSE = new PublicEnum("false");

            private static readonly Dictionary<string, PublicEnum> StaticFields =
            new Dictionary<string, PublicEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public PublicEnum()
            {

            }

            public PublicEnum(string value)
            {
                _value = value;
            }

            public static PublicEnum FromValue(string value)
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

                if (this.Equals(obj as PublicEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PublicEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PublicEnum a, PublicEnum b)
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

            public static bool operator !=(PublicEnum a, PublicEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 是否公开，可选true、false
        /// </summary>
        [JsonProperty("public", NullValueHandling = NullValueHandling.Ignore)]
        public PublicEnum Public { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamespaceMetadata {\n");
            sb.Append("  Public: ").Append(Public).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NamespaceMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NamespaceMetadata input)
        {
            if (input == null) return false;
            if (this.Public != input.Public) return false;

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
                hashCode = hashCode * 59 + this.Public.GetHashCode();
                return hashCode;
            }
        }
    }
}
