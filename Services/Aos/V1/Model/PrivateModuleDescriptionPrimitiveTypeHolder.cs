using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrivateModuleDescriptionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 私有模块（private-module）的描述。可用于客户识别被管理的私有模块。如果想要更新私有模块的描述，可以通过UpdatePrivateModuleMetadata API。
        /// </summary>
        [JsonProperty("module_description", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateModuleDescriptionPrimitiveTypeHolder {\n");
            sb.Append("  moduleDescription: ").Append(ModuleDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateModuleDescriptionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateModuleDescriptionPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.ModuleDescription != input.ModuleDescription || (this.ModuleDescription != null && !this.ModuleDescription.Equals(input.ModuleDescription))) return false;

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
                if (this.ModuleDescription != null) hashCode = hashCode * 59 + this.ModuleDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
