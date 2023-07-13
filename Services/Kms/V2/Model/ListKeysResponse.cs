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
    public class ListKeysResponse : SdkResponse
    {
        /// <summary>
        /// 是否还有下一页： - “true”表示还有数据。 - “false”表示已经是最后一页。
        /// </summary>
        /// <value>是否还有下一页： - “true”表示还有数据。 - “false”表示已经是最后一页。</value>
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
        /// key_id列表。
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Keys { get; set; }

        /// <summary>
        /// 密钥详情列表。详情参见KeyDetails
        /// </summary>
        [JsonProperty("key_details", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeyDetails> KeyDetails { get; set; }

        /// <summary>
        /// 获取下一页所需要传递的“marker”值。当“truncated”为“false”时，“next_marker”为空。
        /// </summary>
        [JsonProperty("next_marker", NullValueHandling = NullValueHandling.Ignore)]
        public string NextMarker { get; set; }

        /// <summary>
        /// 是否还有下一页： - “true”表示还有数据。 - “false”表示已经是最后一页。
        /// </summary>
        [JsonProperty("truncated", NullValueHandling = NullValueHandling.Ignore)]
        public TruncatedEnum Truncated { get; set; }
        /// <summary>
        /// 密钥总条数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeysResponse {\n");
            sb.Append("  keys: ").Append(Keys).Append("\n");
            sb.Append("  keyDetails: ").Append(KeyDetails).Append("\n");
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
            return this.Equals(input as ListKeysResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeysResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Keys == input.Keys ||
                    this.Keys != null &&
                    input.Keys != null &&
                    this.Keys.SequenceEqual(input.Keys)
                ) && 
                (
                    this.KeyDetails == input.KeyDetails ||
                    this.KeyDetails != null &&
                    input.KeyDetails != null &&
                    this.KeyDetails.SequenceEqual(input.KeyDetails)
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
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.KeyDetails != null)
                    hashCode = hashCode * 59 + this.KeyDetails.GetHashCode();
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
