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
    /// 
    /// </summary>
    public class AccessConfigDeatilUpdate 
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

            public static bool operator !=(PathTypeEnum a, PathTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 1.路径必须以/或者字母:\\开头 2.不能包含特殊字符&lt;&gt; &#39; | \&quot; 且不能只输入/ 3.第一级目录不支持通配符*：不能以/_**   /_*开头 4.**只能出现一次 5.最大数量为10
        /// </summary>
        [JsonProperty("paths", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Paths { get; set; }

        /// <summary>
        /// 1.路径必须以/或者字母:\\开头 2.不能包含特殊字符&lt;&gt; &#39; | \&quot; 且不能只输入/ 3.第一级目录不支持通配符*：不能以/_**   /_*开头 4.**只能出现一次 5.最大数量为10
        /// </summary>
        [JsonProperty("black_paths", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BlackPaths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigFormatUpdate Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("windows_log_info", NullValueHandling = NullValueHandling.Ignore)]
        public AccessConfigWindowsLogInfoUpdate WindowsLogInfo { get; set; }

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
        /// 系统内置字段：配置日志接入规则时，可以配置系统内置字段，上报日志后，每条日志数据的标签数据中将会有系统字段 采集场景为主机文件的内置字段为：hostName、hostId、hostIP、pathFile、hostIPv6、category、collectTime、__host_group__ 采集场景为K8S集群容器文件的内置字段为：hostName、hostId、hostIP、pathFile、hostIPv6、clusterId、podName、appName、containerName、nameSpace、category、collectTime、__host_group__、serviceID、podIp、clusterName、workloadType 若修改时传入此字段，将覆盖原有配置
        /// </summary>
        [JsonProperty("system_fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SystemFields { get; set; }

        /// <summary>
        /// 自定义键值对：配置日志接入规则时，可以配置自定义键值对规则，上报日志后，每条日志数据的标签数据中将会有用户自定义的键值对字段，键值对数量不超过20 键的长度限制为128，允许的字符有a-zA-Z0-9_- 值的长度限制为1024 若修改时传入此字段，将覆盖原有配置
        /// </summary>
        [JsonProperty("custom_key_value", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> CustomKeyValue { get; set; }

        /// <summary>
        /// 容器 Label白名单，可选为AND，OR，不配置时默认为OR；当存在多个值时的处理逻辑，AND表示同时满足才会生效，OR表示有一项满足就会生效
        /// </summary>
        [JsonProperty("includeLabelsLogical", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeLabelsLogical { get; set; }

        /// <summary>
        /// 容器 Label黑名单，可选为AND，OR，不配置时默认为OR；当存在多个值时的处理逻辑，AND表示同时满足才会生效，OR表示有一项满足就会生效
        /// </summary>
        [JsonProperty("excludeLabelsLogical", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeLabelsLogical { get; set; }

        /// <summary>
        /// K8S Label白名单，可选为AND，OR，不配置时默认为OR；当存在多个值时的处理逻辑，AND表示同时满足才会生效，OR表示有一项满足就会生效
        /// </summary>
        [JsonProperty("includeK8sLabelsLogical", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeK8sLabelsLogical { get; set; }

        /// <summary>
        /// K8S Label黑名单，可选为AND，OR，不配置时默认为OR；当存在多个值时的处理逻辑，AND表示同时满足才会生效，OR表示有一项满足就会生效
        /// </summary>
        [JsonProperty("excludeK8sLabelsLogical", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeK8sLabelsLogical { get; set; }

        /// <summary>
        /// 环境变量白名单，可选为AND，OR，不配置时默认为OR；当存在多个值时的处理逻辑，AND表示同时满足才会生效，OR表示有一项满足就会生效
        /// </summary>
        [JsonProperty("includeEnvsLogical", NullValueHandling = NullValueHandling.Ignore)]
        public string IncludeEnvsLogical { get; set; }

        /// <summary>
        /// 环境变量黑名单，可选为AND，OR，不配置时默认为OR；当存在多个值时的处理逻辑，AND表示同时满足才会生效，OR表示有一项满足就会生效
        /// </summary>
        [JsonProperty("excludeEnvsLogical", NullValueHandling = NullValueHandling.Ignore)]
        public string ExcludeEnvsLogical { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessConfigDeatilUpdate {\n");
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
            sb.Append("  systemFields: ").Append(SystemFields).Append("\n");
            sb.Append("  customKeyValue: ").Append(CustomKeyValue).Append("\n");
            sb.Append("  includeLabelsLogical: ").Append(IncludeLabelsLogical).Append("\n");
            sb.Append("  excludeLabelsLogical: ").Append(ExcludeLabelsLogical).Append("\n");
            sb.Append("  includeK8sLabelsLogical: ").Append(IncludeK8sLabelsLogical).Append("\n");
            sb.Append("  excludeK8sLabelsLogical: ").Append(ExcludeK8sLabelsLogical).Append("\n");
            sb.Append("  includeEnvsLogical: ").Append(IncludeEnvsLogical).Append("\n");
            sb.Append("  excludeEnvsLogical: ").Append(ExcludeEnvsLogical).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessConfigDeatilUpdate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessConfigDeatilUpdate input)
        {
            if (input == null) return false;
            if (this.Paths != input.Paths || (this.Paths != null && input.Paths != null && !this.Paths.SequenceEqual(input.Paths))) return false;
            if (this.BlackPaths != input.BlackPaths || (this.BlackPaths != null && input.BlackPaths != null && !this.BlackPaths.SequenceEqual(input.BlackPaths))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.WindowsLogInfo != input.WindowsLogInfo || (this.WindowsLogInfo != null && !this.WindowsLogInfo.Equals(input.WindowsLogInfo))) return false;
            if (this.Stdout != input.Stdout || (this.Stdout != null && !this.Stdout.Equals(input.Stdout))) return false;
            if (this.Stderr != input.Stderr || (this.Stderr != null && !this.Stderr.Equals(input.Stderr))) return false;
            if (this.PathType != input.PathType) return false;
            if (this.NamespaceRegex != input.NamespaceRegex || (this.NamespaceRegex != null && !this.NamespaceRegex.Equals(input.NamespaceRegex))) return false;
            if (this.PodNameRegex != input.PodNameRegex || (this.PodNameRegex != null && !this.PodNameRegex.Equals(input.PodNameRegex))) return false;
            if (this.ContainerNameRegex != input.ContainerNameRegex || (this.ContainerNameRegex != null && !this.ContainerNameRegex.Equals(input.ContainerNameRegex))) return false;
            if (this.IncludeLabels != input.IncludeLabels || (this.IncludeLabels != null && input.IncludeLabels != null && !this.IncludeLabels.SequenceEqual(input.IncludeLabels))) return false;
            if (this.ExcludeLabels != input.ExcludeLabels || (this.ExcludeLabels != null && input.ExcludeLabels != null && !this.ExcludeLabels.SequenceEqual(input.ExcludeLabels))) return false;
            if (this.IncludeEnvs != input.IncludeEnvs || (this.IncludeEnvs != null && input.IncludeEnvs != null && !this.IncludeEnvs.SequenceEqual(input.IncludeEnvs))) return false;
            if (this.ExcludeEnvs != input.ExcludeEnvs || (this.ExcludeEnvs != null && input.ExcludeEnvs != null && !this.ExcludeEnvs.SequenceEqual(input.ExcludeEnvs))) return false;
            if (this.LogLabels != input.LogLabels || (this.LogLabels != null && input.LogLabels != null && !this.LogLabels.SequenceEqual(input.LogLabels))) return false;
            if (this.LogEnvs != input.LogEnvs || (this.LogEnvs != null && input.LogEnvs != null && !this.LogEnvs.SequenceEqual(input.LogEnvs))) return false;
            if (this.IncludeK8sLabels != input.IncludeK8sLabels || (this.IncludeK8sLabels != null && input.IncludeK8sLabels != null && !this.IncludeK8sLabels.SequenceEqual(input.IncludeK8sLabels))) return false;
            if (this.ExcludeK8sLabels != input.ExcludeK8sLabels || (this.ExcludeK8sLabels != null && input.ExcludeK8sLabels != null && !this.ExcludeK8sLabels.SequenceEqual(input.ExcludeK8sLabels))) return false;
            if (this.LogK8s != input.LogK8s || (this.LogK8s != null && input.LogK8s != null && !this.LogK8s.SequenceEqual(input.LogK8s))) return false;
            if (this.SystemFields != input.SystemFields || (this.SystemFields != null && input.SystemFields != null && !this.SystemFields.SequenceEqual(input.SystemFields))) return false;
            if (this.CustomKeyValue != input.CustomKeyValue || (this.CustomKeyValue != null && input.CustomKeyValue != null && !this.CustomKeyValue.SequenceEqual(input.CustomKeyValue))) return false;
            if (this.IncludeLabelsLogical != input.IncludeLabelsLogical || (this.IncludeLabelsLogical != null && !this.IncludeLabelsLogical.Equals(input.IncludeLabelsLogical))) return false;
            if (this.ExcludeLabelsLogical != input.ExcludeLabelsLogical || (this.ExcludeLabelsLogical != null && !this.ExcludeLabelsLogical.Equals(input.ExcludeLabelsLogical))) return false;
            if (this.IncludeK8sLabelsLogical != input.IncludeK8sLabelsLogical || (this.IncludeK8sLabelsLogical != null && !this.IncludeK8sLabelsLogical.Equals(input.IncludeK8sLabelsLogical))) return false;
            if (this.ExcludeK8sLabelsLogical != input.ExcludeK8sLabelsLogical || (this.ExcludeK8sLabelsLogical != null && !this.ExcludeK8sLabelsLogical.Equals(input.ExcludeK8sLabelsLogical))) return false;
            if (this.IncludeEnvsLogical != input.IncludeEnvsLogical || (this.IncludeEnvsLogical != null && !this.IncludeEnvsLogical.Equals(input.IncludeEnvsLogical))) return false;
            if (this.ExcludeEnvsLogical != input.ExcludeEnvsLogical || (this.ExcludeEnvsLogical != null && !this.ExcludeEnvsLogical.Equals(input.ExcludeEnvsLogical))) return false;

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
                if (this.Paths != null) hashCode = hashCode * 59 + this.Paths.GetHashCode();
                if (this.BlackPaths != null) hashCode = hashCode * 59 + this.BlackPaths.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.WindowsLogInfo != null) hashCode = hashCode * 59 + this.WindowsLogInfo.GetHashCode();
                if (this.Stdout != null) hashCode = hashCode * 59 + this.Stdout.GetHashCode();
                if (this.Stderr != null) hashCode = hashCode * 59 + this.Stderr.GetHashCode();
                hashCode = hashCode * 59 + this.PathType.GetHashCode();
                if (this.NamespaceRegex != null) hashCode = hashCode * 59 + this.NamespaceRegex.GetHashCode();
                if (this.PodNameRegex != null) hashCode = hashCode * 59 + this.PodNameRegex.GetHashCode();
                if (this.ContainerNameRegex != null) hashCode = hashCode * 59 + this.ContainerNameRegex.GetHashCode();
                if (this.IncludeLabels != null) hashCode = hashCode * 59 + this.IncludeLabels.GetHashCode();
                if (this.ExcludeLabels != null) hashCode = hashCode * 59 + this.ExcludeLabels.GetHashCode();
                if (this.IncludeEnvs != null) hashCode = hashCode * 59 + this.IncludeEnvs.GetHashCode();
                if (this.ExcludeEnvs != null) hashCode = hashCode * 59 + this.ExcludeEnvs.GetHashCode();
                if (this.LogLabels != null) hashCode = hashCode * 59 + this.LogLabels.GetHashCode();
                if (this.LogEnvs != null) hashCode = hashCode * 59 + this.LogEnvs.GetHashCode();
                if (this.IncludeK8sLabels != null) hashCode = hashCode * 59 + this.IncludeK8sLabels.GetHashCode();
                if (this.ExcludeK8sLabels != null) hashCode = hashCode * 59 + this.ExcludeK8sLabels.GetHashCode();
                if (this.LogK8s != null) hashCode = hashCode * 59 + this.LogK8s.GetHashCode();
                if (this.SystemFields != null) hashCode = hashCode * 59 + this.SystemFields.GetHashCode();
                if (this.CustomKeyValue != null) hashCode = hashCode * 59 + this.CustomKeyValue.GetHashCode();
                if (this.IncludeLabelsLogical != null) hashCode = hashCode * 59 + this.IncludeLabelsLogical.GetHashCode();
                if (this.ExcludeLabelsLogical != null) hashCode = hashCode * 59 + this.ExcludeLabelsLogical.GetHashCode();
                if (this.IncludeK8sLabelsLogical != null) hashCode = hashCode * 59 + this.IncludeK8sLabelsLogical.GetHashCode();
                if (this.ExcludeK8sLabelsLogical != null) hashCode = hashCode * 59 + this.ExcludeK8sLabelsLogical.GetHashCode();
                if (this.IncludeEnvsLogical != null) hashCode = hashCode * 59 + this.IncludeEnvsLogical.GetHashCode();
                if (this.ExcludeEnvsLogical != null) hashCode = hashCode * 59 + this.ExcludeEnvsLogical.GetHashCode();
                return hashCode;
            }
        }
    }
}
