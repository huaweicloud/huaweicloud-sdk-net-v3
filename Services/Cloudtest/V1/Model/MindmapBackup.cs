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
    public class MindmapBackup 
    {

        /// <summary>
        /// 备份名称
        /// </summary>
        [JsonProperty("bak_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BakName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人名称
        /// </summary>
        [JsonProperty("creator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorName { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [JsonProperty("creator_num", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatorNum { get; set; }

        /// <summary>
        /// id 主键
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <summary>
        /// 脑图JSON
        /// </summary>
        [JsonProperty("mindmap", NullValueHandling = NullValueHandling.Ignore)]
        public string Mindmap { get; set; }

        /// <summary>
        /// 脑图Id
        /// </summary>
        [JsonProperty("mindmap_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MindmapId { get; set; }

        /// <summary>
        /// 备份类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MindmapBackup {\n");
            sb.Append("  bakName: ").Append(BakName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  creatorName: ").Append(CreatorName).Append("\n");
            sb.Append("  creatorNum: ").Append(CreatorNum).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  memo: ").Append(Memo).Append("\n");
            sb.Append("  mindmap: ").Append(Mindmap).Append("\n");
            sb.Append("  mindmapId: ").Append(MindmapId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MindmapBackup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MindmapBackup input)
        {
            if (input == null) return false;
            if (this.BakName != input.BakName || (this.BakName != null && !this.BakName.Equals(input.BakName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreatorName != input.CreatorName || (this.CreatorName != null && !this.CreatorName.Equals(input.CreatorName))) return false;
            if (this.CreatorNum != input.CreatorNum || (this.CreatorNum != null && !this.CreatorNum.Equals(input.CreatorNum))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Memo != input.Memo || (this.Memo != null && !this.Memo.Equals(input.Memo))) return false;
            if (this.Mindmap != input.Mindmap || (this.Mindmap != null && !this.Mindmap.Equals(input.Mindmap))) return false;
            if (this.MindmapId != input.MindmapId || (this.MindmapId != null && !this.MindmapId.Equals(input.MindmapId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.BakName != null) hashCode = hashCode * 59 + this.BakName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreatorName != null) hashCode = hashCode * 59 + this.CreatorName.GetHashCode();
                if (this.CreatorNum != null) hashCode = hashCode * 59 + this.CreatorNum.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Memo != null) hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.Mindmap != null) hashCode = hashCode * 59 + this.Mindmap.GetHashCode();
                if (this.MindmapId != null) hashCode = hashCode * 59 + this.MindmapId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
