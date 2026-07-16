using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 自定义启动脚本钩子配置。
    /// </summary>
    public class CustomHooks 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("container_hooks", NullValueHandling = NullValueHandling.Ignore)]
        public ContainerHooks ContainerHooks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomHooks {\n");
            sb.Append("  containerHooks: ").Append(ContainerHooks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CustomHooks);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CustomHooks input)
        {
            if (input == null) return false;
            if (this.ContainerHooks != input.ContainerHooks || (this.ContainerHooks != null && !this.ContainerHooks.Equals(input.ContainerHooks))) return false;

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
                if (this.ContainerHooks != null) hashCode = hashCode * 59 + this.ContainerHooks.GetHashCode();
                return hashCode;
            }
        }
    }
}
