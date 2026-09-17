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
    /// Category层级数据类型
    /// </summary>
    public class CategoryLayerDTO 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public BaseCategory Category { get; set; }

        /// <summary>
        /// **参数解释**： 父类字段。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("link_parent_field", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkParentField { get; set; }

        /// <summary>
        /// **参数解释**： 工作项层级ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 子工作项层级数据类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("children", NullValueHandling = NullValueHandling.Ignore)]
        public List<CategoryLayerDTO> Children { get; set; }

        /// <summary>
        /// **参数解释**： 层级对象类型编码。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**： 对象类型编码。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("category_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// **参数解释**： 对象类型ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        /// **参数解释**： 层级类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("layer_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LayerType { get; set; }

        /// <summary>
        /// **参数解释**： 父ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// **参数解释**： 根工作项ID。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("root_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RootId { get; set; }

        /// <summary>
        /// **参数解释**： 画布X轴坐标。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("position_x", NullValueHandling = NullValueHandling.Ignore)]
        public int? PositionX { get; set; }

        /// <summary>
        /// **参数解释**： 画布Y轴坐标。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("position_y", NullValueHandling = NullValueHandling.Ignore)]
        public int? PositionY { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryLayerDTO {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  linkParentField: ").Append(LinkParentField).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  children: ").Append(Children).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  categoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  layerType: ").Append(LayerType).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  rootId: ").Append(RootId).Append("\n");
            sb.Append("  positionX: ").Append(PositionX).Append("\n");
            sb.Append("  positionY: ").Append(PositionY).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CategoryLayerDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CategoryLayerDTO input)
        {
            if (input == null) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.LinkParentField != input.LinkParentField || (this.LinkParentField != null && !this.LinkParentField.Equals(input.LinkParentField))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Children != input.Children || (this.Children != null && input.Children != null && !this.Children.SequenceEqual(input.Children))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.CategoryCode != input.CategoryCode || (this.CategoryCode != null && !this.CategoryCode.Equals(input.CategoryCode))) return false;
            if (this.CategoryId != input.CategoryId || (this.CategoryId != null && !this.CategoryId.Equals(input.CategoryId))) return false;
            if (this.LayerType != input.LayerType || (this.LayerType != null && !this.LayerType.Equals(input.LayerType))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.RootId != input.RootId || (this.RootId != null && !this.RootId.Equals(input.RootId))) return false;
            if (this.PositionX != input.PositionX || (this.PositionX != null && !this.PositionX.Equals(input.PositionX))) return false;
            if (this.PositionY != input.PositionY || (this.PositionY != null && !this.PositionY.Equals(input.PositionY))) return false;

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
                if (this.Category != null) hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.LinkParentField != null) hashCode = hashCode * 59 + this.LinkParentField.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Children != null) hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.CategoryCode != null) hashCode = hashCode * 59 + this.CategoryCode.GetHashCode();
                if (this.CategoryId != null) hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.LayerType != null) hashCode = hashCode * 59 + this.LayerType.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.RootId != null) hashCode = hashCode * 59 + this.RootId.GetHashCode();
                if (this.PositionX != null) hashCode = hashCode * 59 + this.PositionX.GetHashCode();
                if (this.PositionY != null) hashCode = hashCode * 59 + this.PositionY.GetHashCode();
                return hashCode;
            }
        }
    }
}
