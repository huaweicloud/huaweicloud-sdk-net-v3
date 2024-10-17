using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 数据库实例所在Region，项目等信息，当数据库实例类型为ecs（华为云ECS自建数据库），cloud（华为云数据库）时为必填项。
    /// </summary>
    public class CloudBaseInfo 
    {

        /// <summary>
        /// 区域ID，当数据库实例类型为ecs（华为云ECS自建数据库），cloud（华为云数据库）时为必填项。获取方法请参见地区和终端节点。 注意：当该Region下存在子项目时，Region ID为区域项目ID与子项目ID，由“_”下划线拼接，例如：cn-north-4_abc。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 租户在某一Region下的Project ID。 获取方法请参见获取项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 数据库所在可用分区（AZ）名称。
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloudBaseInfo {\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloudBaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloudBaseInfo input)
        {
            if (input == null) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.AzCode != input.AzCode || (this.AzCode != null && !this.AzCode.Equals(input.AzCode))) return false;

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
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.AzCode != null) hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
