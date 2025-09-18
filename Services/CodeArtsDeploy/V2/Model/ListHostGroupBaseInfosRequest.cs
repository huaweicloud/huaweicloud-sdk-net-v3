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
    public class ListHostGroupBaseInfosRequest 
    {
        /// <summary>
        /// 操作系统：windows|linux
        /// </summary>
        /// <value>操作系统：windows|linux</value>
        [JsonConverter(typeof(EnumClassConverter<OsEnum>))]
        public class OsEnum
        {
            /// <summary>
            /// Enum LINUX for value: linux
            /// </summary>
            public static readonly OsEnum LINUX = new OsEnum("linux");

            /// <summary>
            /// Enum WINDOWS for value: windows
            /// </summary>
            public static readonly OsEnum WINDOWS = new OsEnum("windows");

            private static readonly Dictionary<string, OsEnum> StaticFields =
            new Dictionary<string, OsEnum>()
            {
                { "linux", LINUX },
                { "windows", WINDOWS },
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

            public static bool operator !=(OsEnum a, OsEnum b)
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
        [SDKProperty("project_uuid", IsQuery = true)]
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 操作系统：windows|linux
        /// </summary>
        [SDKProperty("os", IsQuery = true)]
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public OsEnum Os { get; set; }
        /// <summary>
        /// 分页页码
        /// </summary>
        [SDKProperty("page_index", IsQuery = true)]
        [JsonProperty("page_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// 分页查询每页条数
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 按主机集群名称搜索关键字
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListHostGroupBaseInfosRequest {\n");
            sb.Append("  applicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  pageIndex: ").Append(PageIndex).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListHostGroupBaseInfosRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListHostGroupBaseInfosRequest input)
        {
            if (input == null) return false;
            if (this.ApplicationId != input.ApplicationId || (this.ApplicationId != null && !this.ApplicationId.Equals(input.ApplicationId))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.Os != input.Os) return false;
            if (this.PageIndex != input.PageIndex || (this.PageIndex != null && !this.PageIndex.Equals(input.PageIndex))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.PageIndex != null) hashCode = hashCode * 59 + this.PageIndex.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
