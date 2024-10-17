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
    /// Response Object
    /// </summary>
    public class ListsAgencyPermissionsResponse : SdkResponse
    {

        /// <summary>
        /// - DRS FullAccess 数据复制服务所有权限
        /// </summary>
        [JsonProperty("common_permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CommonPermissions { get; set; }

        /// <summary>
        /// -  GaussDB ReadOnlyAccess 云数据库 GaussDB服务的只读访问权限 -  GeminiDB ReadOnlyAccess 分布式多模NoSQL数据库服务只读权限 -  GaussDBforMSQLReadOnlyAccess 云数据库HUAWEIGaussDBforMSQL服务的只读访问权限 -  DWS ReadOnlyAccess 数据仓库服务只读权限 -  DDM ReadOnlyAccess 分布式数据库中间件服务只读权限 -  DDS ReadOnlyPolicy 文档数据库服务资源只读权限 -  RDS ReadOnlyAccess 关系型数据库服务资源只读权限 -  MRS ReadOnlyAccess MapReduce服务只读权限,包括集群查询操作,基础服务弹性云服务器、裸金属服务器、云硬盘、虚拟私有云只读权限
        /// </summary>
        [JsonProperty("engine_permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnginePermissions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListsAgencyPermissionsResponse {\n");
            sb.Append("  commonPermissions: ").Append(CommonPermissions).Append("\n");
            sb.Append("  enginePermissions: ").Append(EnginePermissions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListsAgencyPermissionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListsAgencyPermissionsResponse input)
        {
            if (input == null) return false;
            if (this.CommonPermissions != input.CommonPermissions || (this.CommonPermissions != null && input.CommonPermissions != null && !this.CommonPermissions.SequenceEqual(input.CommonPermissions))) return false;
            if (this.EnginePermissions != input.EnginePermissions || (this.EnginePermissions != null && input.EnginePermissions != null && !this.EnginePermissions.SequenceEqual(input.EnginePermissions))) return false;

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
                if (this.CommonPermissions != null) hashCode = hashCode * 59 + this.CommonPermissions.GetHashCode();
                if (this.EnginePermissions != null) hashCode = hashCode * 59 + this.EnginePermissions.GetHashCode();
                return hashCode;
            }
        }
    }
}
