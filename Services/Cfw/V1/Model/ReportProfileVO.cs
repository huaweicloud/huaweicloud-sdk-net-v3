using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReportProfileVO 
    {

        /// <summary>
        /// **参数解释**： 模板ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProfileId { get; set; }

        /// <summary>
        /// **参数解释**： 模板名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 模板类型 **取值范围**： daily 日报 weekly 周报 custom 自定义报告
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// **参数解释**： 启用状态 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// **参数解释**： 最新的报告的ID **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("report_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportId { get; set; }

        /// <summary>
        /// **参数解释**： 最新的报告的生成时间，毫秒级时间戳 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("last_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportProfileVO {\n");
            sb.Append("  profileId: ").Append(ProfileId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  reportId: ").Append(ReportId).Append("\n");
            sb.Append("  lastTime: ").Append(LastTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReportProfileVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReportProfileVO input)
        {
            if (input == null) return false;
            if (this.ProfileId != input.ProfileId || (this.ProfileId != null && !this.ProfileId.Equals(input.ProfileId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.ReportId != input.ReportId || (this.ReportId != null && !this.ReportId.Equals(input.ReportId))) return false;
            if (this.LastTime != input.LastTime || (this.LastTime != null && !this.LastTime.Equals(input.LastTime))) return false;

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
                if (this.ProfileId != null) hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ReportId != null) hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                if (this.LastTime != null) hashCode = hashCode * 59 + this.LastTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
