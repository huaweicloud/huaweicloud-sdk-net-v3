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
    public class PrivateHookVersionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 私有hook的版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义。
        /// </summary>
        [JsonProperty("hook_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HookVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateHookVersionPrimitiveTypeHolder {\n");
            sb.Append("  hookVersion: ").Append(HookVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateHookVersionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateHookVersionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HookVersion == input.HookVersion ||
                    (this.HookVersion != null &&
                    this.HookVersion.Equals(input.HookVersion))
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
                if (this.HookVersion != null)
                    hashCode = hashCode * 59 + this.HookVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
