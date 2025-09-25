using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// **参数解释**: 开关记录列表。 **取值范围**: 不涉及。
    /// </summary>
    public class FullSqlSwitchResult 
    {

        /// <summary>
        /// **参数解释**: 是否开启全量SQL。 **取值范围**: - true：已开启。 - false：已关闭。
        /// </summary>
        [JsonProperty("is_open", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOpen { get; set; }

        /// <summary>
        /// **参数解释**: 开关状态持续的开始时间。格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释**: 开关状态持续的结束时间。格式为“yyyy-mm-ddThh:mm:ssZ”。其中，T指某个时间的开始；Z指时区偏移量。 **取值范围**: 为null则表示，开关状态还在持续，没有发生切换。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释**: 已采集的全量SQL数据的最大保留天数。 **取值范围**: [1,30]
        /// </summary>
        [JsonProperty("save_days", NullValueHandling = NullValueHandling.Ignore)]
        public int? SaveDays { get; set; }

        /// <summary>
        /// **参数解释**: 全量SQL数据存储类型。 **取值范围**: - LTS：LTS云日志服务。
        /// </summary>
        [JsonProperty("storage_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("lts_config", NullValueHandling = NullValueHandling.Ignore)]
        public LtsConfigInfoResult LtsConfig { get; set; }

        /// <summary>
        /// **参数解释**: SQL采集类型列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("sql_type_range", NullValueHandling = NullValueHandling.Ignore)]
        public List<SqlTypeInfoResult> SqlTypeRange { get; set; }

        /// <summary>
        /// **参数解释**: 实例ID。 **取值范围**: 不涉及。是否过滤系统用户。使能该选项后，全量SQL采集将会跳过系统用户所执行的SQL记录
        /// </summary>
        [JsonProperty("is_exclude_sys_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExcludeSysUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullSqlSwitchResult {\n");
            sb.Append("  isOpen: ").Append(IsOpen).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  saveDays: ").Append(SaveDays).Append("\n");
            sb.Append("  storageMode: ").Append(StorageMode).Append("\n");
            sb.Append("  ltsConfig: ").Append(LtsConfig).Append("\n");
            sb.Append("  sqlTypeRange: ").Append(SqlTypeRange).Append("\n");
            sb.Append("  isExcludeSysUser: ").Append(IsExcludeSysUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FullSqlSwitchResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FullSqlSwitchResult input)
        {
            if (input == null) return false;
            if (this.IsOpen != input.IsOpen || (this.IsOpen != null && !this.IsOpen.Equals(input.IsOpen))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.SaveDays != input.SaveDays || (this.SaveDays != null && !this.SaveDays.Equals(input.SaveDays))) return false;
            if (this.StorageMode != input.StorageMode || (this.StorageMode != null && !this.StorageMode.Equals(input.StorageMode))) return false;
            if (this.LtsConfig != input.LtsConfig || (this.LtsConfig != null && !this.LtsConfig.Equals(input.LtsConfig))) return false;
            if (this.SqlTypeRange != input.SqlTypeRange || (this.SqlTypeRange != null && input.SqlTypeRange != null && !this.SqlTypeRange.SequenceEqual(input.SqlTypeRange))) return false;
            if (this.IsExcludeSysUser != input.IsExcludeSysUser || (this.IsExcludeSysUser != null && !this.IsExcludeSysUser.Equals(input.IsExcludeSysUser))) return false;

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
                if (this.IsOpen != null) hashCode = hashCode * 59 + this.IsOpen.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.SaveDays != null) hashCode = hashCode * 59 + this.SaveDays.GetHashCode();
                if (this.StorageMode != null) hashCode = hashCode * 59 + this.StorageMode.GetHashCode();
                if (this.LtsConfig != null) hashCode = hashCode * 59 + this.LtsConfig.GetHashCode();
                if (this.SqlTypeRange != null) hashCode = hashCode * 59 + this.SqlTypeRange.GetHashCode();
                if (this.IsExcludeSysUser != null) hashCode = hashCode * 59 + this.IsExcludeSysUser.GetHashCode();
                return hashCode;
            }
        }
    }
}
