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
    public class ReviewOpinionEntity 
    {

        /// <summary>
        /// 评审意见对象类型，固定为Opinion。
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// 评审意见对象关联的变更对象ID。
        /// </summary>
        [JsonProperty("co_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity CreatedBy { get; set; }

        /// <summary>
        /// 评审意见创建时间。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("curr_owner", NullValueHandling = NullValueHandling.Ignore)]
        public UserEntity CurrOwner { get; set; }

        /// <summary>
        /// 评审意见对象ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 评审意见最后修改时间。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedDate { get; set; }

        /// <summary>
        /// 评审意见。
        /// </summary>
        [JsonProperty("review_comments", NullValueHandling = NullValueHandling.Ignore)]
        public string ReviewComments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReviewOpinionEntity {\n");
            sb.Append("  category: ").Append(Category).Append("\n");
            sb.Append("  coId: ").Append(CoId).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  currOwner: ").Append(CurrOwner).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  reviewComments: ").Append(ReviewComments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReviewOpinionEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReviewOpinionEntity input)
        {
            if (input == null) return false;
            if (this.Category != input.Category || (this.Category != null && !this.Category.Equals(input.Category))) return false;
            if (this.CoId != input.CoId || (this.CoId != null && !this.CoId.Equals(input.CoId))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.CurrOwner != input.CurrOwner || (this.CurrOwner != null && !this.CurrOwner.Equals(input.CurrOwner))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.ReviewComments != input.ReviewComments || (this.ReviewComments != null && !this.ReviewComments.Equals(input.ReviewComments))) return false;

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
                if (this.CoId != null) hashCode = hashCode * 59 + this.CoId.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.CurrOwner != null) hashCode = hashCode * 59 + this.CurrOwner.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.ReviewComments != null) hashCode = hashCode * 59 + this.ReviewComments.GetHashCode();
                return hashCode;
            }
        }
    }
}
