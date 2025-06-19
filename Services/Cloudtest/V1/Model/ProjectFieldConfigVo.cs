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
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class ProjectFieldConfigVo 
    {

        /// <summary>
        /// 字段配置URI标识
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("updator", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Updator { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 项目用例自定义字段名称
        /// </summary>
        [JsonProperty("customName", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomName { get; set; }

        /// <summary>
        /// 字段名（对应后端参数名）
        /// </summary>
        [JsonProperty("table_field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TableFieldName { get; set; }

        /// <summary>
        /// 字段类型(单行文本text、多行文本textArea、单选框radio、多选框checkbox、日期date、数字number、用户user)。
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueType { get; set; }

        /// <summary>
        /// 字段类型国际化名称
        /// </summary>
        [JsonProperty("value_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueTypeName { get; set; }

        /// <summary>
        /// 是否系统字段
        /// </summary>
        [JsonProperty("is_system", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsSystem { get; set; }

        /// <summary>
        /// 是否显示
        /// </summary>
        [JsonProperty("is_display", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsDisplay { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [JsonProperty("is_required", NullValueHandling = NullValueHandling.Ignore)]
        public int? IsRequired { get; set; }

        /// <summary>
        /// 顺序数值
        /// </summary>
        [JsonProperty("sort_numb", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortNumb { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 扩展字段uri(用于连表查扩展字段)
        /// </summary>
        [JsonProperty("custom_field_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomFieldUri { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("creator", NullValueHandling = NullValueHandling.Ignore)]
        public NameAndIdVo Creator { get; set; }

        /// <summary>
        /// 创建时间时间戳
        /// </summary>
        [JsonProperty("create_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// 更新时间时间戳
        /// </summary>
        [JsonProperty("update_time_stamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTimeStamp { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectUuid { get; set; }

        /// <summary>
        /// 可选项
        /// </summary>
        [JsonProperty("option_vos", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProjectFieldConfigOptionVo> OptionVos { get; set; }

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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProjectFieldConfigVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  updator: ").Append(Updator).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  customName: ").Append(CustomName).Append("\n");
            sb.Append("  tableFieldName: ").Append(TableFieldName).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("  valueTypeName: ").Append(ValueTypeName).Append("\n");
            sb.Append("  isSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  isDisplay: ").Append(IsDisplay).Append("\n");
            sb.Append("  isRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  sortNumb: ").Append(SortNumb).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  customFieldUri: ").Append(CustomFieldUri).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  creator: ").Append(Creator).Append("\n");
            sb.Append("  createTimeStamp: ").Append(CreateTimeStamp).Append("\n");
            sb.Append("  updateTimeStamp: ").Append(UpdateTimeStamp).Append("\n");
            sb.Append("  projectUuid: ").Append(ProjectUuid).Append("\n");
            sb.Append("  optionVos: ").Append(OptionVos).Append("\n");
            sb.Append("  customFieldId: ").Append(CustomFieldId).Append("\n");
            sb.Append("  customFieldName: ").Append(CustomFieldName).Append("\n");
            sb.Append("  customFieldParam: ").Append(CustomFieldParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProjectFieldConfigVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProjectFieldConfigVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Updator != input.Updator || (this.Updator != null && !this.Updator.Equals(input.Updator))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CustomName != input.CustomName || (this.CustomName != null && !this.CustomName.Equals(input.CustomName))) return false;
            if (this.TableFieldName != input.TableFieldName || (this.TableFieldName != null && !this.TableFieldName.Equals(input.TableFieldName))) return false;
            if (this.ValueType != input.ValueType || (this.ValueType != null && !this.ValueType.Equals(input.ValueType))) return false;
            if (this.ValueTypeName != input.ValueTypeName || (this.ValueTypeName != null && !this.ValueTypeName.Equals(input.ValueTypeName))) return false;
            if (this.IsSystem != input.IsSystem || (this.IsSystem != null && !this.IsSystem.Equals(input.IsSystem))) return false;
            if (this.IsDisplay != input.IsDisplay || (this.IsDisplay != null && !this.IsDisplay.Equals(input.IsDisplay))) return false;
            if (this.IsRequired != input.IsRequired || (this.IsRequired != null && !this.IsRequired.Equals(input.IsRequired))) return false;
            if (this.SortNumb != input.SortNumb || (this.SortNumb != null && !this.SortNumb.Equals(input.SortNumb))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.CustomFieldUri != input.CustomFieldUri || (this.CustomFieldUri != null && !this.CustomFieldUri.Equals(input.CustomFieldUri))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.Creator != input.Creator || (this.Creator != null && !this.Creator.Equals(input.Creator))) return false;
            if (this.CreateTimeStamp != input.CreateTimeStamp || (this.CreateTimeStamp != null && !this.CreateTimeStamp.Equals(input.CreateTimeStamp))) return false;
            if (this.UpdateTimeStamp != input.UpdateTimeStamp || (this.UpdateTimeStamp != null && !this.UpdateTimeStamp.Equals(input.UpdateTimeStamp))) return false;
            if (this.ProjectUuid != input.ProjectUuid || (this.ProjectUuid != null && !this.ProjectUuid.Equals(input.ProjectUuid))) return false;
            if (this.OptionVos != input.OptionVos || (this.OptionVos != null && input.OptionVos != null && !this.OptionVos.SequenceEqual(input.OptionVos))) return false;
            if (this.CustomFieldId != input.CustomFieldId || (this.CustomFieldId != null && !this.CustomFieldId.Equals(input.CustomFieldId))) return false;
            if (this.CustomFieldName != input.CustomFieldName || (this.CustomFieldName != null && !this.CustomFieldName.Equals(input.CustomFieldName))) return false;
            if (this.CustomFieldParam != input.CustomFieldParam || (this.CustomFieldParam != null && !this.CustomFieldParam.Equals(input.CustomFieldParam))) return false;

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
                if (this.Updator != null) hashCode = hashCode * 59 + this.Updator.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CustomName != null) hashCode = hashCode * 59 + this.CustomName.GetHashCode();
                if (this.TableFieldName != null) hashCode = hashCode * 59 + this.TableFieldName.GetHashCode();
                if (this.ValueType != null) hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.ValueTypeName != null) hashCode = hashCode * 59 + this.ValueTypeName.GetHashCode();
                if (this.IsSystem != null) hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
                if (this.IsDisplay != null) hashCode = hashCode * 59 + this.IsDisplay.GetHashCode();
                if (this.IsRequired != null) hashCode = hashCode * 59 + this.IsRequired.GetHashCode();
                if (this.SortNumb != null) hashCode = hashCode * 59 + this.SortNumb.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.CustomFieldUri != null) hashCode = hashCode * 59 + this.CustomFieldUri.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Creator != null) hashCode = hashCode * 59 + this.Creator.GetHashCode();
                if (this.CreateTimeStamp != null) hashCode = hashCode * 59 + this.CreateTimeStamp.GetHashCode();
                if (this.UpdateTimeStamp != null) hashCode = hashCode * 59 + this.UpdateTimeStamp.GetHashCode();
                if (this.ProjectUuid != null) hashCode = hashCode * 59 + this.ProjectUuid.GetHashCode();
                if (this.OptionVos != null) hashCode = hashCode * 59 + this.OptionVos.GetHashCode();
                if (this.CustomFieldId != null) hashCode = hashCode * 59 + this.CustomFieldId.GetHashCode();
                if (this.CustomFieldName != null) hashCode = hashCode * 59 + this.CustomFieldName.GetHashCode();
                if (this.CustomFieldParam != null) hashCode = hashCode * 59 + this.CustomFieldParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
