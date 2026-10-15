using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowVectorStorageConfigResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  向量存储开关。true表示已开启向量存储，false表示已关闭向量存储。  **约束限制**：  不涉及。  **取值范围**：  - true - false **默认取值**：  不涉及。
        /// </summary>
        [JsonProperty("vector_storage_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? VectorStorageSwitch { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowVectorStorageConfigResponse {\n");
            sb.Append("  vectorStorageSwitch: ").Append(VectorStorageSwitch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowVectorStorageConfigResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowVectorStorageConfigResponse input)
        {
            if (input == null) return false;
            if (this.VectorStorageSwitch != input.VectorStorageSwitch || (this.VectorStorageSwitch != null && !this.VectorStorageSwitch.Equals(input.VectorStorageSwitch))) return false;

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
                if (this.VectorStorageSwitch != null) hashCode = hashCode * 59 + this.VectorStorageSwitch.GetHashCode();
                return hashCode;
            }
        }
    }
}
