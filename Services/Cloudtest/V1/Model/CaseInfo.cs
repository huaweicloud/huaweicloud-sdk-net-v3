using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 更新用例信息列表
    /// </summary>
    public class CaseInfo 
    {

        /// <summary>
        /// 用例id
        /// </summary>
        [JsonProperty("case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseId { get; set; }

        /// <summary>
        /// 脚本路径
        /// </summary>
        [JsonProperty("script_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseInfo {\n");
            sb.Append("  caseId: ").Append(CaseId).Append("\n");
            sb.Append("  scriptUrl: ").Append(ScriptUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaseInfo input)
        {
            if (input == null) return false;
            if (this.CaseId != input.CaseId || (this.CaseId != null && !this.CaseId.Equals(input.CaseId))) return false;
            if (this.ScriptUrl != input.ScriptUrl || (this.ScriptUrl != null && !this.ScriptUrl.Equals(input.ScriptUrl))) return false;

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
                if (this.CaseId != null) hashCode = hashCode * 59 + this.CaseId.GetHashCode();
                if (this.ScriptUrl != null) hashCode = hashCode * 59 + this.ScriptUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
