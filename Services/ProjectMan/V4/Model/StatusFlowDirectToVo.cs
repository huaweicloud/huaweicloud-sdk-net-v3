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
    public class StatusFlowDirectToVo 
    {

        /// <summary>
        ///  父状态的名称
        /// </summary>
        [JsonProperty("parent_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentName { get; set; }

        /// <summary>
        /// 父状态的类型
        /// </summary>
        [JsonProperty("parent_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentType { get; set; }

        /// <summary>
        /// 状态id
        /// </summary>
        [JsonProperty("status_id", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusId { get; set; }

        /// <summary>
        /// 状态名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 状态类型
        /// </summary>
        [JsonProperty("status_type", NullValueHandling = NullValueHandling.Ignore)]
        public string StatusType { get; set; }

        /// <summary>
        /// 是否已开启状态流转， true： 开启, false 没开启
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 父状态的uuid
        /// </summary>
        [JsonProperty("parent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatusFlowDirectToVo {\n");
            sb.Append("  parentName: ").Append(ParentName).Append("\n");
            sb.Append("  parentType: ").Append(ParentType).Append("\n");
            sb.Append("  statusId: ").Append(StatusId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  statusType: ").Append(StatusType).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("  parentId: ").Append(ParentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StatusFlowDirectToVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StatusFlowDirectToVo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParentName == input.ParentName ||
                    (this.ParentName != null &&
                    this.ParentName.Equals(input.ParentName))
                ) && 
                (
                    this.ParentType == input.ParentType ||
                    (this.ParentType != null &&
                    this.ParentType.Equals(input.ParentType))
                ) && 
                (
                    this.StatusId == input.StatusId ||
                    (this.StatusId != null &&
                    this.StatusId.Equals(input.StatusId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.StatusType == input.StatusType ||
                    (this.StatusType != null &&
                    this.StatusType.Equals(input.StatusType))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
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
                if (this.ParentName != null)
                    hashCode = hashCode * 59 + this.ParentName.GetHashCode();
                if (this.ParentType != null)
                    hashCode = hashCode * 59 + this.ParentType.GetHashCode();
                if (this.StatusId != null)
                    hashCode = hashCode * 59 + this.StatusId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.StatusType != null)
                    hashCode = hashCode * 59 + this.StatusType.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                return hashCode;
            }
        }
    }
}
