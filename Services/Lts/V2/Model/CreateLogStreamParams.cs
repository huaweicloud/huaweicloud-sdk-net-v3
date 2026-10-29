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
    /// 创建日志流参数。
    /// </summary>
    public class CreateLogStreamParams 
    {

        /// <summary>
        /// 需要创建的日志流名称。
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// 日志存储时间 说明： 该参数仅对华东-上海一、华北-北京四、华南-广州用户开放。
        /// </summary>
        [JsonProperty("ttl_in_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? TtlInDays { get; set; }

        /// <summary>
        /// 标签字段信息
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagsBody> Tags { get; set; }

        /// <summary>
        /// 日志流名称别名
        /// </summary>
        [JsonProperty("log_stream_name_alias", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamNameAlias { get; set; }

        /// <summary>
        /// 企业项目名称 &gt;只能由中文、英文字母、数字、下划线、中划线组成，且不能使用任何大小写形式的“default”； 描述不超过512个字符。
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启智能冷存储。 **约束限制：** 开启智能冷存储需要日志存储时间大于7天。开启智能冷存储后，需要设置标准存储层数据的保存时间。标准存储至少需保存7天才能转换为智能冷存储层数据。当日志保存时间大于标准存储层数据保存时间，且小于日志存储时间时，日志数据将自动转换为智能冷存储层数据存储。 **取值范围：** true/false。 **默认取值：** false
        /// </summary>
        [JsonProperty("hot_cold_separation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HotColdSeparation { get; set; }

        /// <summary>
        /// **参数解释：** 日志流标准存储时间（单位：天），即日志上报到LTS后日志标准存储的时间。 **约束限制：** 开启智能冷存储需要日志总存储时间大于7天。 **取值范围：** 最小值：7天 最大值：365天 **默认取值：** 不涉及。        
        /// </summary>
        [JsonProperty("hot_storage_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? HotStorageDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateLogStreamParams {\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  ttlInDays: ").Append(TtlInDays).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  logStreamNameAlias: ").Append(LogStreamNameAlias).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  hotColdSeparation: ").Append(HotColdSeparation).Append("\n");
            sb.Append("  hotStorageDays: ").Append(HotStorageDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateLogStreamParams);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateLogStreamParams input)
        {
            if (input == null) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.TtlInDays != input.TtlInDays || (this.TtlInDays != null && !this.TtlInDays.Equals(input.TtlInDays))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.LogStreamNameAlias != input.LogStreamNameAlias || (this.LogStreamNameAlias != null && !this.LogStreamNameAlias.Equals(input.LogStreamNameAlias))) return false;
            if (this.EnterpriseProjectName != input.EnterpriseProjectName || (this.EnterpriseProjectName != null && !this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))) return false;
            if (this.HotColdSeparation != input.HotColdSeparation || (this.HotColdSeparation != null && !this.HotColdSeparation.Equals(input.HotColdSeparation))) return false;
            if (this.HotStorageDays != input.HotStorageDays || (this.HotStorageDays != null && !this.HotStorageDays.Equals(input.HotStorageDays))) return false;

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
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.TtlInDays != null) hashCode = hashCode * 59 + this.TtlInDays.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.LogStreamNameAlias != null) hashCode = hashCode * 59 + this.LogStreamNameAlias.GetHashCode();
                if (this.EnterpriseProjectName != null) hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.HotColdSeparation != null) hashCode = hashCode * 59 + this.HotColdSeparation.GetHashCode();
                if (this.HotStorageDays != null) hashCode = hashCode * 59 + this.HotStorageDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
