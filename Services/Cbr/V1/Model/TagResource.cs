using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TagResource 
    {

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源详情
        /// </summary>
        [JsonProperty("resource_detail", NullValueHandling = NullValueHandling.Ignore)]
        public List<Vault> ResourceDetail { get; set; }

        /// <summary>
        /// 标签列表 没有标签默认为空数字。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 仅op_service权限才可以获取此字段：  目前只包含一个resource_tag 结构体。  key：_sys_enterprise_project_id  value：企业项目id，0表示默认企业项目  非op_service场景不能返回此字段。
        /// </summary>
        [JsonProperty("sys_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<SysTag> SysTags { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TagResource {\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceDetail: ").Append(ResourceDetail).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  sysTags: ").Append(SysTags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TagResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TagResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceDetail == input.ResourceDetail ||
                    this.ResourceDetail != null &&
                    input.ResourceDetail != null &&
                    this.ResourceDetail.SequenceEqual(input.ResourceDetail)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.SysTags == input.SysTags ||
                    this.SysTags != null &&
                    input.SysTags != null &&
                    this.SysTags.SequenceEqual(input.SysTags)
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
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceDetail != null)
                    hashCode = hashCode * 59 + this.ResourceDetail.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.SysTags != null)
                    hashCode = hashCode * 59 + this.SysTags.GetHashCode();
                return hashCode;
            }
        }
    }
}
