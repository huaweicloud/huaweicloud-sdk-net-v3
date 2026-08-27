using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 应用对象名称信息
    /// </summary>
    public class ApplyObjectDetailInfo 
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 对象id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 对象类型
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectType { get; set; }

        /// <summary>
        /// 对象名称
        /// </summary>
        [JsonProperty("object_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectName { get; set; }

        /// <summary>
        /// 域名称（用户）
        /// </summary>
        [JsonProperty("object_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyObjectDetailInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  objectName: ").Append(ObjectName).Append("\n");
            sb.Append("  objectDomain: ").Append(ObjectDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyObjectDetailInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyObjectDetailInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.ObjectType != input.ObjectType || (this.ObjectType != null && !this.ObjectType.Equals(input.ObjectType))) return false;
            if (this.ObjectName != input.ObjectName || (this.ObjectName != null && !this.ObjectName.Equals(input.ObjectName))) return false;
            if (this.ObjectDomain != input.ObjectDomain || (this.ObjectDomain != null && !this.ObjectDomain.Equals(input.ObjectDomain))) return false;

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
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.ObjectType != null) hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ObjectName != null) hashCode = hashCode * 59 + this.ObjectName.GetHashCode();
                if (this.ObjectDomain != null) hashCode = hashCode * 59 + this.ObjectDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
