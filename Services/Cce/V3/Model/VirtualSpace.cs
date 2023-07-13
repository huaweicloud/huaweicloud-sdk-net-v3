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
    /// 
    /// </summary>
    public class VirtualSpace 
    {

        /// <summary>
        /// virtualSpace的名称，当前仅支持三种类型：kubernetes、runtime、user。 - kubernetes：k8s空间配置，需配置lvmConfig； - runtime：运行时空间配置，需配置runtimeConfig； - user：用户空间配置，需配置lvmConfig 
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// virtualSpace的大小，仅支持整数百分比。例如：90%。 &gt;一个group中所有virtualSpace的百分比之和不得超过100% 
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lvmConfig", NullValueHandling = NullValueHandling.Ignore)]
        public LVMConfig LvmConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtimeConfig", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeConfig RuntimeConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VirtualSpace {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  lvmConfig: ").Append(LvmConfig).Append("\n");
            sb.Append("  runtimeConfig: ").Append(RuntimeConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VirtualSpace);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VirtualSpace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.LvmConfig == input.LvmConfig ||
                    (this.LvmConfig != null &&
                    this.LvmConfig.Equals(input.LvmConfig))
                ) && 
                (
                    this.RuntimeConfig == input.RuntimeConfig ||
                    (this.RuntimeConfig != null &&
                    this.RuntimeConfig.Equals(input.RuntimeConfig))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.LvmConfig != null)
                    hashCode = hashCode * 59 + this.LvmConfig.GetHashCode();
                if (this.RuntimeConfig != null)
                    hashCode = hashCode * 59 + this.RuntimeConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
