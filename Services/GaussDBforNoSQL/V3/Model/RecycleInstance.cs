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
    /// 回收备份实例信息。
    /// </summary>
    public class RecycleInstance 
    {

        /// <summary>
        /// **参数解释：** 实例ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 实例名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 实例类型。 **取值范围：** - 取值为“Cluster”，表示GeminiDB Cassandra、GeminiDB Influx、GeminiDB Redis Proxy经典部署模式集群实例类型。 - 取值为“CloudNativeCluster”，表示GeminiDB Cassandra、GeminiDB Influx、GeminiDB Redis云原生部署模式集群实例类型。 - 取值为“RedisCluster”，表示GeminiDB Redis Cluster经典部署模式集群实例类型。 - 取值为“Replication”，表示GeminiDB Redis经典部署模式主备实例类型。 - 取值为“InfluxdbSingle”，表示GeminiDB Influx经典部署模式单节点实例类型。 - 取值为“ReplicaSet”，表示GeminiDB Mongo副本集实例类型。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public string Mode { get; set; }

        /// <summary>
        /// **参数解释：** 产品类型。 **取值范围：** GeminiDB Redis云原生部署模式集群涉及此字段，取值：   -  Standard 标准型   -  Capacity 容量型
        /// </summary>
        [JsonProperty("product_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("data_store", NullValueHandling = NullValueHandling.Ignore)]
        public RecycleDatastore DataStore { get; set; }

        /// <summary>
        /// **参数解释：** 计费方式。 **取值范围：** - prePaid：预付费，即包年/包月。 - postPaid：后付费，即按需付费。
        /// </summary>
        [JsonProperty("charge_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeType { get; set; }

        /// <summary>
        /// **参数解释：** 企业项目ID，取值为“0”，表示为default企业项目 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释：** 备份ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// **参数解释：** 实例创建时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// **参数解释：** 实例删除时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Ignore)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// **参数解释：** 回收备份保留截止时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("retained_until", NullValueHandling = NullValueHandling.Ignore)]
        public string RetainedUntil { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleInstance {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  productType: ").Append(ProductType).Append("\n");
            sb.Append("  dataStore: ").Append(DataStore).Append("\n");
            sb.Append("  chargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  deletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  retainedUntil: ").Append(RetainedUntil).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecycleInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecycleInstance input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Mode != input.Mode || (this.Mode != null && !this.Mode.Equals(input.Mode))) return false;
            if (this.ProductType != input.ProductType || (this.ProductType != null && !this.ProductType.Equals(input.ProductType))) return false;
            if (this.DataStore != input.DataStore || (this.DataStore != null && !this.DataStore.Equals(input.DataStore))) return false;
            if (this.ChargeType != input.ChargeType || (this.ChargeType != null && !this.ChargeType.Equals(input.ChargeType))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.DeletedAt != input.DeletedAt || (this.DeletedAt != null && !this.DeletedAt.Equals(input.DeletedAt))) return false;
            if (this.RetainedUntil != input.RetainedUntil || (this.RetainedUntil != null && !this.RetainedUntil.Equals(input.RetainedUntil))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Mode != null) hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.ProductType != null) hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.DataStore != null) hashCode = hashCode * 59 + this.DataStore.GetHashCode();
                if (this.ChargeType != null) hashCode = hashCode * 59 + this.ChargeType.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null) hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                if (this.RetainedUntil != null) hashCode = hashCode * 59 + this.RetainedUntil.GetHashCode();
                return hashCode;
            }
        }
    }
}
