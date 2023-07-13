using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Classroom.V3.Model
{
    /// <summary>
    /// 习题库简单信息返回体，用于列表返回
    /// </summary>
    public class PackageCard 
    {

        /// <summary>
        /// 习题库id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 习题库名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [JsonProperty("tag_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TagName { get; set; }

        /// <summary>
        /// 学习名称
        /// </summary>
        [JsonProperty("school", NullValueHandling = NullValueHandling.Ignore)]
        public string School { get; set; }

        /// <summary>
        /// 教师名称
        /// </summary>
        [JsonProperty("teacher_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TeacherName { get; set; }

        /// <summary>
        /// 租户习题库编号
        /// </summary>
        [JsonProperty("order_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? OrderCount { get; set; }

        /// <summary>
        /// 背景图url
        /// </summary>
        [JsonProperty("image_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageCard {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  tagName: ").Append(TagName).Append("\n");
            sb.Append("  school: ").Append(School).Append("\n");
            sb.Append("  teacherName: ").Append(TeacherName).Append("\n");
            sb.Append("  orderCount: ").Append(OrderCount).Append("\n");
            sb.Append("  imageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PackageCard);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PackageCard input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TagName == input.TagName ||
                    (this.TagName != null &&
                    this.TagName.Equals(input.TagName))
                ) && 
                (
                    this.School == input.School ||
                    (this.School != null &&
                    this.School.Equals(input.School))
                ) && 
                (
                    this.TeacherName == input.TeacherName ||
                    (this.TeacherName != null &&
                    this.TeacherName.Equals(input.TeacherName))
                ) && 
                (
                    this.OrderCount == input.OrderCount ||
                    (this.OrderCount != null &&
                    this.OrderCount.Equals(input.OrderCount))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TagName != null)
                    hashCode = hashCode * 59 + this.TagName.GetHashCode();
                if (this.School != null)
                    hashCode = hashCode * 59 + this.School.GetHashCode();
                if (this.TeacherName != null)
                    hashCode = hashCode * 59 + this.TeacherName.GetHashCode();
                if (this.OrderCount != null)
                    hashCode = hashCode * 59 + this.OrderCount.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
