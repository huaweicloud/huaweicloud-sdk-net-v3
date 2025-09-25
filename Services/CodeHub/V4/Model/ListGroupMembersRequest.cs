using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListGroupMembersRequest 
    {
        /// <summary>
        /// **参数解释：** 成员加入方式 domain 租户 normal 普通 inherit 继承
        /// </summary>
        /// <value>**参数解释：** 成员加入方式 domain 租户 normal 普通 inherit 继承</value>
        [JsonConverter(typeof(EnumClassConverter<JoinWayEnum>))]
        public class JoinWayEnum
        {
            /// <summary>
            /// Enum DOMAIN for value: domain
            /// </summary>
            public static readonly JoinWayEnum DOMAIN = new JoinWayEnum("domain");

            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly JoinWayEnum NORMAL = new JoinWayEnum("normal");

            /// <summary>
            /// Enum INHERIT for value: inherit
            /// </summary>
            public static readonly JoinWayEnum INHERIT = new JoinWayEnum("inherit");

            private static readonly Dictionary<string, JoinWayEnum> StaticFields =
            new Dictionary<string, JoinWayEnum>()
            {
                { "domain", DOMAIN },
                { "normal", NORMAL },
                { "inherit", INHERIT },
            };

            private string _value;

            public JoinWayEnum()
            {

            }

            public JoinWayEnum(string value)
            {
                _value = value;
            }

            public static JoinWayEnum FromValue(string value)
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

                if (this.Equals(obj as JoinWayEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(JoinWayEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(JoinWayEnum a, JoinWayEnum b)
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

            public static bool operator !=(JoinWayEnum a, JoinWayEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 代码组id，代码组首页，Group ID后的数字Id
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupId { get; set; }

        /// <summary>
        /// **参数解释：** 项目的32位uuid，项目唯一标识，通过[[查询项目列表](https://support.huaweicloud.com/api-projectman/ListProjectsV4.html)](tag:hws)[[查询项目列表](https://support.huaweicloud.com/intl/en-us/api-projectman/ListProjectsV4.html)](tag:hws_hk)[查询项目列表](tag:hcs,hcs_sm)接口查询项目列表获取。 **取值范围：** 字符串长度32。
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 成员搜索字符串
        /// </summary>
        [SDKProperty("query", IsQuery = true)]
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// **参数解释：** 成员加入方式 domain 租户 normal 普通 inherit 继承
        /// </summary>
        [SDKProperty("join_way", IsQuery = true)]
        [JsonProperty("join_way", NullValueHandling = NullValueHandling.Ignore)]
        public JoinWayEnum JoinWay { get; set; }
        /// <summary>
        /// **参数解释：** 过滤成员的access level， 10待审核 20浏览者 30开发者 40管理员 50所有者
        /// </summary>
        [SDKProperty("access_level", IsQuery = true)]
        [JsonProperty("access_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessLevel { get; set; }

        /// <summary>
        /// **参数解释：** 偏移量，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 返回数量。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGroupMembersRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  joinWay: ").Append(JoinWay).Append("\n");
            sb.Append("  accessLevel: ").Append(AccessLevel).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGroupMembersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGroupMembersRequest input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.JoinWay != input.JoinWay) return false;
            if (this.AccessLevel != input.AccessLevel || (this.AccessLevel != null && !this.AccessLevel.Equals(input.AccessLevel))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.GroupId != null) hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                hashCode = hashCode * 59 + this.JoinWay.GetHashCode();
                if (this.AccessLevel != null) hashCode = hashCode * 59 + this.AccessLevel.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
