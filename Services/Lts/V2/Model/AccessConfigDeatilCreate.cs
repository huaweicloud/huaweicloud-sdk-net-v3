using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 日志接入详细信息
    /// </summary>
    public class AccessConfigDeatilCreate 
    {
        /// <summary>
        /// CCE接入类型，仅CCE接入类型时使用
        /// </summary>
        /// <value>CCE接入类型，仅CCE接入类型时使用</value>
        [JsonConverter(typeof(EnumClassConverter<PathTypeEnum>))]
        public class PathTypeEnum
        {
            /// <summary>
            /// Enum HOST_FILE for value: HOST_FILE
            /// </summary>
            public static readonly PathTypeEnum HOST_FILE = new PathTypeEnum("HOST_FILE");

            /// <summary>
            /// Enum CONTAINER_STDOUT for value: CONTAINER_STDOUT
            /// </summary>
            public static readonly PathTypeEnum CONTAINER_STDOUT = new PathTypeEnum("CONTAINER_STDOUT");

            /// <summary>
            /// Enum CONTAINER_FILE for value: CONTAINER_FILE
            /// </summary>
            public static readonly PathTypeEnum CONTAINER_FILE = new PathTypeEnum("CONTAINER_FILE");

            private static readonly Dictionary<string, PathTypeEnum> StaticFields =
            new Dictionary<string, PathTypeEnum>()
            {
                { "HOST_FILE", HOST_FILE },
                { "CONTAINER_STDOUT", CONTAINER_STDOUT },
                { "CONTAINER_FILE", CONTAINER_FILE },
            };

            private string _value;

            public PathTypeEnum()
            {

            }

            public PathTypeEnum(string value)
            {
                _value = value;
            }

            public static PathTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PathTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PathTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PathTypeEnum a, PathTypeEnum b)
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

            public static bool operator !=(PathTypeEnum a, PathTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 采集路径。 1. 路径必须以/或者字母:\\\\开头 2. 不能包含特殊字符&lt;&gt; &#39; | \&quot; 且不能只输入/ 3. 第一级目录不支持通配符*：不能以/_**   /_*开头 4.**只能出现一次&#x60;&#x60; CCE类型中 容器路径和主机路径必填，标准输出不用
        /// </summary>
        [JsonProperty("paths", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// 采集路径黑名单。 1. 路径必须以/或者字母:\\\\开头 2. 不能包含特殊字符&lt;&gt; &#39; | \&quot; 且不能只输入/ 3. 第一级目录不支持通配符*：不能以/_**   /_*开头 4.**只能出现一次
        /// </summary>
        [JsonProperty("black_paths", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlackPaths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigFormatCreate Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("windows_log_info", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigWindowsLogInfoCreate WindowsLogInfo { get; set; }

        /// <summary>
        /// 标准输出开关，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("stdout", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stdout { get; set; }

        /// <summary>
        /// 标准输出开关标准错误开关，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("stderr", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stderr { get; set; }

        /// <summary>
        /// CCE接入类型，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("pathType", NullValueHandling = NullValueHandling.Ignore)]
        public PathTypeEnum PathType { get; set; }
        /// <summary>
        /// K8s Namespace正则匹配，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("namespaceRegex", NullValueHandling = NullValueHandling.Ignore)]
        public string NamespaceRegex { get; set; }

        /// <summary>
        /// K8s Pod正则匹配，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("podNameRegex", NullValueHandling = NullValueHandling.Ignore)]
        public string PodNameRegex { get; set; }

        /// <summary>
        /// K8s 容器名称正则匹配，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("containerNameRegex", NullValueHandling = NullValueHandling.Ignore)]
        public string ContainerNameRegex { get; set; }

        /// <summary>
        /// 容器 Label白名单，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("includeLabels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> IncludeLabels { get; set; }

        /// <summary>
        /// 容器 Label黑名单，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("excludeLabels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExcludeLabels { get; set; }

        /// <summary>
        /// 环境变量白名单，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("includeEnvs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> IncludeEnvs { get; set; }

        /// <summary>
        /// 环境变量黑名单，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("excludeEnvs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExcludeEnvs { get; set; }

        /// <summary>
        /// 容器 Label日志标签，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("logLabels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> LogLabels { get; set; }

        /// <summary>
        /// 环境变量日志标签，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("logEnvs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> LogEnvs { get; set; }

        /// <summary>
        /// K8s Label白名单，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("includeK8sLabels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> IncludeK8sLabels { get; set; }

        /// <summary>
        /// K8s Label黑名单，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("excludeK8sLabels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> ExcludeK8sLabels { get; set; }

        /// <summary>
        /// K8s Label日志标签，最多支持创建30个，keyname不支持重名，仅CCE接入类型时使用
        /// </summary>
        [JsonProperty("logK8s", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> LogK8s { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfigDeatilCreate {\n");
            sb.Append("  paths: ").Append(Paths).Append("\n");
            sb.Append("  blackPaths: ").Append(BlackPaths).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  windowsLogInfo: ").Append(WindowsLogInfo).Append("\n");
            sb.Append("  stdout: ").Append(Stdout).Append("\n");
            sb.Append("  stderr: ").Append(Stderr).Append("\n");
            sb.Append("  pathType: ").Append(PathType).Append("\n");
            sb.Append("  namespaceRegex: ").Append(NamespaceRegex).Append("\n");
            sb.Append("  podNameRegex: ").Append(PodNameRegex).Append("\n");
            sb.Append("  containerNameRegex: ").Append(ContainerNameRegex).Append("\n");
            sb.Append("  includeLabels: ").Append(IncludeLabels).Append("\n");
            sb.Append("  excludeLabels: ").Append(ExcludeLabels).Append("\n");
            sb.Append("  includeEnvs: ").Append(IncludeEnvs).Append("\n");
            sb.Append("  excludeEnvs: ").Append(ExcludeEnvs).Append("\n");
            sb.Append("  logLabels: ").Append(LogLabels).Append("\n");
            sb.Append("  logEnvs: ").Append(LogEnvs).Append("\n");
            sb.Append("  includeK8sLabels: ").Append(IncludeK8sLabels).Append("\n");
            sb.Append("  excludeK8sLabels: ").Append(ExcludeK8sLabels).Append("\n");
            sb.Append("  logK8s: ").Append(LogK8s).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfigDeatilCreate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfigDeatilCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
                ) && 
                (
                    this.BlackPaths == input.BlackPaths ||
                    this.BlackPaths != null &&
                    input.BlackPaths != null &&
                    this.BlackPaths.SequenceEqual(input.BlackPaths)
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.WindowsLogInfo == input.WindowsLogInfo ||
                    (this.WindowsLogInfo != null &&
                    this.WindowsLogInfo.Equals(input.WindowsLogInfo))
                ) && 
                (
                    this.Stdout == input.Stdout ||
                    (this.Stdout != null &&
                    this.Stdout.Equals(input.Stdout))
                ) && 
                (
                    this.Stderr == input.Stderr ||
                    (this.Stderr != null &&
                    this.Stderr.Equals(input.Stderr))
                ) && 
                (
                    this.PathType == input.PathType ||
                    (this.PathType != null &&
                    this.PathType.Equals(input.PathType))
                ) && 
                (
                    this.NamespaceRegex == input.NamespaceRegex ||
                    (this.NamespaceRegex != null &&
                    this.NamespaceRegex.Equals(input.NamespaceRegex))
                ) && 
                (
                    this.PodNameRegex == input.PodNameRegex ||
                    (this.PodNameRegex != null &&
                    this.PodNameRegex.Equals(input.PodNameRegex))
                ) && 
                (
                    this.ContainerNameRegex == input.ContainerNameRegex ||
                    (this.ContainerNameRegex != null &&
                    this.ContainerNameRegex.Equals(input.ContainerNameRegex))
                ) && 
                (
                    this.IncludeLabels == input.IncludeLabels ||
                    this.IncludeLabels != null &&
                    input.IncludeLabels != null &&
                    this.IncludeLabels.SequenceEqual(input.IncludeLabels)
                ) && 
                (
                    this.ExcludeLabels == input.ExcludeLabels ||
                    this.ExcludeLabels != null &&
                    input.ExcludeLabels != null &&
                    this.ExcludeLabels.SequenceEqual(input.ExcludeLabels)
                ) && 
                (
                    this.IncludeEnvs == input.IncludeEnvs ||
                    this.IncludeEnvs != null &&
                    input.IncludeEnvs != null &&
                    this.IncludeEnvs.SequenceEqual(input.IncludeEnvs)
                ) && 
                (
                    this.ExcludeEnvs == input.ExcludeEnvs ||
                    this.ExcludeEnvs != null &&
                    input.ExcludeEnvs != null &&
                    this.ExcludeEnvs.SequenceEqual(input.ExcludeEnvs)
                ) && 
                (
                    this.LogLabels == input.LogLabels ||
                    this.LogLabels != null &&
                    input.LogLabels != null &&
                    this.LogLabels.SequenceEqual(input.LogLabels)
                ) && 
                (
                    this.LogEnvs == input.LogEnvs ||
                    this.LogEnvs != null &&
                    input.LogEnvs != null &&
                    this.LogEnvs.SequenceEqual(input.LogEnvs)
                ) && 
                (
                    this.IncludeK8sLabels == input.IncludeK8sLabels ||
                    this.IncludeK8sLabels != null &&
                    input.IncludeK8sLabels != null &&
                    this.IncludeK8sLabels.SequenceEqual(input.IncludeK8sLabels)
                ) && 
                (
                    this.ExcludeK8sLabels == input.ExcludeK8sLabels ||
                    this.ExcludeK8sLabels != null &&
                    input.ExcludeK8sLabels != null &&
                    this.ExcludeK8sLabels.SequenceEqual(input.ExcludeK8sLabels)
                ) && 
                (
                    this.LogK8s == input.LogK8s ||
                    this.LogK8s != null &&
                    input.LogK8s != null &&
                    this.LogK8s.SequenceEqual(input.LogK8s)
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
                if (this.Paths != null)
                    hashCode = hashCode * 59 + this.Paths.GetHashCode();
                if (this.BlackPaths != null)
                    hashCode = hashCode * 59 + this.BlackPaths.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.WindowsLogInfo != null)
                    hashCode = hashCode * 59 + this.WindowsLogInfo.GetHashCode();
                if (this.Stdout != null)
                    hashCode = hashCode * 59 + this.Stdout.GetHashCode();
                if (this.Stderr != null)
                    hashCode = hashCode * 59 + this.Stderr.GetHashCode();
                if (this.PathType != null)
                    hashCode = hashCode * 59 + this.PathType.GetHashCode();
                if (this.NamespaceRegex != null)
                    hashCode = hashCode * 59 + this.NamespaceRegex.GetHashCode();
                if (this.PodNameRegex != null)
                    hashCode = hashCode * 59 + this.PodNameRegex.GetHashCode();
                if (this.ContainerNameRegex != null)
                    hashCode = hashCode * 59 + this.ContainerNameRegex.GetHashCode();
                if (this.IncludeLabels != null)
                    hashCode = hashCode * 59 + this.IncludeLabels.GetHashCode();
                if (this.ExcludeLabels != null)
                    hashCode = hashCode * 59 + this.ExcludeLabels.GetHashCode();
                if (this.IncludeEnvs != null)
                    hashCode = hashCode * 59 + this.IncludeEnvs.GetHashCode();
                if (this.ExcludeEnvs != null)
                    hashCode = hashCode * 59 + this.ExcludeEnvs.GetHashCode();
                if (this.LogLabels != null)
                    hashCode = hashCode * 59 + this.LogLabels.GetHashCode();
                if (this.LogEnvs != null)
                    hashCode = hashCode * 59 + this.LogEnvs.GetHashCode();
                if (this.IncludeK8sLabels != null)
                    hashCode = hashCode * 59 + this.IncludeK8sLabels.GetHashCode();
                if (this.ExcludeK8sLabels != null)
                    hashCode = hashCode * 59 + this.ExcludeK8sLabels.GetHashCode();
                if (this.LogK8s != null)
                    hashCode = hashCode * 59 + this.LogK8s.GetHashCode();
                return hashCode;
            }
        }
    }
}
