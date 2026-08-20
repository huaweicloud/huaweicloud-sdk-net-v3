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
    /// 创建快照的结果
    /// </summary>
    public class CreateSnapshotResult 
    {

        /// <summary>
        /// 快照ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 快照名称。创建时自动生成，工作项快照名称生成规则为：“工作项类型”+“ v” + “年”+“.”+“月”+“.”+“日”+“.”+“当日生成版本次数”。例如工作项类型为IR的工作项在2026年3月25日第一次打快照系统生成的快照名称为：IR v26.03.25.1。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 快照类型。工作项快照固定为：issue_snap_item。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 快照的工作项ID。
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IssueId { get; set; }

        /// <summary>
        /// 快照的创建人ID。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 快照是否可被删除。
        /// </summary>
        [JsonProperty("deletable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deletable { get; set; }

        /// <summary>
        /// 创建快照失败的原因。
        /// </summary>
        [JsonProperty("errormsg", NullValueHandling = NullValueHandling.Ignore)]
        public string Errormsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateSnapshotResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  deletable: ").Append(Deletable).Append("\n");
            sb.Append("  errormsg: ").Append(Errormsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateSnapshotResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateSnapshotResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.IssueId != input.IssueId || (this.IssueId != null && !this.IssueId.Equals(input.IssueId))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.Deletable != input.Deletable || (this.Deletable != null && !this.Deletable.Equals(input.Deletable))) return false;
            if (this.Errormsg != input.Errormsg || (this.Errormsg != null && !this.Errormsg.Equals(input.Errormsg))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.IssueId != null) hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.Deletable != null) hashCode = hashCode * 59 + this.Deletable.GetHashCode();
                if (this.Errormsg != null) hashCode = hashCode * 59 + this.Errormsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
