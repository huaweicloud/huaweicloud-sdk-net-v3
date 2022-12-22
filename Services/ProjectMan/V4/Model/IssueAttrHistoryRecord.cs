using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class IssueAttrHistoryRecord 
    {

        /// <summary>
        /// 操作的字段
        /// </summary>
        [JsonProperty("field_key", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldKey { get; set; }

        /// <summary>
        /// 操作字段的含义
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 历史记录id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 工作项id
        /// </summary>
        [JsonProperty("issue_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? IssueId { get; set; }

        /// <summary>
        /// 变更后的值,json字符串
        /// </summary>
        [JsonProperty("new_value", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }

        /// <summary>
        /// 变更前的值,json字符串
        /// </summary>
        [JsonProperty("old_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        /// <summary>
        /// 变更的时间
        /// </summary>
        [JsonProperty("operated_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? OperatedTime { get; set; }

        /// <summary>
        /// 操作类型,新建，修改，删除
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public string Operation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public IssueUser Operator { get; set; }

        /// <summary>
        /// 变更的属性
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public string Property { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueAttrHistoryRecord {\n");
            sb.Append("  fieldKey: ").Append(FieldKey).Append("\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  issueId: ").Append(IssueId).Append("\n");
            sb.Append("  newValue: ").Append(NewValue).Append("\n");
            sb.Append("  oldValue: ").Append(OldValue).Append("\n");
            sb.Append("  operatedTime: ").Append(OperatedTime).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueAttrHistoryRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueAttrHistoryRecord input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldKey == input.FieldKey ||
                    (this.FieldKey != null &&
                    this.FieldKey.Equals(input.FieldKey))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IssueId == input.IssueId ||
                    (this.IssueId != null &&
                    this.IssueId.Equals(input.IssueId))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
                ) && 
                (
                    this.OldValue == input.OldValue ||
                    (this.OldValue != null &&
                    this.OldValue.Equals(input.OldValue))
                ) && 
                (
                    this.OperatedTime == input.OperatedTime ||
                    (this.OperatedTime != null &&
                    this.OperatedTime.Equals(input.OperatedTime))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
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
                if (this.FieldKey != null)
                    hashCode = hashCode * 59 + this.FieldKey.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IssueId != null)
                    hashCode = hashCode * 59 + this.IssueId.GetHashCode();
                if (this.NewValue != null)
                    hashCode = hashCode * 59 + this.NewValue.GetHashCode();
                if (this.OldValue != null)
                    hashCode = hashCode * 59 + this.OldValue.GetHashCode();
                if (this.OperatedTime != null)
                    hashCode = hashCode * 59 + this.OperatedTime.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Operator != null)
                    hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                return hashCode;
            }
        }
    }
}
