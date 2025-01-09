using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessPolicyDetailInfo 
    {
        /// <summary>
        /// 黑名单类型，当前黑名单只支持互联网。 * INTERNET： 互联网
        /// </summary>
        /// <value>黑名单类型，当前黑名单只支持互联网。 * INTERNET： 互联网</value>
        [JsonConverter(typeof(EnumClassConverter<BlacklistTypeEnum>))]
        public class BlacklistTypeEnum
        {
            /// <summary>
            /// Enum INTERNET for value: INTERNET
            /// </summary>
            public static readonly BlacklistTypeEnum INTERNET = new BlacklistTypeEnum("INTERNET");

            private static readonly Dictionary<string, BlacklistTypeEnum> StaticFields =
            new Dictionary<string, BlacklistTypeEnum>()
            {
                { "INTERNET", INTERNET },
            };

            private string _value;

            public BlacklistTypeEnum()
            {

            }

            public BlacklistTypeEnum(string value)
            {
                _value = value;
            }

            public static BlacklistTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BlacklistTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BlacklistTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BlacklistTypeEnum a, BlacklistTypeEnum b)
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

            public static bool operator !=(BlacklistTypeEnum a, BlacklistTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 访问控制类型。默认为接入类型 * ACCESS_TYPE： 接入类型 * IP_WHITE_LIST： IP白名单
        /// </summary>
        /// <value>访问控制类型。默认为接入类型 * ACCESS_TYPE： 接入类型 * IP_WHITE_LIST： IP白名单</value>
        [JsonConverter(typeof(EnumClassConverter<AccessControlTypeEnum>))]
        public class AccessControlTypeEnum
        {
            /// <summary>
            /// Enum ACCESS_TYPE for value: ACCESS_TYPE
            /// </summary>
            public static readonly AccessControlTypeEnum ACCESS_TYPE = new AccessControlTypeEnum("ACCESS_TYPE");

            /// <summary>
            /// Enum IP_WHITE_LIST for value: IP_WHITE_LIST
            /// </summary>
            public static readonly AccessControlTypeEnum IP_WHITE_LIST = new AccessControlTypeEnum("IP_WHITE_LIST");

            private static readonly Dictionary<string, AccessControlTypeEnum> StaticFields =
            new Dictionary<string, AccessControlTypeEnum>()
            {
                { "ACCESS_TYPE", ACCESS_TYPE },
                { "IP_WHITE_LIST", IP_WHITE_LIST },
            };

            private string _value;

            public AccessControlTypeEnum()
            {

            }

            public AccessControlTypeEnum(string value)
            {
                _value = value;
            }

            public static AccessControlTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AccessControlTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccessControlTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccessControlTypeEnum a, AccessControlTypeEnum b)
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

            public static bool operator !=(AccessControlTypeEnum a, AccessControlTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 策略名
        /// </summary>
        [JsonProperty("policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyName { get; set; }

        /// <summary>
        /// 黑名单类型，当前黑名单只支持互联网。 * INTERNET： 互联网
        /// </summary>
        [JsonProperty("blacklist_type", NullValueHandling = NullValueHandling.Ignore)]
        public BlacklistTypeEnum BlacklistType { get; set; }
        /// <summary>
        /// 访问控制类型。默认为接入类型 * ACCESS_TYPE： 接入类型 * IP_WHITE_LIST： IP白名单
        /// </summary>
        [JsonProperty("access_control_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccessControlTypeEnum AccessControlType { get; set; }
        /// <summary>
        /// 策略的ip列表。
        /// </summary>
        [JsonProperty("ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpInfo> IpList { get; set; }

        /// <summary>
        /// 策略总数。
        /// </summary>
        [JsonProperty("ip_total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpTotalCount { get; set; }

        /// <summary>
        /// 策略id。
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 接入策略创建的时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessPolicyDetailInfo {\n");
            sb.Append("  policyName: ").Append(PolicyName).Append("\n");
            sb.Append("  blacklistType: ").Append(BlacklistType).Append("\n");
            sb.Append("  accessControlType: ").Append(AccessControlType).Append("\n");
            sb.Append("  ipList: ").Append(IpList).Append("\n");
            sb.Append("  ipTotalCount: ").Append(IpTotalCount).Append("\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessPolicyDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessPolicyDetailInfo input)
        {
            if (input == null) return false;
            if (this.PolicyName != input.PolicyName || (this.PolicyName != null && !this.PolicyName.Equals(input.PolicyName))) return false;
            if (this.BlacklistType != input.BlacklistType) return false;
            if (this.AccessControlType != input.AccessControlType) return false;
            if (this.IpList != input.IpList || (this.IpList != null && input.IpList != null && !this.IpList.SequenceEqual(input.IpList))) return false;
            if (this.IpTotalCount != input.IpTotalCount || (this.IpTotalCount != null && !this.IpTotalCount.Equals(input.IpTotalCount))) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.PolicyName != null) hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                hashCode = hashCode * 59 + this.BlacklistType.GetHashCode();
                hashCode = hashCode * 59 + this.AccessControlType.GetHashCode();
                if (this.IpList != null) hashCode = hashCode * 59 + this.IpList.GetHashCode();
                if (this.IpTotalCount != null) hashCode = hashCode * 59 + this.IpTotalCount.GetHashCode();
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
