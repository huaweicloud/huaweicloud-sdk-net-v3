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
    public class ListHostClustersRequest 
    {
        /// <summary>
        /// 操作系统：windows|linux
        /// </summary>
        /// <value>操作系统：windows|linux</value>
        [JsonConverter(typeof(EnumClassConverter<OsEnum>))]
        public class OsEnum
        {
            /// <summary>
            /// Enum WINDOWS for value: windows
            /// </summary>
            public static readonly OsEnum WINDOWS = new OsEnum("windows");

            /// <summary>
            /// Enum LINUX for value: linux
            /// </summary>
            public static readonly OsEnum LINUX = new OsEnum("linux");

            private static readonly Dictionary<string, OsEnum> StaticFields =
            new Dictionary<string, OsEnum>()
            {
                { "windows", WINDOWS },
                { "linux", LINUX },
            };

            private string _value;

            public OsEnum()
            {

            }

            public OsEnum(string value)
            {
                _value = value;
            }

            public static OsEnum FromValue(string value)
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

                if (this.Equals(obj as OsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsEnum a, OsEnum b)
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

            public static bool operator !=(OsEnum a, OsEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序方式：DESC、ASC，默认为DESC
        /// </summary>
        /// <value>排序方式：DESC、ASC，默认为DESC</value>
        [JsonConverter(typeof(EnumClassConverter<SortTypeEnum>))]
        public class SortTypeEnum
        {
            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly SortTypeEnum DESC = new SortTypeEnum("DESC");

            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly SortTypeEnum ASC = new SortTypeEnum("ASC");

            private static readonly Dictionary<string, SortTypeEnum> StaticFields =
            new Dictionary<string, SortTypeEnum>()
            {
                { "DESC", DESC },
                { "ASC", ASC },
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

            public static bool operator !=(SortTypeEnum a, SortTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 项目id
        /// </summary>
        [SDKProperty("project_id", IsQuery = true)]
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 主机集群模糊查询信息
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 操作系统：windows|linux
        /// </summary>
        [SDKProperty("os", IsQuery = true)]
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public OsEnum Os { get; set; }
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
        /// 排序字段：nick_name|name|owner_name|create_time，不传使用默认排序
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SortField { get; set; }

        /// <summary>
        /// 排序方式：DESC、ASC，默认为DESC
        /// </summary>
        [SDKProperty("sort_type", IsQuery = true)]
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public SortTypeEnum SortType { get; set; }
        /// <summary>
        /// 是否为代理机
        /// </summary>
        [SDKProperty("is_proxy_mode", IsQuery = true)]
        [JsonProperty("is_proxy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsProxyMode { get; set; }

        /// <summary>
        /// 自定义资源池id
        /// </summary>
        [SDKProperty("slave_cluster_id", IsQuery = true)]
        [JsonProperty("slave_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveClusterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHostClustersRequest {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  pageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  isProxyMode: ").Append(IsProxyMode).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHostClustersRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHostClustersRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.PageIndex == input.PageIndex ||
                    (this.PageIndex != null &&
                    this.PageIndex.Equals(input.PageIndex))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.SortField == input.SortField ||
                    (this.SortField != null &&
                    this.SortField.Equals(input.SortField))
                ) && 
                (
                    this.SortType == input.SortType ||
                    (this.SortType != null &&
                    this.SortType.Equals(input.SortType))
                ) && 
                (
                    this.IsProxyMode == input.IsProxyMode ||
                    (this.IsProxyMode != null &&
                    this.IsProxyMode.Equals(input.IsProxyMode))
                ) && 
                (
                    this.SlaveClusterId == input.SlaveClusterId ||
                    (this.SlaveClusterId != null &&
                    this.SlaveClusterId.Equals(input.SlaveClusterId))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.PageIndex != null)
                    hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.PageSize != null)
                    hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.SortField != null)
                    hashCode = hashCode * 59 + this.SortField.GetHashCode();
                if (this.SortType != null)
                    hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.IsProxyMode != null)
                    hashCode = hashCode * 59 + this.IsProxyMode.GetHashCode();
                if (this.SlaveClusterId != null)
                    hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
