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
    /// 生成测试套的请求信息
    /// </summary>
    public class CreateTestSuitByRepoFileInfo 
    {

        /// <summary>
        /// 要生成的测试套名称
        /// </summary>
        [JsonProperty("testsuite_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TestsuiteName { get; set; }

        /// <summary>
        /// 仓库id
        /// </summary>
        [JsonProperty("repository_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryId { get; set; }

        /// <summary>
        /// 仓库分支
        /// </summary>
        [JsonProperty("repository_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string RepositoryBranch { get; set; }

        /// <summary>
        /// 仓库中yaml或json文件的相对路径，仅支持swagger 2.0版本的yaml和json文件
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTestSuitByRepoFileInfo {\n");
            sb.Append("  testsuiteName: ").Append(TestsuiteName).Append("\n");
            sb.Append("  repositoryId: ").Append(RepositoryId).Append("\n");
            sb.Append("  repositoryBranch: ").Append(RepositoryBranch).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTestSuitByRepoFileInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTestSuitByRepoFileInfo input)
        {
            if (input == null) return false;
            if (this.TestsuiteName != input.TestsuiteName || (this.TestsuiteName != null && !this.TestsuiteName.Equals(input.TestsuiteName))) return false;
            if (this.RepositoryId != input.RepositoryId || (this.RepositoryId != null && !this.RepositoryId.Equals(input.RepositoryId))) return false;
            if (this.RepositoryBranch != input.RepositoryBranch || (this.RepositoryBranch != null && !this.RepositoryBranch.Equals(input.RepositoryBranch))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;

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
                if (this.TestsuiteName != null) hashCode = hashCode * 59 + this.TestsuiteName.GetHashCode();
                if (this.RepositoryId != null) hashCode = hashCode * 59 + this.RepositoryId.GetHashCode();
                if (this.RepositoryBranch != null) hashCode = hashCode * 59 + this.RepositoryBranch.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                return hashCode;
            }
        }
    }
}
