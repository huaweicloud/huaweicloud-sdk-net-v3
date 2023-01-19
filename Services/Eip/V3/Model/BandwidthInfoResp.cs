using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 公网IP绑定的带宽信息
    /// </summary>
    public class BandwidthInfoResp 
    {
        /// <summary>
        /// 带宽类型
        /// </summary>
        /// <value>带宽类型</value>
        [JsonConverter(typeof(EnumClassConverter<BandwidthTypeEnum>))]
        public class BandwidthTypeEnum
        {
            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly BandwidthTypeEnum PER = new BandwidthTypeEnum("PER");

            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly BandwidthTypeEnum WHOLE = new BandwidthTypeEnum("WHOLE");

            private static readonly Dictionary<string, BandwidthTypeEnum> StaticFields =
            new Dictionary<string, BandwidthTypeEnum>()
            {
                { "PER", PER },
                { "WHOLE", WHOLE },
            };

            private string _value;

            public BandwidthTypeEnum()
            {

            }

            public BandwidthTypeEnum(string value)
            {
                _value = value;
            }

            public static BandwidthTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BandwidthTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BandwidthTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BandwidthTypeEnum a, BandwidthTypeEnum b)
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

            public static bool operator !=(BandwidthTypeEnum a, BandwidthTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 带宽名称
        /// </summary>
        [JsonProperty("bandwidth_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthName { get; set; }

        /// <summary>
        /// 带宽大小
        /// </summary>
        [JsonProperty("bandwidth_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthNumber { get; set; }

        /// <summary>
        /// 带宽类型
        /// </summary>
        [JsonProperty("bandwidth_type", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthTypeEnum BandwidthType { get; set; }
        /// <summary>
        /// 带宽id
        /// </summary>
        [JsonProperty("bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BandwidthInfoResp {\n");
            sb.Append("  bandwidthName: ").Append(BandwidthName).Append("\n");
            sb.Append("  bandwidthNumber: ").Append(BandwidthNumber).Append("\n");
            sb.Append("  bandwidthType: ").Append(BandwidthType).Append("\n");
            sb.Append("  bandwidthId: ").Append(BandwidthId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BandwidthInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BandwidthInfoResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandwidthName == input.BandwidthName ||
                    (this.BandwidthName != null &&
                    this.BandwidthName.Equals(input.BandwidthName))
                ) && 
                (
                    this.BandwidthNumber == input.BandwidthNumber ||
                    (this.BandwidthNumber != null &&
                    this.BandwidthNumber.Equals(input.BandwidthNumber))
                ) && 
                (
                    this.BandwidthType == input.BandwidthType ||
                    (this.BandwidthType != null &&
                    this.BandwidthType.Equals(input.BandwidthType))
                ) && 
                (
                    this.BandwidthId == input.BandwidthId ||
                    (this.BandwidthId != null &&
                    this.BandwidthId.Equals(input.BandwidthId))
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
                if (this.BandwidthName != null)
                    hashCode = hashCode * 59 + this.BandwidthName.GetHashCode();
                if (this.BandwidthNumber != null)
                    hashCode = hashCode * 59 + this.BandwidthNumber.GetHashCode();
                if (this.BandwidthType != null)
                    hashCode = hashCode * 59 + this.BandwidthType.GetHashCode();
                if (this.BandwidthId != null)
                    hashCode = hashCode * 59 + this.BandwidthId.GetHashCode();
                return hashCode;
            }
        }
    }
}
