using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BatchDeleteAclRulesResponseData 
    {

        /// <summary>
        /// **参数解释**： 批量删除规则返回 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("responseDatas", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchDeleteRuleInfo> ResponseDatas { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDeleteAclRulesResponseData {\n");
            sb.Append("  responseDatas: ").Append(ResponseDatas).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDeleteAclRulesResponseData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDeleteAclRulesResponseData input)
        {
            if (input == null) return false;
            if (this.ResponseDatas != input.ResponseDatas || (this.ResponseDatas != null && input.ResponseDatas != null && !this.ResponseDatas.SequenceEqual(input.ResponseDatas))) return false;

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
                if (this.ResponseDatas != null) hashCode = hashCode * 59 + this.ResponseDatas.GetHashCode();
                return hashCode;
            }
        }
    }
}
