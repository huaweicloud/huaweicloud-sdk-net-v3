using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aad.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListUnblockQuotaStatisticsResponse : SdkResponse
    {
        /// <summary>
        /// 用户类型：common_user , native_protection_user
        /// </summary>
        /// <value>用户类型：common_user , native_protection_user</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum COMMON_USER for value: common_user
            /// </summary>
            public static readonly TypeEnum COMMON_USER = new TypeEnum("common_user");

            /// <summary>
            /// Enum NATIVE_PROTECTION_USER for value: native_protection_user
            /// </summary>
            public static readonly TypeEnum NATIVE_PROTECTION_USER = new TypeEnum("native_protection_user");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "common_user", COMMON_USER },
                { "native_protection_user", NATIVE_PROTECTION_USER },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户类型：common_user , native_protection_user
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 解封总配额
        /// </summary>
        [JsonProperty("total_unblocking_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalUnblockingQuota { get; set; }

        /// <summary>
        /// 剩余解封配额
        /// </summary>
        [JsonProperty("remaining_unblocking_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainingUnblockingQuota { get; set; }

        /// <summary>
        /// 今日解封配额
        /// </summary>
        [JsonProperty("unblocking_quota_today", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnblockingQuotaToday { get; set; }

        /// <summary>
        /// 今日剩余解封配额
        /// </summary>
        [JsonProperty("remaining_unblocking_quota_today", NullValueHandling = NullValueHandling.Ignore)]
        public int? RemainingUnblockingQuotaToday { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUnblockQuotaStatisticsResponse {\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  totalUnblockingQuota: ").Append(TotalUnblockingQuota).Append("\n");
            sb.Append("  remainingUnblockingQuota: ").Append(RemainingUnblockingQuota).Append("\n");
            sb.Append("  unblockingQuotaToday: ").Append(UnblockingQuotaToday).Append("\n");
            sb.Append("  remainingUnblockingQuotaToday: ").Append(RemainingUnblockingQuotaToday).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUnblockQuotaStatisticsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUnblockQuotaStatisticsResponse input)
        {
            if (input == null) return false;
            if (this.Type != input.Type) return false;
            if (this.TotalUnblockingQuota != input.TotalUnblockingQuota || (this.TotalUnblockingQuota != null && !this.TotalUnblockingQuota.Equals(input.TotalUnblockingQuota))) return false;
            if (this.RemainingUnblockingQuota != input.RemainingUnblockingQuota || (this.RemainingUnblockingQuota != null && !this.RemainingUnblockingQuota.Equals(input.RemainingUnblockingQuota))) return false;
            if (this.UnblockingQuotaToday != input.UnblockingQuotaToday || (this.UnblockingQuotaToday != null && !this.UnblockingQuotaToday.Equals(input.UnblockingQuotaToday))) return false;
            if (this.RemainingUnblockingQuotaToday != input.RemainingUnblockingQuotaToday || (this.RemainingUnblockingQuotaToday != null && !this.RemainingUnblockingQuotaToday.Equals(input.RemainingUnblockingQuotaToday))) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TotalUnblockingQuota != null) hashCode = hashCode * 59 + this.TotalUnblockingQuota.GetHashCode();
                if (this.RemainingUnblockingQuota != null) hashCode = hashCode * 59 + this.RemainingUnblockingQuota.GetHashCode();
                if (this.UnblockingQuotaToday != null) hashCode = hashCode * 59 + this.UnblockingQuotaToday.GetHashCode();
                if (this.RemainingUnblockingQuotaToday != null) hashCode = hashCode * 59 + this.RemainingUnblockingQuotaToday.GetHashCode();
                return hashCode;
            }
        }
    }
}
