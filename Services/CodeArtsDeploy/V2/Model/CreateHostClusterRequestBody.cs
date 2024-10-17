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
    /// 主机集群详细信息
    /// </summary>
    public class CreateHostClusterRequestBody 
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
        /// 主机集群名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 操作系统：windows|linux
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public OsEnum Os { get; set; }
        /// <summary>
        /// slave集群id，默认为null时使用默认slave集群，用户自定义slave时为slave集群id
        /// </summary>
        [JsonProperty("slave_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SlaveClusterId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 主机集群是否为代理机接入模式， 1：是 0：否
        /// </summary>
        [JsonProperty("is_proxy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsProxyMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateHostClusterRequestBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  slaveClusterId: ").Append(SlaveClusterId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isProxyMode: ").Append(IsProxyMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateHostClusterRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateHostClusterRequestBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Os != input.Os) return false;
            if (this.SlaveClusterId != input.SlaveClusterId || (this.SlaveClusterId != null && !this.SlaveClusterId.Equals(input.SlaveClusterId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsProxyMode != input.IsProxyMode || (this.IsProxyMode != null && !this.IsProxyMode.Equals(input.IsProxyMode))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.SlaveClusterId != null) hashCode = hashCode * 59 + this.SlaveClusterId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsProxyMode != null) hashCode = hashCode * 59 + this.IsProxyMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
