using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 带宽信息
    /// </summary>
    public class EipSpecBandwidth 
    {
        /// <summary>
        /// 带宽类型
        /// </summary>
        /// <value>带宽类型</value>
        [JsonConverter(typeof(EnumClassConverter<SharetypeEnum>))]
        public class SharetypeEnum
        {
            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly SharetypeEnum PER = new SharetypeEnum("PER");

            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly SharetypeEnum WHOLE = new SharetypeEnum("WHOLE");

            private static readonly Dictionary<string, SharetypeEnum> StaticFields =
            new Dictionary<string, SharetypeEnum>()
            {
                { "PER", PER },
                { "WHOLE", WHOLE },
            };

            private string _value;

            public SharetypeEnum()
            {

            }

            public SharetypeEnum(string value)
            {
                _value = value;
            }

            public static SharetypeEnum FromValue(string value)
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

                if (this.Equals(obj as SharetypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SharetypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SharetypeEnum a, SharetypeEnum b)
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

            public static bool operator !=(SharetypeEnum a, SharetypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 带宽大小
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 带宽类型
        /// </summary>
        [JsonProperty("sharetype", NullValueHandling = NullValueHandling.Ignore)]
        public SharetypeEnum Sharetype { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipSpecBandwidth {\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  sharetype: ").Append(Sharetype).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipSpecBandwidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipSpecBandwidth input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Sharetype == input.Sharetype ||
                    (this.Sharetype != null &&
                    this.Sharetype.Equals(input.Sharetype))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Sharetype != null)
                    hashCode = hashCode * 59 + this.Sharetype.GetHashCode();
                return hashCode;
            }
        }
    }
}
