using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 关联Wiki详情
    /// </summary>
    public class AttachWikiDetail 
    {

        /// <summary>
        /// 工作项ID
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? IssueId { get; set; }

        /// <summary>
        /// Wiki标题
        /// </summary>
        [JsonProperty("wiki_title", NullValueHandling = NullValueHandling.Ignore)]
        public string WikiTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("wiki_author", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleUser WikiAuthor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
        public SimpleProject Project { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// wiki ID
        /// </summary>
        [JsonProperty("wiki_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WikiId { get; set; }

        /// <summary>
        /// region值
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachWikiDetail {\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  wikiTitle: ").Append(WikiTitle).Append("\n");
            sb.Append("  wikiAuthor: ").Append(WikiAuthor).Append("\n");
            sb.Append("  project: ").Append(Project).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  wikiId: ").Append(WikiId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachWikiDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachWikiDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IssueId == input.IssueId ||
                    (this.IssueId != null &&
                    this.IssueId.Equals(input.IssueId))
                ) && 
                (
                    this.WikiTitle == input.WikiTitle ||
                    (this.WikiTitle != null &&
                    this.WikiTitle.Equals(input.WikiTitle))
                ) && 
                (
                    this.WikiAuthor == input.WikiAuthor ||
                    (this.WikiAuthor != null &&
                    this.WikiAuthor.Equals(input.WikiAuthor))
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
                ) && 
                (
                    this.CreatedDate == input.CreatedDate ||
                    (this.CreatedDate != null &&
                    this.CreatedDate.Equals(input.CreatedDate))
                ) && 
                (
                    this.WikiId == input.WikiId ||
                    (this.WikiId != null &&
                    this.WikiId.Equals(input.WikiId))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.IssueId != null)
                    hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.WikiTitle != null)
                    hashCode = hashCode * 59 + this.WikiTitle.GetHashCode();
                if (this.WikiAuthor != null)
                    hashCode = hashCode * 59 + this.WikiAuthor.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
                if (this.CreatedDate != null)
                    hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.WikiId != null)
                    hashCode = hashCode * 59 + this.WikiId.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
