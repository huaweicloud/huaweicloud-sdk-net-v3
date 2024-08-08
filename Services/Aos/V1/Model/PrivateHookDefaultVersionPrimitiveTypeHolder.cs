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
    public class PrivateHookDefaultVersionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 私有hook的默认版本号。版本号必须遵循语义化版本号（Semantic Version），为用户自定义。
        /// </summary>
        [JsonProperty("default_version", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateHookDefaultVersionPrimitiveTypeHolder {\n");
            sb.Append("  defaultVersion: ").Append(DefaultVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateHookDefaultVersionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateHookDefaultVersionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DefaultVersion == input.DefaultVersion ||
                    (this.DefaultVersion != null &&
                    this.DefaultVersion.Equals(input.DefaultVersion))
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
                if (this.DefaultVersion != null)
                    hashCode = hashCode * 59 + this.DefaultVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
