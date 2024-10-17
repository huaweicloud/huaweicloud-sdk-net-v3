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
    public class MysqlProxyFlavorsResponseComputeFlavors 
    {

        /// <summary>
        /// 数据库代理规格ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 数据库代理规格码。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// CPU大小。例如：1表示1U。
        /// </summary>
        [JsonProperty("cpu", NullValueHandling = NullValueHandling.Ignore)]
        public string Cpu { get; set; }

        /// <summary>
        /// 内存大小，单位为GB。
        /// </summary>
        [JsonProperty("mem", NullValueHandling = NullValueHandling.Ignore)]
        public string Mem { get; set; }

        /// <summary>
        /// 数据库类型。
        /// </summary>
        [JsonProperty("db_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DbType { get; set; }

        /// <summary>
        /// 可用区信息，其中key是该规格绑定的可用区，value是该规格在对应可用区中的状态。 取值范围：     normal：正常     abandon：禁用      - 仅展示数据库主实例所在可用区规格状态。
        /// </summary>
        [JsonProperty("az_status", NullValueHandling = NullValueHandling.Ignore)]
        public Object AzStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlProxyFlavorsResponseComputeFlavors {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  cpu: ").Append(Cpu).Append("\n");
            sb.Append("  mem: ").Append(Mem).Append("\n");
            sb.Append("  dbType: ").Append(DbType).Append("\n");
            sb.Append("  azStatus: ").Append(AzStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlProxyFlavorsResponseComputeFlavors);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlProxyFlavorsResponseComputeFlavors input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Cpu != input.Cpu || (this.Cpu != null && !this.Cpu.Equals(input.Cpu))) return false;
            if (this.Mem != input.Mem || (this.Mem != null && !this.Mem.Equals(input.Mem))) return false;
            if (this.DbType != input.DbType || (this.DbType != null && !this.DbType.Equals(input.DbType))) return false;
            if (this.AzStatus != input.AzStatus || (this.AzStatus != null && !this.AzStatus.Equals(input.AzStatus))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Cpu != null) hashCode = hashCode * 59 + this.Cpu.GetHashCode();
                if (this.Mem != null) hashCode = hashCode * 59 + this.Mem.GetHashCode();
                if (this.DbType != null) hashCode = hashCode * 59 + this.DbType.GetHashCode();
                if (this.AzStatus != null) hashCode = hashCode * 59 + this.AzStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
