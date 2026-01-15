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
    public class ListNotificationRecordsRequest 
    {
        /// <summary>
        /// 通过该类型查询桌面或桌面池相关的通知拦截记录 - DESKTOP: 查找当前projectId下与桌面相关的通知拦截记录 - DESKTOP_POOL: 查找当前projectId下与桌面池相关的通知拦截记录
        /// </summary>
        /// <value>通过该类型查询桌面或桌面池相关的通知拦截记录 - DESKTOP: 查找当前projectId下与桌面相关的通知拦截记录 - DESKTOP_POOL: 查找当前projectId下与桌面池相关的通知拦截记录</value>
        [JsonConverter(typeof(EnumClassConverter<QueryTypeEnum>))]
        public class QueryTypeEnum
        {
            /// <summary>
            /// Enum DESKTOP for value: DESKTOP
            /// </summary>
            public static readonly QueryTypeEnum DESKTOP = new QueryTypeEnum("DESKTOP");

            /// <summary>
            /// Enum DESKTOP_POOL for value: DESKTOP_POOL
            /// </summary>
            public static readonly QueryTypeEnum DESKTOP_POOL = new QueryTypeEnum("DESKTOP_POOL");

            private static readonly Dictionary<string, QueryTypeEnum> StaticFields =
            new Dictionary<string, QueryTypeEnum>()
            {
                { "DESKTOP", DESKTOP },
                { "DESKTOP_POOL", DESKTOP_POOL },
            };

            private string _value;

            public QueryTypeEnum()
            {

            }

            public QueryTypeEnum(string value)
            {
                _value = value;
            }

            public static QueryTypeEnum FromValue(string value)
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

                if (this.Equals(obj as QueryTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QueryTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QueryTypeEnum a, QueryTypeEnum b)
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

            public static bool operator !=(QueryTypeEnum a, QueryTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 过滤出与SMN通知类型一致的通知拦截记录 - EMAIL: 通过邮件查找通知拦截记录 - SMS: 通过短信查找通知拦截记录
        /// </summary>
        /// <value>过滤出与SMN通知类型一致的通知拦截记录 - EMAIL: 通过邮件查找通知拦截记录 - SMS: 通过短信查找通知拦截记录</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum EMAIL for value: EMAIL
            /// </summary>
            public static readonly TypeEnum EMAIL = new TypeEnum("EMAIL");

            /// <summary>
            /// Enum SMS for value: SMS
            /// </summary>
            public static readonly TypeEnum SMS = new TypeEnum("SMS");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EMAIL", EMAIL },
                { "SMS", SMS },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - operate_time 发送时间
        /// </summary>
        /// <value>排序字段名称，需要结合sort_type字段一起使用。 - operate_time 发送时间</value>
        [JsonConverter(typeof(EnumClassConverter<SortFieldEnum>))]
        public class SortFieldEnum
        {
            /// <summary>
            /// Enum OPERATE_TIME for value: operate_time
            /// </summary>
            public static readonly SortFieldEnum OPERATE_TIME = new SortFieldEnum("operate_time");

            private static readonly Dictionary<string, SortFieldEnum> StaticFields =
            new Dictionary<string, SortFieldEnum>()
            {
                { "operate_time", OPERATE_TIME },
            };

            private string _value;

            public SortFieldEnum()
            {

            }

            public SortFieldEnum(string value)
            {
                _value = value;
            }

            public static SortFieldEnum FromValue(string value)
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

                if (this.Equals(obj as SortFieldEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortFieldEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortFieldEnum a, SortFieldEnum b)
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

            public static bool operator !=(SortFieldEnum a, SortFieldEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        /// <value>排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。</value>
        [JsonConverter(typeof(EnumClassConverter<SortTypeEnum>))]
        public class SortTypeEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly SortTypeEnum ASC = new SortTypeEnum("ASC");

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly SortTypeEnum DESC = new SortTypeEnum("DESC");

            private static readonly Dictionary<string, SortTypeEnum> StaticFields =
            new Dictionary<string, SortTypeEnum>()
            {
                { "ASC", ASC },
                { "DESC", DESC },
            };

            private string _value;

            public SortTypeEnum()
            {

            }

            public SortTypeEnum(string value)
            {
                _value = value;
            }

            public static SortTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SortTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortTypeEnum a, SortTypeEnum b)
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

            public static bool operator !=(SortTypeEnum a, SortTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 通过该类型查询桌面或桌面池相关的通知拦截记录 - DESKTOP: 查找当前projectId下与桌面相关的通知拦截记录 - DESKTOP_POOL: 查找当前projectId下与桌面池相关的通知拦截记录
        /// </summary>
        [SDKProperty("query_type", IsQuery = true)]
        [JsonProperty("query_type", NullValueHandling = NullValueHandling.Ignore)]
        public QueryTypeEnum QueryType { get; set; }
        /// <summary>
        /// 桌面名
        /// </summary>
        [SDKProperty("desktop_name", IsQuery = true)]
        [JsonProperty("desktop_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopName { get; set; }

        /// <summary>
        /// 桌面池名称，桌面池名称必须保证唯一。桌面名称只允许输入中文、大写字母、小写字母、数字、中划线，长度范围为1~255。
        /// </summary>
        [SDKProperty("desktop_pool_name", IsQuery = true)]
        [JsonProperty("desktop_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopPoolName { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 过滤出与SMN通知类型一致的通知拦截记录 - EMAIL: 通过邮件查找通知拦截记录 - SMS: 通过短信查找通知拦截记录
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 用于分页查询，取值范围0-1000，默认值1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - operate_time 发送时间
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public SortFieldEnum SortField { get; set; }
        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        [SDKProperty("sort_type", IsQuery = true)]
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public SortTypeEnum SortType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNotificationRecordsRequest {\n");
            sb.Append("  queryType: ").Append(QueryType).Append("\n");
            sb.Append("  desktopName: ").Append(DesktopName).Append("\n");
            sb.Append("  desktopPoolName: ").Append(DesktopPoolName).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNotificationRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNotificationRecordsRequest input)
        {
            if (input == null) return false;
            if (this.QueryType != input.QueryType) return false;
            if (this.DesktopName != input.DesktopName || (this.DesktopName != null && !this.DesktopName.Equals(input.DesktopName))) return false;
            if (this.DesktopPoolName != input.DesktopPoolName || (this.DesktopPoolName != null && !this.DesktopPoolName.Equals(input.DesktopPoolName))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Type != input.Type) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SortField != input.SortField) return false;
            if (this.SortType != input.SortType) return false;

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
                hashCode = hashCode * 59 + this.QueryType.GetHashCode();
                if (this.DesktopName != null) hashCode = hashCode * 59 + this.DesktopName.GetHashCode();
                if (this.DesktopPoolName != null) hashCode = hashCode * 59 + this.DesktopPoolName.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.SortField.GetHashCode();
                hashCode = hashCode * 59 + this.SortType.GetHashCode();
                return hashCode;
            }
        }
    }
}
