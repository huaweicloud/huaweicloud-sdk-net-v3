using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ComputeFlavors 
    {

        /// <summary>
        /// 规格id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 资源类型编码。
        /// </summary>
        [JsonProperty("typeCode", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeCode { get; set; }

        /// <summary>
        /// DDM内部记录的虚机规格类型。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// iaas记录的虚机规格类型。
        /// </summary>
        [JsonProperty("iaasCode", NullValueHandling = NullValueHandling.Ignore)]
        public string IaasCode { get; set; }

        /// <summary>
        /// cpu核数。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 内存大小,单位:G。
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public string Mem { get; set; }

        /// <summary>
        /// 最大连接数。
        /// </summary>
        [JsonProperty("maxConnections", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConnections { get; set; }

        /// <summary>
        /// 计算资源服务类型。
        /// </summary>
        [JsonProperty("serverType", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerType { get; set; }

        /// <summary>
        /// 计算资源架构类型，目前分X86和ARM两种。
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// 可用区状态。
        /// </summary>
        [JsonProperty("azStatus", NullValueHandling = NullValueHandling.Ignore)]
        public Object AzStatus { get; set; }

        /// <summary>
        /// 局点状态。
        /// </summary>
        [JsonProperty("regionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionStatus { get; set; }

        /// <summary>
        /// 计算资源架构类型，目前分X86和ARM两种。
        /// </summary>
        [JsonProperty("groupType", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// 服务引擎类型。
        /// </summary>
        [JsonProperty("dbType", NullValueHandling = NullValueHandling.Ignore)]
        public string DbType { get; set; }

        /// <summary>
        /// 扩展字段，目前存储可用区相关信息。
        /// </summary>
        [JsonProperty("extendFields", NullValueHandling = NullValueHandling.Ignore)]
        public Object ExtendFields { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComputeFlavors {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  typeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  iaasCode: ").Append(IaasCode).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("  maxConnections: ").Append(MaxConnections).Append("\n");
            sb.Append("  serverType: ").Append(ServerType).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("  regionStatus: ").Append(RegionStatus).Append("\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  extendFields: ").Append(ExtendFields).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ComputeFlavors);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ComputeFlavors input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TypeCode != input.TypeCode || (this.TypeCode != null && !this.TypeCode.Equals(input.TypeCode))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.IaasCode != input.IaasCode || (this.IaasCode != null && !this.IaasCode.Equals(input.IaasCode))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Mem != input.Mem || (this.Mem != null && !this.Mem.Equals(input.Mem))) return false;
            if (this.MaxConnections != input.MaxConnections || (this.MaxConnections != null && !this.MaxConnections.Equals(input.MaxConnections))) return false;
            if (this.ServerType != input.ServerType || (this.ServerType != null && !this.ServerType.Equals(input.ServerType))) return false;
            if (this.Architecture != input.Architecture || (this.Architecture != null && !this.Architecture.Equals(input.Architecture))) return false;
            if (this.AzStatus != input.AzStatus || (this.AzStatus != null && !this.AzStatus.Equals(input.AzStatus))) return false;
            if (this.RegionStatus != input.RegionStatus || (this.RegionStatus != null && !this.RegionStatus.Equals(input.RegionStatus))) return false;
            if (this.GroupType != input.GroupType || (this.GroupType != null && !this.GroupType.Equals(input.GroupType))) return false;
            if (this.DbType != input.DbType || (this.DbType != null && !this.DbType.Equals(input.DbType))) return false;
            if (this.ExtendFields != input.ExtendFields || (this.ExtendFields != null && !this.ExtendFields.Equals(input.ExtendFields))) return false;

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
                if (this.TypeCode != null) hashCode = hashCode * 59 + this.TypeCode.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.IaasCode != null) hashCode = hashCode * 59 + this.IaasCode.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null) hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.MaxConnections != null) hashCode = hashCode * 59 + this.MaxConnections.GetHashCode();
                if (this.ServerType != null) hashCode = hashCode * 59 + this.ServerType.GetHashCode();
                if (this.Architecture != null) hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.AzStatus != null) hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                if (this.RegionStatus != null) hashCode = hashCode * 59 + this.RegionStatus.GetHashCode();
                if (this.GroupType != null) hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.DbType != null) hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.ExtendFields != null) hashCode = hashCode * 59 + this.ExtendFields.GetHashCode();
                return hashCode;
            }
        }
    }
}
