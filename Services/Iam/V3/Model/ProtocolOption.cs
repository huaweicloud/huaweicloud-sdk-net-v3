using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ProtocolOption 
    {

        /// <summary>
        /// 映射ID。身份提供商类型为iam_user_sso时，不需要绑定映射ID，无需传入此字段；否则此字段必填。
        /// </summary>
        [JsonProperty("mapping_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MappingId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProtocolOption {\n");
            sb.Append("  mappingId: ").Append(MappingId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProtocolOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProtocolOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MappingId == input.MappingId ||
                    (this.MappingId != null &&
                    this.MappingId.Equals(input.MappingId))
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
                if (this.MappingId != null)
                    hashCode = hashCode * 59 + this.MappingId.GetHashCode();
                return hashCode;
            }
        }
    }
}
