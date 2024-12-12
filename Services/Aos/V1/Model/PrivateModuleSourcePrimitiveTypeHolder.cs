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
    public class PrivateModuleSourcePrimitiveTypeHolder 
    {

        /// <summary>
        /// 在模板中使用模块需要定义如下格式：   module \&quot;my_hello_word_module\&quot; {     source &#x3D; {module_source}   }  其中{module_source}为本参数
        /// </summary>
        [JsonProperty("module_source", NullValueHandling = NullValueHandling.Ignore)]
        public string ModuleSource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateModuleSourcePrimitiveTypeHolder {\n");
            sb.Append("  moduleSource: ").Append(ModuleSource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateModuleSourcePrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateModuleSourcePrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.ModuleSource != input.ModuleSource || (this.ModuleSource != null && !this.ModuleSource.Equals(input.ModuleSource))) return false;

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
                if (this.ModuleSource != null) hashCode = hashCode * 59 + this.ModuleSource.GetHashCode();
                return hashCode;
            }
        }
    }
}
