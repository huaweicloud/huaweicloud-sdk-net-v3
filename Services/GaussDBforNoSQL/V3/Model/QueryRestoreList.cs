using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 可恢复的实例信息结构体
    /// </summary>
    public class QueryRestoreList 
    {

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例模式
        /// </summary>
        [JsonProperty("instance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// 引擎名称
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 引擎版本
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// VPC ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 子网ID列表
        /// </summary>
        [JsonProperty("subnet_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubnetIds { get; set; }

        /// <summary>
        /// 安全组ID列表
        /// </summary>
        [JsonProperty("security_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SecurityGroupIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryRestoreList {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceMode: ").Append(InstanceMode).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  subnetIds: ").Append(SubnetIds).Append("\n");
            sb.Append("  securityGroupIds: ").Append(SecurityGroupIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryRestoreList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryRestoreList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceMode == input.InstanceMode ||
                    (this.InstanceMode != null &&
                    this.InstanceMode.Equals(input.InstanceMode))
                ) && 
                (
                    this.EngineName == input.EngineName ||
                    (this.EngineName != null &&
                    this.EngineName.Equals(input.EngineName))
                ) && 
                (
                    this.EngineVersion == input.EngineVersion ||
                    (this.EngineVersion != null &&
                    this.EngineVersion.Equals(input.EngineVersion))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SubnetIds == input.SubnetIds ||
                    this.SubnetIds != null &&
                    input.SubnetIds != null &&
                    this.SubnetIds.SequenceEqual(input.SubnetIds)
                ) && 
                (
                    this.SecurityGroupIds == input.SecurityGroupIds ||
                    this.SecurityGroupIds != null &&
                    input.SecurityGroupIds != null &&
                    this.SecurityGroupIds.SequenceEqual(input.SecurityGroupIds)
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceMode != null)
                    hashCode = hashCode * 59 + this.InstanceMode.GetHashCode();
                if (this.EngineName != null)
                    hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null)
                    hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SubnetIds != null)
                    hashCode = hashCode * 59 + this.SubnetIds.GetHashCode();
                if (this.SecurityGroupIds != null)
                    hashCode = hashCode * 59 + this.SecurityGroupIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
