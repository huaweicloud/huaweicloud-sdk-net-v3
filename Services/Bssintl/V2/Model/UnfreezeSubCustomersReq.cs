using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UnfreezeSubCustomersReq 
    {
        /// <summary>
        /// |参数名称：解冻类型| |参数的约束及描述：该参数非必填，解冻类型，支持枚举| |ACCOUNT：解冻账号，ACCOUNT_AND_RESOURCE：解冻账号与资源|
        /// </summary>
        /// <value>|参数名称：解冻类型| |参数的约束及描述：该参数非必填，解冻类型，支持枚举| |ACCOUNT：解冻账号，ACCOUNT_AND_RESOURCE：解冻账号与资源|</value>
        [JsonConverter(typeof(EnumClassConverter<UnfreezeTypeEnum>))]
        public class UnfreezeTypeEnum
        {
            /// <summary>
            /// Enum ACCOUNT for value: ACCOUNT
            /// </summary>
            public static readonly UnfreezeTypeEnum ACCOUNT = new UnfreezeTypeEnum("ACCOUNT");

            /// <summary>
            /// Enum ACCOUNT_AND_RESOURCE for value: ACCOUNT_AND_RESOURCE
            /// </summary>
            public static readonly UnfreezeTypeEnum ACCOUNT_AND_RESOURCE = new UnfreezeTypeEnum("ACCOUNT_AND_RESOURCE");

            private static readonly Dictionary<string, UnfreezeTypeEnum> StaticFields =
            new Dictionary<string, UnfreezeTypeEnum>()
            {
                { "ACCOUNT", ACCOUNT },
                { "ACCOUNT_AND_RESOURCE", ACCOUNT_AND_RESOURCE },
            };

            private string _value;

            public UnfreezeTypeEnum()
            {

            }

            public UnfreezeTypeEnum(string value)
            {
                _value = value;
            }

            public static UnfreezeTypeEnum FromValue(string value)
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

                if (this.Equals(obj as UnfreezeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UnfreezeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UnfreezeTypeEnum a, UnfreezeTypeEnum b)
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

            public static bool operator !=(UnfreezeTypeEnum a, UnfreezeTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 需要解冻的客户账号ID列表。 您可以调用查询客户列表接口获取customer_id。
        /// </summary>
        [JsonProperty("customer_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CustomerIds { get; set; }

        /// <summary>
        /// 解冻原因。
        /// </summary>
        [JsonProperty("reason", NullValueHandling = NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见查询云经销商列表。如果需要查询云经销商的子客户列表，必须携带该字段。除此之外，此参数不做处理。
        /// </summary>
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }

        /// <summary>
        /// |参数名称：解冻类型| |参数的约束及描述：该参数非必填，解冻类型，支持枚举| |ACCOUNT：解冻账号，ACCOUNT_AND_RESOURCE：解冻账号与资源|
        /// </summary>
        [JsonProperty("unfreeze_type", NullValueHandling = NullValueHandling.Ignore)]
        public UnfreezeTypeEnum UnfreezeType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnfreezeSubCustomersReq {\n");
            sb.Append("  customerIds: ").Append(CustomerIds).Append("\n");
            sb.Append("  reason: ").Append(Reason).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("  unfreezeType: ").Append(UnfreezeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnfreezeSubCustomersReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnfreezeSubCustomersReq input)
        {
            if (input == null) return false;
            if (this.CustomerIds != input.CustomerIds || (this.CustomerIds != null && input.CustomerIds != null && !this.CustomerIds.SequenceEqual(input.CustomerIds))) return false;
            if (this.Reason != input.Reason || (this.Reason != null && !this.Reason.Equals(input.Reason))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;
            if (this.UnfreezeType != input.UnfreezeType) return false;

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
                if (this.CustomerIds != null) hashCode = hashCode * 59 + this.CustomerIds.GetHashCode();
                if (this.Reason != null) hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                hashCode = hashCode * 59 + this.UnfreezeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
