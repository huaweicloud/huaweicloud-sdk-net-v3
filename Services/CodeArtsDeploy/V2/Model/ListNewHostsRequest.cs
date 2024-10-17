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
    public class ListNewHostsRequest 
    {
        /// <summary>
        /// 排序方式：DESC、ASC，默认为DESC
        /// </summary>
        /// <value>排序方式：DESC、ASC，默认为DESC</value>
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
        /// 项目id
        /// </summary>
        [SDKProperty("group_id", IsPath = true)]
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 主机名模糊查询信息
        /// </summary>
        [SDKProperty("key_field", IsQuery = true)]
        [JsonProperty("key_field", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyField { get; set; }

        /// <summary>
        /// 环境id
        /// </summary>
        [SDKProperty("environment_id", IsQuery = true)]
        [JsonProperty("environment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// 页码数
        /// </summary>
        [SDKProperty("page_index", IsQuery = true)]
        [JsonProperty("page_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// 每页显示的条目数量，默认为10
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 排序字段：as_proxy|host_name|owner_name，不传使用默认排序
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SortKey { get; set; }

        /// <summary>
        /// 排序方式：DESC、ASC，默认为DESC
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public SortDirEnum SortDir { get; set; }
        /// <summary>
        /// 是否为代理机
        /// </summary>
        [SDKProperty("as_proxy", IsQuery = true)]
        [JsonProperty("as_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsProxy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNewHostsRequest {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  keyField: ").Append(KeyField).Append("\n");
            sb.Append("  environmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  pageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  asProxy: ").Append(AsProxy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNewHostsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNewHostsRequest input)
        {
            if (input == null) return false;
            if (this.GroupId != input.GroupId || (this.GroupId != null && !this.GroupId.Equals(input.GroupId))) return false;
            if (this.KeyField != input.KeyField || (this.KeyField != null && !this.KeyField.Equals(input.KeyField))) return false;
            if (this.EnvironmentId != input.EnvironmentId || (this.EnvironmentId != null && !this.EnvironmentId.Equals(input.EnvironmentId))) return false;
            if (this.PageIndex != input.PageIndex || (this.PageIndex != null && !this.PageIndex.Equals(input.PageIndex))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && !this.SortKey.Equals(input.SortKey))) return false;
            if (this.SortDir != input.SortDir) return false;
            if (this.AsProxy != input.AsProxy || (this.AsProxy != null && !this.AsProxy.Equals(input.AsProxy))) return false;

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
                if (this.KeyField != null) hashCode = hashCode * 59 + this.KeyField.GetHashCode();
                if (this.EnvironmentId != null) hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.PageIndex != null) hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.SortKey != null) hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.AsProxy != null) hashCode = hashCode * 59 + this.AsProxy.GetHashCode();
                return hashCode;
            }
        }
    }
}
