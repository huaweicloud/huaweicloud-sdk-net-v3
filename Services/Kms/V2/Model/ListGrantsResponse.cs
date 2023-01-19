using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListGrantsResponse : SdkResponse
    {
        /// <summary>
        /// 是否还有下一页：  - “true”表示还有数据。  - “false”表示已经是最后一页。
        /// </summary>
        /// <value>是否还有下一页：  - “true”表示还有数据。  - “false”表示已经是最后一页。</value>
        [JsonConverter(typeof(EnumClassConverter<TruncatedEnum>))]
        public class TruncatedEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly TruncatedEnum TRUE = new TruncatedEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly TruncatedEnum FALSE = new TruncatedEnum("false");

            private static readonly Dictionary<string, TruncatedEnum> StaticFields =
            new Dictionary<string, TruncatedEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public TruncatedEnum()
            {

            }

            public TruncatedEnum(string value)
            {
                _value = value;
            }

            public static TruncatedEnum FromValue(string value)
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

                if (this.Equals(obj as TruncatedEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TruncatedEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TruncatedEnum a, TruncatedEnum b)
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

            public static bool operator !=(TruncatedEnum a, TruncatedEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// grant列表，详情请参见grants字段数据结构说明。
        /// </summary>
        [JsonProperty("grants", NullValueHandling = NullValueHandling.Ignore)]
        public List<Grants> Grants { get; set; }

        /// <summary>
        /// 获取下一页所需要传递的marker值。 当“truncated”为“false”时，“next_marker”为空。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 是否还有下一页：  - “true”表示还有数据。  - “false”表示已经是最后一页。
        /// </summary>
        [JsonProperty("truncated", NullValueHandling = NullValueHandling.Ignore)]
        public TruncatedEnum Truncated { get; set; }
        /// <summary>
        /// grant总条数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGrantsResponse {\n");
            sb.Append("  grants: ").Append(Grants).Append("\n");
            sb.Append("  nextMarker: ").Append(NextMarker).Append("\n");
            sb.Append("  truncated: ").Append(Truncated).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGrantsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGrantsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Grants == input.Grants ||
                    this.Grants != null &&
                    input.Grants != null &&
                    this.Grants.SequenceEqual(input.Grants)
                ) && 
                (
                    this.NextMarker == input.NextMarker ||
                    (this.NextMarker != null &&
                    this.NextMarker.Equals(input.NextMarker))
                ) && 
                (
                    this.Truncated == input.Truncated ||
                    (this.Truncated != null &&
                    this.Truncated.Equals(input.Truncated))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Grants != null)
                    hashCode = hashCode * 59 + this.Grants.GetHashCode();
                if (this.NextMarker != null)
                    hashCode = hashCode * 59 + this.NextMarker.GetHashCode();
                if (this.Truncated != null)
                    hashCode = hashCode * 59 + this.Truncated.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
