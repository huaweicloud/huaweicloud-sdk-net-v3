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
    public class LVMConfig 
    {

        /// <summary>
        /// LVM写入模式：linear、striped。linear：线性模式；striped：条带模式，使用多块磁盘组成条带模式，能够提升磁盘性能。
        /// </summary>
        [JsonProperty("lvType", NullValueHandling = NullValueHandling.Ignore)]
        public string LvType { get; set; }

        /// <summary>
        /// 磁盘挂载路径。仅在用户配置中生效。支持包含：数字、大小写字母、点、中划线、下划线的绝对路径。
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LVMConfig {\n");
            sb.Append("  lvType: ").Append(LvType).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LVMConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LVMConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LvType == input.LvType ||
                    (this.LvType != null &&
                    this.LvType.Equals(input.LvType))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
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
                if (this.LvType != null)
                    hashCode = hashCode * 59 + this.LvType.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                return hashCode;
            }
        }
    }
}
