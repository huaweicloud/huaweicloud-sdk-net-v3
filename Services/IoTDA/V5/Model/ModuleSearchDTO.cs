using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// OTA模块结构。
    /// </summary>
    public class ModuleSearchDTO 
    {

        /// <summary>
        /// 模块名称。
        /// </summary>
        [JsonProperty("module_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleName { get; set; }

        /// <summary>
        /// 模块版本号。
        /// </summary>
        [JsonProperty("module_version", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModuleSearchDTO {\n");
            sb.Append("  moduleName: ").Append(ModuleName).Append("\n");
            sb.Append("  moduleVersion: ").Append(ModuleVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModuleSearchDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModuleSearchDTO input)
        {
            if (input == null) return false;
            if (this.ModuleName != input.ModuleName || (this.ModuleName != null && !this.ModuleName.Equals(input.ModuleName))) return false;
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
                if (this.ModuleName != null) hashCode = hashCode * 59 + this.ModuleName.GetHashCode();
                if (this.ModuleVersion != null) hashCode = hashCode * 59 + this.ModuleVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
