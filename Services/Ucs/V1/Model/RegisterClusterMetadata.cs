using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ucs.V1.Model
{
    /// <summary>
    /// 集群元数据信息。
    /// </summary>
    public class RegisterClusterMetadata 
    {

        /// <summary>
        /// 集群ID信息，仅在注册CCE导入集群时使用，其他类型集群无需填写。
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// CCE集群填写CCE集群名称，其他类型集群自定义
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 标签信息。可为空，不为空时，必须满足kurbenetes label规范,最多可支持100个标签。
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// 集群annotations信息。 附着集群必填一个kubeconfig字段，取值是kubeconfig文件的内容。kubeconfig文件获取方法请参见[获取KubeConfig文件](https://support.huaweicloud.com/usermanual-ucs/ucs_01_0138.html)
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Annotations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RegisterClusterMetadata {\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegisterClusterMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RegisterClusterMetadata input)
        {
            if (input == null) return false;
            if (this.Uid != input.Uid || (this.Uid != null && !this.Uid.Equals(input.Uid))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && input.Labels != null && !this.Labels.SequenceEqual(input.Labels))) return false;
            if (this.Annotations != input.Annotations || (this.Annotations != null && input.Annotations != null && !this.Annotations.SequenceEqual(input.Annotations))) return false;

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
                if (this.Uid != null) hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Annotations != null) hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                return hashCode;
            }
        }
    }
}
