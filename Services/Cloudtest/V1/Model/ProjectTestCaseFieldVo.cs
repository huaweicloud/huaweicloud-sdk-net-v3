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
    public class ProjectTestCaseFieldVo 
    {

        /// <summary>
        /// 项目用例自定义字段主键
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 项目用例自定义字段名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 项目用例自定义字段类型（单行文本text、多行文本textArea、单选框radio、多选框checkBox、日期date、数字number、单选用户user）
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 项目用例自定义字段选项（数字类型时，数组两个值，第一个是最小值，第二个是最大值）
        /// </summary>
        [JsonProperty("options", NullValueHandling = NullValueHandling.Ignore)]
        public string Options { get; set; }

        /// <summary>
        /// 项目用例自定义字段描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 项目用例自定义字段创建人
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public string Creator { get; set; }

        /// <summary>
        /// 项目用例自定义字段更新人
        /// </summary>
        [JsonProperty("updater", NullValueHandling = NullValueHandling.Ignore)]
        public string Updater { get; set; }

        /// <summary>
        /// 项目用例自定义字段id（1-25数字）
        /// </summary>
        [JsonProperty("custom_field_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomFieldId { get; set; }

        /// <summary>
        /// 项目用例自定义字段名称
        /// </summary>
        [JsonProperty("custom_field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomFieldName { get; set; }

        /// <summary>
        /// 项目用例自定义字段入参或者返回参数名称
        /// </summary>
        [JsonProperty("custom_field_param", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomFieldParam { get; set; }

        /// <summary>
        /// 项目用例自定义字段类型国际化名称
        /// </summary>
        [JsonProperty("type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeName { get; set; }

        /// <summary>
        /// 项目用例自定义字段创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 项目用例自定义字段创建时间时间戳
        /// </summary>
        [JsonProperty("create_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimeTimestamp { get; set; }

        /// <summary>
        /// 项目用例自定义字段更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 项目用例自定义字段更新时间时间戳
        /// </summary>
        [JsonProperty("update_time_timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimeTimestamp { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectTestCaseFieldVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  options: ").Append(Options).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  updater: ").Append(Updater).Append("\n");
            sb.Append("  customFieldId: ").Append(CustomFieldId).Append("\n");
            sb.Append("  customFieldName: ").Append(CustomFieldName).Append("\n");
            sb.Append("  customFieldParam: ").Append(CustomFieldParam).Append("\n");
            sb.Append("  typeName: ").Append(TypeName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  createTimeTimestamp: ").Append(CreateTimeTimestamp).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  updateTimeTimestamp: ").Append(UpdateTimeTimestamp).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectTestCaseFieldVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectTestCaseFieldVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Options != input.Options || (this.Options != null && !this.Options.Equals(input.Options))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.Updater != input.Updater || (this.Updater != null && !this.Updater.Equals(input.Updater))) return false;
            if (this.CustomFieldId != input.CustomFieldId || (this.CustomFieldId != null && !this.CustomFieldId.Equals(input.CustomFieldId))) return false;
            if (this.CustomFieldName != input.CustomFieldName || (this.CustomFieldName != null && !this.CustomFieldName.Equals(input.CustomFieldName))) return false;
            if (this.CustomFieldParam != input.CustomFieldParam || (this.CustomFieldParam != null && !this.CustomFieldParam.Equals(input.CustomFieldParam))) return false;
            if (this.TypeName != input.TypeName || (this.TypeName != null && !this.TypeName.Equals(input.TypeName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.CreateTimeTimestamp != input.CreateTimeTimestamp || (this.CreateTimeTimestamp != null && !this.CreateTimeTimestamp.Equals(input.CreateTimeTimestamp))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.UpdateTimeTimestamp != input.UpdateTimeTimestamp || (this.UpdateTimeTimestamp != null && !this.UpdateTimeTimestamp.Equals(input.UpdateTimeTimestamp))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;

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
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Options != null) hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.Updater != null) hashCode = hashCode * 59 + this.Updater.GetHashCode();
                if (this.CustomFieldId != null) hashCode = hashCode * 59 + this.CustomFieldId.GetHashCode();
                if (this.CustomFieldName != null) hashCode = hashCode * 59 + this.CustomFieldName.GetHashCode();
                if (this.CustomFieldParam != null) hashCode = hashCode * 59 + this.CustomFieldParam.GetHashCode();
                if (this.TypeName != null) hashCode = hashCode * 59 + this.TypeName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.CreateTimeTimestamp != null) hashCode = hashCode * 59 + this.CreateTimeTimestamp.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.UpdateTimeTimestamp != null) hashCode = hashCode * 59 + this.UpdateTimeTimestamp.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                return hashCode;
            }
        }
    }
}
