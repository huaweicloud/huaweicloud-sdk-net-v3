using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 源码仓库参数
    /// </summary>
    public class Source 
    {

        /// <summary>
        /// 源码仓名字
        /// </summary>
        [JsonProperty("codehub_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CodehubName { get; set; }

        /// <summary>
        /// 触发分支
        /// </summary>
        [JsonProperty("branches", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Branches { get; set; }

        /// <summary>
        /// 源码仓来源
        /// </summary>
        [JsonProperty("scm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScmType { get; set; }

        /// <summary>
        /// 是否开启触发执行流水线功能
        /// </summary>
        [JsonProperty("hook_flag", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HookFlag { get; set; }

        /// <summary>
        /// 触发分支
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 源码仓ssh地址
        /// </summary>
        [JsonProperty("git_url", NullValueHandling = NullValueHandling.Ignore)]
        public string GitUrl { get; set; }

        /// <summary>
        /// 源码仓ID
        /// </summary>
        [JsonProperty("codehub_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CodehubId { get; set; }

        /// <summary>
        /// 源码仓首页url
        /// </summary>
        [JsonProperty("web_url", NullValueHandling = NullValueHandling.Ignore)]
        public string WebUrl { get; set; }

        /// <summary>
        /// 分支列表
        /// </summary>
        [JsonProperty("branch_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> BranchList { get; set; }

        /// <summary>
        /// 初始化ID
        /// </summary>
        [JsonProperty("init_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InitId { get; set; }

        /// <summary>
        /// 是否废弃
        /// </summary>
        [JsonProperty("disable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Source {\n");
            sb.Append("  codehubName: ").Append(CodehubName).Append("\n");
            sb.Append("  branches: ").Append(Branches).Append("\n");
            sb.Append("  scmType: ").Append(ScmType).Append("\n");
            sb.Append("  hookFlag: ").Append(HookFlag).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  gitUrl: ").Append(GitUrl).Append("\n");
            sb.Append("  codehubId: ").Append(CodehubId).Append("\n");
            sb.Append("  webUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  branchList: ").Append(BranchList).Append("\n");
            sb.Append("  initId: ").Append(InitId).Append("\n");
            sb.Append("  disable: ").Append(Disable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Source);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Source input)
        {
            if (input == null) return false;
            if (this.CodehubName != input.CodehubName || (this.CodehubName != null && !this.CodehubName.Equals(input.CodehubName))) return false;
            if (this.Branches != input.Branches || (this.Branches != null && input.Branches != null && !this.Branches.SequenceEqual(input.Branches))) return false;
            if (this.ScmType != input.ScmType || (this.ScmType != null && !this.ScmType.Equals(input.ScmType))) return false;
            if (this.HookFlag != input.HookFlag || (this.HookFlag != null && !this.HookFlag.Equals(input.HookFlag))) return false;
            if (this.Branch != input.Branch || (this.Branch != null && !this.Branch.Equals(input.Branch))) return false;
            if (this.GitUrl != input.GitUrl || (this.GitUrl != null && !this.GitUrl.Equals(input.GitUrl))) return false;
            if (this.CodehubId != input.CodehubId || (this.CodehubId != null && !this.CodehubId.Equals(input.CodehubId))) return false;
            if (this.WebUrl != input.WebUrl || (this.WebUrl != null && !this.WebUrl.Equals(input.WebUrl))) return false;
            if (this.BranchList != input.BranchList || (this.BranchList != null && input.BranchList != null && !this.BranchList.SequenceEqual(input.BranchList))) return false;
            if (this.InitId != input.InitId || (this.InitId != null && !this.InitId.Equals(input.InitId))) return false;
            if (this.Disable != input.Disable || (this.Disable != null && !this.Disable.Equals(input.Disable))) return false;

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
                if (this.CodehubName != null) hashCode = hashCode * 59 + this.CodehubName.GetHashCode();
                if (this.Branches != null) hashCode = hashCode * 59 + this.Branches.GetHashCode();
                if (this.ScmType != null) hashCode = hashCode * 59 + this.ScmType.GetHashCode();
                if (this.HookFlag != null) hashCode = hashCode * 59 + this.HookFlag.GetHashCode();
                if (this.Branch != null) hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.GitUrl != null) hashCode = hashCode * 59 + this.GitUrl.GetHashCode();
                if (this.CodehubId != null) hashCode = hashCode * 59 + this.CodehubId.GetHashCode();
                if (this.WebUrl != null) hashCode = hashCode * 59 + this.WebUrl.GetHashCode();
                if (this.BranchList != null) hashCode = hashCode * 59 + this.BranchList.GetHashCode();
                if (this.InitId != null) hashCode = hashCode * 59 + this.InitId.GetHashCode();
                if (this.Disable != null) hashCode = hashCode * 59 + this.Disable.GetHashCode();
                return hashCode;
            }
        }
    }
}
