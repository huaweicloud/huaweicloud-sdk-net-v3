using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EngineFlavorData 
    {

        /// <summary>
        /// CPU大小。例如：1表示1U。
        /// </summary>
        [JsonProperty("vcpus", NullValueHandling = NullValueHandling.Ignore)]
        public string Vcpus { get; set; }

        /// <summary>
        /// 内存大小，单位为GB。
        /// </summary>
        [JsonProperty("ram", NullValueHandling = NullValueHandling.Ignore)]
        public string Ram { get; set; }

        /// <summary>
        /// 资源规格编码。例如：rds.mysql.m1.xlarge.rr。  更多规格说明请参考数据库实例规格。  “rds”代表RDS产品。 “mysql”代表数据库引擎。 “m1.xlarge”代表性能规格，为高内存类型。 “rr”表示只读实例（“.ha”表示主备实例）。 “rha.rr”表示高可用只读实例，规格编码示例：rds.mysql.n1.large.4.rha.rr。 具有公测权限的用户才可选择高可用，您可联系华为云客服人员申请。 高可用只读功能介绍请参见高可用只读简介。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 是否支持ipv6。
        /// </summary>
        [JsonProperty("is_ipv6_supported", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsIpv6Supported { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeCode { get; set; }

        /// <summary>
        /// 规格所在az的状态，包含以下状态： normal：在售。 unsupported：暂不支持该规格。 sellout：售罄。 abandon：未启用
        /// </summary>
        [JsonProperty("az_status", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> AzStatus { get; set; }

        /// <summary>
        /// 性能规格，包含以下状态： normal：通用增强型。 normal2：通用增强Ⅱ型。 armFlavors：鲲鹏通用增强型。 dedicicateNormal（dedicatedNormalLocalssd）：x86独享型。 armLocalssd：鲲鹏通用型。 normalLocalssd：x86通用型。 general：通用型。 dedicated 对于MySQL引擎：独享型。 对于PostgreSQL和SQL Server引擎：独享型，仅云盘SSD支持。 rapid 对于MySQL引擎：独享型（已下线）。 对于PostgreSQL和SQL Server引擎：独享型，仅极速型SSD支持。 bigmem：超大内存型。 highPerformancePrivilegeEdition：超高IO 尊享版
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// 最大连接数
        /// </summary>
        [JsonProperty("max_connection", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxConnection { get; set; }

        /// <summary>
        /// 数据库每秒执行的事务数，每个事务中包含18条SQL语句。
        /// </summary>
        [JsonProperty("tps", NullValueHandling = NullValueHandling.Ignore)]
        public string Tps { get; set; }

        /// <summary>
        /// 数据库每秒执行的SQL数，包含insert、select、update、delete等。
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public string Qps { get; set; }

        /// <summary>
        /// 最小磁盘容量，单位G
        /// </summary>
        [JsonProperty("min_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public string MinVolumeSize { get; set; }

        /// <summary>
        /// 最大磁盘容量，单位G
        /// </summary>
        [JsonProperty("max_volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public string MaxVolumeSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EngineFlavorData {\n");
            sb.Append("  vcpus: ").Append(Vcpus).Append("\n");
            sb.Append("  ram: ").Append(Ram).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  isIpv6Supported: ").Append(IsIpv6Supported).Append("\n");
            sb.Append("  typeCode: ").Append(TypeCode).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  maxConnection: ").Append(MaxConnection).Append("\n");
            sb.Append("  tps: ").Append(Tps).Append("\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("  minVolumeSize: ").Append(MinVolumeSize).Append("\n");
            sb.Append("  maxVolumeSize: ").Append(MaxVolumeSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EngineFlavorData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EngineFlavorData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vcpus == input.Vcpus ||
                    (this.Vcpus != null &&
                    this.Vcpus.Equals(input.Vcpus))
                ) && 
                (
                    this.Ram == input.Ram ||
                    (this.Ram != null &&
                    this.Ram.Equals(input.Ram))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.IsIpv6Supported == input.IsIpv6Supported ||
                    (this.IsIpv6Supported != null &&
                    this.IsIpv6Supported.Equals(input.IsIpv6Supported))
                ) && 
                (
                    this.TypeCode == input.TypeCode ||
                    (this.TypeCode != null &&
                    this.TypeCode.Equals(input.TypeCode))
                ) && 
                (
                    this.AzStatus == input.AzStatus ||
                    this.AzStatus != null &&
                    input.AzStatus != null &&
                    this.AzStatus.SequenceEqual(input.AzStatus)
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.MaxConnection == input.MaxConnection ||
                    (this.MaxConnection != null &&
                    this.MaxConnection.Equals(input.MaxConnection))
                ) && 
                (
                    this.Tps == input.Tps ||
                    (this.Tps != null &&
                    this.Tps.Equals(input.Tps))
                ) && 
                (
                    this.Qps == input.Qps ||
                    (this.Qps != null &&
                    this.Qps.Equals(input.Qps))
                ) && 
                (
                    this.MinVolumeSize == input.MinVolumeSize ||
                    (this.MinVolumeSize != null &&
                    this.MinVolumeSize.Equals(input.MinVolumeSize))
                ) && 
                (
                    this.MaxVolumeSize == input.MaxVolumeSize ||
                    (this.MaxVolumeSize != null &&
                    this.MaxVolumeSize.Equals(input.MaxVolumeSize))
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
                if (this.Vcpus != null)
                    hashCode = hashCode * 59 + this.Vcpus.GetHashCode();
                if (this.Ram != null)
                    hashCode = hashCode * 59 + this.Ram.GetHashCode();
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.IsIpv6Supported != null)
                    hashCode = hashCode * 59 + this.IsIpv6Supported.GetHashCode();
                if (this.TypeCode != null)
                    hashCode = hashCode * 59 + this.TypeCode.GetHashCode();
                if (this.AzStatus != null)
                    hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.MaxConnection != null)
                    hashCode = hashCode * 59 + this.MaxConnection.GetHashCode();
                if (this.Tps != null)
                    hashCode = hashCode * 59 + this.Tps.GetHashCode();
                if (this.Qps != null)
                    hashCode = hashCode * 59 + this.Qps.GetHashCode();
                if (this.MinVolumeSize != null)
                    hashCode = hashCode * 59 + this.MinVolumeSize.GetHashCode();
                if (this.MaxVolumeSize != null)
                    hashCode = hashCode * 59 + this.MaxVolumeSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
