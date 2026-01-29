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
    public class AlmStatus 
    {

        /// <summary>
        /// **参数解释：**  状态Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：**  工作项的状态属性。 **取值范围：**  - START - IN_PROGRESS - END
        /// </summary>
        [JsonProperty("belonging", NullValueHandling = NullValueHandling.Ignore)]
        public string Belonging { get; set; }

        /// <summary>
        /// **参数解释：**  状态所属的项目空间id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("space_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SpaceId { get; set; }

        /// <summary>
        /// **参数解释：**  状态名称。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：**  状态code值。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释：**  状态定义级别，1,2,3为系统级，4为租户自定义，5为项目自定义。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("definition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DefinitionType { get; set; }

        /// <summary>
        /// **参数解释：**  状态归属定义级别，1,2,3为系统级，4为租户自定义，5为项目自定义。区别于definition_type。如果为系统级和租户自定义级，在项目中会复制一份元数据，归属于项目空间。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("belong_definition_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? BelongDefinitionType { get; set; }

        /// <summary>
        /// **参数解释：**  状态名称，和name值相同。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("display_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// **参数解释：**  位置顺序。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("position", NullValueHandling = NullValueHandling.Ignore)]
        public int? Position { get; set; }

        /// <summary>
        /// **参数解释：**  是否显示。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("displayable", NullValueHandling = NullValueHandling.Ignore)]
        public int? Displayable { get; set; }

        /// <summary>
        /// **参数解释：**  是否可编辑。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("editable", NullValueHandling = NullValueHandling.Ignore)]
        public int? Editable { get; set; }

        /// <summary>
        /// **参数解释：**  是否可删除。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("deletable", NullValueHandling = NullValueHandling.Ignore)]
        public int? Deletable { get; set; }

        /// <summary>
        /// **参数解释：**  是否可变，即是否为固定值。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("mutable", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mutable { get; set; }

        /// <summary>
        /// **参数解释：**  标题的拼音首字母。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("title_py", NullValueHandling = NullValueHandling.Ignore)]
        public string TitlePy { get; set; }

        /// <summary>
        /// **参数解释：**  创建人用户Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// **参数解释：**  创建时间。Unix时间戳，精度为毫秒。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// **参数解释：**  最近修改时间。Unix时间戳，精度为毫秒。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifiedDate { get; set; }

        /// <summary>
        /// **参数解释：**  最近修改人用户Id。 **取值范围：**    不涉及。
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlmStatus {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  belonging: ").Append(Belonging).Append("\n");
            sb.Append("  spaceId: ").Append(SpaceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  definitionType: ").Append(DefinitionType).Append("\n");
            sb.Append("  belongDefinitionType: ").Append(BelongDefinitionType).Append("\n");
            sb.Append("  displayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("  position: ").Append(Position).Append("\n");
            sb.Append("  displayable: ").Append(Displayable).Append("\n");
            sb.Append("  editable: ").Append(Editable).Append("\n");
            sb.Append("  deletable: ").Append(Deletable).Append("\n");
            sb.Append("  mutable: ").Append(Mutable).Append("\n");
            sb.Append("  titlePy: ").Append(TitlePy).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlmStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlmStatus input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Belonging != input.Belonging || (this.Belonging != null && !this.Belonging.Equals(input.Belonging))) return false;
            if (this.SpaceId != input.SpaceId || (this.SpaceId != null && !this.SpaceId.Equals(input.SpaceId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.DefinitionType != input.DefinitionType || (this.DefinitionType != null && !this.DefinitionType.Equals(input.DefinitionType))) return false;
            if (this.BelongDefinitionType != input.BelongDefinitionType || (this.BelongDefinitionType != null && !this.BelongDefinitionType.Equals(input.BelongDefinitionType))) return false;
            if (this.DisplayValue != input.DisplayValue || (this.DisplayValue != null && !this.DisplayValue.Equals(input.DisplayValue))) return false;
            if (this.Position != input.Position || (this.Position != null && !this.Position.Equals(input.Position))) return false;
            if (this.Displayable != input.Displayable || (this.Displayable != null && !this.Displayable.Equals(input.Displayable))) return false;
            if (this.Editable != input.Editable || (this.Editable != null && !this.Editable.Equals(input.Editable))) return false;
            if (this.Deletable != input.Deletable || (this.Deletable != null && !this.Deletable.Equals(input.Deletable))) return false;
            if (this.Mutable != input.Mutable || (this.Mutable != null && !this.Mutable.Equals(input.Mutable))) return false;
            if (this.TitlePy != input.TitlePy || (this.TitlePy != null && !this.TitlePy.Equals(input.TitlePy))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Belonging != null) hashCode = hashCode * 59 + this.Belonging.GetHashCode();
                if (this.SpaceId != null) hashCode = hashCode * 59 + this.SpaceId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.DefinitionType != null) hashCode = hashCode * 59 + this.DefinitionType.GetHashCode();
                if (this.BelongDefinitionType != null) hashCode = hashCode * 59 + this.BelongDefinitionType.GetHashCode();
                if (this.DisplayValue != null) hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
                if (this.Position != null) hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.Displayable != null) hashCode = hashCode * 59 + this.Displayable.GetHashCode();
                if (this.Editable != null) hashCode = hashCode * 59 + this.Editable.GetHashCode();
                if (this.Deletable != null) hashCode = hashCode * 59 + this.Deletable.GetHashCode();
                if (this.Mutable != null) hashCode = hashCode * 59 + this.Mutable.GetHashCode();
                if (this.TitlePy != null) hashCode = hashCode * 59 + this.TitlePy.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                return hashCode;
            }
        }
    }
}
