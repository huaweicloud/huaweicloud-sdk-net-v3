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
    public class PrivateHookDescriptionPrimitiveTypeHolder 
    {

        /// <summary>
        /// 私有hook的描述。可用于客户识别创建的私有hook。可通过UpdatePrivateHook API更新私有hook的描述。
        /// </summary>
        [JsonProperty("hook_description", NullValueHandling = NullValueHandling.Ignore)]
        public string HookDescription { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateHookDescriptionPrimitiveTypeHolder {\n");
            sb.Append("  hookDescription: ").Append(HookDescription).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateHookDescriptionPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateHookDescriptionPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HookDescription == input.HookDescription ||
                    (this.HookDescription != null &&
                    this.HookDescription.Equals(input.HookDescription))
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
                if (this.HookDescription != null)
                    hashCode = hashCode * 59 + this.HookDescription.GetHashCode();
                return hashCode;
            }
        }
    }
}
