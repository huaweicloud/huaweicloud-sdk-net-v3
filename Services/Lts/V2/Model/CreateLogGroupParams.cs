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
    /// 创建日志组参数。
    /// </summary>
    public class CreateLogGroupParams 
    {

        /// <summary>
        /// 需要创建的日志组名称。
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 日志存储时间（天），取值范围：1-30。
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TtlInDays { get; set; }

        /// <summary>
        /// 标签字段信息
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsBody> Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLogGroupParams {\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLogGroupParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLogGroupParams input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LogGroupName == input.LogGroupName ||
                    (this.LogGroupName != null &&
                    this.LogGroupName.Equals(input.LogGroupName))
                ) && 
                (
                    this.TtlInDays == input.TtlInDays ||
                    (this.TtlInDays != null &&
                    this.TtlInDays.Equals(input.TtlInDays))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.LogGroupName != null)
                    hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.TtlInDays != null)
                    hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
