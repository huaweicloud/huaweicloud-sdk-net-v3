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
    /// Request Object
    /// </summary>
    public class ListUsersOfGroupRequest 
    {
        /// <summary>
        /// 激活类型。 - USER_ACTIVATE：用户激活 - ADMIN_ACTIVATE：管理员激活
        /// </summary>
        /// <value>激活类型。 - USER_ACTIVATE：用户激活 - ADMIN_ACTIVATE：管理员激活</value>
        [JsonConverter(typeof(EnumClassConverter<ActiveTypeEnum>))]
        public class ActiveTypeEnum
        {
            /// <summary>
            /// Enum USER_ACTIVATE for value: USER_ACTIVATE
            /// </summary>
            public static readonly ActiveTypeEnum USER_ACTIVATE = new ActiveTypeEnum("USER_ACTIVATE");

            /// <summary>
            /// Enum ADMIN_ACTIVATE for value: ADMIN_ACTIVATE
            /// </summary>
            public static readonly ActiveTypeEnum ADMIN_ACTIVATE = new ActiveTypeEnum("ADMIN_ACTIVATE");

            private static readonly Dictionary<string, ActiveTypeEnum> StaticFields =
            new Dictionary<string, ActiveTypeEnum>()
            {
                { "USER_ACTIVATE", USER_ACTIVATE },
                { "ADMIN_ACTIVATE", ADMIN_ACTIVATE },
            };

            private string _value;

            public ActiveTypeEnum()
            {

            }

            public ActiveTypeEnum(string value)
            {
                _value = value;
            }

            public static ActiveTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ActiveTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ActiveTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ActiveTypeEnum a, ActiveTypeEnum b)
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

            public static bool operator !=(ActiveTypeEnum a, ActiveTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户名支持模糊查询。
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 用户组ID。
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 用户描述支持模糊查询。
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 激活类型。 - USER_ACTIVATE：用户激活 - ADMIN_ACTIVATE：管理员激活
        /// </summary>
        [SDKProperty("active_type", IsQuery = true)]
        [JsonProperty("active_type", NullValueHandling = NullValueHandling.Ignore)]
        public ActiveTypeEnum ActiveType { get; set; }
        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 用于分页查询，返回桌面数量限制。如果不指定或为0，默认2000，最大2000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListUsersOfGroupRequest {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  activeType: ").Append(ActiveType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListUsersOfGroupRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListUsersOfGroupRequest input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ActiveType != input.ActiveType) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.ActiveType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
