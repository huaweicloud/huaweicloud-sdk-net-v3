using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// spec是集合类的元素类型，内容为插件实例安装/升级的具体请求信息
    /// </summary>
    public class InstanceRequestSpec 
    {

        /// <summary>
        /// 待安装、升级插件的具体版本版本号，例如1.0.0
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("clusterID", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterID { get; set; }

        /// <summary>
        /// 插件模板安装参数（各插件不同），升级插件时需要填写全量安装参数，未填写参数将使用插件模板中的默认值，当前插件安装参数可通过查询插件实例接口获取。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Values { get; set; }

        /// <summary>
        /// 待安装插件模板名称，如coredns
        /// </summary>
        [JsonProperty("addonTemplateName", NullValueHandling = NullValueHandling.Ignore)]
        public string AddonTemplateName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceRequestSpec {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  clusterID: ").Append(ClusterID).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("  addonTemplateName: ").Append(AddonTemplateName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InstanceRequestSpec);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InstanceRequestSpec input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.ClusterID == input.ClusterID ||
                    (this.ClusterID != null &&
                    this.ClusterID.Equals(input.ClusterID))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.AddonTemplateName == input.AddonTemplateName ||
                    (this.AddonTemplateName != null &&
                    this.AddonTemplateName.Equals(input.AddonTemplateName))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ClusterID != null)
                    hashCode = hashCode * 59 + this.ClusterID.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.AddonTemplateName != null)
                    hashCode = hashCode * 59 + this.AddonTemplateName.GetHashCode();
                return hashCode;
            }
        }
    }
}
