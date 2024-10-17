using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEnvironmentsRequest 
    {
        /// <summary>
        /// 排序字段，支持按照环境名称|用户名称|创建时间|用户昵称排序
        /// </summary>
        /// <value>排序字段，支持按照环境名称|用户名称|创建时间|用户昵称排序</value>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum NAME for value: NAME
            /// </summary>
            public static readonly SortKeyEnum NAME = new SortKeyEnum("NAME");

            /// <summary>
            /// Enum USER_NAME for value: USER_NAME
            /// </summary>
            public static readonly SortKeyEnum USER_NAME = new SortKeyEnum("USER_NAME");

            /// <summary>
            /// Enum CREATED_TIME for value: CREATED_TIME
            /// </summary>
            public static readonly SortKeyEnum CREATED_TIME = new SortKeyEnum("CREATED_TIME");

            /// <summary>
            /// Enum NICK_NAME for value: NICK_NAME
            /// </summary>
            public static readonly SortKeyEnum NICK_NAME = new SortKeyEnum("NICK_NAME");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "NAME", NAME },
                { "USER_NAME", USER_NAME },
                { "CREATED_TIME", CREATED_TIME },
                { "NICK_NAME", NICK_NAME },
            };

            private string _value;

            public SortKeyEnum()
            {

            }

            public SortKeyEnum(string value)
            {
                _value = value;
            }

            public static SortKeyEnum FromValue(string value)
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
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

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序顺序，DESC降序，ASC升序
        /// </summary>
        /// <value>排序顺序，DESC降序，ASC升序</value>
        [JsonConverter(typeof(EnumClassConverter<SortDirEnum>))]
        public class SortDirEnum
        {
            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly SortDirEnum DESC = new SortDirEnum("DESC");

            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly SortDirEnum ASC = new SortDirEnum("ASC");

            private static readonly Dictionary<string, SortDirEnum> StaticFields =
            new Dictionary<string, SortDirEnum>()
            {
                { "DESC", DESC },
                { "ASC", ASC },
            };

            private string _value;

            public SortDirEnum()
            {

            }

            public SortDirEnum(string value)
            {
                _value = value;
            }

            public static SortDirEnum FromValue(string value)
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

                if (this.Equals(obj as SortDirEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortDirEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortDirEnum a, SortDirEnum b)
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

            public static bool operator !=(SortDirEnum a, SortDirEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 应用id
        /// </summary>
        [SDKProperty("application_id", IsPath = true)]
        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 分页页码， 表示从此页开始查询， page大于等于1
        /// </summary>
        [SDKProperty("page_index", IsQuery = true)]
        [JsonProperty("page_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// 每页显示的条目数量，size小于等于100
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 要查询的环境名称
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 排序字段，支持按照环境名称|用户名称|创建时间|用户昵称排序
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public SortKeyEnum SortKey { get; set; }
        /// <summary>
        /// 排序顺序，DESC降序，ASC升序
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public SortDirEnum SortDir { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEnvironmentsRequest {\n");
            sb.Append("  applicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  pageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEnvironmentsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEnvironmentsRequest input)
        {
            if (input == null) return false;
            if (this.ApplicationId != input.ApplicationId || (this.ApplicationId != null && !this.ApplicationId.Equals(input.ApplicationId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.PageIndex != input.PageIndex || (this.PageIndex != null && !this.PageIndex.Equals(input.PageIndex))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SortKey != input.SortKey) return false;
            if (this.SortDir != input.SortDir) return false;

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
                if (this.ApplicationId != null) hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.PageIndex != null) hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                return hashCode;
            }
        }
    }
}
