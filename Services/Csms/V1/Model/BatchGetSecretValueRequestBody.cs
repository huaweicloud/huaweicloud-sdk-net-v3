using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchGetSecretValueRequestBody 
    {

        /// <summary>
        /// **参数解释：**  待获取凭据值的凭据名称。 **约束限制：**  不涉及  **取值范围：** 不涉及  **默认取值：**  不涉及
        /// </summary>
        [JsonProperty("secret_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecretNameList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchGetSecretValueRequestBody {\n");
            sb.Append("  secretNameList: ").Append(SecretNameList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchGetSecretValueRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchGetSecretValueRequestBody input)
        {
            if (input == null) return false;
            if (this.SecretNameList != input.SecretNameList || (this.SecretNameList != null && input.SecretNameList != null && !this.SecretNameList.SequenceEqual(input.SecretNameList))) return false;

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
                if (this.SecretNameList != null) hashCode = hashCode * 59 + this.SecretNameList.GetHashCode();
                return hashCode;
            }
        }
    }
}
