using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ecs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowServerAutoRecoveryResponse : SdkResponse
    {

        /// <summary>
        /// 云服务器是否配置了自动恢复动作。  - true：表示配置了自动恢复。 - false：表示没有配置自动恢复。
        /// </summary>
        [JsonProperty("support_auto_recovery", NullValueHandling = NullValueHandling.Ignore)]
        public string SupportAutoRecovery { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerAutoRecoveryResponse {\n");
            sb.Append("  supportAutoRecovery: ").Append(SupportAutoRecovery).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerAutoRecoveryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerAutoRecoveryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SupportAutoRecovery == input.SupportAutoRecovery ||
                    (this.SupportAutoRecovery != null &&
                    this.SupportAutoRecovery.Equals(input.SupportAutoRecovery))
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
                if (this.SupportAutoRecovery != null)
                    hashCode = hashCode * 59 + this.SupportAutoRecovery.GetHashCode();
                return hashCode;
            }
        }
    }
}
