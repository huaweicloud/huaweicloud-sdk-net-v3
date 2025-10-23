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
    public class CreateCherryPickMergeRequestResponse : SdkResponse
    {

        /// <summary>
        /// CherryPick结果
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// CherryPick标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// CherryPick临时分支名名称
        /// </summary>
        [JsonProperty("cherry_pick_branch_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CherryPickBranchName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCherryPickMergeRequestResponse {\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  cherryPickBranchName: ").Append(CherryPickBranchName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateCherryPickMergeRequestResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateCherryPickMergeRequestResponse input)
        {
            if (input == null) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.CherryPickBranchName != input.CherryPickBranchName || (this.CherryPickBranchName != null && !this.CherryPickBranchName.Equals(input.CherryPickBranchName))) return false;

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
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.CherryPickBranchName != null) hashCode = hashCode * 59 + this.CherryPickBranchName.GetHashCode();
                return hashCode;
            }
        }
    }
}
