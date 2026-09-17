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
    public class CommentExtendAttribute 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public UserVO Operator { get; set; }

        /// <summary>
        /// 操作人Id
        /// </summary>
        [JsonProperty("operator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 系统生成评论时执行的动作
        /// </summary>
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        /// <summary>
        /// 系统生成评论时执行的动作(英文)
        /// </summary>
        [JsonProperty("action_us", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionUs { get; set; }

        /// <summary>
        /// 系统生成评论对应的对象类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 工作项流转前的状态Code
        /// </summary>
        [JsonProperty("pre_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string PreStatusCode { get; set; }

        /// <summary>
        /// 工作项流转后的状态Code
        /// </summary>
        [JsonProperty("new_status_code", NullValueHandling = NullValueHandling.Ignore)]
        public string NewStatusCode { get; set; }

        /// <summary>
        /// 对象类型根据field_type_id值变化而变化。 field_type_id&#x3D;10001时，为StatusVO field_type_id&#x3D;10007、10008时，为字符串 field_type_id&#x3D;10003、10004时，为日期时间 field_type_id&#x3D;10005、10006时，为数字
        /// </summary>
        [JsonProperty("pre_status", NullValueHandling = NullValueHandling.Ignore)]
        public Object PreStatus { get; set; }

        /// <summary>
        /// 对象类型根据field_type_id值变化而变化。 field_type_id&#x3D;10001、10002时，为StatusVO field_type_id&#x3D;10007、10008时，为字符串 field_type_id&#x3D;10003、10004时，为日期时间 field_type_id&#x3D;10005、10006时，为数字 field_type_id&#x3D;10009、10010时，为UserVO
        /// </summary>
        [JsonProperty("new_status", NullValueHandling = NullValueHandling.Ignore)]
        public Object NewStatus { get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        /// <summary>
        /// 字段类型对应的Id
        /// </summary>
        [JsonProperty("field_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldTypeId { get; set; }

        /// <summary>
        /// 字段显示名
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentExtendAttribute {\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  operatorId: ").Append(OperatorId).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  actionUs: ").Append(ActionUs).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  preStatusCode: ").Append(PreStatusCode).Append("\n");
            sb.Append("  newStatusCode: ").Append(NewStatusCode).Append("\n");
            sb.Append("  preStatus: ").Append(PreStatus).Append("\n");
            sb.Append("  newStatus: ").Append(NewStatus).Append("\n");
            sb.Append("  fieldType: ").Append(FieldType).Append("\n");
            sb.Append("  fieldTypeId: ").Append(FieldTypeId).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommentExtendAttribute);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommentExtendAttribute input)
        {
            if (input == null) return false;
            if (this.Operator != input.Operator || (this.Operator != null && !this.Operator.Equals(input.Operator))) return false;
            if (this.OperatorId != input.OperatorId || (this.OperatorId != null && !this.OperatorId.Equals(input.OperatorId))) return false;
            if (this.Action != input.Action || (this.Action != null && !this.Action.Equals(input.Action))) return false;
            if (this.ActionUs != input.ActionUs || (this.ActionUs != null && !this.ActionUs.Equals(input.ActionUs))) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.PreStatusCode != input.PreStatusCode || (this.PreStatusCode != null && !this.PreStatusCode.Equals(input.PreStatusCode))) return false;
            if (this.NewStatusCode != input.NewStatusCode || (this.NewStatusCode != null && !this.NewStatusCode.Equals(input.NewStatusCode))) return false;
            if (this.PreStatus != input.PreStatus || (this.PreStatus != null && !this.PreStatus.Equals(input.PreStatus))) return false;
            if (this.NewStatus != input.NewStatus || (this.NewStatus != null && !this.NewStatus.Equals(input.NewStatus))) return false;
            if (this.FieldType != input.FieldType || (this.FieldType != null && !this.FieldType.Equals(input.FieldType))) return false;
            if (this.FieldTypeId != input.FieldTypeId || (this.FieldTypeId != null && !this.FieldTypeId.Equals(input.FieldTypeId))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;

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
                if (this.Operator != null) hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.OperatorId != null) hashCode = hashCode * 59 + this.OperatorId.GetHashCode();
                if (this.Action != null) hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.ActionUs != null) hashCode = hashCode * 59 + this.ActionUs.GetHashCode();
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.PreStatusCode != null) hashCode = hashCode * 59 + this.PreStatusCode.GetHashCode();
                if (this.NewStatusCode != null) hashCode = hashCode * 59 + this.NewStatusCode.GetHashCode();
                if (this.PreStatus != null) hashCode = hashCode * 59 + this.PreStatus.GetHashCode();
                if (this.NewStatus != null) hashCode = hashCode * 59 + this.NewStatus.GetHashCode();
                if (this.FieldType != null) hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.FieldTypeId != null) hashCode = hashCode * 59 + this.FieldTypeId.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                return hashCode;
            }
        }
    }
}
