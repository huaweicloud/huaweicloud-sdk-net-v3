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
    /// 测试套执行结果
    /// </summary>
    public class ExecuteTaskInfo 
    {

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 发布版本号
        /// </summary>
        [JsonProperty("release_dev", NullValueHandling = NullValueHandling.Ignore)]
        public string ReleaseDev { get; set; }

        /// <summary>
        /// 结果Code
        /// </summary>
        [JsonProperty("result_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 任务执行结果Uri
        /// </summary>
        [JsonProperty("test_result_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestResultUri { get; set; }

        /// <summary>
        /// 状态Code
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusCode { get; set; }

        /// <summary>
        /// 分支/迭代uri
        /// </summary>
        [JsonProperty("version_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionUri { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteTaskInfo {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  releaseDev: ").Append(ReleaseDev).Append("\n");
            sb.Append("  resultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  testResultUri: ").Append(TestResultUri).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  versionUri: ").Append(VersionUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteTaskInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteTaskInfo input)
        {
            if (input == null) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.ReleaseDev != input.ReleaseDev || (this.ReleaseDev != null && !this.ReleaseDev.Equals(input.ReleaseDev))) return false;
            if (this.ResultCode != input.ResultCode || (this.ResultCode != null && !this.ResultCode.Equals(input.ResultCode))) return false;
            if (this.TestResultUri != input.TestResultUri || (this.TestResultUri != null && !this.TestResultUri.Equals(input.TestResultUri))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.VersionUri != input.VersionUri || (this.VersionUri != null && !this.VersionUri.Equals(input.VersionUri))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ReleaseDev != null) hashCode = hashCode * 59 + this.ReleaseDev.GetHashCode();
                if (this.ResultCode != null) hashCode = hashCode * 59 + this.ResultCode.GetHashCode();
                if (this.TestResultUri != null) hashCode = hashCode * 59 + this.TestResultUri.GetHashCode();
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.VersionUri != null) hashCode = hashCode * 59 + this.VersionUri.GetHashCode();
                return hashCode;
            }
        }
    }
}
