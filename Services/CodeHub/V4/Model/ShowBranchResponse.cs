using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V4.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowBranchResponse : SdkResponse
    {

        /// <summary>
        /// 分支名
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("commit", NullValueHandling = NullValueHandling.Ignore)]
        public CommitDto Commit { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [JsonProperty("merged", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Merged { get; set; }

        /// <summary>
        /// 是否为保护分支
        /// </summary>
        [JsonProperty("protected", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Protected { get; set; }

        /// <summary>
        /// 开发者是否可以推送
        /// </summary>
        [JsonProperty("developers_can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DevelopersCanPush { get; set; }

        /// <summary>
        /// 开发者是否可以合并
        /// </summary>
        [JsonProperty("developers_can_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DevelopersCanMerge { get; set; }

        /// <summary>
        /// 是否可以推送
        /// </summary>
        [JsonProperty("can_push", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanPush { get; set; }

        /// <summary>
        /// 是否为默认分支
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Total", IsHeader = true)]
        [JsonProperty("X-Total", NullValueHandling = NullValueHandling.Ignore)]
        public string XTotal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowBranchResponse {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  commit: ").Append(Commit).Append("\n");
            sb.Append("  merged: ").Append(Merged).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  developersCanPush: ").Append(DevelopersCanPush).Append("\n");
            sb.Append("  developersCanMerge: ").Append(DevelopersCanMerge).Append("\n");
            sb.Append("  canPush: ").Append(CanPush).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  xTotal: ").Append(XTotal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowBranchResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowBranchResponse input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Commit != input.Commit || (this.Commit != null && !this.Commit.Equals(input.Commit))) return false;
            if (this.Merged != input.Merged || (this.Merged != null && !this.Merged.Equals(input.Merged))) return false;
            if (this.Protected != input.Protected || (this.Protected != null && !this.Protected.Equals(input.Protected))) return false;
            if (this.DevelopersCanPush != input.DevelopersCanPush || (this.DevelopersCanPush != null && !this.DevelopersCanPush.Equals(input.DevelopersCanPush))) return false;
            if (this.DevelopersCanMerge != input.DevelopersCanMerge || (this.DevelopersCanMerge != null && !this.DevelopersCanMerge.Equals(input.DevelopersCanMerge))) return false;
            if (this.CanPush != input.CanPush || (this.CanPush != null && !this.CanPush.Equals(input.CanPush))) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.XTotal != input.XTotal || (this.XTotal != null && !this.XTotal.Equals(input.XTotal))) return false;

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
                if (this.Merged != null) hashCode = hashCode * 59 + this.Merged.GetHashCode();
                if (this.Protected != null) hashCode = hashCode * 59 + this.Protected.GetHashCode();
                if (this.DevelopersCanPush != null) hashCode = hashCode * 59 + this.DevelopersCanPush.GetHashCode();
                if (this.DevelopersCanMerge != null) hashCode = hashCode * 59 + this.DevelopersCanMerge.GetHashCode();
                if (this.CanPush != null) hashCode = hashCode * 59 + this.CanPush.GetHashCode();
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.XTotal != null) hashCode = hashCode * 59 + this.XTotal.GetHashCode();
                return hashCode;
            }
        }
    }
}
