using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rfs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PrivateModuleVersionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 模块的版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义
        /// </summary>
        [JsonProperty("module_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateModuleVersionPrimitiveTypeHolder {\n");
            sb.Append("  moduleVersion: ").Append(ModuleVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateModuleVersionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateModuleVersionPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.ModuleVersion != input.ModuleVersion || (this.ModuleVersion != null && !this.ModuleVersion.Equals(input.ModuleVersion))) return false;

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
                if (this.ModuleVersion != null) hashCode = hashCode * 59 + this.ModuleVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
