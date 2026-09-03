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
    /// 
    /// </summary>
    public class CloudTestCaseInfo 
    {

        /// <summary>
        /// 用例id
        /// </summary>
        [JsonProperty("case_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseId { get; set; }

        /// <summary>
        /// tmss用例类型
        /// </summary>
        [JsonProperty("caseType", NullValueHandling = NullValueHandling.Ignore)]
        public int? CaseType { get; set; }

        /// <summary>
        /// 是否未禁用，1为未禁用，0为已禁用
        /// </summary>
        [JsonProperty("is_forbidden", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsForbidden { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public CommonDto Owner { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public CommonDto Result { get; set; }

        /// <summary>
        /// 用例脚本路径
        /// </summary>
        [JsonProperty("scriptUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ScriptUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public CommonDto Status { get; set; }

        /// <summary>
        /// 用例名称
        /// </summary>
        [JsonProperty("testCaseName", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseName { get; set; }

        /// <summary>
        /// 用例编号
        /// </summary>
        [JsonProperty("testCaseNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseNumber { get; set; }

        /// <summary>
        /// tmss版本地址
        /// </summary>
        [JsonProperty("tmssVersionUri", NullValueHandling = NullValueHandling.Ignore)]
        public string TmssVersionUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudTestCaseInfo {\n");
            sb.Append("  caseId: ").Append(CaseId).Append("\n");
            sb.Append("  caseType: ").Append(CaseType).Append("\n");
            sb.Append("  isForbidden: ").Append(IsForbidden).Append("\n");
            sb.Append("  owner: ").Append(Owner).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  scriptUrl: ").Append(ScriptUrl).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  testCaseName: ").Append(TestCaseName).Append("\n");
            sb.Append("  testCaseNumber: ").Append(TestCaseNumber).Append("\n");
            sb.Append("  tmssVersionUri: ").Append(TmssVersionUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudTestCaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudTestCaseInfo input)
        {
            if (input == null) return false;
            if (this.CaseId != input.CaseId || (this.CaseId != null && !this.CaseId.Equals(input.CaseId))) return false;
            if (this.CaseType != input.CaseType || (this.CaseType != null && !this.CaseType.Equals(input.CaseType))) return false;
            if (this.IsForbidden != input.IsForbidden || (this.IsForbidden != null && !this.IsForbidden.Equals(input.IsForbidden))) return false;
            if (this.Owner != input.Owner || (this.Owner != null && !this.Owner.Equals(input.Owner))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.ScriptUrl != input.ScriptUrl || (this.ScriptUrl != null && !this.ScriptUrl.Equals(input.ScriptUrl))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.TestCaseName != input.TestCaseName || (this.TestCaseName != null && !this.TestCaseName.Equals(input.TestCaseName))) return false;
            if (this.TestCaseNumber != input.TestCaseNumber || (this.TestCaseNumber != null && !this.TestCaseNumber.Equals(input.TestCaseNumber))) return false;
            if (this.TmssVersionUri != input.TmssVersionUri || (this.TmssVersionUri != null && !this.TmssVersionUri.Equals(input.TmssVersionUri))) return false;

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
                if (this.CaseType != null) hashCode = hashCode * 59 + this.CaseType.GetHashCode();
                if (this.IsForbidden != null) hashCode = hashCode * 59 + this.IsForbidden.GetHashCode();
                if (this.Owner != null) hashCode = hashCode * 59 + this.Owner.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.ScriptUrl != null) hashCode = hashCode * 59 + this.ScriptUrl.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TestCaseName != null) hashCode = hashCode * 59 + this.TestCaseName.GetHashCode();
                if (this.TestCaseNumber != null) hashCode = hashCode * 59 + this.TestCaseNumber.GetHashCode();
                if (this.TmssVersionUri != null) hashCode = hashCode * 59 + this.TmssVersionUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
