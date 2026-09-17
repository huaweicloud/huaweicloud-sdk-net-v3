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
    /// 特性集OpenApi返回体
    /// </summary>
    public class FeatureSetOpenApiVO 
    {

        /// <summary>
        /// 特性集ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// 父特性集ID
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 位置信息
        /// </summary>
        [JsonProperty("position_float", NullValueHandling = NullValueHandling.Ignore)]
        public float? PositionFloat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity ModifiedBy { get; set; }

        /// <summary>
        /// **参数解释**： 特性集创建时间的时间戳。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// **参数解释**： 特性集修改时间的时间戳。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 子特性集
        /// </summary>
        [JsonProperty("child_fs", NullValueHandling = NullValueHandling.Ignore)]
        public List<FeatureSetOpenApiVO> ChildFs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FeatureSetOpenApiVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  number: ").Append(Number).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  positionFloat: ").Append(PositionFloat).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  childFs: ").Append(ChildFs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FeatureSetOpenApiVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FeatureSetOpenApiVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Number != input.Number || (this.Number != null && !this.Number.Equals(input.Number))) return false;
            if (this.ParentId != input.ParentId || (this.ParentId != null && !this.ParentId.Equals(input.ParentId))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.PositionFloat != input.PositionFloat || (this.PositionFloat != null && !this.PositionFloat.Equals(input.PositionFloat))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.ChildFs != input.ChildFs || (this.ChildFs != null && input.ChildFs != null && !this.ChildFs.SequenceEqual(input.ChildFs))) return false;

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
                if (this.Number != null) hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.ParentId != null) hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.PositionFloat != null) hashCode = hashCode * 59 + this.PositionFloat.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.ChildFs != null) hashCode = hashCode * 59 + this.ChildFs.GetHashCode();
                return hashCode;
            }
        }
    }
}
