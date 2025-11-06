using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListCommitsRequest 
    {

        /// <summary>
        /// 仓库短id
        /// </summary>
        [SDKProperty("repo_id", IsPath = true)]
        [JsonProperty("repo_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepoId { get; set; }

        /// <summary>
        /// 仓库的branch名或tag名，如果为空则查询默认分支
        /// </summary>
        [SDKProperty("ref_name", IsQuery = true)]
        [JsonProperty("ref_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RefName { get; set; }

        /// <summary>
        /// 在此日期之后或当天提交，格式 YYYY-MM-DDTHH:MM:SSZ
        /// </summary>
        [SDKProperty("since", IsQuery = true)]
        [JsonProperty("since", NullValueHandling = NullValueHandling.Ignore)]
        public string Since { get; set; }

        /// <summary>
        /// 在此日期之前或当天提交，格式 YYYY-MM-DDTHH:MM:SSZ
        /// </summary>
        [SDKProperty("until", IsQuery = true)]
        [JsonProperty("until", NullValueHandling = NullValueHandling.Ignore)]
        public string Until { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [SDKProperty("path", IsQuery = true)]
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 是否检索仓库中每个提交
        /// </summary>
        [SDKProperty("all", IsQuery = true)]
        [JsonProperty("all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? All { get; set; }

        /// <summary>
        /// 有关每个提交的统计信息是否添加到响应中
        /// </summary>
        [SDKProperty("with_stats", IsQuery = true)]
        [JsonProperty("with_stats", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WithStats { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [SDKProperty("page", IsQuery = true)]
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// 每页条目数
        /// </summary>
        [SDKProperty("per_page", IsQuery = true)]
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCommitsRequest {\n");
            sb.Append("  repoId: ").Append(RepoId).Append("\n");
            sb.Append("  refName: ").Append(RefName).Append("\n");
            sb.Append("  since: ").Append(Since).Append("\n");
            sb.Append("  until: ").Append(Until).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  all: ").Append(All).Append("\n");
            sb.Append("  withStats: ").Append(WithStats).Append("\n");
            sb.Append("  page: ").Append(Page).Append("\n");
            sb.Append("  perPage: ").Append(PerPage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCommitsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCommitsRequest input)
        {
            if (input == null) return false;
            if (this.RepoId != input.RepoId || (this.RepoId != null && !this.RepoId.Equals(input.RepoId))) return false;
            if (this.RefName != input.RefName || (this.RefName != null && !this.RefName.Equals(input.RefName))) return false;
            if (this.Since != input.Since || (this.Since != null && !this.Since.Equals(input.Since))) return false;
            if (this.Until != input.Until || (this.Until != null && !this.Until.Equals(input.Until))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.All != input.All || (this.All != null && !this.All.Equals(input.All))) return false;
            if (this.WithStats != input.WithStats || (this.WithStats != null && !this.WithStats.Equals(input.WithStats))) return false;
            if (this.Page != input.Page || (this.Page != null && !this.Page.Equals(input.Page))) return false;
            if (this.PerPage != input.PerPage || (this.PerPage != null && !this.PerPage.Equals(input.PerPage))) return false;

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
                if (this.RepoId != null) hashCode = hashCode * 59 + this.RepoId.GetHashCode();
                if (this.RefName != null) hashCode = hashCode * 59 + this.RefName.GetHashCode();
                if (this.Since != null) hashCode = hashCode * 59 + this.Since.GetHashCode();
                if (this.Until != null) hashCode = hashCode * 59 + this.Until.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.All != null) hashCode = hashCode * 59 + this.All.GetHashCode();
                if (this.WithStats != null) hashCode = hashCode * 59 + this.WithStats.GetHashCode();
                if (this.Page != null) hashCode = hashCode * 59 + this.Page.GetHashCode();
                if (this.PerPage != null) hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                return hashCode;
            }
        }
    }
}
