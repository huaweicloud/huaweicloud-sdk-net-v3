using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bms.V1.Model
{
    /// <summary>
    /// 创建弹性公网IP的extendparam字段数据结构说明
    /// </summary>
    public class ExtendParamEip 
    {
        /// <summary>
        /// 弹性公网IP的计费模式。若带宽计费类型为bandwidth，则支持prePaid和postPaid；若带宽计费类型为traffic，仅支持postPaid。取值范围：prePaid：预付费，即包年包月postPaid：后付费，即按需付费 说明：如果bandwidth对象中sharetype是WHOLE且id有值，弹性公网IP只能创建为按需付费的，故该参数传参“prePaid”无效。
        /// </summary>
        /// <value>弹性公网IP的计费模式。若带宽计费类型为bandwidth，则支持prePaid和postPaid；若带宽计费类型为traffic，仅支持postPaid。取值范围：prePaid：预付费，即包年包月postPaid：后付费，即按需付费 说明：如果bandwidth对象中sharetype是WHOLE且id有值，弹性公网IP只能创建为按需付费的，故该参数传参“prePaid”无效。</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingmodeEnum>))]
        public class ChargingmodeEnum
        {
            /// <summary>
            /// Enum PREPAID for value: prePaid
            /// </summary>
            public static readonly ChargingmodeEnum PREPAID = new ChargingmodeEnum("prePaid");

            /// <summary>
            /// Enum POSTPAID for value: postPaid
            /// </summary>
            public static readonly ChargingmodeEnum POSTPAID = new ChargingmodeEnum("postPaid");

            private static readonly Dictionary<string, ChargingmodeEnum> StaticFields =
            new Dictionary<string, ChargingmodeEnum>()
            {
                { "prePaid", PREPAID },
                { "postPaid", POSTPAID },
            };

            private string _value;

            public ChargingmodeEnum()
            {

            }

            public ChargingmodeEnum(string value)
            {
                _value = value;
            }

            public static ChargingmodeEnum FromValue(string value)
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

                if (this.Equals(obj as ChargingmodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingmodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargingmodeEnum a, ChargingmodeEnum b)
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

            public static bool operator !=(ChargingmodeEnum a, ChargingmodeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 弹性公网IP的计费模式。若带宽计费类型为bandwidth，则支持prePaid和postPaid；若带宽计费类型为traffic，仅支持postPaid。取值范围：prePaid：预付费，即包年包月postPaid：后付费，即按需付费 说明：如果bandwidth对象中sharetype是WHOLE且id有值，弹性公网IP只能创建为按需付费的，故该参数传参“prePaid”无效。
        /// </summary>
        [JsonProperty("chargingmode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingmodeEnum Chargingmode { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtendParamEip {\n");
            sb.Append("  chargingmode: ").Append(Chargingmode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtendParamEip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtendParamEip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Chargingmode == input.Chargingmode ||
                    (this.Chargingmode != null &&
                    this.Chargingmode.Equals(input.Chargingmode))
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
                if (this.Chargingmode != null)
                    hashCode = hashCode * 59 + this.Chargingmode.GetHashCode();
                return hashCode;
            }
        }
    }
}
