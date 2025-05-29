using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 返回的日志组信息
    /// </summary>
    public class LogGroup 
    {

        /// <summary>
        /// 创建时间 
        /// </summary>
        [JsonProperty("creation_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationTime { get; set; }

        /// <summary>
        /// 日志组名称 
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 日志组ID 
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志存储时间 天 
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TtlInDays { get; set; }

        /// <summary>
        /// 日志流所属标签
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Tag { get; set; }

        /// <summary>
        /// 日志组别名
        /// </summary>
        [JsonProperty("log_group_name_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupNameAlias { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogGroup {\n");
            sb.Append("  creationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  logGroupNameAlias: ").Append(LogGroupNameAlias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogGroup);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogGroup input)
        {
            if (input == null) return false;
            if (this.CreationTime != input.CreationTime || (this.CreationTime != null && !this.CreationTime.Equals(input.CreationTime))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.TtlInDays != input.TtlInDays || (this.TtlInDays != null && !this.TtlInDays.Equals(input.TtlInDays))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && input.Tag != null && !this.Tag.SequenceEqual(input.Tag))) return false;
            if (this.LogGroupNameAlias != input.LogGroupNameAlias || (this.LogGroupNameAlias != null && !this.LogGroupNameAlias.Equals(input.LogGroupNameAlias))) return false;

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
                if (this.CreationTime != null) hashCode = hashCode * 59 + this.CreationTime.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.TtlInDays != null) hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.LogGroupNameAlias != null) hashCode = hashCode * 59 + this.LogGroupNameAlias.GetHashCode();
                return hashCode;
            }
        }
    }
}
