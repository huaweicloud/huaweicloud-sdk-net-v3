using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class SearchUsersRequest 
    {
        /// <summary>
        /// 根据管理员类型查询。 * 1：普通管理员 * 2：非管理员 
        /// </summary>
        /// <value>根据管理员类型查询。 * 1：普通管理员 * 2：非管理员 </value>
        [JsonConverter(typeof(EnumClassConverter<AdminTypeEnum>))]
        public class AdminTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AdminTypeEnum NUMBER_1 = new AdminTypeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly AdminTypeEnum NUMBER_2 = new AdminTypeEnum(2);

            private static readonly Dictionary<int?, AdminTypeEnum> StaticFields =
            new Dictionary<int?, AdminTypeEnum>()
            {
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public AdminTypeEnum()
            {

            }

            public AdminTypeEnum(int? value)
            {
                _value = value;
            }

            public static AdminTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as AdminTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AdminTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AdminTypeEnum a, AdminTypeEnum b)
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

            public static bool operator !=(AdminTypeEnum a, AdminTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 请求requestId，用来标识一路请求，用于问题跟踪定位，建议使用UUID，若不携带，则后台自动生成。
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }

        /// <summary>
        /// 语言参数，默认为中文zh-CN，英文为en-US。
        /// </summary>
        [SDKProperty("Accept-Language", IsHeader = true)]
        [JsonProperty("Accept-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// 查询偏移量,若超过最大数量，则返回最后一页。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询数量。 默认值：10。 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 搜索条件，支持名称、手机、邮箱、帐号、第三方帐号模糊搜索。
        /// </summary>
        [SDKProperty("searchKey", IsQuery = true)]
        [JsonProperty("searchKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchKey { get; set; }

        /// <summary>
        /// 排序字段名称 支持的取值： - userType - adminType - ldapAccount - deptCode - status - sortLevel
        /// </summary>
        [SDKProperty("sortField", IsQuery = true)]
        [JsonProperty("sortField", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 是否按升序排序。
        /// </summary>
        [SDKProperty("isAsc", IsQuery = true)]
        [JsonProperty("isAsc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAsc { get; set; }

        /// <summary>
        /// 部门编码，不带则查询所有。
        /// </summary>
        [SDKProperty("deptCode", IsQuery = true)]
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 是否查询子部门。 默认值: true 
        /// </summary>
        [SDKProperty("enableSubDept", IsQuery = true)]
        [JsonProperty("enableSubDept", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSubDept { get; set; }

        /// <summary>
        /// 根据管理员类型查询。 * 1：普通管理员 * 2：非管理员 
        /// </summary>
        [SDKProperty("adminType", IsQuery = true)]
        [JsonProperty("adminType", NullValueHandling = NullValueHandling.Ignore)]
        public AdminTypeEnum AdminType { get; set; }
        /// <summary>
        /// 是否开启智能协同白板功能功能位，不带则搜索所有。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("enableRoom", IsQuery = true)]
        [JsonProperty("enableRoom", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableRoom { get; set; }

        /// <summary>
        /// 用户类型。默认2。 * 2：普通用户 * 12：智慧屏用户 * 13：ideaHub用户 * 14: SmartRooms用户 
        /// </summary>
        [SDKProperty("userType", IsQuery = true)]
        [JsonProperty("userType", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> UserType { get; set; }

        /// <summary>
        /// 用户状态。不带则查询所有。 * 0：正常 * 1：停用。 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// 是否查询未激活的终端。 默认值: false 
        /// </summary>
        [SDKProperty("containsUnActive", IsQuery = true)]
        [JsonProperty("containsUnActive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContainsUnActive { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchUsersRequest {\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("  acceptLanguage: ").Append(AcceptLanguage).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  searchKey: ").Append(SearchKey).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  isAsc: ").Append(IsAsc).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  enableSubDept: ").Append(EnableSubDept).Append("\n");
            sb.Append("  adminType: ").Append(AdminType).Append("\n");
            sb.Append("  enableRoom: ").Append(EnableRoom).Append("\n");
            sb.Append("  userType: ").Append(UserType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  containsUnActive: ").Append(ContainsUnActive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchUsersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchUsersRequest input)
        {
            if (input == null) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;
            if (this.AcceptLanguage != input.AcceptLanguage || (this.AcceptLanguage != null && !this.AcceptLanguage.Equals(input.AcceptLanguage))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SearchKey != input.SearchKey || (this.SearchKey != null && !this.SearchKey.Equals(input.SearchKey))) return false;
            if (this.SortField != input.SortField || (this.SortField != null && !this.SortField.Equals(input.SortField))) return false;
            if (this.IsAsc != input.IsAsc || (this.IsAsc != null && !this.IsAsc.Equals(input.IsAsc))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.EnableSubDept != input.EnableSubDept || (this.EnableSubDept != null && !this.EnableSubDept.Equals(input.EnableSubDept))) return false;
            if (this.AdminType != input.AdminType) return false;
            if (this.EnableRoom != input.EnableRoom || (this.EnableRoom != null && !this.EnableRoom.Equals(input.EnableRoom))) return false;
            if (this.UserType != input.UserType || (this.UserType != null && input.UserType != null && !this.UserType.SequenceEqual(input.UserType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ContainsUnActive != input.ContainsUnActive || (this.ContainsUnActive != null && !this.ContainsUnActive.Equals(input.ContainsUnActive))) return false;

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
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                if (this.AcceptLanguage != null) hashCode = hashCode * 59 + this.AcceptLanguage.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SearchKey != null) hashCode = hashCode * 59 + this.SearchKey.GetHashCode();
                if (this.SortField != null) hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.IsAsc != null) hashCode = hashCode * 59 + this.IsAsc.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.EnableSubDept != null) hashCode = hashCode * 59 + this.EnableSubDept.GetHashCode();
                hashCode = hashCode * 59 + this.AdminType.GetHashCode();
                if (this.EnableRoom != null) hashCode = hashCode * 59 + this.EnableRoom.GetHashCode();
                if (this.UserType != null) hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ContainsUnActive != null) hashCode = hashCode * 59 + this.ContainsUnActive.GetHashCode();
                return hashCode;
            }
        }
    }
}
