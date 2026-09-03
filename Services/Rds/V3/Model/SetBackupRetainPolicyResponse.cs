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
    public class SetBackupRetainPolicyResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**  设置备份保留策略同步接口返回成功响应结果  **约束限制**  不涉及  **取值范围**  不涉及  **默认取值**  不涉及
        /// </summary>
        [JsonProperty("resp", NullValueHandling = NullValueHandling.Ignore)]
        public string Resp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetBackupRetainPolicyResponse {\n");
            sb.Append("  resp: ").Append(Resp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetBackupRetainPolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetBackupRetainPolicyResponse input)
        {
            if (input == null) return false;
            if (this.Resp != input.Resp || (this.Resp != null && !this.Resp.Equals(input.Resp))) return false;

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
                if (this.Resp != null) hashCode = hashCode * 59 + this.Resp.GetHashCode();
                return hashCode;
            }
        }
    }
}
