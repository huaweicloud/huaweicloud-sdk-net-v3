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
    /// 
    /// </summary>
    public class AddProtectResponse 
    {

        /// <summary>
        /// 分支名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("commit", NullValueHandling = NullValueHandling.Ignore)]
        public CommitRepoV2 Commit { get; set; }

        /// <summary>
        /// 是否保护
        /// </summary>
        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        /// <summary>
        /// 是否允许开发者提交
        /// </summary>
        [JsonProperty("developers_can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DevelopersCanPush { get; set; }

        /// <summary>
        /// 是否允许开发者合并
        /// </summary>
        [JsonProperty("developers_can_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DevelopersCanMerge { get; set; }

        /// <summary>
        /// 是否允许管理员提交
        /// </summary>
        [JsonProperty("master_can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MasterCanPush { get; set; }

        /// <summary>
        /// 是否允许管理员合并
        /// </summary>
        [JsonProperty("master_can_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MasterCanMerge { get; set; }

        /// <summary>
        /// 没有人允许提交
        /// </summary>
        [JsonProperty("no_one_can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoOneCanPush { get; set; }

        /// <summary>
        /// 没有人允许合并
        /// </summary>
        [JsonProperty("no_one_can_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoOneCanMerge { get; set; }

        /// <summary>
        /// 是否在一个打开的合并请求
        /// </summary>
        [JsonProperty("in_an_opened_merge_request", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InAnOpenedMergeRequest { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddProtectResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  commit: ").Append(Commit).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  developersCanPush: ").Append(DevelopersCanPush).Append("\n");
            sb.Append("  developersCanMerge: ").Append(DevelopersCanMerge).Append("\n");
            sb.Append("  masterCanPush: ").Append(MasterCanPush).Append("\n");
            sb.Append("  masterCanMerge: ").Append(MasterCanMerge).Append("\n");
            sb.Append("  noOneCanPush: ").Append(NoOneCanPush).Append("\n");
            sb.Append("  noOneCanMerge: ").Append(NoOneCanMerge).Append("\n");
            sb.Append("  inAnOpenedMergeRequest: ").Append(InAnOpenedMergeRequest).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddProtectResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddProtectResponse input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Commit != input.Commit || (this.Commit != null && !this.Commit.Equals(input.Commit))) return false;
            if (this.Protected != input.Protected || (this.Protected != null && !this.Protected.Equals(input.Protected))) return false;
            if (this.DevelopersCanPush != input.DevelopersCanPush || (this.DevelopersCanPush != null && !this.DevelopersCanPush.Equals(input.DevelopersCanPush))) return false;
            if (this.DevelopersCanMerge != input.DevelopersCanMerge || (this.DevelopersCanMerge != null && !this.DevelopersCanMerge.Equals(input.DevelopersCanMerge))) return false;
            if (this.MasterCanPush != input.MasterCanPush || (this.MasterCanPush != null && !this.MasterCanPush.Equals(input.MasterCanPush))) return false;
            if (this.MasterCanMerge != input.MasterCanMerge || (this.MasterCanMerge != null && !this.MasterCanMerge.Equals(input.MasterCanMerge))) return false;
            if (this.NoOneCanPush != input.NoOneCanPush || (this.NoOneCanPush != null && !this.NoOneCanPush.Equals(input.NoOneCanPush))) return false;
            if (this.NoOneCanMerge != input.NoOneCanMerge || (this.NoOneCanMerge != null && !this.NoOneCanMerge.Equals(input.NoOneCanMerge))) return false;
            if (this.InAnOpenedMergeRequest != input.InAnOpenedMergeRequest || (this.InAnOpenedMergeRequest != null && !this.InAnOpenedMergeRequest.Equals(input.InAnOpenedMergeRequest))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Commit != null) hashCode = hashCode * 59 + this.Commit.GetHashCode();
                if (this.Protected != null) hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.DevelopersCanPush != null) hashCode = hashCode * 59 + this.DevelopersCanPush.GetHashCode();
                if (this.DevelopersCanMerge != null) hashCode = hashCode * 59 + this.DevelopersCanMerge.GetHashCode();
                if (this.MasterCanPush != null) hashCode = hashCode * 59 + this.MasterCanPush.GetHashCode();
                if (this.MasterCanMerge != null) hashCode = hashCode * 59 + this.MasterCanMerge.GetHashCode();
                if (this.NoOneCanPush != null) hashCode = hashCode * 59 + this.NoOneCanPush.GetHashCode();
                if (this.NoOneCanMerge != null) hashCode = hashCode * 59 + this.NoOneCanMerge.GetHashCode();
                if (this.InAnOpenedMergeRequest != null) hashCode = hashCode * 59 + this.InAnOpenedMergeRequest.GetHashCode();
                return hashCode;
            }
        }
    }
}
