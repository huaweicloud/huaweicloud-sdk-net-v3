using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 和列信息相关的对象
    /// </summary>
    public class ObjectWithColumnInfo 
    {

        /// <summary>
        /// 本节点id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 父节点id
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 节点别名
        /// </summary>
        [JsonProperty("alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AliasName { get; set; }

        /// <summary>
        /// 提示信息，例如提示库下表过多
        /// </summary>
        [JsonProperty("notices", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notices { get; set; }

        /// <summary>
        /// 扩展信息，例如提示有无数据,结构是否在目标库中存在
        /// </summary>
        [JsonProperty("extend_info", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 是否支持展开查询
        /// </summary>
        [JsonProperty("is_support_expand", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportExpand { get; set; }

        /// <summary>
        /// 是否有列信息
        /// </summary>
        [JsonProperty("has_column_info", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasColumnInfo { get; set; }

        /// <summary>
        /// 是否预置
        /// </summary>
        [JsonProperty("is_preset", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPreset { get; set; }

        /// <summary>
        /// token个数
        /// </summary>
        [JsonProperty("token_count", NullValueHandling = NullValueHandling.Ignore)]
        public string TokenCount { get; set; }

        /// <summary>
        /// 是否已经下发给node
        /// </summary>
        [JsonProperty("is_sent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSent { get; set; }

        /// <summary>
        /// 下发给node的别名
        /// </summary>
        [JsonProperty("sent_alias_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SentAliasName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ObjectWithColumnInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  aliasName: ").Append(AliasName).Append("\n");
            sb.Append("  notices: ").Append(Notices).Append("\n");
            sb.Append("  extendInfo: ").Append(ExtendInfo).Append("\n");
            sb.Append("  isSupportExpand: ").Append(IsSupportExpand).Append("\n");
            sb.Append("  hasColumnInfo: ").Append(HasColumnInfo).Append("\n");
            sb.Append("  isPreset: ").Append(IsPreset).Append("\n");
            sb.Append("  tokenCount: ").Append(TokenCount).Append("\n");
            sb.Append("  isSent: ").Append(IsSent).Append("\n");
            sb.Append("  sentAliasName: ").Append(SentAliasName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ObjectWithColumnInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ObjectWithColumnInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AliasName != input.AliasName || (this.AliasName != null && !this.AliasName.Equals(input.AliasName))) return false;
            if (this.Notices != input.Notices || (this.Notices != null && input.Notices != null && !this.Notices.SequenceEqual(input.Notices))) return false;
            if (this.ExtendInfo != input.ExtendInfo || (this.ExtendInfo != null && !this.ExtendInfo.Equals(input.ExtendInfo))) return false;
            if (this.IsSupportExpand != input.IsSupportExpand || (this.IsSupportExpand != null && !this.IsSupportExpand.Equals(input.IsSupportExpand))) return false;
            if (this.HasColumnInfo != input.HasColumnInfo || (this.HasColumnInfo != null && !this.HasColumnInfo.Equals(input.HasColumnInfo))) return false;
            if (this.IsPreset != input.IsPreset || (this.IsPreset != null && !this.IsPreset.Equals(input.IsPreset))) return false;
            if (this.TokenCount != input.TokenCount || (this.TokenCount != null && !this.TokenCount.Equals(input.TokenCount))) return false;
            if (this.IsSent != input.IsSent || (this.IsSent != null && !this.IsSent.Equals(input.IsSent))) return false;
            if (this.SentAliasName != input.SentAliasName || (this.SentAliasName != null && !this.SentAliasName.Equals(input.SentAliasName))) return false;

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
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AliasName != null) hashCode = hashCode * 59 + this.AliasName.GetHashCode();
                if (this.Notices != null) hashCode = hashCode * 59 + this.Notices.GetHashCode();
                if (this.ExtendInfo != null) hashCode = hashCode * 59 + this.ExtendInfo.GetHashCode();
                if (this.IsSupportExpand != null) hashCode = hashCode * 59 + this.IsSupportExpand.GetHashCode();
                if (this.HasColumnInfo != null) hashCode = hashCode * 59 + this.HasColumnInfo.GetHashCode();
                if (this.IsPreset != null) hashCode = hashCode * 59 + this.IsPreset.GetHashCode();
                if (this.TokenCount != null) hashCode = hashCode * 59 + this.TokenCount.GetHashCode();
                if (this.IsSent != null) hashCode = hashCode * 59 + this.IsSent.GetHashCode();
                if (this.SentAliasName != null) hashCode = hashCode * 59 + this.SentAliasName.GetHashCode();
                return hashCode;
            }
        }
    }
}
