using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 分身动作Tag映射信息。
    /// </summary>
    public class ActionTagInfo 
    {

        /// <summary>
        /// 原子动作中文名称。
        /// </summary>
        [JsonProperty("action_name_zh", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionNameZh { get; set; }

        /// <summary>
        /// 原子动作英文名称。
        /// </summary>
        [JsonProperty("action_name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionNameEn { get; set; }

        /// <summary>
        /// 动作时长
        /// </summary>
        [JsonProperty("action_duration", NullValueHandling = NullValueHandling.Ignore)]
        public float? ActionDuration { get; set; }

        /// <summary>
        /// 动作分类名称。
        /// </summary>
        [JsonProperty("catalog", NullValueHandling = NullValueHandling.Ignore)]
        public string Catalog { get; set; }

        /// <summary>
        /// 样例视频文件名，最大长度256，最小长度1。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 动作标签。
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionTagInfo {\n");
            sb.Append("  actionNameZh: ").Append(ActionNameZh).Append("\n");
            sb.Append("  actionNameEn: ").Append(ActionNameEn).Append("\n");
            sb.Append("  actionDuration: ").Append(ActionDuration).Append("\n");
            sb.Append("  catalog: ").Append(Catalog).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionTagInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ActionTagInfo input)
        {
            if (input == null) return false;
            if (this.ActionNameZh != input.ActionNameZh || (this.ActionNameZh != null && !this.ActionNameZh.Equals(input.ActionNameZh))) return false;
            if (this.ActionNameEn != input.ActionNameEn || (this.ActionNameEn != null && !this.ActionNameEn.Equals(input.ActionNameEn))) return false;
            if (this.ActionDuration != input.ActionDuration || (this.ActionDuration != null && !this.ActionDuration.Equals(input.ActionDuration))) return false;
            if (this.Catalog != input.Catalog || (this.Catalog != null && !this.Catalog.Equals(input.Catalog))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;

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
                if (this.ActionNameZh != null) hashCode = hashCode * 59 + this.ActionNameZh.GetHashCode();
                if (this.ActionNameEn != null) hashCode = hashCode * 59 + this.ActionNameEn.GetHashCode();
                if (this.ActionDuration != null) hashCode = hashCode * 59 + this.ActionDuration.GetHashCode();
                if (this.Catalog != null) hashCode = hashCode * 59 + this.Catalog.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }
}
