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
    public class PrivateHookVersionDescriptionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 私有hook版本的描述。可用于客户识别创建私有hook的版本。注意：hook版本为不可更新（immutable），所以该字段不可更新，如果需要更新，请删除后重建。
        /// </summary>
        [JsonProperty("hook_version_description", NullValueHandling = NullValueHandling.Ignore)]
        public string HookVersionDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateHookVersionDescriptionPrimitiveTypeHolder {\n");
            sb.Append("  hookVersionDescription: ").Append(HookVersionDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateHookVersionDescriptionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateHookVersionDescriptionPrimitiveTypeHolder input)
        {
            if (input == null) return false;
            if (this.HookVersionDescription != input.HookVersionDescription || (this.HookVersionDescription != null && !this.HookVersionDescription.Equals(input.HookVersionDescription))) return false;

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
                if (this.HookVersionDescription != null) hashCode = hashCode * 59 + this.HookVersionDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
